using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WeifenLuo.WinFormsUI.Docking;

namespace system
{
    public partial class FormDialog : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public static bool simbolDialog = false;
        public static string InputFilePath_global = "";     //全局变量的输入路径
        public static string OutputFilePath_global = "";    //全局变量的输出路径
        public static string AllFilePath = "";    //生成的txt所在文件路径
        public static string AllFileType = "";     //生成的文件的类型
        public static List<string> AllFileName = new List<string>();
        public static List<string> AllUploadFiles = new List<string>(); //上传文件的全部本地路径
        public static List<string> AllRecievePaths = new List<string>();   //服务器存储路径
        public FormDialog()
        {
            InitializeComponent();
            if (FormLogin.language == true)
            {
                this.Text = "目录";
                ButtonOpenFile.Text = "打开文件";
                LabelDialog.Text = "已选文件";
            }
            XmlReader xmlReader = null;
            try
            {
                //加载xml文档
                xmlReader = new XmlTextReader(Application.StartupPath + @"\xml\dbconnect.xml");//参数：存储的绝对路径
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlReader);
                XmlNode root = xmlDoc.DocumentElement;  //获取根节点
                XmlNode InputPath = root.SelectSingleNode("//inputPath");
                InputFilePath_global = InputPath.InnerText;
                XmlNode OutputPath = root.SelectSingleNode("//outputPath");
                OutputFilePath_global = OutputPath.InnerText;
                Output("The input path that the user has selected：" + InputFilePath_global); //打印用户的输入路径
                Output("The output path that the user has selected：" + OutputFilePath_global); //打印用户的输出路径
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                xmlReader.Close();
            }
        } 
        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            simbolDialog = true;
            OpenFileDialog filename = new OpenFileDialog(); //定义一个文件打开控件
            XmlReader xmlReader = null;
            try
            {
                //加载xml文档
                xmlReader = new XmlTextReader(Application.StartupPath + @"\xml\dbconnect.xml");//参数：存储的绝对路径
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlReader);
                XmlNode root = xmlDoc.DocumentElement;  //获取根节点
                XmlNode lastFilePath = root.SelectSingleNode("//lastFilePath");
                if (lastFilePath != null)
                {
                    filename.InitialDirectory = lastFilePath.InnerText;    //打开的默认目录为exe所在目录
                }
                else
                {
                    filename.InitialDirectory = Application.StartupPath;   //打开的默认目录为exe所在目录
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                xmlReader.Close();
            }
            filename.Multiselect = true;    // 允许多选
            filename.Filter = "npz文件(*.npz)|*.npz|NPZ文件(*.NPZ)|*.NPZ|mseed文件(*.mseed)|*.mseed|MSEED文件(*.MSEED)|*.MSEED|sac文件(*.sac)|*.sac|SAC文件(*.SAC)|*.SAC|txt文件(*.txt)|*.txt|TXT文件(*.TXT)|*.TXT|csv文件(*.csv)|*.csv|CSV文件(*.CSV)|*.CSV"; // 设置控件打开的文件类型
            filename.FilterIndex = 1;   //设置控件打开文件类型的显示顺序
            filename.RestoreDirectory = false;   //是否记忆之前打开的目录
            if (filename.ShowDialog() == DialogResult.OK)
            {

                AllFilePath = null;  //发布完之后清空路径
                AllFileName.Clear();  //发布完之后清空内容
                int FileNum = filename.FileNames.Length;
                for (int i = 0; i < FileNum; i++)
                {
                    string Path = filename.FileNames[i].ToString(); //获得用户选择的文件的绝对路径
                    string ParentPath = Path.Substring(0, Path.LastIndexOf(@"\"));    //获取用户选择的文件的绝对路径的上一级路径，用于存放txt文件
                    string CurrentFileName = Path.Substring(Path.LastIndexOf("\\") + 1);   //获取用户选择的不带路径的文件
                    string TxtName = "input" + DateTime.Now.ToString("HHmmss") + ".txt";  //设置生成的txt文件的名字
                    //output("用户选择的文件目录为：" + ParentPath);   //打印出用户选择的文件目录
                    //output("");
                    Output("The file that the user has selected：" + CurrentFileName); //打印出用户选择的文件名
                    AllFileName.Add(CurrentFileName );
                    AllFilePath = ParentPath;
                    AllUploadFiles.Add(Path);   //当前循环的绝对路径
                    AllRecievePaths.Add(InputFilePath_global + @"\" + CurrentFileName);   //当前循环的输入文件夹存储路径
                    AllFileType = FormMain.getType(CurrentFileName);        //获取选择文件的格式
                    Console.WriteLine(AllFileType);
                }
                try
                {
                    string url = Application.StartupPath + @"\xml\dbconnect.xml";
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(url);
                    XmlNode lastFilePath = xmlDoc.SelectSingleNode("//lastFilePath");
                    if (AllFilePath != null)
                    {
                        lastFilePath.InnerText = AllFilePath;
                    }                    
                    xmlDoc.Save(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }            
        }       
        //读取txt操作
        public static string ReadFile(string path, string name)
        {
            StreamReader sr;
            FileInfo fi = new FileInfo(path + "/" + name);
            sr = fi.OpenText();
            string info = sr.ReadToEnd();
            sr.Close();
            sr.Dispose();
            return info;
        }
        //写入txt操作
        public static void WriteFile(string path, string name, string info)
        {
            StreamWriter sw;
            FileInfo fi = new FileInfo(path + "/" + name);
            sw = fi.CreateText();
            sw.WriteLine(info);
            sw.Close();
            sw.Dispose();
        }
        //打印日志信息
        public void Output(string log)
        {
            //如果日志信息长度超过100行，则自动清空
            if (TextBoxDialog.GetLineFromCharIndex(TextBoxDialog.Text.Length) > 100)
                TextBoxDialog.Text = "";
            //添加日志
            TextBoxDialog.AppendText(DateTime.Now.ToString("HH:mm:ss ") + log + "\r\n");

        }
    }
}

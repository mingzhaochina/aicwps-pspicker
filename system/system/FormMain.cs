using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;
using Renci.SshNet;
using WeifenLuo.WinFormsUI.Docking;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.Xml;

namespace system
{
    public partial class FormMain : Form
    {
        public static bool simbolCalculate = false;
        public static string TxtName = "";
        public static string readJasonPath = "";   //用于保存readJason时的文件路径
        public static string readChartPath = "";   //用于保存readJason时的文件路径
        public static string outPutPath = "";   //用于保存readJason时的文件路径
        public static string outPutPath_online = "";
        public static string probability_begin = "";
        public static string pfNum_begin = "";
        public static string device_begin = "";
        public static string multithreading_begin = "";
        public static string type_begin = "";
        public static string picture_begin = "";
        public static Dictionary<string, string> resultDict;

        private string ipAddress;
        private string userName;
        private string passward;
        private int port = 22;

        public static SshClient sshClient;
        private static SFTPHelper helper;
        private bool connectState = false;
        private string message = "Calculating, please wait...";

        public FormMain()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //加载起始页窗体
            FormRunOption formRunOption = new FormRunOption();
            formRunOption.Show(idockPanel);
            if (FormLogin.language == true)
            {
                XmlReader xmlReader = null;
                try
                {
                    //加载xml文档                    
                    xmlReader = new XmlTextReader(Application.StartupPath + @"\xml\languageChinese.xml");//参数：存储的绝对路径
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(xmlReader);
                    XmlNode root = xmlDoc.DocumentElement;  //获取根节点                    
                    XmlNode sysname = root.SelectSingleNode("//sysname");
                    if (sysname != null)
                    {
                        FormMain.TxtName = sysname.InnerText;
                    }
                    XmlNode menu = root.SelectSingleNode("//menu");
                    if (menu != null)
                    {
                        RibbonPage1.Text = menu.InnerText;
                    }
                    XmlNode logo = root.SelectSingleNode("//logo");
                    if (logo != null)
                    {
                        MainPanelImage.Title = logo.InnerText;
                    }
                    XmlNode panelHomepage = root.SelectSingleNode("//panelHomepage");
                    if (panelHomepage != null)
                    {
                        PanelHomepage.Title = panelHomepage.InnerText;
                    }
                    XmlNode itemOption = root.SelectSingleNode("//itemOption");
                    if (itemOption != null)
                    {
                        ItemOption.Title = itemOption.InnerText;
                    }
                    XmlNode itemCancel = root.SelectSingleNode("//itemCancel");
                    if (itemCancel != null)
                    {
                        ItemCancel.Title = itemCancel.InnerText;
                    }
                    XmlNode panelSave = root.SelectSingleNode("//panelSave");
                    if (panelSave != null)
                    {
                        PanelSave.Title = panelSave.InnerText;
                    }
                    XmlNode itemBegin = root.SelectSingleNode("//itemBegin");
                    if (itemBegin != null)
                    {
                        ItemBegin.Title = itemBegin.InnerText;
                    }
                    XmlNode itemAdd = root.SelectSingleNode("//itemAdd");
                    if (itemAdd != null)
                    {
                        ItemAdd.Title = itemAdd.InnerText;
                    }
                    XmlNode itemResult = root.SelectSingleNode("//itemResult");
                    if (itemResult != null)
                    {
                        ItemResult.Title = itemResult.InnerText;
                    }
                    XmlNode itemChart = root.SelectSingleNode("//itemChart");
                    if (itemChart != null)
                    {
                        ItemChart.Title = itemChart.InnerText;
                    }
                    XmlNode panelExcel = root.SelectSingleNode("//panelExcel");
                    if (panelExcel != null)
                    {
                        PanelExcel.Title = panelExcel.InnerText;
                    }
                    XmlNode itemExport = root.SelectSingleNode("//itemExport");
                    if (itemExport != null)
                    {
                        ItemExport.Title = itemExport.InnerText;
                    }
                    XmlNode itemPrint = root.SelectSingleNode("//itemPrint");
                    if (itemPrint != null)
                    {
                        ItemPrint.Title = itemPrint.InnerText;
                    }
                    XmlNode panelAbout = root.SelectSingleNode("//panelAbout");
                    if (panelAbout != null)
                    {
                        PanelAbout.Title = panelAbout.InnerText;
                    }
                    XmlNode itemAbout = root.SelectSingleNode("//itemAbout");
                    if (itemAbout != null)
                    {
                        ItemAbout.Title = itemAbout.InnerText;
                    }
                    XmlNode itemHelp = root.SelectSingleNode("//itemHelp");
                    if (itemHelp != null)
                    {
                        ItemHelp.Title = itemHelp.InnerText;
                    }
                    XmlNode panelExit = root.SelectSingleNode("//panelExit");
                    if (panelExit != null)
                    {
                        PanelExit.Title = panelExit.InnerText;
                    }
                    XmlNode itemExit = root.SelectSingleNode("//itemExit");
                    if (itemExit != null)
                    {
                        ItemExit.Title = itemExit.InnerText;
                    }
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
            if (FormLogin.if_online)
            {
                Lblmessage.Visible = true;
                setMessage("connecting...");
                loadInfo();
                if (ipAddress != null && userName != null && passward != null)
                {
                    Thread thread = new Thread(delegate ()
                    {
                        connectState = connToServer();
                        if (connectState == false)
                        {
                            message = "Sorry,failed to connect...retrying...";
                            setMessage(message);
                            connectState = connToServer();
                            if (connectState == false)
                            {
                                MessageBox.Show("Please exit and login again.");
                            }
                            else
                            {
                                message = "Connected";
                                setMessage(message);
                                ItemBegin.Enabled = true;
                            }

                        }
                        else
                        {
                            message = "Connected";
                            setMessage(message);
                            ItemBegin.Enabled = true;
                        }
                    });
                    thread.Start();

                }

            }

        }

        private void setMessage(string mes)
        {
            Lblmessage.Text = mes;
        }

        private void qRibbon1_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {

        }
        //设置页按钮
        private void ItemOption_ItemActivated_1(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            FormRunOption formRunOption = new FormRunOption();
            string name = formRunOption.Name;
            //使用循环判断当前已经打开的窗体中是否有主页的窗体
            foreach (DockContent item in idockPanel.Contents)
            {
                if (item.Name == name)
                {
                    item.Activate();
                    return;
                }
            }
            //如果上面满足if条件的话，就会运行到return，直接跳出代码，不会再执行下面这两句代码
            formRunOption.Show(idockPanel);
        }

        //关闭当前页
        private void ItemCancel_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            Form frm = ActiveMdiChild;//获取当前多窗体中处于激活状态的子窗体
            if (frm != null)
                frm.Close();
            //Application.Exit();
        }

        private void RibbonPage1_Activated(object sender, EventArgs e)
        {

        }

        private void dockPanel1_ActiveContentChanged(object sender, EventArgs e)
        {

        }

        //退出按钮
        private void ItemExit_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {

            Application.Exit();
            Application.ExitThread();
        }

        private void ItemAdd_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            //加载目录页窗体
            FormDialog dialog = new FormDialog();            
            string name = dialog.Name;
            //使用循环判断当前已经打开的窗体中是否有目录的窗体
            foreach (DockContent item in idockPanel.Contents)
            {
                if (item.Name == name)
                {
                    item.Activate();
                    return;
                }
            }
            //如果上面满足if条件的话，就会运行到return，直接跳出代码，不会再执行下面这两句代码
            dialog.Show(idockPanel);

        }

        private void MainPanelImage_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {

        }

        private void ItemBegin_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            if (FormDialog.simbolDialog == true)
            {
                resultDict= load_xml();
                
                bool success = false;
                Lblmessage.Visible = true;
                Lblmessage.Text = "Calculating, please wait...";
                TxtName = DateTime.Now.ToString("MMddhhmmss");  //设置生成的txt文件的名字
                outPutPath = FormDialog.OutputFilePath_global + @"\" + TxtName;
                if (FormLogin.if_online)
                {
                    //    Thread thread = new Thread(delegate ()
                    //    {
                    //        var testCmd = sshClient.RunCommand("mkdir " + "output");
                    //        if (!string.IsNullOrWhiteSpace(testCmd.Error))
                    //            Console.WriteLine(testCmd.Error);
                    //        else
                    //            Console.WriteLine(testCmd.Result);
                    //        string outPutPath_online = "/home/" + userName + "/output/" + TxtName;
                    //        string inputPath = "/home/" + userName + "/input";
                    //        sshClient.RunCommand("mkdir " + outPutPath_online);
                    //        send_online(FormDialog.AllUploadFiles, FormDialog.AllRecievePaths); //把本地文件全部发送到服务器上
                    //        calcute_online(inputPath);                                                  
                    //        //sshClient.RunCommand("docker run -v " + inputPath + ":/classification_sample/input -v " + outPutPath + ":/classification_sample/output -e PYTHONUNBUFFERED=0 phasenet_model_cross_entropy_ai_picking python3 classification_sample -i input -m  inference_graph.xml -d CPU -dt " + FormDialog.AllFileType + " -o output -ot csv -pl");
                    //        success = download(outPutPath_online);

                    //        if (success)
                    //        {
                    //            //Lblmessage.Visible = false;
                    //            Lblmessage.Text = "Connected";
                    //            ItemResult.Enabled = true;
                    //            ItemChart.Enabled = true;
                    //        }
                    //        else
                    //        {
                    //            Lblmessage.Text = "Sorry,failed to calculate...";
                    //        }
                    //    });
                    var testCmd = sshClient.RunCommand("mkdir " + "output");
                    if (!string.IsNullOrWhiteSpace(testCmd.Error))
                        Console.WriteLine(testCmd.Error);
                    else
                        Console.WriteLine(testCmd.Result);
                    outPutPath_online = "/home/" + userName + "/output/" + TxtName;
                    string inputPath_online = "/home/" + userName + "/input";
                    sshClient.RunCommand("mkdir " + outPutPath_online);
                    send_online(FormDialog.AllUploadFiles, FormDialog.AllFileName); //把本地文件全部发送到服务器上
                    calcute_online(inputPath_online,outPutPath_online);
                    //sshClient.RunCommand("docker run -v " + inputPath + ":/classification_sample/input -v " + outPutPath + ":/classification_sample/output -e PYTHONUNBUFFERED=0 phasenet_model_cross_entropy_ai_picking python3 classification_sample -i input -m  inference_graph.xml -d CPU -dt " + FormDialog.AllFileType + " -o output -ot csv -pl");
                    success = download(outPutPath_online);

                    if (success)
                    {
                        //Lblmessage.Visible = false;
                        Lblmessage.Text = "Connected";
                        ItemResult.Enabled = true;
                        ItemChart.Enabled = true;
                    }
                    else
                    {
                        Lblmessage.Text = "Sorry,failed to calculate...";
                    }

                }
                else
                {
                    
                    send(FormDialog.AllUploadFiles, FormDialog.AllRecievePaths); //把本地文件全部发送到服务器上
                    success = calculate();    //开始计算

                    //下载结束后，关闭提示
                    if (success)
                    {
                        Lblmessage.Visible = false;
                    }
                }

                
               //inputFileName = FormDialog.AllFileName;  //文件路径全赋给inputfilepath
                
                simbolCalculate = true;
                FormDialog.AllUploadFiles.Clear();   //发布完之后清空路径
                FormDialog.AllRecievePaths.Clear();  //发布完之后清空路径

            }
            else
                MessageBox.Show("Please add files first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static string getType(string filename)
        {
            string type = filename.Substring(filename.Length - 3);
            if (type == "npz" || type == "sac"||type=="txt"|| type == "csv"|| type == "NPZ" || type == "SAC" || type == "TXT"||type == "CSV")
            {
                string newType = type.ToLower();
                return newType;
            }
            else
            {
                return "mseed";
            }
        }

        private static Dictionary<string,string> load_xml()
        {
            //加载xml信息
            XmlReader xmlReader = null;
            Dictionary<string, string> resultDict = new Dictionary<string, string>();
            try
            {
                //加载xml文档
                xmlReader = new XmlTextReader(Application.StartupPath + @"\xml\dbconnect.xml");//参数：存储的绝对路径
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlReader);
                XmlNode root = xmlDoc.DocumentElement;  //获取根节点

                XmlNode probability = root.SelectSingleNode("//probability");
                if (probability != null)
                {
                    probability_begin = probability.InnerText;
                    resultDict.Add("probability", probability_begin);
                }
                XmlNode device = root.SelectSingleNode("//device");
                if (device != null)
                {
                    device_begin = device.InnerText;
                    resultDict.Add("device", device_begin);
                }
                XmlNode multithreading = root.SelectSingleNode("//multithreading");
                if (multithreading != null)
                {
                    multithreading_begin = multithreading.InnerText;
                    resultDict.Add("multithreading", multithreading_begin);
                }
                XmlNode type = root.SelectSingleNode("//type");
                if (type != null)
                {
                    type_begin = type.InnerText;
                    resultDict.Add("type", type_begin);
                }
                XmlNode picture = root.SelectSingleNode("//picture");
                if (picture != null)
                {
                    picture_begin = picture.InnerText;
                    resultDict.Add("picture", picture_begin);
                }
                XmlNode pfNum = root.SelectSingleNode("//pfNum");
                if (pfNum != null)
                {
                    pfNum_begin = pfNum.InnerText;
                    resultDict.Add("pfNum", pfNum_begin);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                xmlReader.Close();
            }

            return resultDict;
        }

        private static bool calculate()
        {
            //Dictionary<string, string> resultDict = load_xml();

            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;//是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            p.Start();//启动程序
            p.StandardInput.WriteLine("md " + outPutPath);
            p.StandardInput.WriteLine("docker run -v /docker_test/docker_input:/classification_sample/input -v /docker_test/docker_output/" + TxtName + ":/classification_sample/output -e PYTHONUNBUFFERED=0 phasenet_model_cross_entropy_ai_picking python3 classification_sample -i input -m  inference_graph.xml -d " + resultDict["device"] + " -dt " + FormDialog.AllFileType + " -o output -ot " + resultDict["type"] + " -" + resultDict["picture"] +" "+resultDict["pfNum"]+ " & exit");
            p.StandardInput.AutoFlush = true;
            //获取cmd窗口的输出信息
            //string output = p.StandardOutput.ReadToEnd();
            //等待程序执行完退出进程
            //p.BeginOutputReadLine();
            p.StandardOutput.ReadToEnd();
            p.EnableRaisingEvents = true;
            p.WaitForExit();
            p.Close();
            DeleteDir(FormDialog.InputFilePath_global);
            return true;
        }

       private static bool calcute_online(string inputPath_online,string outputPath_online)
        {
            Console.WriteLine("docker run -v " + inputPath_online + ":/classification_sample/input -v " + outputPath_online + ":/classification_sample/output -e PYTHONUNBUFFERED=0 phasenet_model_cross_entropy_ai_picking python3 classification_sample -i input -m  inference_graph.xml -d " + resultDict["device"] + " -dt " + FormDialog.AllFileType + " -o output -ot " + resultDict["type"] + " -" + resultDict["picture"] + " " + resultDict["pfNum"]);
            sshClient.RunCommand("docker run -v " + inputPath_online + ":/classification_sample/input -v " + outputPath_online + ":/classification_sample/output -e PYTHONUNBUFFERED=0 phasenet_model_cross_entropy_ai_picking python3 classification_sample -i input -m  inference_graph.xml -d " + resultDict["device"] + " -dt " + FormDialog.AllFileType + " -o output -ot " + resultDict["type"] + " -" + resultDict["picture"] + " " + resultDict["pfNum"]);
            return true;
        }

        private bool send(List<string> input, List<string> output)
        {
            bool success = false;
            int len = output.Count;
            for (int i = 0; i < len; i++)
            {
                System.IO.File.Copy(input[i],output[i]);
                if (File.Exists(output[i]))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }            
            return success;
        }

        private bool send_online(List<string> input, List<string> output)
        {
            //SFTPHelper helper = new SFTPHelper("13.92.56.195", "majiahui", "nxycMJH19960622");
            if (connectState)
            {
                bool success = false;
                int len = output.Count;
                for (int i = 0; i < len; i++)
                {
                    success=helper.Put(input[i], "/home/" + userName + "/input/" + output[i]);
                    if (success)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                return success;
            }
            else
            {
                return false;
            }
        }

        private bool download(string outPutPath_online)
        {
            var result = sshClient.RunCommand("ls " + outPutPath_online);
            string[] files = result.Result.Split('\n');
            string createPath = Application.StartupPath + "/result/" + DateTime.Now.ToString("MM.dd  HH-mm");
            string downLoadPath = createPath + "/";
            readJasonPath = downLoadPath;   //将Jason文件的路径赋给它
            readChartPath = downLoadPath;   //将图片文件的路径赋给它

            if (!Directory.Exists(Application.StartupPath + "/result"))
                Directory.CreateDirectory(Application.StartupPath + "/result");
            Directory.CreateDirectory(createPath);

            while (files.Length < 2)
            {
                result = sshClient.RunCommand("ls /home/" + userName + "/output");
                files = result.Result.Split('\n');
            }
            if (files.Length >= 2)
            {
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;//是否使用操作系统shell启动
                p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
                p.StartInfo.CreateNoWindow = true;//不显示程序窗口
                p.Start();//启动程序
                p.StandardInput.WriteLine("md " + outPutPath + " & exit");
                p.StandardInput.AutoFlush = true;
                //获取cmd窗口的输出信息
                //string output = p.StandardOutput.ReadToEnd();
                //等待程序执行完退出进程
                //p.BeginOutputReadLine();
                p.StandardOutput.ReadToEnd();
                p.EnableRaisingEvents = true;
                p.WaitForExit();
                p.Close();
                foreach (var file in files)
                {
                    if (file.Split('.').Length < 2)
                    {
                        continue;
                    }
                    else
                    {
                        helper.Get(outPutPath_online + "/" + file, outPutPath + "/" + file);
                    }

                }
                
                sshClient.RunCommand("rm -rf /home/" + userName + "/input/*");
                return true;
            }
            else
            {
                sshClient.RunCommand("rm -rf /home/" + userName + "/input/*");
                return false;
            }
        }
        /*
        public static bool download(string remotePath, string localPath)
        {
            SFTPHelper helper = new SFTPHelper("13.92.56.195", "majiahui", "nxycMJH19960622");
            bool connect = helper.Connect();
            if (helper.Get(remotePath, localPath))
            {
                helper.Disconnect();
                return true;
            }
            else
            {
                helper.Disconnect();
                return false;
            }
        }
        */
        /*
        private bool download()
        {
            if (!Directory.Exists(outPutPath))
            {
                Directory.CreateDirectory(outPutPath);
            }
            SshExec exec = new SshExec("13.92.56.195", "majiahui");
            exec.Password = "nxycMJH19960622";
            exec.Connect();
            DirectoryInfo root = new DirectoryInfo(FormDialog.OutputFilePath_global);
            FileInfo[] files = root.GetFiles();
            bool success = false;
            int len = files.Length;
            string createPath = Application.StartupPath + "/result/" + DateTime.Now.ToString("MM.dd  HH-mm");
            string downLoadPath = createPath + "/";
            readJasonPath = downLoadPath;   //将Jason文件的路径赋给它
            readChartPath = downLoadPath;   //将图片文件的路径赋给它

            if (!Directory.Exists(Application.StartupPath + "/result"))
                Directory.CreateDirectory(Application.StartupPath + "/result");
            Directory.CreateDirectory(createPath);
            
            while (files.Length < 2)
            {
                result = exec.RunCommand("ls /home/majiahui/output");
                files = result.Split('\n');
            }
            if (files.Length >= 2)
            {
                SFTPHelper helper = new SFTPHelper("13.92.56.195", "majiahui", "nxycMJH19960622");
                helper.Connect();
                foreach (var file in files)
                {
                    helper.Get(outPutPath + "/" + file, downLoadPath + file);
                }
                helper.Disconnect();
                exec.RunCommand("rm -rf /home/majiahui/input/*");
               //exec.RunCommand("rm -rf /home/majiahui/output/*");  //下载完成后删除输入和输出文件夹下的文件
                exec.Close();
                return true;
            }
            else
            {
                exec.RunCommand("rm -rf /home/majiahui/input/*");
                //exec.RunCommand("rm -rf /home/majiahui/output/*");  //下载完成后删除输入和输出文件夹下的文件
                exec.Close();
                return false;
            }
        }
        */
        private void LblMessage_Click(object sender, EventArgs e)
        {

        }

        private void ItemAbout_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            FormAbout abt = new FormAbout();
            string name = abt.Name;
            //使用循环判断当前已经打开的窗体中是否有主页的窗体
            foreach (DockContent item in idockPanel.Contents)
            {
                if (item.Name == name)
                {
                    item.Activate();
                    return;
                }
            }
            //如果上面满足if条件的话，就会运行到return，直接跳出代码，不会再执行下面这两句代码
            abt.Show(idockPanel);
        }

        private void PanelSave_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {

        }
        private void ItemResult_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            if (simbolCalculate == true)
            {
                //加载结果页窗体
                FormOutPut outform = new FormOutPut();
                string name = outform.Name;
                //使用循环判断当前已经打开的窗体中是否有结果的窗体
                foreach (DockContent item in idockPanel.Contents)
                {
                    if (item.Name == name)
                    {
                        item.Activate();
                        return;
                    }
                }
                //如果上面满足if条件的话，就会运行到return，直接跳出代码，不会再执行下面这两句代码
                outform.Show(idockPanel);
            }
            else
                MessageBox.Show("Please calculate first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ItemExport_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            FormOutPut.ExportExcel("result",FormOutPut.pubdgv);
        }

        private void ItemHelp_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            //download("/home/majiahui/files/help.pdf", Application.StartupPath + "/help.pdf");
            System.Diagnostics.Process.Start(Application.StartupPath + "/help.pdf");
        }

        private void ItemChart_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            if (simbolCalculate == true)
            {
                //加载图片页窗体
                FormChart chartform = new FormChart();
                string name = chartform.Name;
                //使用循环判断当前已经打开的窗体中是否有结果的窗体
                foreach (DockContent item in idockPanel.Contents)
                {
                    if (item.Name == name)
                    {
                        item.Activate();
                        return;
                    }
                }
                //如果上面满足if条件的话，就会运行到return，直接跳出代码，不会再执行下面这两句代码
                chartform.Show(idockPanel);
            }
            else
                MessageBox.Show("Please calculate first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void DeleteDir(string srcPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)            //判断是否文件夹
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true);          //删除子目录和文件
                    }
                    else
                    {
                        File.Delete(i.FullName);      //删除指定文件
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void ItemOption_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            FormRunOption formRunOption = new FormRunOption();
            formRunOption.Show();
        }

        //加载登录信息
        private void loadInfo()
        {
            XmlReader xmlReader = null;
            try
            {
                //加载xml文档
                xmlReader = new XmlTextReader(Application.StartupPath + @"\xml\dbconnect.xml");//参数：存储的绝对路径
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlReader);
                XmlNode root = xmlDoc.DocumentElement;  //获取根节点
                XmlNode ip = root.SelectSingleNode("//ip");
                if (ip != null)
                {
                    ipAddress = ip.InnerText;
                }

                XmlNode uid = root.SelectSingleNode("//uid");
                if (uid != null)
                {
                    userName = uid.InnerText;
                }
                XmlNode pwd = root.SelectSingleNode("//pwd");
                if (pwd != null)
                {
                    passward = pwd.InnerText;
                }


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

        private bool connToServer()
        {
            try
            {
                sshClient = new SshClient(ipAddress, port, userName, passward);

                sshClient.Connect();

                helper = new SFTPHelper(ipAddress, port, userName, passward);
                helper.Connect();

            }
            catch (Exception execption)
            {
                Console.Write(execption.Message);
            }

            return helper.Connected;
        }

        public static bool download(string remotePath, string localPath)
        {
            //SFTPHelper helper = new SFTPHelper("13.92.56.195", "majiahui", "nxycMJH19960622");
            //bool connect = helper.Connect();
            bool downloadfigure = helper.Get(remotePath, localPath);
            if (downloadfigure)
            {
                //helper.Disconnect();
                return true;
            }
            else
            {
                //helper.Disconnect();
                return false;
            }
        }

        private void ItemLanguage_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {

        }


        /*
class Program
{
//static void Main(string[] args)
//{
//    String str = ssh_conn("13.92.56.195", "hao", "nxycMJH19960622", "");
//    System.Console.Write(str);
//    System.Console.Read();

//}
public static string ssh_conn(string ip, string root, string pass, string command)
{
SshStream ssh = new SshStream(ip, root, pass);
ssh.Prompt = "#";
ssh.RemoveTerminalEmulationCharacters = true;
//Writing to the SSH channel  
//string response = ssh.ReadResponse();
ssh.Write(command);
ssh.Flush();
ssh.Write("/n");
//Reading from the SSH channel  
String response = ssh.ReadResponse();
return response;
}
}
*/
    }
}

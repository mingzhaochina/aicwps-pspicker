using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace system
{
    public partial class FormLogin : Form
    {
        //public static string version_global = "";
        private string version_global = "";
        //public static bool if_online = false;
        internal static bool if_online=false;
        public static bool language = true; //程序语言设置

        public FormLogin()
        {
            InitializeComponent();
            ShowBg_img();//随机更换背景图片
        }
        //窗体加载事件
        private void FormLogin_Load(object sender, EventArgs e)
        {
            XmlReader xmlReader = null;
            try
            {
                //加载xml文档
                xmlReader = new XmlTextReader(Application.StartupPath + @"\xml\dbconnect.xml");//参数：存储的绝对路径
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlReader);
                XmlNode root = xmlDoc.DocumentElement;  //获取根节点                                
                XmlNode Version = root.SelectSingleNode("//version");
                {
                    qComboBoxVersion.Text = Version.InnerText;
                }
                XmlNode Language = root.SelectSingleNode("//language");
                {
                    qComboBoxLanguage.Text = Language.InnerText;
                }
                if (Language.InnerText == "Chinese")
                {
                    label1.Text = "用户名";
                    label2.Text = "密码";
                    label3.Text = "版本";
                    label4.Text = "语言";
                    ButtonEnter.Text = "确定";
                    ButtonCancel.Text = "取消";
                    ButtonSetting.Text = "设置";
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
        private void ShowBg_img()
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\bg_img\" + "4.jpg");//参数：存储图片文件的路径
            this.BackgroundImageLayout = ImageLayout.Tile;
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSpecAnyUser_Click(object sender, EventArgs e)
        {
            TextBoxUsername.Text = string.Empty;    //清空文本框
        }

        private void buttonSpecAnyPassword_Click(object sender, EventArgs e)
        {
            TextBoxPassword.Text = string.Empty;    //清空文本框
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            if (qComboBoxLanguage.Text == "Chinese")
            {
                language = true;
            }
            else
            {
                language = false;
            }
            FormSetting set = new FormSetting();
            set.ShowDialog();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string url = Application.StartupPath + @"\xml\dbconnect.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(url);

                XmlNode Version = xmlDoc.SelectSingleNode("//version");
                if (qComboBoxVersion.Text != null)
                {
                    Version.InnerText = qComboBoxVersion.Text;
                    version_global = qComboBoxVersion.Text;
                    if (version_global == "Online")
                    {
                        if_online = true;
                    }
                }

                XmlNode Language = xmlDoc.SelectSingleNode("//language");
                if (qComboBoxLanguage.Text == "Chinese")
                {
                    language = true;
                    Language.InnerText = qComboBoxLanguage.Text;
                }
                else
                {
                    language = false;
                    Language.InnerText = qComboBoxLanguage.Text;
                }
                xmlDoc.Save(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
            /*
            if (TextBoxUsername.Text == "admin" && TextBoxPassword.Text == "123456")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Username:admin  Password:123456","Warning");
            }
            */

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using System.Threading;

namespace system
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
            if (FormLogin.language == true)
            {
                this.Text = "连接设置";
                LabelSQL.Text = "服务器地址";
                LabelDB.Text = "服务器名";
                LabelUserName.Text = "用户名";
                LabelPassword.Text = "密码";
                LabelSystemname.Text = "系统名";
                LabelLocalIP.Text = "本地IP";
                ConnectButtonTest.Text = "测试";
                ConnectSaveButton.Text = "保存";
            }

        }
        //窗体加载
        private void FormSetting_Load(object sender, EventArgs e)
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
                    TextBoxSQL.Text = ip.InnerText;
                }
                XmlNode dbname = root.SelectSingleNode("//dbname");
                if (dbname != null)
                {
                    TextBoxDB.Text = dbname.InnerText;
                }
                XmlNode uid = root.SelectSingleNode("//uid");
                if (uid != null)
                {
                    TextBoxUsername.Text = uid.InnerText;
                }
                XmlNode pwd = root.SelectSingleNode("//pwd");
                if (pwd != null)
                {
                    TextBoxPassword.Text = pwd.InnerText;
                }
                XmlNode sysname = root.SelectSingleNode("//sysname");
                if (sysname != null)
                {
                    TextBoxSystem.Text = sysname.InnerText;
                }
                XmlNode ftp = root.SelectSingleNode("//ftp");
                if (ftp != null)
                {
                    TextBoxFTP.Text = ftp.InnerText;
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSpecAnySQL_Click(object sender, EventArgs e)
        {
            TextBoxSQL.Text = string.Empty;    //清空文本框
        }

        private void buttonSpecAnyDB_Click(object sender, EventArgs e)
        {
            TextBoxDB.Text = string.Empty;    //清空文本框
        }

        private void buttonSpecAnyUsername_Click(object sender, EventArgs e)
        {
            TextBoxUsername.Text = string.Empty;    //清空文本框
        }

        private void buttonSpecAnyPassword_Click(object sender, EventArgs e)
        {
            TextBoxPassword.Text = string.Empty;    //清空文本框
        }

        private void buttonSpecAnySystem_Click(object sender, EventArgs e)
        {
            TextBoxSystem.Text = string.Empty;    //清空文本框
        }

        private void buttonSpecAnyFTP_Click(object sender, EventArgs e)
        {
            TextBoxFTP.Text = string.Empty;    //清空文本框
        }

        private void ConnectButtonTest_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(() => connect());
            thread.Start();
        }

        private void connect()
        {
            SFTPHelper helper = new SFTPHelper(TextBoxSQL.Text, 22, TextBoxUsername.Text, TextBoxPassword.Text);
            helper.Connect();
            bool connect = helper.Connected;
            if (connect == true)
            {
                MessageBox.Show("连接成功！", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("连接失败！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            helper.Disconnect();
        }

        private void ConnectSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string url = Application.StartupPath + @"\xml\dbconnect.xml";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(url);
                XmlNode ip = xmlDoc.SelectSingleNode("//ip");
                if (ip != null)
                {
                    ip.InnerText = TextBoxSQL.Text;
                }
                XmlNode dbname = xmlDoc.SelectSingleNode("//dbname");
                if (dbname != null)
                {
                    dbname.InnerText = TextBoxDB.Text;
                }
                XmlNode uid = xmlDoc.SelectSingleNode("//uid");
                if (uid != null)
                {
                    uid.InnerText = TextBoxUsername.Text;
                }
                XmlNode pwd = xmlDoc.SelectSingleNode("//pwd");
                if (pwd != null)
                {
                    pwd.InnerText = TextBoxPassword.Text;   
                }
                XmlNode sysname = xmlDoc.SelectSingleNode("//sysname");
                if (sysname != null)
                {
                    sysname.InnerText = TextBoxSystem.Text;
                }
                XmlNode ftp = xmlDoc.SelectSingleNode("//ftp");
                if (ftp != null)
                {
                    ftp.InnerText = TextBoxFTP.Text;
                }
                xmlDoc.Save(url);
                MessageBox.Show("保存成功！", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //授权判断
        //获取本机的MAC地址

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Renci.SshNet;


namespace system
{
    public partial class FormChart : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private int picNum = 0;
        public string[] chartNames = null;
        private int downloadNum = 0; //for online
        public FormChart()
        {
            InitializeComponent();
            if (FormLogin.language == true)
            {
                this.Text = "图表";
                ButtonLast.Text = "上一张";
                ButtonNext.Text = "下一张";
            }
            if (FormLogin.if_online)
            {
                var result = FormMain.sshClient.RunCommand("ls " + FormMain.outPutPath_online + "/figures");
                if (result.Result == "")
                {
                    result = FormMain.sshClient.RunCommand("ls " + FormMain.outPutPath_online + "/figures_top");
                    
                }
                string[] file_list = result.Result.Split('\n');
                
                if (FormMain.picture_begin == "pl")
                {
                    Directory.CreateDirectory(FormMain.outPutPath + @"\figures");
                    foreach (var file_name in file_list)
                    {
                        if (file_name != "")
                        {
                            FormMain.download(FormMain.outPutPath_online + "/figures/" + file_name, FormMain.outPutPath + "/figures/" + file_name);
                        }
                        
                    }
                }
                else
                {
                    Directory.CreateDirectory(FormMain.outPutPath + @"\figures_top");
                    foreach (var file_name in file_list)
                    {
                        if(file_name != "")
                        {
                            FormMain.download(FormMain.outPutPath_online + "/figures_top/" + file_name, FormMain.outPutPath + "/figures_top/" + file_name);
                        }
                        
                    }
                }



            }
            string[] files;
            if (FormMain.picture_begin == "pl")
                files = Directory.GetFiles(FormMain.outPutPath + @"\figures");
            else
                files = Directory.GetFiles(FormMain.outPutPath + @"\figures_top");
            chartNames = files;
            if (files.Length == 0)
            {
                MessageBox.Show("No best picture found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bitmap MyBitMap = new Bitmap(chartNames[picNum]);
                pictureBox.Image = MyBitMap;
                labelFileName.Text = chartNames[picNum];
            }
        }
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            picNum++;
            if (picNum < chartNames.Length)
            {
                Bitmap MyBitMap = new Bitmap(chartNames[picNum]);
                pictureBox.Image = MyBitMap;
                labelFileName.Text = chartNames[picNum];
            }
            else
            {
                MessageBox.Show("This is the last picture!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                picNum--;
            }
        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {
            picNum--;
            if (picNum >= 0)
            {                
                Bitmap MyBitMap = new Bitmap(chartNames[picNum]);
                pictureBox.Image = MyBitMap;
                labelFileName.Text = chartNames[picNum];
            }
            else
            {
                MessageBox.Show("This is the first picture!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                picNum++;
            }
        }

        private void FormChart_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace system
{
    public partial class FormAbout : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FormAbout()
        {
            InitializeComponent();
            if (FormLogin.language == true)
                this.Text = "关于";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

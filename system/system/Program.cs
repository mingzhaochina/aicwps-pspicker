using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace system
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin login = new FormLogin();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                Application.Run(new FormMain());              
            }
            else
            {
                return;
            }
            
        }
    }
}

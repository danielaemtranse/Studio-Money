using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Studio_Money
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Studio_Money.Forms.frmMain());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace My_System_Helper
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm main = new MainForm();
            main_ref = main;

            

            Application.Run(main);
        }

        

        static MainForm main_ref = null;

        
    }
}

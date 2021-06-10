using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace H_Brains
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
            var login = new Login();
            if (login.ShowDialog() != DialogResult.OK)
            {
                return;

            }
            Application.Run(new Form2());
        }
            
            
            
       
    }
}

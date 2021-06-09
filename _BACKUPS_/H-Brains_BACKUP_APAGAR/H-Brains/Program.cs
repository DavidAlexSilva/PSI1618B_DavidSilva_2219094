using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

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
            Application.Run(new Login());
        }
            
            
            
        private static string _connectionString ="Server=127.0.0.1;Database=logins;Uid=root;Pwd=root";
        private static MySqlConnection db = new MySqlConnection(_connectionString);
        private static void Login() 
        {
            Console.Clear();
            Console.WriteLine("Login");

        
        }
    
    }
}

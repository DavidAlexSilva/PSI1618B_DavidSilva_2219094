using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace H_Brains
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private static MySqlConnection dbo = new MySqlConnection();

        private void Login_Load(object sender, EventArgs e)
        {

            MySqlCommand dbo = new MySqlCommand();
            MySqlConnection mySqlConnection = new MySqlConnection(); 

            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.PasswordChar = '*';
            textBox1.MaxLength = 10;
           
        } 
        
        
        
        
        
        private static void Log()
        {
                Console.Clear();
                Console.WriteLine("Login");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Parameters.Add("");

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if (Utilizador.Text == "explicador") 
            {
                if (Password.Text == "Hbrains") 
                {
                 new Form2().ShowDialog();
                 this.Hide();    
                }
                else 
                {
                    MessageBox.Show("ERRO");
                }
            }
            if (Utilizador.Text == "H_Tiago") 
            {
                if (Password.Text=="Hbrains") 
                {
                    new Form2().ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ERRO");
                }
            }
            /*else
            {
                MessageBox.Show("ERRO");
            }*/
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int res;
            Application.EnableVisualStyles();
            /*Application.SetCompatibleTextRenderingDefault();*/
            res = Convert.ToInt32(MessageBox.Show("Continuar","Mensagem",MessageBoxButtons.YesNo));
            

            if (res==1) 
            {
                MessageBox.Show("SIM", "Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                
                 
           
                
            } 
            
            else 
            { }
            if (res == 2) 
             {
             MessageBox.Show("NAO","Mensagem", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
             
            }
            Application.Exit();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form12().Show();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}

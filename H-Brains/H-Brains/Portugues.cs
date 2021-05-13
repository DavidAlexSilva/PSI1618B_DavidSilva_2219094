using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Brains
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form12().Show();
        }
        public class Login 
        {
            public static string Utilizador_Explicador { get; set; }
            public static string Utilizador_Aluno { get; set; }
            public Login() 
            {
                if (Login.Utilizador_Aluno=="explicador") 
                {
                    Console.Write("");
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                }
                else 
                {
                }
                if(Login.Utilizador_Aluno=="H_Tiago")
                {
                    new Form6();
                    Console.Read();

                }
            
            }
        }
    
    private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Login login = new Login();
            new Form6.Login();

            







        }
        
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
        }
    }
}

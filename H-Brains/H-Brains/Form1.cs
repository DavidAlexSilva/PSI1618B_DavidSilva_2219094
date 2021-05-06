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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.PasswordChar = '*';
            textBox1.MaxLength = 10;
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

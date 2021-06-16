using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

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

        private static SqlConnection dbo = new SqlConnection();

        public string Utlizador { get; internal set; }

        private void Login_Load(object sender, EventArgs e)
        {

            MySqlCommand dbo = new MySqlCommand();
            

            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*textBox1.Text = "";
            textBox1.PasswordChar = '*';
            textBox1.MaxLength = 10;/*
           
        } 
        
        
        
        

      private void button1_Click(object sender, EventArgs e) 
        {
            /*SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Conn.Open();
            SqlCommand Result = new SqlCommand();
            Result.Connection = Conn;
            Result.CommandText = @"
                select * from Login
                where log=@username and pass=@pass
                ";
            Result.Parameters.Add("@username", SqlDbType.VarChar).Value = Utilizador.Text;
            Result.Parameters.Add("@pass", SqlDbType.Int).Value = Password.Text;
            if (Result.ExecuteNonQuery() == 1) 
             {
                 MessageBox.Show("LOGIN INCORRETO");
                 return;
             }
             else
             {
                 DialogResult = DialogResult.OK;

             }

             Conn.Close();
             SqlConnection Conne = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
             Conne.Open();
             SqlCommand Comand = new SqlCommand();
             Comand.Connection = Conne;
             Comand.CommandText = @"
                 select * from Login
                 where log=@username and pass=@pass
                 ";
             Comand.Parameters.Add("@username", SqlDbType.VarChar).Value = Utilizador.Text;
             Comand.Parameters.Add("@pass", SqlDbType.Int).Value = Password.Text;
             int Resul = Comand.ExecuteNonQuery();
             if (Resul == 2)
             {
                 MessageBox.Show("LOGIN INCORRETO");
                 return;

             }
             else
             {
                 DialogResult = DialogResult.OK;

             }
             Conne.Open();

             */
            }

         private void pictureBox3_Click(object sender, EventArgs e)
         {
             int res;
             Application.EnableVisualStyles();
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

        private class MySqlCommand
        {
     
    }
}
}

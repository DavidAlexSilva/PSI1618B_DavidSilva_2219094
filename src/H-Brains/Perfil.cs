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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form12_Load(object sender, EventArgs e)
        {
         

           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Perf = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Perf.Open();
            SqlCommand perfi = new SqlCommand();
            perfi.Connection = Perf;
            perfi.CommandText = @"
                                     select * from alunos where PessoaId=21";
            DataTable Perfil = new DataTable();

            using (SqlDataReader reader = perfi.ExecuteReader())
            {
                Perfil.Load(reader);
            }
            textBox1.Text = Perfil.Rows[0]["Primeiro_Nome"].ToString();
        }

        private void Apelido_Click(object sender, EventArgs e)
        {
            SqlConnection Perf = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Perf.Open();
            SqlCommand perfi = new SqlCommand();
            perfi.Connection = Perf;
            perfi.CommandText = @"
                                   select * from alunos where PessoaId=21";
            DataTable Perfil = new DataTable();

            using (SqlDataReader reader = perfi.ExecuteReader())
            {
                Perfil.Load(reader);
            }
            textBox2.Text = Perfil.Rows[0]["Ultimo_Nome"].ToString();
        }

        private void Morada_Click(object sender, EventArgs e)
        {
            SqlConnection Perf = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Perf.Open();
            SqlCommand perfi = new SqlCommand();
            perfi.Connection = Perf;
            perfi.CommandText = @"select * from alunos where PessoaId=21";
            DataTable Perfil = new DataTable();

            using (SqlDataReader reader = perfi.ExecuteReader())
            {
                Perfil.Load(reader);
            }
            textBox3.Text = Perfil.Rows[0]["Morada"].ToString();
        }
    }
}

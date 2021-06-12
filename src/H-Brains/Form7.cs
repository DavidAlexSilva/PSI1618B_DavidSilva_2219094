using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Brains
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form12().Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection MAT = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            MAT.Open();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = MAT;
            Comando.CommandText = @"select * from Tarefas
  where TarefaID=73
 ";
            DataTable mats = new DataTable();
            using (SqlDataReader reader = Comando.ExecuteReader())
            {
                mats.Load(reader);

            }
            textBox1.Text = mats.Rows[0]["Texto"].ToString();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection MAT = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            MAT.Open();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = MAT;
            Comando.CommandText = @"SELECT TOP (1000) [TarefaID]
  ,[AlunoID]
  ,[MateriaId]
 ,[Data]
 ,[Texto]
  FROM [PSIM1619I_DavidSilva_2219094].[dbo].[Tarefas]
  where TarefaID = 73";
            DataTable mats = new DataTable();
            using (SqlDataReader reader = Comando.ExecuteReader())
            {
                mats.Load(reader);

            }
        }

       
    }
}

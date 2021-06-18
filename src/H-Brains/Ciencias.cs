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
    public partial class Form8 : Form
    {
        public Form8()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            CN.Open();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = CN;
            Comando.CommandText = @"   select * from Tarefas
  where TarefaID=68";
            DataTable cin = new DataTable();
            using (SqlDataReader reader = Comando.ExecuteReader())
            {
                cin.Load(reader);

            }

            foreach (DataRow dr in cin.Rows)
            {

                textBox1.Text = dr["Texto"].ToString() + "\n";

                foreach (DataRow row in cin.Rows)
                {

                    textBox1.Text = dr["Texto"].ToString() + "\n";

                }
            }
        }

        private static void Form8_Load1(object sender, EventArgs e)
        {
            SqlConnection Cien = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Cien.Open();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Cien;
            Comando.CommandText = @"SELECT TOP (1000) [TarefaID]
,[AlunoID] 
,[MateriaId]
,[Data]
 ,[Texto]
  FROM [PSIM1619I_DavidSilva_2219094].[dbo].[Tarefas]
  where TarefaID = 68";
            DataTable ci = new DataTable();
            using (SqlDataReader reader = Comando.ExecuteReader())
            {

                ci.Load(reader);

            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            new vericacao().Show();
        }
    }
}
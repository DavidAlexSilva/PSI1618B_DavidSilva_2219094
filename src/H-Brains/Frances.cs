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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form12().Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            SqlConnection FRN = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            FRN.Open();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = FRN;
            Comando.CommandText = @"SELECT TOP (1000) [TarefaID]
      ,[AlunoID]
      ,[MateriaId]
      ,[Data]
      ,[Texto]
  FROM [PSIM1619I_DavidSilva_2219094].[dbo].[Tarefas]
  where TarefaID = 74";
            DataTable fcs = new DataTable();
            using (SqlDataReader reader=Comando.ExecuteReader()) 
            {
                fcs.Load(reader);
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection Tare = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Tare.Open();
            SqlCommand ComFranc= new SqlCommand();
            ComFranc.Connection = Tare;
            ComFranc.CommandText = @"
                                       
    select * from Tarefas
  where TarefaID=74";
            DataTable fr = new DataTable();
            using (SqlDataReader reader = ComFranc.ExecuteReader())
            {
                fr.Load(reader);
            }
            textBox1.Text = fr.Rows[0]["Texto"].ToString();
        }
    }
}

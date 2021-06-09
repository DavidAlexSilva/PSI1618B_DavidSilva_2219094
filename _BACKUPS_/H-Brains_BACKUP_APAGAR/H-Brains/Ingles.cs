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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
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

        private void Form11_Load(object sender, EventArgs e)
        {
            SqlConnection ING = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            ING.Open();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = ING;
            Comando.CommandText = @"   SELECT TOP (1000) [TarefaID]
      ,[AlunoID]
      ,[MateriaId]
      ,[Data]
      ,[Texto]
  FROM [PSIM1619I_DavidSilva_2219094].[dbo].[Tarefas]
  where TarefaID = 69";
            DataTable ings = new DataTable();
            using (SqlDataReader reader = Comando.ExecuteReader())
            {
                ings.Load(reader);

            }

        }
    }
}

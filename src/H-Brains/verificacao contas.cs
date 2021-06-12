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
    public partial class verificacao_contas : Form
    {
        public verificacao_contas()
        {
            InitializeComponent();
        }

        private void Tabela_Materias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Conn.Open();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conn;
            Comando.CommandText = @"SELECT  [log]
      ,[pass]
  FROM [PSIM1619I_DavidSilva_2219094].[dbo].[Login]";

            DataTable dt = new DataTable();
            using (SqlDataReader reader = Comando.ExecuteReader())
            {
                dt.Load(reader);
            }
            Tabela_Materias.DataSource = dt;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            new Form3().Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
    }
}

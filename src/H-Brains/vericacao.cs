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
    public partial class vericacao : Form
    {

        public vericacao()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

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

        private void Tabela_Materias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vericacao_Load(object sender, EventArgs e)
        {

            SqlConnection ver = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            ver.Open();
            SqlCommand alunos = new SqlCommand();
            alunos.Connection = ver;
            alunos.CommandText = @"
select * from Login
inner join alunos on Login.PessoaID=alunos.PessoaId
";


          DataTable dt = new DataTable();
            using (SqlDataReader reader = alunos.ExecuteReader())
            {
                dt.Load(reader);
            }
            Verificacao.DataSource = dt;






        }

     




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Verificacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
             new vericar2().Show();
        }
    }
}

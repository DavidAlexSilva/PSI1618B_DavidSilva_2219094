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
    public partial class vericar2 : Form
    {

        public vericar2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void verificar2_Load(object sender, EventArgs e)
        {
                SqlConnection ver = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            ver.Open();
            SqlCommand alunos = new SqlCommand();
            alunos.Connection = ver;
            alunos.CommandText = @"
select * from Login
inner join explicadores on Login.PessoaID=explicadores.PessoaId

";


          DataTable dt = new DataTable();
            using (SqlDataReader reader = alunos.ExecuteReader())
            {
                dt.Load(reader);
            }
           Verificacao_explic.DataSource = dt;


        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            new vericacao().Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            new Form5().ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

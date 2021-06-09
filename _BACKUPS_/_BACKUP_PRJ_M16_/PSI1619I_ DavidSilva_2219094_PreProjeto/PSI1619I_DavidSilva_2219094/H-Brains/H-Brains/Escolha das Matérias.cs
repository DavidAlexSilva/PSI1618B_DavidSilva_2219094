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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Tabela_Materias_TextChanged(object sender, EventArgs e)
        {

        }

        private void Materias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form12().Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {   
           
            

            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Conn.Open();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conn;
            Comando.CommandText = @"SELECT
concat(alunos.Primeiro_Nome, ' ', alunos.Ultimo_Nome) AS 'Aluno',
Materias.Nome,
concat(explicadores.Primeiro_Nome,'',explicadores.Ultimo_Nome) as 'Explicadores'
FROM Tarefas
INNER JOIN alunos ON alunos.PessoaId = Tarefas.AlunoID
INNER JOIN Materias ON Materias.MateriaId = Tarefas.MateriaId
INNER JOIN explicadores ON explicadores.PessoaId = Materias.ExplicadorID";
          
          DataTable dt = new DataTable();
            using (SqlDataReader reader = Comando.ExecuteReader()) 
            {
              dt.Load(reader);
            }
           Tabela_Materias.DataSource = dt;
        } 
    }
}

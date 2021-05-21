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
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HBrains"].ConnectionString);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = @"select 
                alunos.Primeiro_Nome + ' ' + alunos.Ultimo_Nome as 'Aluno',
                Materias.Nome as 'Disciplina',
                explicadores.Primeiro_Nome + ' ' + explicadores.Ultimo_Nome as 'Explicador'
                from Tarefas
                inner join alunos on alunos.PessoaId = Tarefas.AlunoID
                inner
                join Materias on Materias.MateriaId = Tarefas.MateriaId
                inner
                join Materia_Has_Explicador on Materia_Has_Explicador.MateriaId = Materias.MateriaId
                inner
                join explicadores on explicadores.PessoaId = Materia_Has_Explicador.ExplicadorID";
            
            DataTable dt = new DataTable();
            using (SqlDataReader reader = command.ExecuteReader()) 
            {
              dt.Load(reader);
            }
            Tabela_Materias.DataSource = dt;

            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Conn.Open();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conn;
            command.CommandText = @"select 
                                alunos.Primeiro_Nome + ' ' + alunos.Ultimo_Nome as 'Aluno',
                                Materias.Nome as 'Disciplina',
                                explicadores.Primeiro_Nome + ' ' + explicadores.Ultimo_Nome as 'Explicador'
                                from Tarefas
                                inner join alunos on alunos.PessoaId = Tarefas.AlunoID
                                inner
                                join Materias on Materias.MateriaId = Tarefas.MateriaId
                                inner
                                join Materia_Has_Explicador on Materia_Has_Explicador.MateriaId = Materias.MateriaId
                                inner
                                join explicadores on explicadores.PessoaId = Materia_Has_Explicador.ExplicadorID";
 
          

        }
    }
}

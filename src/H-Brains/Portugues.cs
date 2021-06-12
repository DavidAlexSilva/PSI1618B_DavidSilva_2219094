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
    public partial class Form6 : Form
    {
        public Form6()
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
        public class Login 
        {
            public static string Utilizador_Explicador { get; set; }
            public static string Utilizador_Aluno { get; set; }
            public Login() 
            {
                if (Login.Utilizador_Aluno=="explicador") 
                {
                    Console.Write("");
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                }
                else 
                {
                }
                if(Login.Utilizador_Aluno=="H_Tiago")
                {
                    new Form6();
                    Console.Read();

                }
            
            }
        }
    
    private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }
        
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Conn.Open();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conn;
            Comando.CommandText = @"SELECT TOP (1000) [TarefaID]
      ,[AlunoID]
      ,[MateriaId]
      ,[Data]
      ,[Texto]
            FROM[PSIM1619I_DavidSilva_2219094].[dbo].[Tarefas]
    where TarefaID = 72";
            DataTable dw = new DataTable();
            using (SqlDataReader reader = Comando.ExecuteReader())
            {
                dw.Load(reader);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection Tare = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Tare.Open();
            SqlCommand ComPort = new SqlCommand();
            ComPort.Connection = Tare;
            ComPort.CommandText = @"
                                     select * from Tarefas
  where TarefaID=72";
            DataTable pt = new DataTable();
            using (SqlDataReader reader = ComPort.ExecuteReader())
            {
                pt.Load(reader);
            }
            textBox1.Text = pt.Rows[0]["Texto"].ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form5 : Form
    {
        public Form5()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            new Form12().Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            new vericacao().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Cale = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Cale.Open();
            SqlCommand Calend = new SqlCommand();
            Calend.Connection = Cale;
            Calend.CommandText = @"
                                     select *from Tarefas
 where TarefaID=79;";
            DataTable calenda = new DataTable();

            using (SqlDataReader reader = Calend.ExecuteReader())
            {
                calenda.Load(reader);
            }
            textBox1.Text = calenda.Rows[0]["Texto"].ToString();

            using (SqlDataReader reader = Calend.ExecuteReader())
            {
                calenda.Load(reader);
            }
            textBox1.Text = calenda.Rows[0]["Texto"].ToString();


         
           

        
        }

        private void SaveFileDialog(TextBox textBox)
        {
            throw new NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Cale_mat = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Cale_mat.Open();
            SqlCommand Calend_mat = new SqlCommand();
            Calend_mat.Connection = Cale_mat;
            Calend_mat.CommandText = @"
                                      select *from Tarefas
 where TarefaID=81";
            DataTable calenda_mat = new DataTable();

            using (SqlDataReader reader = Calend_mat.ExecuteReader())
            {
                calenda_mat.Load(reader);
            }
            textBox2.Text = calenda_mat.Rows[0]["Texto"].ToString();

            using (SqlDataReader reader = Calend_mat.ExecuteReader())
            {
                calenda_mat.Load(reader);
            }
            textBox2.Text = calenda_mat.Rows[0]["Texto"].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection Cale_cie = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Cale_cie.Open();
            SqlCommand Calend_cien = new SqlCommand();
            Calend_cien.Connection = Cale_cie;
            Calend_cien.CommandText = @"
                                       select *from Tarefas
 where TarefaID=82";
            DataTable calenda_cie = new DataTable();

            using (SqlDataReader reader = Calend_cien.ExecuteReader())
            {
                calenda_cie.Load(reader);
            }
            textBox3.Text = calenda_cie.Rows[0]["Texto"].ToString();

            using (SqlDataReader reader = Calend_cien.ExecuteReader())
            {
                calenda_cie.Load(reader);
            }
            textBox3.Text = calenda_cie.Rows[0]["Texto"].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection Cale_Fran = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Cale_Fran.Open();
            SqlCommand Calend_Fran = new SqlCommand();
            Calend_Fran.Connection = Cale_Fran;
            Calend_Fran.CommandText = @"
                                        select *from Tarefas
 where TarefaID=83";
            DataTable calenda_Fran = new DataTable();

            using (SqlDataReader reader = Calend_Fran.ExecuteReader())
            {
                calenda_Fran.Load(reader);
            }
            textBox4.Text = calenda_Fran.Rows[0]["Texto"].ToString();

            using (SqlDataReader reader = Calend_Fran.ExecuteReader())
            {
                calenda_Fran.Load(reader);
            }
            textBox4.Text = calenda_Fran.Rows[0]["Texto"].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection Cale_FQ = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Cale_FQ.Open();
            SqlCommand Calend_FQ = new SqlCommand();
            Calend_FQ.Connection = Cale_FQ;
            Calend_FQ.CommandText = @"
                                          select *from Tarefas
 where TarefaID=84";
            DataTable calenda_FQ = new DataTable();

            using (SqlDataReader reader = Calend_FQ.ExecuteReader())
            {
                calenda_FQ.Load(reader);
            }
            textBox5.Text = calenda_FQ.Rows[0]["Texto"].ToString();

            using (SqlDataReader reader = Calend_FQ.ExecuteReader())
            {
                calenda_FQ.Load(reader);
            }
            textBox5.Text = calenda_FQ.Rows[0]["Texto"].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection Cale_IG = new SqlConnection(ConfigurationManager.ConnectionStrings["Hbrains"].ConnectionString);
            Cale_IG.Open();
            SqlCommand Calend_IG = new SqlCommand();
            Calend_IG.Connection = Cale_IG;
            Calend_IG.CommandText = @"
                                           select *from Tarefas
 where TarefaID=85";
            DataTable calenda_IG  = new DataTable();

            using (SqlDataReader reader = Calend_IG.ExecuteReader())
            {
                calenda_IG.Load(reader);
            }
            textBox6.Text = calenda_IG.Rows[0]["Texto"].ToString();

            using (SqlDataReader reader = Calend_IG.ExecuteReader())
            {
                calenda_IG.Load(reader);
            }
            textBox6.Text = calenda_IG.Rows[0]["Texto"].ToString();
        }
    }
}

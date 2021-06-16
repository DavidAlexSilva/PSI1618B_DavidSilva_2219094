using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Brains
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            new Form2().Show();
           
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            new SaveFileDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            new Form12().Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            new vericacao().Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
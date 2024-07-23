using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace LegendTaskManager2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                var newForm5 = new Form5();
                newForm5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter email address and password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }
    }
}

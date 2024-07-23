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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }
    }
}

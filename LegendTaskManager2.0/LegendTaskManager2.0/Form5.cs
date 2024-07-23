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
    public partial class Form5 : Form
    {
        SqlDataAdapter adapt;
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-U7UAGSB;Initial Catalog=TaskManager;Integrated Security=True");
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Tasks", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Tasks values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Task Inserted Successfully.");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}

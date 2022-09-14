
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse__
{
    public partial class Product_List : NikkiBase
    {

      //  SqlConnection con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30");

        String cs = @"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public Product_List()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

       

        private void Product_List_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Product", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            
      

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Product where p_id like '" + textBox1.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Product where type like '" + textBox2.Text + "%' ", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Product where  size_id like '" + textBox3.Text + "%' ", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Product where finish_id like '" + textBox4.Text + "%' ", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Product where  model_no like '" + textBox5.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}

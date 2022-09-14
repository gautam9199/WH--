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
    public partial class CustomerList : NikkiBase
    {
      //  SqlConnection con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30");

        String cs = @"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public CustomerList()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Customer where c_name like '" + textBox1.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            // dataGridView1.BackColor = Color.FromArgb(150, 0, 0, 0);

            // you can write this code in rowdatabound event


            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Customer", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


      


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Customer where  company_name like '" + textBox2.Text + "%' ", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Customer where  phone_no like '" + textBox3.Text + "%' ", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Customer where address like '" + textBox4.Text + "%' ", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Customer where email like '" + textBox5.Text + "%' ", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Customer where  website like '" + textBox6.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}

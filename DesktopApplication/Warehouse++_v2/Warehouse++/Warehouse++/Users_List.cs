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
    public partial class Users_List : NikkiBase
    {

     //   SqlConnection con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30");


        String cs = @"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public Users_List()
        {
            InitializeComponent();
        }

        private void Users_List_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select user_id,username,name,phone_no,address,userType from Login", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Customer where c_id like '" + textBox1.Text + "%' OR c_name like '" + textBox1.Text + "%' or company_name like '" + textBox1.Text + "%' or phone_no like '" + textBox1.Text + "%' or email like '" + textBox1.Text + "%'", con);

            dt = new DataTable();
            
            adapt.Fill(dt);
     
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}

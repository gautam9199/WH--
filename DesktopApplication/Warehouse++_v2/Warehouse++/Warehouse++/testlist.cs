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
    public partial class testlist : Form
    {

        String cs = @"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public testlist()
        {
            InitializeComponent();
        }

        private void testlist_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Location", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Warehouse__
{
    public partial class Order_List : NikkiBase
    {

        String cs = @"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        List<String> coid = new List<String>();
        List<String> icoid = new List<String>();
        List<String> dtime = new List<String>();
        List<String> cname = new List<String>();
        List<String> comname = new List<String>();
        List<String> pq = new List<String>();
        String ciid,cnameS,comnameS,dtimeS,pqS;


        public Order_List()
        {
            InitializeComponent();
        }

     

        private void Order_List_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            // dataGridView1.BackColor = Color.FromArgb(150, 0, 0, 0);

            // you can write this code in rowdatabound event


            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Order1", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            /*     string[][] Array = new string[100][];
                for (int i = 0; i < 100; i++) // Set some values to test
              Array[i] = new string[2] { "Value 1", "Value 2" };

                  dataGridView1.DataSource = (from arr in Array select new { Col1 = arr[0], Col2 = arr[1] });
                      Page.DataBind(); */

        }

     
    }
}

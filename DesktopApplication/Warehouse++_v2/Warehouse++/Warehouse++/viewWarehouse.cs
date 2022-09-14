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
    public partial class viewWarehouse : NikkiBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30");

        public void viewPL(String lid)
        {

            List<String> pidList = new List<String>();
            rt.Text = String.Empty;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select DISTINCT p_id  From qrGenerate where l_id='" + lid + "' and qr_removed='no'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {

                pidList.Add(rd["p_id"].ToString());

            }

            rd.Close();

            String[] numArr = pidList.ToArray();
            for (int i = 0; i < numArr.Length; i++)
            {
                //  qrGen(numArr[i]);
                SqlCommand cmd1 = new SqlCommand("Select count(*) AS quan  From qrGenerate where l_id='" + lid + "' and qr_removed='no' and p_id='" + numArr[i] + "'", con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if (rd1.Read())
                {
                    rt.AppendText("Product id=" + numArr[i] + "quan=" + rd1["quan"].ToString() + "\n");
                }
                rd1.Close();
            }
            con.Close();
        }
        public viewWarehouse()
        {
            InitializeComponent();
        }


        private void waa1_Click(object sender, EventArgs e)
        {
            viewPL("wa-a1");
        }

        private void waa2_Click_1(object sender, EventArgs e)
        {
            viewPL("wa-a2");
        }

        private void waa3_Click(object sender, EventArgs e)
        {
            viewPL("wa-a3");
        }

        private void waa4_Click(object sender, EventArgs e)
        {
            viewPL("wa-a4");
        }

        private void waa62_Click(object sender, EventArgs e)
        {

        }

        private void viewWarehouse_LocationChanged(object sender, EventArgs e)
        {

        }

        private void viewWarehouse_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void waa42_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void waa50_Click(object sender, EventArgs e)
        {

        }

        private void waa43_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void waa34_Click(object sender, EventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            viewPL("wa-a6");
        }

        private void waa5_Click(object sender, EventArgs e)
        {
            viewPL("wa-a5");
        }
    }
}

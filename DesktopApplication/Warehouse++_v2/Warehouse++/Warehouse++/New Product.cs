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
    public partial class New_Product : NikkiBase
    {
        public static string passingtext,passingtype,passingsize,passingfinish,pid;

        //SqlDataReader rd;
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30");

        public New_Product()
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void resetbt_Click(object sender, EventArgs e)
        {
            mnotb.Text = "";
            typecb.Text = "";
            sizecb.Text = "";
            fincb.Text = "";
            ratetb.Text = "";
            boxtb.Text = "";
            quanttb.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //passingtext = mnotb.text;
            // passingtype = typecb.text;
            // passingsize = sizecb.text;
            // passingfinish = fincb.text; 
            //QRgenerator qrg = new QRgenerator();
            //qrg.Show();
            /*  QRgenerator qrt = new QRgenerator();
              qrt.Show();
              this.Hide();   
              SqlCommand cmd = new SqlCommand("INSERT INTO Product VALUES ('" + mnotb.Text + "','" + typecb.Items[0].ToString() + "','" + sizecb.Items[0].ToString() + "','" + fincb.Items[0].ToString() + "','" + ratetb.Text + "','" + boxtb.Text + "','" + quanttb.Text + "')", con);

              int m = cmd.ExecuteNonQuery(); */

            if (mnotb.Text != "" && typecb.Text != "" && sizecb.Text.ToString() != "" && fincb.Text != "" && ratetb.Text != "" && boxtb.Text != "" && quanttb.Text != "")
            {
                pid = mnotb.Text + '_' + typecb.Text + '_' + sizecb.Text + '_' + fincb.Text;

            con.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO Product VALUES('"+pid+"','" + mnotb.Text + "','" + typecb.Text + "','" + sizecb.Text + "','" + fincb.Text + "','" + ratetb.Text + "','" + boxtb.Text.ToString() + "','" + quanttb.Text + "','"+0+"')", con);
                int i=cmd1.ExecuteNonQuery();
            if (i > 0)
            {
                mnotb.Text = "";
                typecb.Text = "";
                sizecb.Text = "";
                fincb.Text = "";
                ratetb.Text = "";
                boxtb.Text = "";
                quanttb.Text = "";
                MessageBox.Show("Product Added Successfully");

            }
            con.Close();
            }
            else
            {
                MessageBox.Show("Kindly Fill Required Details");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void New_Product_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
    }
}

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
    public partial class New_Customer : NikkiBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30");

        public New_Customer()
        {
            InitializeComponent();
        }

        private void New_Customer_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

       

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Com_name.Text = "";
            cname.Text = "";
            C_contact.Text = "";
            c_add.Text = "";
            c_email.Text = "";
            c_web.Text = "";
          

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (Com_name.Text != "" && cname.Text != "" && C_contact.Text.ToString() != "" && c_add.Text != "")
            {

                con.Open();
                SqlCommand cmd1 = new SqlCommand("INSERT INTO Customer VALUES('" + cname.Text + "','" + Com_name.Text + "','" + C_contact.Text.ToString() + "','" + c_add.Text + "','" + c_email.Text + "','" + c_web.Text + "')", con);
                int i = cmd1.ExecuteNonQuery();
                if (i > 0)
                {
                    Com_name.Text = "";
                    cname.Text = "";
                    C_contact.Text = "";
                    c_add.Text = "";
                    c_email.Text = "";
                    c_web.Text = "";
                    MessageBox.Show("Customer Added Successfully");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Kindly Fill Required Details");
            }
        }
    }
}

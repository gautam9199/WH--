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
    public partial class Add_User : NikkiBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30");

        public Add_User()
        {
            InitializeComponent();
        }

        private void Add_User_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void utypet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (unamet.Text != "" && usernamet.Text != "" && contactt.Text.ToString() != "" && addt.Text != "" && comboBox1.SelectedItem.ToString() != "" && pwdt.Text != "" )
            {

                con.Open();
                SqlCommand cmd1 = new SqlCommand("INSERT INTO Login VALUES('" + usernamet.Text + "','" + pwdt.Text.ToString() + "','" + unamet.Text + "','" + contactt.Text.ToString() + "','" + addt.Text.ToString() + "','" + comboBox1.SelectedItem.ToString() + "')", con);
                int i = cmd1.ExecuteNonQuery();
                if (i > 0)
                {
                    unamet.Text = "";
                    contactt.Text = "";
                    addt.Text = "";
                    comboBox1.Text = "";
                    pwdt.Text = "";
                    usernamet.Text = "";
                    MessageBox.Show("User Added Successfully");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Required Fields");
            }
        }

        private void unamet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            unamet.Text = "";
            contactt.Text = "";
            addt.Text = "";
            comboBox1.Text = "";
            pwdt.Text = "";
            usernamet.Text = "";

        }
    }
}

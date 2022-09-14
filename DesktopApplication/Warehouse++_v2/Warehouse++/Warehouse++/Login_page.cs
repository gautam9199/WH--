using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Warehouse__
{
    public partial class Login_page: withoutms
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30");


        public Login_page()
        {
            InitializeComponent();
           
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

         //   SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\project_software\warehouse++finalized\Warehouse++\Warehouse++\proj_database.mdf; Integrated Security = True; Connect Timeout = 30");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select * From Login Where username = '"+ Username_txt.Text+"' and password = '"+ Password_txt.Text+"'",con);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                this.Hide();
                Mainpage ss = new Mainpage();
                ss.Show();
                rd.Close();
            }
           
             else
            {
                MessageBox.Show("Invalid Username or Password");
                rd.Close();
            }
            con.Close();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Login_page_Load(object sender, EventArgs e)
        {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
        
        /*   this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
          this.WindowState = FormWindowState.Maximized;*/
            this.AcceptButton = Login_btn;

        }

        private void Username_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_page_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    
    

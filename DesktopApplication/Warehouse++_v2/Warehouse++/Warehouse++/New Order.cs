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
    public partial class New_Order : NikkiBase
    {
        static String company_name;
         static int co_id,c_id;

        SqlConnection con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30");

        public void addRate(ComboBox pid, TextBox rate) {
            // DataRowView drv = (DataRowView)pid.SelectedItem;
            // String valueOfItem = drv["p_id"].ToString();
           // String valueOfItem = pid.Text.ToString();
            String valueOfItem = pid.SelectedItem.ToString();

            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select rate From Product Where p_id='" + valueOfItem + "'", con);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                rate.Text = rd[0].ToString();
            }
            else {
             //   MessageBox.Show("no value");
            }

            rd.Close();
            con.Close();
        }

        public void calculateAmount(TextBox q,TextBox r,TextBox a)
        {
            int quantity = int.Parse(q.Text);
            int rate = int.Parse(r.Text);

            int amount = quantity * rate;
            a.Text = (amount.ToString());

            total_price.Text=(int.Parse(total_price.Text)+ int.Parse(a.Text)).ToString();

        }

        public void addOrder(ComboBox pid,TextBox quant) {
            //    DataRowView drv = (DataRowView)pid.SelectedItem;
            //   String valueOfItem = drv["p_id"].ToString();
            String valueOfItem = pid.SelectedItem.ToString();

            con.Open();
            SqlCommand cmd2 = new SqlCommand("INSERT INTO Order1 VALUES('" + o_num.Text + "','" + c_id.ToString() + "','"+o_date.Text+"','" + valueOfItem+"','"+quant.Text+"')", con);
            int i = cmd2.ExecuteNonQuery();
            if (i > 0)
            {
              //nothing
            }
            con.Close();
        }

        public New_Order()
        {
            InitializeComponent();           
        }

    
        private void New_Order_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;


            con.Open();

            SqlCommand cmd8 = new SqlCommand("Select DISTINCT p_id From Product", con);
            SqlDataReader rd8 = cmd8.ExecuteReader();
            while (rd8.Read())
            {
                comboBox1.Items.Add(rd8["p_id"]);
                comboBox2.Items.Add(rd8["p_id"]);
                comboBox3.Items.Add(rd8["p_id"]);
                comboBox4.Items.Add(rd8["p_id"]);
                comboBox5.Items.Add(rd8["p_id"]);
                comboBox6.Items.Add(rd8["p_id"]);
            }
            rd8.Close();

            con.Close();


            //  this.productTableAdapter.Fill(this.proj_databaseDataSet.Product);
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            con.Open();

            SqlCommand cmd3 = new SqlCommand("Select DISTINCT company_name From Customer", con);
            SqlDataReader rd = cmd3.ExecuteReader();
            while (rd.Read())
            {
                comboBox7.Items.Add(rd["company_name"]);
            }
            rd.Close();

            //for getting c_od number
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Order1 WHERE co_id=(SELECT max(co_id) FROM Order1)", con);
            SqlDataReader rd1 = cmd1.ExecuteReader();
            while (rd1.Read())
            {
                co_id = int.Parse(rd1["co_id"].ToString());
            }
            rd1.Close();
            con.Close();
            if (co_id < 1)
            {
                co_id = 1;
                o_num.Text = co_id.ToString();
            }
            else
            {
                co_id += 1;
                o_num.Text = co_id.ToString();
            }
            o_date.Text = DateTime.Now.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            addRate(comboBox1, r1);
        }

        private void comboBox2_DropDownClosed(object sender, EventArgs e)
        {
            addRate(comboBox2, r2);
        }

        private void comboBox3_DropDownClosed(object sender, EventArgs e)
        {
            addRate(comboBox3, r3);
        }

        private void comboBox4_DropDownClosed(object sender, EventArgs e)
        {
            addRate(comboBox4, r4);
        }


        private void comboBox5_DropDownClosed(object sender, EventArgs e)
        {
            addRate(comboBox5, r5);
        }

        private void comboBox6_DropDownClosed(object sender, EventArgs e)
        {
            addRate(comboBox6, r6);
        }

        private void q1_TextChanged(object sender, EventArgs e)
        {
            calculateAmount(q1, r1, a1);
        }

        private void q2_TextChanged(object sender, EventArgs e)
        {
            calculateAmount(q2, r2, a2);
        }

        private void q3_TextChanged(object sender, EventArgs e)
        {
            calculateAmount(q3, r3, a3);
        }

        private void q4_TextChanged(object sender, EventArgs e)
        {
            calculateAmount(q4, r4, a4);
        }

        private void q5_TextChanged(object sender, EventArgs e)
        {
            calculateAmount(q5, r5, a5);
        }

        private void q6_TextChanged(object sender, EventArgs e)
        {
            calculateAmount(q6, r6, a6);
        }

        private void place_Click(object sender, EventArgs e)
        {
            if (int.Parse(total_price.Text) != 0)
            {
                if (int.Parse(a1.Text) != 0)
                {
                    addOrder(comboBox1, q1);
                }
                if (int.Parse(a2.Text) != 0)
                {
                    addOrder(comboBox2, q2);
                }
                if (int.Parse(a3.Text) != 0)
                {
                    addOrder(comboBox3, q3);
                }
                if (int.Parse(a4.Text) != 0)
                {
                    addOrder(comboBox4, q4);
                }
                if (int.Parse(a5.Text) != 0)
                {
                    addOrder(comboBox5, q5);
                }
                if (int.Parse(a6.Text) != 0)
                {
                    addOrder(comboBox6, q6);
                }

                MessageBox.Show("Order Placed Successfully");
            }
            else
            {
                MessageBox.Show("Kindly Add items");
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_DropDownClosed_1(object sender, EventArgs e)
        {
            company_name = comboBox7.SelectedItem.ToString();
            con.Open();
            SqlCommand cmd4 = new SqlCommand("Select DISTINCT c_name From Customer Where company_name='" + company_name + "'", con);
            SqlDataReader rd = cmd4.ExecuteReader();
            while (rd.Read())
            {
                comboBox8.Items.Add(rd["c_name"]);
            }
            rd.Close();
            con.Close();
        }

        private void c_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void o_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void o_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_DropDownClosed(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd5 = new SqlCommand("Select * From Customer Where company_name='" + company_name + "' AND c_name='"+comboBox8.SelectedItem.ToString()+"'", con);
            SqlDataReader rd = cmd5.ExecuteReader();
            if (rd.Read())
            {
                c_id = int.Parse(rd["c_id"].ToString());
                c_contact.Text = rd["phone_no"].ToString();
                c_email.Text = rd["email"].ToString();
                c_add.Text = rd["address"].ToString();
                
            }
            rd.Close();
            con.Close();
        }
    }
}

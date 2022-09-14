using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse__
{
    public partial class Mainpage : NikkiBase
    {
        public Mainpage()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            addproduct_btn.Hide();
            Productlist_btn.Hide();
            Viewwarehouse_btn.Hide();
           // Expandwarehouse_btn.Hide();
            neworder_btn.Hide();
            Orderlist_btn.Hide();
            Addcustomer_btn.Hide();
            Customerlist_btn.Hide();
            addqrbtn.Hide();
            addstockbtn.Hide();

            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();

        }

        private void Mainpage_Load(object sender, EventArgs e)
        {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Product product = new New_Product();
            product.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product_List prolist = new Product_List();
            prolist.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Order order = new New_Order();
            order.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            neworder_btn.Show();
            Orderlist_btn.Show();
           
            pictureBox6.Show();
         
         
            pictureBox10.Show();
            

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            addproduct_btn.Show();
            Productlist_btn.Show();
            pictureBox4.Show();
     
            pictureBox8.Show();
         

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Customer customer = new New_Customer();
            customer.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            New_Product product = new New_Product();
            product.Show();
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_List prolist = new Product_List();
            prolist.Show();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Order order = new New_Order();
            order.Show();
        }

        private void orderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_List olist = new Order_List();
            olist.Show();

        }

        private void Orderlist_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order_List olist = new Order_List();
            olist.Show();
        }

        private void Addcustomer_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Customer customer = new New_Customer();
            customer.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customerlist_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerList cl = new CustomerList();
            cl.Show();
        }

        private void Warehouse_btn_Click(object sender, EventArgs e)
        {
            Viewwarehouse_btn.Show();
        //    Expandwarehouse_btn.Show();
            addstockbtn.Show();
            addqrbtn.Show();

            pictureBox5.Show();
           
            pictureBox9.Show();
            pictureBox12.Show();
        }

        private void Customer_btn_Click(object sender, EventArgs e)
        {
            Addcustomer_btn.Show();
            Customerlist_btn.Show();
           
            pictureBox7.Show();
           
            pictureBox11.Show();
        }

        private void vIewWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void expandWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerLsitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Product_btn5_MouseDown(object sender, MouseEventArgs e)
        {

            addproduct_btn.Hide();
            Productlist_btn.Hide();
            pictureBox4.Hide();

            pictureBox8.Hide();
        }

        private void Warehouse_btn_MouseDown(object sender, MouseEventArgs e)
        {
            Viewwarehouse_btn.Hide();
         //   Expandwarehouse_btn.Hide();
            addstockbtn.Hide();
            addqrbtn.Hide();
            pictureBox5.Hide();

            pictureBox9.Hide();

            pictureBox12.Hide();


        }

        private void sales_btn_MouseDown(object sender, MouseEventArgs e)
        {
            neworder_btn.Hide();
            Orderlist_btn.Hide();

            pictureBox6.Hide();

            pictureBox10.Hide();
        }

        private void Customer_btn_MouseDown(object sender, MouseEventArgs e)
        {
            Addcustomer_btn.Hide();
            Customerlist_btn.Hide();
            pictureBox7.Hide();

            pictureBox11.Hide();
        }

        private void Expandwarehouse_btn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addstockbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock_add sd = new Stock_add();
            sd.Show();
        }

        private void Viewwarehouse_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewWarehouse vw = new viewWarehouse();
            vw.Show();
        }

        private void addqrbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Location al = new Add_Location();
            al.Show();
        }
    }

}

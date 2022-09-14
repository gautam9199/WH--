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
    public partial class MainMDI : Form
    {

       


        private int childFormNumber = 0;

        public MainMDI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        ////////////////////////////////////////////////

        private void Mainpage_Load(object sender, EventArgs e)
        {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            Product_List prolist = new Product_List();
            prolist.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            New_Order order = new New_Order();
            order.Show();
        }

       

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

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
            Order_List olist = new Order_List();
            olist.Show();
        }

        private void Addcustomer_btn_Click(object sender, EventArgs e)
        {
            New_Customer customer = new New_Customer();
            customer.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Application.Exit();
            //this.Dispose();
           // this.Close();
            Login_page Login = new Login_page();
            Login.Show();

        }

        private void Customerlist_btn_Click(object sender, EventArgs e)
        {

        }

       
        private void vIewWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewWarehouse vw = new viewWarehouse();
            vw.Show();
        }

        private void expandWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerLsitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList cl = new CustomerList();
            cl.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addSockToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Stock_add stock = new Stock_add();
            stock.Show();
        }

        private void addQrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRgenerator qr = new QRgenerator();
            qr.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_User addUser = new Add_User();
            addUser.Show();
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Location al = new Add_Location();
                al.Show();
        }

        private void MainMDI_Load(object sender, EventArgs e)
        {
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mainpage mp = new Mainpage();
            mp.Show();
        }

        private void addProductToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
            New_Product np =new New_Product();
            np.Show();
        }

        private void productListToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
         
            Product_List pl = new Product_List();
            pl.Show();
        }

        private void addOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            New_Order nwo = new New_Order();
            nwo.Show();
        }

        private void orderListToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            Order_List ol = new Order_List();
            ol.Show();
        }

        private void addCustomerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
       
            New_Customer nc = new New_Customer();
            nc.Show();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            CustomerList cl = new CustomerList();
            cl.Show();
        }

        private void viewWarehouseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
     
            viewWarehouse vw = new viewWarehouse();
            vw.Show();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_add sa = new Stock_add();
            sa.Show();
        }

        private void addLocationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
      
            Add_Location al = new Add_Location();
            al.Show();
        }

        private void addUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          
            Add_User au = new Add_User();
            au.Show();
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users_List usl = new Users_List();
            usl.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_page usll = new Login_page();
            usll.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testlist tl = new testlist();
            tl.Show();
        }

        private void qrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRgenerator wr = new QRgenerator();
            wr.Show();

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printQr pq = new printQr();
            pq.Show();

        }
    }
}


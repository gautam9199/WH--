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
    public partial class Welcome : NikkiBase
    {
        public static Form MainForm { get; set; }
        static void CreatMainForm()
        {
            MainMDI main = new MainMDI();
           
            Welcome.MainForm = main;
        }
        public Welcome()
        {
            InitializeComponent();
            Welcome.CreatMainForm();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            warehousetimer.Stop();

            this.Hide();
           
            Login_page f = new Login_page();
            //f.MdiParent = main;
            Welcome.MainForm.Show();
            f.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
    }
}

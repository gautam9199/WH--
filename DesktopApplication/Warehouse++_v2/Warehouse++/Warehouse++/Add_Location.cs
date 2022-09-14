using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse__
{
    public partial class Add_Location : NikkiBase
    {
        static int lid;
        String status = "false";
        // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\project_software\warehouse++finalized\Warehouse++\Warehouse++\proj_database.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30");
        public static List<String> data1 = new List<String>();

        public Add_Location()
        {
            InitializeComponent();
        }

        public void qrGenerate(TextBox r, TextBox l)
        {

            con.Open();

            Zen.Barcode.CodeQrBarcodeDraw qrcd = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            var qrText = r.Text.ToString() + "-" + l.Text.ToString();

            pbqr.Image = qrcd.Draw(qrText, 50);

            MemoryStream ms = new MemoryStream();
            pbqr.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imgData = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(imgData, 0, imgData.Length);

            //qid to send to another form
            data1.Add(l.Text.ToString());

            SqlCommand cmd2 = new SqlCommand("INSERT INTO  LOCATION VALUES ('" + r.Text + "','" + l.Text + "',@photo)", con);
            cmd2.Parameters.Add(new SqlParameter
            {
                ParameterName = "@photo",
                SqlDbType = SqlDbType.VarBinary,
                Size = imgData.Length,
                Value = imgData
            });
            int j = cmd2.ExecuteNonQuery();
            if (j > 0)
            {
             //   MessageBox.Show("QR Generated");
            }
            con.Close();
        }

        private void generate_Click(object sender, EventArgs e)
        {

            pbqr.Visible = true;
            if ((r1.Text != "") && (l1.Text != ""))
            {
                status = "true";
                qrGenerate(r1, l1);
                
            }
            if ((r2.Text != "") && (l2.Text != ""))
            {
                status = "true";
                qrGenerate(r2,l2);
            }
            if ((r3.Text != "") && (l3.Text != ""))
            {
                status = "true";
                qrGenerate(r3,l3);
            }
            if ((r4.Text != "") && (l4.Text != ""))
            {
                status = "true";
                qrGenerate(r4,l4);
            }
            if ((r5.Text != "") && (l5.Text != ""))
            {
                status = "true";
                qrGenerate(r5, l5);
            }
            if ((r6.Text != "") && (l6.Text != ""))
            {
                status = "true";
                qrGenerate(r6, l6);
            }
            if ((r7.Text != "") && (l7.Text != ""))
            {
                status = "true";
                qrGenerate(r7,l7);
            }
            if ((r8.Text != "") && (l8.Text != ""))
            {
                status = "true";
                qrGenerate(r8,l8);
            }
            if ((r9.Text != "") && (l9.Text != ""))
            {
                status = "true";
                qrGenerate(r9,l9);
            }
            if ((r10.Text != "") && (l10.Text != ""))
            {
                status = "true";
                qrGenerate(r10, l10);
            }

           

            pbqr.Visible = false;
            //  pbqr.Hide();

            if (status == "true")
            {
                printLoc frm3 = new printLoc();
                frm3.Show();
            }
            else {
                MessageBox.Show("Please Fill Location Details");
            }
        }

        private void pbqr_Click(object sender, EventArgs e)
        {

        }

        private void Add_Location_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            r1.Text = "";
           r2.Text = "";
            r3.Text = "";
            r4.Text = "";
            r5.Text = "";
            r6.Text = "";
            r7.Text = "";
            r8.Text = "";
            r9.Text = "";
            r10.Text = "";

            l1.Text = "";
            l2.Text = "";
            l3.Text = "";
            l4.Text = "";
            l5.Text = "";
            l6.Text = "";
            l7.Text = "";
            l8.Text = "";
            l9.Text = "";
            l10.Text = "";

        }
    }
}

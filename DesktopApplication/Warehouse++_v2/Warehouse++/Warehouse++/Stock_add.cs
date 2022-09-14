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
    public partial class Stock_add : NikkiBase
    {
        //  SqlConnection con = new SqlConnection(@"=Data Source=ADMIN;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30");
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30");

        static String pid1;
        static String pid, qid, qid1;
        List<int> numList = new List<int>();

        public static List<String> data = new List<String>();
        //    public static string SetValueForText2 = "";
        //   public static string SetValueForText3 = "";

        public Stock_add()
        {
            InitializeComponent();
        }

        private void Stock_add_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouseDataSet2.Login' table. You can move, or remove it, as needed.
            //  this.loginTableAdapter.Fill(this.warehouseDataSet.Login);
            // TODO: This line of code loads data into the 'warehouseDataSet2.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter2.Fill(this.warehouseDataSet2.Product);
            // TODO: This line of code loads data into the 'warehouseDataSet1.Product' table. You can move, or remove it, as needed.
            //   this.productTableAdapter1.Fill(this.warehouseDataSet1.Product);



            con.Open();

            SqlCommand cmd8 = new SqlCommand("Select DISTINCT p_id From Product", con);
            SqlDataReader rd8 = cmd8.ExecuteReader();
            while (rd8.Read())
            {
                comboBox1.Items.Add(rd8["p_id"]);
            }
            rd8.Close();

            con.Close();



            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'proj_databaseDataSet.Product' table. You can move, or remove it, as needed.
          //  this.productTableAdapter.Fill(this.proj_databaseDataSet.Product);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && quantity.Text != "")
            {
                pbqr.Visible = true;

                //   DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                // pid1 = drv["p_id"].ToString();

                pid1 = comboBox1.SelectedItem.ToString();

                // pid = comboBox1.SelectedItem.ToString();
                for (int i = 0; i < int.Parse(quantity.Text.ToString()); i++)
                {
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO qrGenerate  VALUES('" + pid1 + "','', CONVERT(varbinary(max), '') ,'','no','no','no')", con);
                    int j = cmd2.ExecuteNonQuery();
                    if (j > 0)
                    {
                        SqlCommand cmd1 = new SqlCommand("Select * From Product Where p_id='" + pid1 + "'", con);
                        SqlDataReader rd = cmd1.ExecuteReader();
                        if (rd.Read())
                        {
                            int quan = int.Parse(rd["total_quantity"].ToString());
                            quan = quan + 1;
                            rd.Close();
                            SqlCommand cmd3 = new SqlCommand("UPDATE Product SET total_quantity='" + quan + "' Where p_id='" + pid1 + "'", con);
                            int k = cmd3.ExecuteNonQuery();
                            if (k > 0)
                            {
                                //nothing
                            }
                        }

                        //    MessageBox.Show("abc");

                    }
                    con.Close();
                }

                //later added
                con.Open();
                SqlCommand cmd7 = new SqlCommand("Select * From qrGenerate Where qr_gen='no'", con);
                SqlDataReader rd1 = cmd7.ExecuteReader();
                while (rd1.Read())
                {
                    int id = int.Parse(rd1["Id"].ToString());
                    numList.Add(id);

                }

                rd1.Close();
                con.Close();

                int[] numArr = numList.ToArray();
                for (int i = 0; i < numArr.Length; i++)
                {
                    qrGen(numArr[i]);
                }

                pbqr.Visible = false;
                MessageBox.Show("QR Generated");



                printQr frm2 = new printQr();
                frm2.Show();
                //  QRgenerator qrg = new QRgenerator();
                // qrg.show();
            }
            else {

                MessageBox.Show("Kindly Fill Required Details");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void qrGen(int num)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select * From qrGenerate Where Id='" + num + "'", con);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                pid = rd["p_id"].ToString();
                qid = rd["Id"].ToString();
                rd.Close();
            }
            else
            {
                MessageBox.Show("no value");
                rd.Close();
            }

            Zen.Barcode.CodeQrBarcodeDraw qrcd = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            var qrText = pid + "\n" + "q" + qid + "\n" + "lid";

            qid1 = "q" + qid;
            pbqr.Image = qrcd.Draw(qrText, 50);

            MemoryStream ms = new MemoryStream();
            pbqr.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imgData = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(imgData, 0, imgData.Length);

            //qid to send to another form
            data.Add(qid1.ToString());

            SqlCommand cmd2 = new SqlCommand("UPDATE qrGenerate SET q_image= @photo,q_id='" + qid1.ToString() + "',qr_gen='yes' Where Id='" + qid + "'", con);
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
              //  MessageBox.Show("abc");
            }
            con.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            /*  byte[] getImg;
              con.Open();
              SqlCommand cmd4 = new SqlCommand("Select * From qrGenerate Where Id='" + 7 + "'", con);
              SqlDataReader rd1 = cmd4.ExecuteReader();
              while (rd1.Read())
              {

                  byte[] imgArr = (byte[])rd1["q_image"];
                  System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                  Image img = (Image)converter.ConvertFrom(imgArr);
                  pbqr.Image = img;

              }


              rd1.Close();
              con.Close(); */

            comboBox1.Text = "";
            quantity.Text = "";
        }
    }
}

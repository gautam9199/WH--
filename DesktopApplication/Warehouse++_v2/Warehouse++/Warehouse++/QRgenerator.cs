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
    public partial class QRgenerator : NikkiBase
    {
        
        static String pid,qid,qid1;
        List<int> numList = new List<int>();



        SqlConnection con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30");

        public QRgenerator()
        {
            InitializeComponent();
            btpr.Hide();
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
                MessageBox.Show("abc");
            } 
            con.Close(); 

   /* byte[] WinImage = new byte[0];
                MemoryStream stream = new MemoryStream();
                pbqr.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                WinImage = stream.ToArray();

                SqlCommand cmd2 = new SqlCommand("UPDATE qrGenerate SET q_image= CONVERT(varbinary(max), '"+WinImage+"'),q_id='" + qid1.ToString() + "',qr_gen='yes' Where Id='" + qid + "'", con);
                int j = cmd2.ExecuteNonQuery();
                if (j > 0)
                {
                    MessageBox.Show("abc");
                }
                con.Close();  */
        }


       
        private void btqr_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("Select * From qrGenerate Where qr_gen='no'", con);
            SqlDataReader rd1 = cmd3.ExecuteReader();
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


            //btpr.Show();
        }

        public void btpr_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void QRgenerator_Load(object sender, EventArgs e)
        {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            textBox1.Text = New_Product.passingtext;
            textBox2.Text = New_Product.passingtype;
            textBox3.Text = New_Product.passingsize;
            textBox4.Text = New_Product.passingfinish;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            byte[] getImg;
            con.Open();
            SqlCommand cmd4 = new SqlCommand("Select * From qrGenerate Where Id='"+7+"'", con);
            SqlDataReader rd1 = cmd4.ExecuteReader();
            while (rd1.Read())
            {

                byte[] imgArr = (byte[])rd1["q_image"];
                System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                Image img = (Image)converter.ConvertFrom(imgArr);
                pbqr.Image = img;

            }
           

            rd1.Close();
            con.Close(); 
        }

 
        private void pbqr_Click(object sender, EventArgs e)
        {

        }
    }
}

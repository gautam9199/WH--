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
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace Warehouse__
{
    public partial class printQr : NikkiBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=warehouse;Persist Security Info=True;User ID=shabnam1;Password=***********; Integrated Security = True; Connect Timeout = 30");

        PictureBox pic;

        public printQr()
        {
            InitializeComponent();
        }

        private void printQr_Load(object sender, EventArgs e)
        {
            //  String[] pb = new String[] { pictureBox1 };
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
       String[] qrs = Stock_add.data.ToArray();
            

            for(int i = 0; i < qrs.Length; i++)
            {
                if (i == 0)
                {
                    byte[] getImg;
                    con.Open();
                    SqlCommand cmd0 = new SqlCommand("Select * From qrGenerate Where q_id='" + qrs[i] + "'", con);
                    SqlDataReader rd0 = cmd0.ExecuteReader();
                    while (rd0.Read())
                    {

                        byte[] imgArr = (byte[])rd0["q_image"];
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        Image img = (Image)converter.ConvertFrom(imgArr);
                        pictureBox0.Image = img;

                    }


                    rd0.Close();
                    con.Close();
                }

               else if (i == 1)
                {
                    byte[] getImg;
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("Select * From qrGenerate Where q_id='" + qrs[i] + "'", con);
                    SqlDataReader rd1 = cmd1.ExecuteReader();
                    while (rd1.Read())
                    {

                        byte[] imgArr = (byte[])rd1["q_image"];
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        Image img = (Image)converter.ConvertFrom(imgArr);
                        pictureBox1.Image = img;

                    }


                    rd1.Close();
                    con.Close();
                }
                else if (i == 2)
                {
                    byte[] getImg;
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("Select * From qrGenerate Where q_id='" + qrs[i] + "'", con);
                    SqlDataReader rd2 = cmd2.ExecuteReader();
                    while (rd2.Read())
                    {

                        byte[] imgArr = (byte[])rd2["q_image"];
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        Image img = (Image)converter.ConvertFrom(imgArr);
                        pictureBox2.Image = img;

                    }


                    rd2.Close();
                    con.Close();
                }
                else if (i == 3)
                {
                    byte[] getImg;
                    con.Open();
                    SqlCommand cmd3 = new SqlCommand("Select * From qrGenerate Where q_id='" + qrs[i] + "'", con);
                    SqlDataReader rd3 = cmd3.ExecuteReader();
                    while (rd3.Read())
                    {

                        byte[] imgArr = (byte[])rd3["q_image"];
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        Image img = (Image)converter.ConvertFrom(imgArr);
                        pictureBox3.Image = img;

                    }


                    rd3.Close();
                    con.Close();
                }
                else if (i == 4)
                {
                    byte[] getImg;
                    con.Open();
                    SqlCommand cmd4 = new SqlCommand("Select * From qrGenerate Where q_id='" + qrs[i] + "'", con);
                    SqlDataReader rd4 = cmd4.ExecuteReader();
                    while (rd4.Read())
                    {

                        byte[] imgArr = (byte[])rd4["q_image"];
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        Image img = (Image)converter.ConvertFrom(imgArr);
                        pictureBox4.Image = img;

                    }


                    rd4.Close();
                    con.Close();
                }
                 else if (i == 5)
                   {
                    byte[] getImg;
                    con.Open();
                    SqlCommand cmd5 = new SqlCommand("Select * From qrGenerate Where q_id='" + qrs[i] + "'", con);
                    SqlDataReader rd5 = cmd5.ExecuteReader();
                    while (rd5.Read())
                    {

                        byte[] imgArr = (byte[])rd5["q_image"];
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        Image img = (Image)converter.ConvertFrom(imgArr);
                        pictureBox5.Image = img;

                    }


                    rd5.Close();
                    con.Close();
                }
                   else if (i == 6)
                   {
                    byte[] getImg;
                    con.Open();
                    SqlCommand cmd6 = new SqlCommand("Select * From qrGenerate Where q_id='" + qrs[i] + "'", con);
                    SqlDataReader rd6 = cmd6.ExecuteReader();
                    while (rd6.Read())
                    {

                        byte[] imgArr = (byte[])rd6["q_image"];
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        Image img = (Image)converter.ConvertFrom(imgArr);
                        pictureBox6.Image = img;

                    }


                    rd6.Close();
                    con.Close();
                }
                   else if (i == 7)
                   {
                    byte[] getImg;
                    con.Open();
                    SqlCommand cmd7 = new SqlCommand("Select * From qrGenerate Where q_id='" + qrs[i] + "'", con);
                    SqlDataReader rd7 = cmd7.ExecuteReader();
                    while (rd7.Read())
                    {

                        byte[] imgArr = (byte[])rd7["q_image"];
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        Image img = (Image)converter.ConvertFrom(imgArr);
                        pictureBox7.Image = img;

                    }


                    rd7.Close();
                    con.Close();
                }
                else if (i == 8)
                   {
                    byte[] getImg;
                    con.Open();
                    SqlCommand cmd8 = new SqlCommand("Select * From qrGenerate Where q_id='" + qrs[i] + "'", con);
                    SqlDataReader rd8 = cmd8.ExecuteReader();
                    while (rd8.Read())
                    {

                        byte[] imgArr = (byte[])rd8["q_image"];
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        Image img = (Image)converter.ConvertFrom(imgArr);
                        pictureBox8.Image = img;

                    }


                    rd8.Close();
                    con.Close();
                }
                   else if (i == 9)
                   {
                    byte[] getImg;
                    con.Open();
                    SqlCommand cmd9= new SqlCommand("Select * From qrGenerate Where q_id='" + qrs[i] + "'", con);
                    SqlDataReader rd9 = cmd9.ExecuteReader();
                    while (rd9.Read())
                    {

                        byte[] imgArr = (byte[])rd9["q_image"];
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        Image img = (Image)converter.ConvertFrom(imgArr);
                        pictureBox9.Image = img;

                    }


                    rd9.Close();
                    con.Close();
                } 
                
           }
            }

        private void Add_Click(object sender, EventArgs e)
        {
            PrintScreen();
            printPreviewDialog1.ShowDialog();
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        private void PrintScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
    }


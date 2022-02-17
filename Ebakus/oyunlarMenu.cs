using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ebakus
{
    public partial class oyunlarMenu : Form
    {
        MySqlConnection connection = Form1.connection;
        public oyunlarMenu()
        {
            InitializeComponent();
            butonGeriDon.Left = 50;
            butonGeriDon.Top = Screen.PrimaryScreen.Bounds.Height - butonGeriDon.Height - 50;
        }

        private void oyunlarMenu_Load(object sender, EventArgs e)
        {
            groupBox1.Left = (Screen.PrimaryScreen.Bounds.Width - 1100) / 2;
            groupBox2.Left = groupBox1.Left + groupBox1.Width + 100;
            groupBox3.Left = groupBox2.Left + groupBox2.Width + 100;

            groupBox1.Top = (Screen.PrimaryScreen.Bounds.Height - groupBox1.Height) / 2;
            groupBox2.Top = groupBox1.Top;
            groupBox3.Top = groupBox1.Top;
        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Linen, Color.Linen);
        }
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);
                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);
                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void turkiyePuzzleGiris_Click(object sender, EventArgs e)
        {
            string okulNo = OgrenciBilgileri.okul_no;
            Boolean varMi = false;
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select * from cografya_puzzel", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = komut.ExecuteReader();//veri tabanını oku
            while (reader.Read())
            {
                if (okulNo == reader["okul_no"].ToString())
                {
                    varMi = true;
                }

            }
            connection.Close();
            if (varMi == false)
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO cografya_puzzel(okul_no,level) VALUES(" + okulNo + " ," + 1 + ")", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            oyun_cografya_puzzle frm = new oyun_cografya_puzzle();
            this.Hide();
            frm.Show();
        }
        
        private void oyunlarMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogrenciMenu frm = new ogrenciMenu();
            this.Hide();
            frm.Show();
        }

        private void hafizaOyna_Click(object sender, EventArgs e)
        {
            string okulNo = OgrenciBilgileri.okul_no;
            Boolean varMi = false;
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select * from oyunHafiza", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = komut.ExecuteReader();//veri tabanını oku
            while (reader.Read())
            {
                if (okulNo == reader["okulNo"].ToString())
                {
                    varMi = true;
                }

            }
            connection.Close();
            if (varMi == false)
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO oyunHafiza(okulNo,level) VALUES(" + okulNo + " ," + 1 + ")", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

            HafizaOyunuMenu frm = new HafizaOyunuMenu();
            this.Hide();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string okulNo = OgrenciBilgileri.okul_no;
            Boolean varMi = false;
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select * from canavarOyun", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = komut.ExecuteReader();//veri tabanını oku
            while (reader.Read())
            {
                if (okulNo == reader["okulNo"].ToString())
                {
                    varMi = true;
                }

            }
            connection.Close();
            if (varMi == false)
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO canavarOyun(isim,soyad,puan,okulNo) VALUES('" + OgrenciBilgileri.isim + "' ,'" + OgrenciBilgileri.soyad + " ','" + 0 + " ','" + OgrenciBilgileri.okul_no + "')", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

            canavar frm = new canavar();
            this.Hide();
            frm.Show();
        }
    }
}

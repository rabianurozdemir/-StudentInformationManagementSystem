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
using System.Threading;


namespace Ebakus
{
    public partial class Login : Form
    {
        
        MySqlConnection connection = Form1.connection;
        bool move;
        int mouse_x;
        int mouse_y;
        public Login()
        {
            InitializeComponent();
        }

        private void logincikisbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            AcceptButton = ogrenciGirisButon;
            ogretmensifre.PasswordChar = '\0';
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }



        private void ogrencikullaniciadi_Enter(object sender, EventArgs e)
        {
            if (ogrencikullaniciadi.Text == "Kullanıcı Adı")
            {
                ogrencikullaniciadi.Text = null;
            }

            ogrencikullaniciadi.ForeColor = Color.White;
        }

        private void ogrencikullaniciadi_Leave(object sender, EventArgs e)
        {
            if (ogrencikullaniciadi.Text == "")
            {
                ogrencikullaniciadi.ForeColor = Color.Silver;
                ogrencikullaniciadi.Text = "Kullanıcı Adı";
            }
        }
        private void ogrencisifre_Enter_1(object sender, EventArgs e)
        {
            if (ogrencisifre.Text == "Şifre")
            {
                ogrencisifre.Text = null;
                ogrencisifre.PasswordChar = '*';
                pictureBox1.Image = global::Ebakus.Properties.Resources.witness;
            }
            pictureBox1.Show();
            ogrencisifre.ForeColor = Color.White;
        }

        private void ogrencisifre_Leave(object sender, EventArgs e)
        {
            if (ogrencisifre.Text == "")
            {
                ogrencisifre.ForeColor = Color.Silver;
                ogrencisifre.Text = "Şifre";
                ogrencisifre.PasswordChar = '\0';
                pictureBox1.Image = global::Ebakus.Properties.Resources.kapaligoz;
            }
        }

        private void ogretmenkullaniciadi_Enter(object sender, EventArgs e)
        {
            if (ogretmenkullaniciadi.Text == "Kullanıcı Adı")
            {
                ogretmenkullaniciadi.Text = "";
            }
            ogretmenkullaniciadi.ForeColor = Color.White;

        }

        private void ogretmenkullaniciadi_Leave(object sender, EventArgs e)
        {
            if (ogretmenkullaniciadi.Text == "")
            {
                ogretmenkullaniciadi.ForeColor = Color.Silver;
                ogretmenkullaniciadi.Text = "Kullanıcı Adı";
            }
        }

        private void ogretmensifre_Enter(object sender, EventArgs e)
        {
            if (ogretmensifre.Text == "Şifre")
            {
                ogretmensifre.Text = null;
                ogretmensifre.PasswordChar = '*';
                pictureBox1.Image = global::Ebakus.Properties.Resources.witness;
            }
            pictureBox1.Show();
            ogretmensifre.ForeColor = Color.White;
        }

        private void ogretmensifre_Leave(object sender, EventArgs e)
        {
            if (ogretmensifre.Text == "")
            {
                ogretmensifre.ForeColor = Color.Silver;
                ogretmensifre.Text = "Şifre";
                ogrencisifre.PasswordChar = '\0';
                pictureBox1.Image = global::Ebakus.Properties.Resources.kapaligoz;
            }
        }

        private void linkogretmen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkogretmen.Hide();
            linkogrenci.Show();
            panelogrenci.Hide();
            panelogretmen.Show();
            AcceptButton = ogretmenGirisButon;
        }

        private void linkogrenci_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkogrenci.Hide();
            linkogretmen.Show();
            panelogretmen.Hide();
            panelogrenci.Show();
            AcceptButton = ogrenciGirisButon;
        }

        private void linkyonetim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dogru_kullanici_adi = "";
            string dogru_sifre = "";
            string kullanici_adi = "";
            string sifre = "";
            Boolean girdiMi = false;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            kullanici_adi = ogretmenkullaniciadi.Text;
            sifre = ogretmensifre.Text;
            if (kullanici_adi == "yonetimpaneli" && sifre == "yonetimpaneli")
            {
                girisbilgileriyanlis.Hide();
                connection.Close();
                yonetimpaneligiris formyonetimpaneli = new yonetimpaneligiris();
                this.Hide();
                formyonetimpaneli.Show();
            }
            else
            {
                MySqlCommand command = new MySqlCommand("Select * from ogretmenGiris", connection);//ogretmenGiris tablosundan veri çek
                MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku
                while (reader.Read())
                {
                    dogru_kullanici_adi = reader["kullanici_adi"].ToString();
                    dogru_sifre = reader["sifre"].ToString();
                    if (kullanici_adi == dogru_kullanici_adi && sifre == dogru_sifre)
                    {
                        girdiMi = true;
                        break;
                    }
                }
                connection.Close();
            }
            

            if (girdiMi)
            {
                girisbilgileriyanlis.Hide();
                connection.Open();

                MySqlCommand komut = new MySqlCommand("Select * from ogretmenBilgileri where kimlik_no = " + dogru_kullanici_adi, connection);//ogretmenBilgileri tablosundan veri çek

                MySqlDataReader tara = komut.ExecuteReader();//veri tabanını oku


                while (tara.Read())
                {


                    OgretmenBilgileri.id = Convert.ToInt32(tara["id"]);
                    OgretmenBilgileri.isim = tara["isim"].ToString();
                    OgretmenBilgileri.soyad = tara["soyad"].ToString();
                    OgretmenBilgileri.kimlik_no = tara["kimlik_no"].ToString();
                    OgretmenBilgileri.mail = tara["mail"].ToString();
                    OgretmenBilgileri.cinsiyet = tara["cinsiyet"].ToString();
                    OgretmenBilgileri.sinif = tara["sinif"].ToString();
                }
                connection.Close();
                this.Close();
                ogretmenMenu formyonetimogretmenMenu = new ogretmenMenu();
                formyonetimogretmenMenu.Show();
            }
            else
            {
                girisbilgileriyanlis.Show();
            }
            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dogru_kullanici_adi = "";
            string dogru_sifre = "";
            string kullanici_adi = "";
            string sifre = "";
            Boolean girdiMi=false;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            kullanici_adi = ogrencikullaniciadi.Text;
            sifre = ogrencisifre.Text;
            MySqlCommand command = new MySqlCommand("Select * from ogrenciGiris", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku
            while (reader.Read())
            {
                dogru_kullanici_adi = reader["kullanici_adi"].ToString();
                dogru_sifre = reader["sifre"].ToString();
                if (kullanici_adi == dogru_kullanici_adi && sifre == dogru_sifre)
                {
                    girdiMi = true;
                    break;
                }
            }
            connection.Close();
            if (girdiMi)
            {
                girisbilgileriyanlis.Hide();
                connection.Open();
                MySqlCommand komut = new MySqlCommand("Select * from ogrenciBilgileri where okul_no= " + dogru_kullanici_adi, connection);//ogretmenGiris tablosundan veri çek
                MySqlDataReader tara = komut.ExecuteReader();//veri tabanını oku
                while (tara.Read())
                {
                    OgrenciBilgileri ogrenci = new OgrenciBilgileri();
                    OgrenciBilgileri.id = Convert.ToInt32(tara["id"]);
                    OgrenciBilgileri.isim = tara["isim"].ToString();
                    OgrenciBilgileri.soyad = tara["soyad"].ToString();
                    OgrenciBilgileri.okul_no = tara["okul_no"].ToString();
                    OgrenciBilgileri.kimlik_no = tara["kimlik_no"].ToString();
                    OgrenciBilgileri.mail = tara["mail"].ToString();
                    OgrenciBilgileri.cinsiyet = tara["cinsiyet"].ToString();
                    OgrenciBilgileri.sinif = tara["sinif"].ToString();
                }
                connection.Close();
                connection.Open();
                MySqlCommand kmt = new MySqlCommand("Select * from ogretmenBilgileri where sinif= " + OgrenciBilgileri.sinif, connection);//ogretmenGiris tablosundan veri çek
                MySqlDataReader read = kmt.ExecuteReader();//veri tabanını oku
                while (read.Read())
                {
                    OgrenciBilgileri.ogretmenAdi = read["isim"].ToString();
                    OgrenciBilgileri.ogretmenAdi += " "+ read["soyad"].ToString();
                }
                connection.Close();
                ogrenciMenu frm = new ogrenciMenu();
                this.Hide();
                frm.Show();
            }
            else
            {
                girisbilgileriyanlis.Show();
            }


            connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (ogretmensifre.PasswordChar == '*')
            {
                ogretmensifre.PasswordChar = '\0';
                ogrencisifre.PasswordChar = '\0';
                pictureBox1.Image = global::Ebakus.Properties.Resources.kapaligoz;
            }
            else if(ogretmensifre.PasswordChar == '\0')
            {
                ogretmensifre.PasswordChar = '*';
                ogrencisifre.PasswordChar = '*';
                pictureBox1.Image = global::Ebakus.Properties.Resources.witness;
            }

        }
    }
}

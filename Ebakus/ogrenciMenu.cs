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
    public partial class ogrenciMenu : Form
    {
        MySqlConnection connection = Form1.connection;
        public ogrenciMenu()
        {
            InitializeComponent();
            hosgeldinPanel.Top = 30;
            hosgeldinPanel.Left = 30;
            ebakuslogo.Top = 30;
            ebakus_label.Top = ebakuslogo.Height + ebakuslogo.Top + 10;
            ebakus_label.Left= (Screen.PrimaryScreen.Bounds.Width - ebakus_label.Width) / 2;
            ebakuslogo.Left = (Screen.PrimaryScreen.Bounds.Width - ebakuslogo.Width) / 2;
            kutuphanegiris_buton.Left = (Screen.PrimaryScreen.Bounds.Width - kutuphanegiris_buton.Width) / 2;
            derslerim_giris_buton.Left = (Screen.PrimaryScreen.Bounds.Width - derslerim_giris_buton.Width) / 2;
            buton_cikis.Left = (Screen.PrimaryScreen.Bounds.Width - buton_cikis.Width) / 2;
            oyunGirisbuton.Left = (Screen.PrimaryScreen.Bounds.Width - oyunGirisbuton.Width) / 2;
            mesajButon.Left = (Screen.PrimaryScreen.Bounds.Width - mesajButon.Width) / 2;

            derslerim_giris_buton.Top = ebakus_label.Height + ebakus_label.Top + 40;
            kutuphanegiris_buton.Top = derslerim_giris_buton.Top + derslerim_giris_buton.Height + 20;
            mesajButon.Top = kutuphanegiris_buton.Top + kutuphanegiris_buton.Height + 20;
            oyunGirisbuton.Top = mesajButon.Top + mesajButon.Height + 20;
            buton_cikis.Top = oyunGirisbuton.Top + oyunGirisbuton.Height + 20;

        }        

        private void kutuphanegiris_buton_Click(object sender, EventArgs e)
        {
            kutuphane frm = new kutuphane();
            this.Hide();
            frm.Show();
        }

        private void derslerim_giris_buton_Click(object sender, EventArgs e)
        {

            ogrenciNot frm = new ogrenciNot();
            this.Hide();
            frm.Show();
        }
      

        private void ortkmenusayfasi_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int okunmamis = 0;
            string zaman = DateTime.Now.ToLongTimeString();
            string saat = zaman.Substring(0, 2);
            hosgeldinIsim.Text += " " + OgrenciBilgileri.isim + " " + OgrenciBilgileri.soyad;
            Boolean varMi = false;
            connection.Open();
            MySqlCommand command = new MySqlCommand("Select *from mesaj where alici = " + OgrenciBilgileri.okul_no, connection);//notOgrenci tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku

            while (reader.Read())
            {
                if (Convert.ToBoolean(reader["ogrenciOkundu"]) == false)
                {
                    varMi = true;
                    okunmamis++;
                }
            }
            if (varMi == true)
            {
                hosgeldinMesaj.Text = "Okunmamış " + okunmamis + " mesajınız bulunmaktadır";
                mesajButon.Image = global::Ebakus.Properties.Resources.bildirimMesaj;
            }
            connection.Close();
            if (Convert.ToInt32(saat) > 5 && Convert.ToInt32(saat) <= 17)
            {
                hosgeldinSaat.Text = "İyi Günler!";
            }
            else if (Convert.ToInt32(saat) > 17 && Convert.ToInt32(saat) <= 21)
            {
                hosgeldinSaat.Text = "İyi Akşamlar!";
            }
            else if (Convert.ToInt32(saat) > 21 || Convert.ToInt32(saat) <= 5)
            {
                hosgeldinSaat.Text = "İyi Geceler!";
            }
            Cursor.Current = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oyunGirisbuton_Click(object sender, EventArgs e)
        {
            oyunlarMenu frm = new oyunlarMenu();
            this.Hide();
            frm.Show();
        }


        private void ogrenciMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
        }

        private void mesajButon_Click_2(object sender, EventArgs e)
        {
            ogrenciMesaj frm = new ogrenciMesaj();
            this.Hide();
            frm.Show();
        }

    }

}

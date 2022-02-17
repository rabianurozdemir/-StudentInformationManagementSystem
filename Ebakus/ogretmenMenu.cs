using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebakus
{
    public partial class ogretmenMenu : Form
    {
        MySqlConnection connection = Form1.connection;
        public ogretmenMenu()
        {
            InitializeComponent();
            hosgeldinPanel.Top = 30;
            hosgeldinPanel.Left = 30;
            ebakuslogo.Top = 30;
            ebakus_label.Top = ebakuslogo.Height + ebakuslogo.Top+ 10;
            ebakus_label.Left = (Screen.PrimaryScreen.Bounds.Width - ebakus_label.Width) / 2;
            ebakuslogo.Left = (Screen.PrimaryScreen.Bounds.Width - ebakuslogo.Width) / 2;
            kutuphanegiris_buton.Left = (Screen.PrimaryScreen.Bounds.Width - kutuphanegiris_buton.Width) / 2;
            derslerim_giris_buton.Left = (Screen.PrimaryScreen.Bounds.Width - derslerim_giris_buton.Width) / 2;
            buton_cikis.Left = (Screen.PrimaryScreen.Bounds.Width - buton_cikis.Width) / 2;
            mesajlar.Left = (Screen.PrimaryScreen.Bounds.Width - mesajlar.Width) / 2;

            derslerim_giris_buton.Top = ebakus_label.Height + ebakus_label.Top + 40;
            kutuphanegiris_buton.Top = derslerim_giris_buton.Top + derslerim_giris_buton.Height+20;
            mesajlar.Top = kutuphanegiris_buton.Top + kutuphanegiris_buton.Height+20;
            buton_cikis.Top = mesajlar.Top + mesajlar.Height + 20;
        }

        private void ogretmenMenu_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int okunmamis=0;
            string zaman = DateTime.Now.ToLongTimeString();
            string saat = zaman.Substring(0, 2);
            hosgeldinIsim.Text += " "+ OgretmenBilgileri.isim +" " + OgretmenBilgileri.soyad;
            Boolean varMi = false;
            connection.Open();
            MySqlCommand command = new MySqlCommand("Select *from mesaj where alici = " + OgretmenBilgileri.sinif, connection);
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku

            while (reader.Read())
            {
                if (Convert.ToBoolean(reader["ogretmenOkundu"]) == false)
                {
                    varMi = true;
                    okunmamis++;
                }
            }
            if (varMi == true)
            {
                hosgeldinMesaj.Text = "Okunmamış " + okunmamis + " mesajınız bulunmaktadır";
                mesajlar.Image = global::Ebakus.Properties.Resources.bildirimMesaj;
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

        private void kutuphanegiris_buton_Click(object sender, EventArgs e)
        {
            kutuphane frm = new kutuphane();
            this.Hide();
            frm.Show();
        }

        private void derslerim_giris_buton_Click(object sender, EventArgs e)
        {
            ogretmenDersler frm = new ogretmenDersler();
            this.Hide();
            frm.Show();
        }

        private void buton_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mesajlar_Click(object sender, EventArgs e)
        {
            ogretmenMesaj frm = new ogretmenMesaj();
            this.Hide();
            frm.Show();
        }

        private void ogretmenMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

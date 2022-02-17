using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ebakus
{
    public partial class ogretmenMesaj : Form
    {
        MySqlConnection connection = Form1.connection;

        public ogretmenMesaj()
        {
            InitializeComponent();
            datagridviewSetting(dataGridView1);
            panelSetting(mesajPanel, mesajBaslikPanel);
            datagridviewSetting(aliciEkleData);
        }

        private void ogretmenMesaj_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ogretmenMesaj_Load(object sender, EventArgs e)
        {
            gelenMesajGoster(dataGridView1);
        }

        void aliciEkle(DataGridView dataGridView)
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridView.Show();
            connection.Open();
            MySqlCommand command = new MySqlCommand("Select *from ogrenciBilgileri where sinif = " + OgretmenBilgileri.sinif, connection);//notOgrenci tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku

            dataGridView.Rows.Clear();
            while (reader.Read())
            {

                    dataGridView.Height += 22;
                    dataGridView.Rows.Add(//datagridview ekleme fonk
            new object[]
            {

                    reader["isim"].ToString(),
                    reader["soyad"].ToString(),
                    reader["okul_no"].ToString(),
            });
                   
                
            }
            connection.Close();
            dataGridView.ClearSelection();
            Cursor.Current = Cursors.Default;

        }

        void gelenMesajGoster(DataGridView dataGridView)
        {
            Cursor.Current = Cursors.WaitCursor;
            int satir=0;
            dataGridView.Show();
            connection.Open();
            MySqlCommand command = new MySqlCommand("Select *from mesaj where alici = " + OgretmenBilgileri.sinif + " ORDER BY tarih DESC", connection);//notOgrenci tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku

            datagridviewSetting(dataGridView);
            dataGridView.Rows.Clear();
            dataGridView.Columns[0].HeaderText = "Gönderici";
            while (reader.Read())
            {
                if (Convert.ToBoolean(reader["ogretmenGoster"]) == true)
                {
                    dataGridView.Height += 22;
                    dataGridView.Rows.Add(//datagridview ekleme fonk
            new object[]
            {

                    reader["gondericiAdi"].ToString(),
                    reader["konu"].ToString(),
                    reader["icerik"].ToString(),
                    Convert.ToDateTime(reader["tarih"]),
                    reader["id"].ToString()
            });
                    if (Convert.ToBoolean(reader["ogretmenOkundu"]) == false)
                    {
                        dataGridView.Rows[satir].DefaultCellStyle.Font = new Font("Consolas", 12, FontStyle.Bold);

                    }
                    else if (Convert.ToBoolean(reader["ogretmenOkundu"]) == true)
                    {
                        dataGridView.Rows[satir].DefaultCellStyle.Font = new Font("Consolas", 12);
                    }
                    satir++;
                }
            }
            connection.Close();
            dataGridView.ClearSelection();
            Cursor.Current = Cursors.Default;
        }
        void gonderilmisMesajGoster(DataGridView dataGridView)
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridView.Show();
            connection.Open();
            MySqlCommand command = new MySqlCommand("Select *from mesaj where gonderici = " + OgretmenBilgileri.sinif + " ORDER BY tarih DESC", connection);//notOgrenci tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku
            datagridviewSetting(dataGridView);
            dataGridView.Rows.Clear();
            dataGridView.Columns[0].HeaderText = "Gönderilen";
            while (reader.Read())
            {
                if (Convert.ToBoolean(reader["ogrenciGoster"]) == true)
                {
                    dataGridView.Height += 22;
                    dataGridView.Rows.Add(//datagridview ekleme fonk
                new object[]
                {
                    reader["aliciAdi"].ToString(),
                    reader["konu"].ToString(),
                    reader["icerik"].ToString(),
                    Convert.ToDateTime(reader["tarih"]),
                    reader["id"].ToString()
                });
                }
            }
            connection.Close();
            dataGridView.ClearSelection();
            Cursor.Current = Cursors.Default;
        }
        public void panelSetting(Panel anaPanel, Panel ustPanel)
        {
            anaPanel.Size = new Size(1200, 400);
            anaPanel.MaximumSize = new Size(1200, 400);
            ustPanel.Size = new Size(1200, 30);
            ustPanel.MaximumSize = new Size(1200, 30);
            anaPanel.Left = (Screen.PrimaryScreen.Bounds.Width - anaPanel.Width) / 2;
            ustPanel.Left = (Screen.PrimaryScreen.Bounds.Width - ustPanel.Width) / 2;
            anaPanel.Top = (Screen.PrimaryScreen.Bounds.Height - anaPanel.Height) / 2;
            ustPanel.Top = (Screen.PrimaryScreen.Bounds.Height - anaPanel.Height) / 2;
            basliklabel.Left = (Screen.PrimaryScreen.Bounds.Width - basliklabel.Width) / 2;
            basliklabel.Top = anaPanel.Top - 10 - basliklabel.Height;
            yeniMesajButon.Left = anaPanel.Left;
            yeniMesajButon.Top = anaPanel.Top - 50;
            gelenKutusuButon.Left = yeniMesajButon.Left + yeniMesajButon.Width + 20;
            gelenKutusuButon.Top = yeniMesajButon.Top;
            gonderilmisButon.Left = gelenKutusuButon.Left + gelenKutusuButon.Width + 20;
            gonderilmisButon.Top = gelenKutusuButon.Top;
            silButon.Left = anaPanel.Left + anaPanel.Width - silButon.Width;
            okunduButon.Top = gonderilmisButon.Top;
            okunduButon.Left = silButon.Left -20- okunduButon.Width;
            silButon.Top = okunduButon.Top;
            

            yeniMesajPanel.Size = new Size(400, 400);
            yeniMesajPanel.MaximumSize = new Size(400, 400);
            yeniMesajPanel.Left = (Screen.PrimaryScreen.Bounds.Width - yeniMesajPanel.Width-15);
            yeniMesajPanel.Top = (Screen.PrimaryScreen.Bounds.Height - yeniMesajPanel.Height-15);
            yeniMesajPanel.BringToFront();

            konuLabel.Left = anaPanel.Width / 2 - konuLabel.Width;
            konuLabelYazi.Left = konuLabel.Left - konuLabelYazi.Width - 10;
            konuLabel.Top = 40;
            konuLabelYazi.Top = 40;
            yanitlaButon.Left = anaPanel.Width - yanitlaButon.Width - 10;
            yanitlaButon.Top = konuLabel.Top;


            icerikTxt.Top = 80;
            icerikTxt.Left = 0;
            icerikTxt.Width = 1200;
            icerikTxt.Height = 320;
            icerikmesajTxt.Height = anaPanel.Height - icerikmesajTxt.Top - 50;

            kimLabelYazi.Left = 10;
            kimlabel.Left = kimLabelYazi.Width + kimLabelYazi.Left + 10;

            tarihLabelYazi.Left = kimlabel.Left + 100;
            tarihLabel.Left = tarihLabelYazi.Left + tarihLabelYazi.Width + 10;

            butonGeriDon.Left = 50;
            butonGeriDon.Top = Screen.PrimaryScreen.Bounds.Height - butonGeriDon.Height - 50;
            
        }
        public void datagridviewSetting(DataGridView datagridview)
        {
            int satir = datagridview.RowCount;
            datagridview.BackgroundColor = Color.FromArgb(245, 245, 220);
            datagridview.RowHeadersVisible = false;//yan okların görüntüsü gidiyo
            datagridview.Size = new Size(1200, 400);//data grid e en boy verilir750,350
            datagridview.Top = (Screen.PrimaryScreen.Bounds.Height - datagridview.Height) / 2;
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview.EnableHeadersVisualStyles = false;
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//HEADERDAN VE SATIRIN TAMAMINI SECMEYİ SAĞLIYOR
            datagridview.BorderStyle = BorderStyle.None;
            datagridview.AllowUserToResizeColumns = true;
            datagridview.AllowUserToResizeRows = false;
            datagridview.ClearSelection();
            datagridview.Left = (Screen.PrimaryScreen.Bounds.Width - datagridview.Width) / 2;
            datagridview.AllowUserToAddRows = false;//datagrid altındaki boş satır silinir.
            datagridview.Height = 58;
            datagridview.MaximumSize = new Size(1200, 400);
            datagridview.ClearSelection();

            datagridview.DefaultCellStyle.Font = new Font("Consolas", 12);
            datagridview.DefaultCellStyle.SelectionForeColor = Color.Black;
            datagridview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(221, 221, 221);
            datagridview.DefaultCellStyle.BackColor = Color.FromArgb(238, 216, 174);
            datagridview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridview.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(91, 91, 91); ;
            datagridview.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 14);
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;//header boyunu girilebilir yapar
            datagridview.ColumnHeadersHeight = 58;//Header boyu girilir
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;//border kaldırma

            tumunuSecButon.Left = datagridview.Width+datagridview.Left - tumunuSecButon.Width - 75;
            tumunuSecButon.Top = datagridview.Top + 20;
            tumunuSecButon.Font= new Font("Consolas", 9);

        }

        private void gelenKutusuButon_Click(object sender, EventArgs e)
        {
            tumunuSecButon.Show();
            okunduButon.Show();
            silButon.Show();
            mesajBaslikPanel.Hide();
            mesajPanel.Hide();
            yeniMesajPanel.Hide();
            gelenKutusuButon.BackColor = Color.RoyalBlue;
            gonderilmisButon.BackColor = Color.White;
            basliklabel.Text = "Gelen Kutusu";
            gelenMesajGoster(dataGridView1);
        }

        private void silButon_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ArrayList secili = new ArrayList();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[5].Value) == true) //checkbox seçiliyse 
                {
                    string id = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    secili.Add(id); //seçiliyse listeye ekle
                }
            }
            connection.Open();
            foreach (string sec in secili) //çoklu silme işlemi gerçekleşiyor
            {
                MySqlCommand komut = new MySqlCommand("update mesaj set ogretmenGoster= 0, ogretmenOkundu = 1 where id='" + sec + "'");
                komut.Connection = connection;
                komut.ExecuteNonQuery();
            }
            connection.Close();
            gelenKutusuButon_Click(sender,e);
            Cursor.Current = Cursors.Default;
        }

        private void okunduButon_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ArrayList secili = new ArrayList();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[5].Value) == true) //checkbox seçiliyse 
                {
                    string id = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    secili.Add(id); //seçiliyse listeye ekle
                }
            }
            connection.Open();
            foreach (string sec in secili) //çoklu silme işlemi gerçekleşiyor
            {
                MySqlCommand komut = new MySqlCommand("update mesaj set ogretmenOkundu= 1 where id='" + sec + "'");
                komut.Connection = connection;
                komut.ExecuteNonQuery();
            }
            connection.Close();
            gelenMesajGoster(dataGridView1);
            Cursor.Current = Cursors.Default;

        }

        private void yeniMesajButon_Click(object sender, EventArgs e)
        {
            int adet = 0;
            for (int i = 0; i < aliciEkleData.Rows.Count; i++)
            {
                if (Convert.ToBoolean(aliciEkleData.Rows[i].Cells[3].Value) == true) //checkbox seçiliyse 
                {
                    adet++;
                }
            }
            aliciTxt.Text = adet.ToString()+ " kişi";
            yeniMesajPanel.Show();

        }
        public struct Ogrenci
        {
            public string isim, soyad, okulNo;
        }
        private void gonderButon_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime dateTime = DateTime.Now;
            Ogrenci[] ogrenci = new Ogrenci[0];
            object sonuc = null;
            int sayi = 0;
            for (int i = 0; i < aliciEkleData.Rows.Count; i++)
            {
                if (Convert.ToBoolean(aliciEkleData.Rows[i].Cells[3].Value) == true) //checkbox seçiliyse 
                {
                    sayi++;
                    Array.Resize(ref ogrenci, sayi);
                    ogrenci[sayi-1].isim = aliciEkleData.Rows[i].Cells[0].Value.ToString();
                    ogrenci[sayi - 1].soyad = aliciEkleData.Rows[i].Cells[1].Value.ToString();
                    ogrenci[sayi - 1].okulNo = aliciEkleData.Rows[i].Cells[2].Value.ToString();
                }
            }
            connection.Open();
            for (int i = 0; i < ogrenci.Length; i++)
            {
                MySqlCommand ekle = new MySqlCommand("insert into mesaj (gonderici,alici,tarih,konu,icerik,ogrenciOkundu,gondericiAdi,aliciAdi) values ('" + OgretmenBilgileri.sinif + "','" + ogrenci[i].okulNo + "','" + dateTime.ToString("s") + "','" + konuTxt.Text + "','" + icerikmesajTxt.Text + "', 0 ,'" + OgretmenBilgileri.isim + "','" + ogrenci[i].isim + " " + ogrenci[i].soyad + "')", connection);
                ekle.Connection = connection;
                sonuc = null;
                sonuc = ekle.ExecuteNonQuery();
            }
            connection.Close();
            if (sonuc != null)
            {
                MessageBox.Show("Mesajınız İletildi");
                icerikmesajTxt.Text = "";
                konuTxt.Text = "";
                gonderilmisButon_Click_1(sender, e);
                yeniMesajKapat_Click(sender, e);
            }
            Cursor.Current = Cursors.Default;
        }

        private void yeniMesajKapat_Click(object sender, EventArgs e)
        {
            yeniMesajPanel.Hide();
        }

        private void gonderilmisButon_Click_1(object sender, EventArgs e)
        {
            tumunuSecButon.Show();
            silButon.Show();
            okunduButon.Hide();
            mesajPanel.Hide();
            mesajBaslikPanel.Hide();
            yeniMesajPanel.Hide();
            gelenKutusuButon.BackColor = Color.White;
            gonderilmisButon.BackColor = Color.RoyalBlue;
            basliklabel.Text = "Gönderilmiş";
            gonderilmisMesajGoster(dataGridView1);
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            Cursor.Current = Cursors.WaitCursor;
            tumunuSecButon.Hide();
            kimlabel.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            konuLabel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            icerikTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tarihLabel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dataGridView1.Hide();
            okunduButon.Hide();
            silButon.Hide();
            mesajBaslikPanel.Show();
            mesajPanel.Show();
            gelenKutusuButon.BackColor = Color.White;
            connection.Open();
            MySqlCommand komut = new MySqlCommand("update mesaj set ogretmenOkundu= 1 where id='" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "'");
            komut.Connection = connection;
            komut.ExecuteNonQuery();
            connection.Close();
            Cursor.Current = Cursors.Default;
        }

        private void yeniMesajKapat_Click_1(object sender, EventArgs e)
        {
            yeniMesajPanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aliciTxt.Text = OgrenciBilgileri.ogretmenAdi;
            basliklabel.Text = "Yeni Mesaj";
            yeniMesajPanel.Show();
            konuTxt.Text = konuLabel.Text;
            icerikmesajTxt.Text += icerikTxt.Text;
            icerikmesajTxt.Text += "\n\nYanıt olarak:\n";
        }

        private void aliciEkleButon_Click(object sender, EventArgs e)
        {
            aliciEklePanel.Width = 400;
            aliciEklePanel.Height = 400;
            aliciEkleData.MaximumSize = new Size(400, 350);
            aliciEkleData.Left = 0;
            aliciEkleData.Top = 0;
            aliciEklePanel.Left = yeniMesajPanel.Left;
            aliciEklePanel.Top = yeniMesajPanel.Top;
            ekleTamamButon.Top = aliciEklePanel.Height - ekleTamamButon.Height - 10;
            ekleTamamButon.Left = 10;
            seciliSilButon.Top = ekleTamamButon.Top;
            seciliSilButon.Left = ekleTamamButon.Left + ekleTamamButon.Width + 10;
            hepsiButon.Top = seciliSilButon.Top;
            hepsiButon.Left = seciliSilButon.Left + seciliSilButon.Width + 10;
            aliciEkle(aliciEkleData);
            aliciEklePanel.Show();
            yeniMesajPanel.Hide();
        }

        private void ekleTamamButon_Click(object sender, EventArgs e)
        {
            aliciEklePanel.Hide();
            yeniMesajPanel.Show();
            int adet = 0;
            for (int i = 0; i < aliciEkleData.Rows.Count; i++)
            {
                if (Convert.ToBoolean(aliciEkleData.Rows[i].Cells[3].Value) == true) //checkbox seçiliyse 
                {
                    adet++;
                }
            }
            aliciTxt.Text = adet.ToString() + " kişi";
        }

        private void hepsiButon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < aliciEkleData.Rows.Count; i++)
            {
                aliciEkleData.Rows[i].Cells[3].Value = true;
            }
        }

        private void seciliSilButon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < aliciEkleData.Rows.Count; i++)
            {
                aliciEkleData.Rows[i].Cells[3].Value = false;
            }
        }

        private void butonGeriDon_Click(object sender, EventArgs e)
        {
            ogretmenMenu frm = new ogretmenMenu();
            this.Hide();
            frm.Show();
        }

        private void tumunuSecButon_Click(object sender, EventArgs e)
        {
            if (tumunuSecButon.Text == "Tümünü Seç")
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[5].Value = true;
                }
                tumunuSecButon.Text = "Kaldır";
            }
            else if (tumunuSecButon.Text == "Kaldır")
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[5].Value = false;
                }
                tumunuSecButon.Text = "Tümünü Seç";
            }
            
        }
    }
}

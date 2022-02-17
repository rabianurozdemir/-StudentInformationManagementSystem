using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using MySql.Data.MySqlClient;

namespace Ebakus
{
    public partial class HafizaOyun : Form
    {
        
        Image[] resimler = new Image[0];
        MySqlConnection connection = Form1.connection;
        int[] indeksler = { 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
        
        PictureBox ilkKutu;
        int ilkIndeks, bulunan, deneme, bolum;

        void PanelSettings() //resimlerin içinde bulunduğu panel ayarlarını ve geri dön butonu ayarlarını yaptığımız metot
        {
            //program farklı ekranlarda çalıştırıldığında responsive görünüm için butonları oranladık
            panel1.Left = Screen.PrimaryScreen.Bounds.Width / 2 - panel1.Width / 2;
            panel1.Top = Screen.PrimaryScreen.Bounds.Height / 2 - panel1.Height / 2;
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            butonGeriDon.Top = Screen.PrimaryScreen.Bounds.Height - butonGeriDon.Height - 50;
            butonGeriDon.Left = 50;
        }
        public HafizaOyun(Image[] images, int bolum)
        {
            InitializeComponent();
            PanelSettings();

            for (int i = 0; i < images.Length; i++)
            {
                Array.Resize(ref resimler, i+1);
                this.resimler[i] = images[i];
            }
            this.bolum = bolum;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            resimleriKaristir(); //form3 yüklendiğinde bu metodu çalıştır
        }

        private void butonGeriDon_Click(object sender, EventArgs e)
        {
            HafizaOyunuMenu form2 = new HafizaOyunuMenu(); //geri dön butonuna tıklandığında oyun haritasına dön
            form2.Show();
            this.Hide();
        }

        private void resimleriKaristir()
        {
            Random random = new Random();

            for (int i = 0; i < 16; i++) //Yerdeğiştirme algoritması ile resimleri karıştırdık
            {
                int sayi = random.Next(0,16);
                int gecici = indeksler[i];
                indeksler[i] = indeksler[sayi];
                indeksler[sayi] = gecici;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox kutu = (PictureBox)sender;
            int kutuNo = int.Parse(kutu.Name.Substring(10));
            int indeksNo = indeksler[kutuNo-1];
            kutu.Image = resimler[indeksNo];
            kutu.Refresh();

            if (ilkKutu==null)
            {
                ilkKutu = kutu;
                ilkIndeks = indeksNo;
                deneme++;
            }
            else
            {
                pictureBox1.Enabled = false;
                System.Threading.Thread.Sleep(1000);
                pictureBox1.Enabled = true;

                ilkKutu.Image = null;
                kutu.Image = null;
                if (Math.Abs(ilkIndeks-indeksNo)==8)
                {
                    bulunan++;
                    ilkKutu.Visible = false;
                    kutu.Visible = false;

                    //aşağıdaki veritabanı işlemleri ile oyunu oynayan kişinin kaldığı yerden devam etmesini sağladık
                    if (bulunan==8)
                    {
                        connection.Open();
                        if (bolum == 1)
                        {
                            
                            MySqlCommand command = new MySqlCommand("update oyunHafiza set level= 2 where okulNo='" + OgrenciBilgileri.okul_no + "'");
                            command.Connection = connection;
                            command.ExecuteNonQuery();
                            
                        }
                        else if (bolum == 2)
                        {
                            MySqlCommand command = new MySqlCommand("update oyunHafiza set level= 3 where okulNo='" + OgrenciBilgileri.okul_no + "'");
                            command.Connection = connection;
                            command.ExecuteNonQuery();
                        }
                        else if (bolum == 3)
                        {
                            MySqlCommand command = new MySqlCommand("update oyunHafiza set level= 4 where okulNo='" + OgrenciBilgileri.okul_no + "'");
                            command.Connection = connection;
                            command.ExecuteNonQuery();
                        }
                        else if (bolum == 4)
                        {
                            MySqlCommand command = new MySqlCommand("update oyunHafiza set level= 5 where okulNo='" + OgrenciBilgileri.okul_no + "'");
                            command.Connection = connection;
                            command.ExecuteNonQuery();
                        }
                        else if (bolum == 5)
                        {
                            MySqlCommand command = new MySqlCommand("update oyunHafiza set level= 6 where okulNo='" + OgrenciBilgileri.okul_no + "'");
                            command.Connection = connection;
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                        System.Media.SoundPlayer ses = new System.Media.SoundPlayer(); //oyun bittiğinde alkış sesi
                        ses.SoundLocation = "yeeey.wav";
                        ses.Play();
                        MessageBox.Show("Tebrikler! " + deneme + " denemede tüm eşleştirmeleri tamamladınız."); //kaç denemede bitirdiniz
                        ses.Stop();
                        bulunan = 0;
                        deneme = 0;
                        foreach (Control kontrol in Controls)
                        {
                            kontrol.Visible = true;
                        }
                        resimleriKaristir();
                    }
                }
                ilkKutu = null;
            }
        }

    }
}

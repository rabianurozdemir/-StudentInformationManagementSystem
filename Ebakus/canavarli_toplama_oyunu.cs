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
    public partial class canavar : Form
    {
        MySqlConnection connection = Form1.connection;

        System.Drawing.Rectangle sayfa = Screen.PrimaryScreen.WorkingArea;
        System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
        public canavar()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------------------------------------------

        int islem = 0;//Bitirilmiş işlem sayısını yazmak için ve işlem zorluklarını ne zaman arttırıcağımı anlamak için,
        int sayac = 10;//geri sayım için,
        int sayac_progressbar_icin = 0; //progressBar için,
        //alttakileri işlem oluşturdan hangi sayıların geleceğini ,sorulan işlemi ve hangisinin doğru olduğunu öğrenmek  için,---------
        int sonuc2;
        int denizalti_label_sonuc;
        int gokyuzu_label_sonuc;
        int yeryuzu_label_sonuc;
        //------------------------------
        int geri_don_klik ;//oyundan çıkıldığı zamanı anlamak için ,çıkılma durumuna göre islem_kontrol fonksiyonunu çalıştırmıyorum

        int basla_tiklama_sayisi = 0;//başla butonunda tıklama sayısına göre tıklandığı zaman nelerin olacağını yazmak için,
       
        //------------------------------------------------------------------------------------------------------------------------

        //Enine hangi oranla bölünüyor 1-6-2
        public void konum()
        {

            hareket_alanı_panel.Size = new System.Drawing.Size((sayfa.Width / 9) * 6, (sayfa.Height / 9) * 6);
            hareket_alanı_panel.Location = new Point((sayfa.Width - hareket_alanı_panel.Width) / 2, sayfa.Height / 12);

            bilgiler_panel.Size = new System.Drawing.Size(sayfa.Width, (sayfa.Height / 9) * 2);

            ilkuc.Location = new Point(hareket_alanı_panel.Right + (sayfa.Width - hareket_alanı_panel.Right - ilkuc.Width) / 2, sayfa.Height / 9);
            ilkuc.Size = new System.Drawing.Size(sayfa.Width / 9, hareket_alanı_panel.Height / 2);

            en_iyiler_label.Location = new Point(ilkuc.Left + (ilkuc.Width - en_iyiler_label.Width) / 2, sayfa.Height / 20);

            button_basla.Size = new System.Drawing.Size(ilkuc.Width, (sayfa.Height / 9));
            button_basla.Location = new Point(ilkuc.Location.X, ilkuc.Location.Y + ilkuc.Height + button_basla.Height / 2);



            yukari_yon_buton.Location = new Point((sayfa.Width - hareket_alanı_panel.Right - yukari_yon_buton.Width) / 2, sayfa.Height / 12 + (hareket_alanı_panel.Height / 7) * 1);
            asagi_yon_buton.Location = new Point(yukari_yon_buton.Left, sayfa.Height / 12 + (hareket_alanı_panel.Height / 7) * 4);
            yukari_yon_buton.Size = new System.Drawing.Size(button_basla.Width / 2, button_basla.Height);
            asagi_yon_buton.Size = new System.Drawing.Size(button_basla.Width / 2, button_basla.Height);

            gokyuzu_label.Size = new System.Drawing.Size(hareket_alanı_panel.Width / 6, hareket_alanı_panel.Height / 3);
            yeryuzu_label.Size = new System.Drawing.Size(hareket_alanı_panel.Width / 6, hareket_alanı_panel.Height / 3);
            denizalti_label.Size = new System.Drawing.Size(hareket_alanı_panel.Width / 6, hareket_alanı_panel.Height / 3);
            gokyuzu_label.Location = new Point(hareket_alanı_panel.Right - gokyuzu_label.Width, sayfa.Height / 12);
            yeryuzu_label.Location = new Point(gokyuzu_label.Left, sayfa.Height / 12 + gokyuzu_label.Height);
            denizalti_label.Location = new Point(gokyuzu_label.Left, sayfa.Height / 12 + gokyuzu_label.Height * 2);

            alanlariayirma_picturebox1.Size = new System.Drawing.Size(hareket_alanı_panel.Width, hareket_alanı_panel.Height / 90);
            alanlariayirma_picturebox1.Location = new Point(hareket_alanı_panel.Left, sayfa.Height / 12 + gokyuzu_label.Height);
            alanlari_ayirma_pictureBox2.Size = new System.Drawing.Size(hareket_alanı_panel.Width, hareket_alanı_panel.Height / 90);
            alanlari_ayirma_pictureBox2.Location = new Point(hareket_alanı_panel.Left, sayfa.Height / 12 + (gokyuzu_label.Height) * 2);

            panelustune_picturebox.Size = new System.Drawing.Size((sayfa.Width / 9) * 6, hareket_alanı_panel.Height / 90);
            panelustune_picturebox.Location = new Point((sayfa.Width - hareket_alanı_panel.Width) / 2, sayfa.Height / 12 - hareket_alanı_panel.Height / 90);
            panelaltina_picturebox.Size = new System.Drawing.Size((sayfa.Width / 9) * 6 + hareket_alanı_panel.Height / 90, hareket_alanı_panel.Height / 90);
            panelaltina_picturebox.Location = new Point((sayfa.Width - hareket_alanı_panel.Width) / 2, sayfa.Height / 12 + hareket_alanı_panel.Height);
            panelsolicin_pictureBox1.Size = new System.Drawing.Size(hareket_alanı_panel.Height / 90, hareket_alanı_panel.Height);
            panelsolicin_pictureBox1.Location = new Point((sayfa.Width - hareket_alanı_panel.Width) / 2, sayfa.Height / 12);
            panelsagicin_pictureBox2.Size = new System.Drawing.Size(hareket_alanı_panel.Height / 90, hareket_alanı_panel.Height + hareket_alanı_panel.Height / 90);
            panelsagicin_pictureBox2.Location = new Point((sayfa.Width - hareket_alanı_panel.Width) / 2 + hareket_alanı_panel.Width, sayfa.Height / 12 - hareket_alanı_panel.Height / 90);

            progressBar1.Size = new System.Drawing.Size((sayfa.Width / 9) * 6 + hareket_alanı_panel.Height / 90, hareket_alanı_panel.Height / 45);
            progressBar1.Location = new Point((sayfa.Width - hareket_alanı_panel.Width) / 2, sayfa.Height / 12 + hareket_alanı_panel.Height + panelaltina_picturebox.Height);

            karakter.Size = new System.Drawing.Size((gokyuzu_label.Width / 4) * 3, (gokyuzu_label.Height / 4) * 3);
            karakter.Location = new Point(karakter.Width / 3, (gokyuzu_label.Height / 8));

            //alttakiler sayıların çıktığı yerler
            kalan_sure_label.Size = new System.Drawing.Size(150, 40);
            bitirilen_islem_sayisi_label.Size = new System.Drawing.Size(150, 40);
            kalan_sure_label.Location = new Point(bilgiler_panel.Width - 20 - kalan_sure_label.Width, 20);
            bitirilen_islem_sayisi_label.Location = new Point(kalan_sure_label.Left, bilgiler_panel.Height - 20 - bitirilmis_islem_sayisi_label.Height);

            //alttakiler sadece yazının yazıldığı yer
            geri_sayim_label.Location = new Point(kalan_sure_label.Left - geri_sayim_label.Width-10, kalan_sure_label.Top);
            bitirilmis_islem_sayisi_label.Location = new Point(bitirilen_islem_sayisi_label.Left - bitirilmis_islem_sayisi_label.Width - 10, bitirilen_islem_sayisi_label.Top);

            

            islem_label.Location = new Point((bilgiler_panel.Width-islem_label.Width)/2, (bilgiler_panel.Height - islem_label.Height)/2);
            islem_yazısi.Location = new Point(islem_label.Left, 20);


            birIsim.Left = 10;
            ikiIsim.Left = 10;
            ucIsim.Left = 10;

            birPuan.Left = ilkuc.Width - 35;
            ikiPuan.Left = ilkuc.Width - 35;
            ucPuan.Left = ilkuc.Width - 35;

            birIsim.Top = 30;
            birPuan.Top = birIsim.Top;
            ikiIsim.Top = birIsim.Top+20 + birIsim.Height;
            ikiPuan.Top = ikiIsim.Top;
            ucIsim.Top = 20 + ikiIsim.Height+ ikiIsim.Top;
            ucPuan.Top = ucIsim.Top;

            butonGeriDon.Left = 50;
            butonGeriDon.Top = bilgiler_panel.Height - butonGeriDon.Height - 50;
        }
        private void canavar_Load(object sender, EventArgs e)
        {

            konum();
            geri_don_klik = 0;

            yukari_yon_buton.Enabled = false;
            asagi_yon_buton.Enabled = false;

            listele();

        }
        private void listele()
        {
            string[] isim = new string[3];
            string[] puan = new string[3];
            int sayi = 0;
            connection.Open();
            MySqlCommand command = new MySqlCommand("Select *from canavarOyun ORDER BY puan DESC", connection);//notOgrenci tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku
            while (reader.Read())
            {
                isim[sayi] = reader["isim"].ToString() + " " + reader["soyad"].ToString().Substring(0,1)+".";
                puan[sayi] = reader["puan"].ToString();
                sayi++;
                if (sayi >= 3)
                {
                    break;
                }
            }
            connection.Close();

            birIsim.Text = isim[0];
            birPuan.Text = puan[0];
            ikiIsim.Text = isim[1];
            ikiPuan.Text = puan[1];
            ucIsim.Text = isim[2];
            ucPuan.Text = puan[2];
        }
       
        public void islem_olustur()
        {

            int alt_sinir;
            int ust_sinir;
            if (islem <= 3)
            {
                //işlem integer ını yukarda 0 tanımladım 3 olana kadar alt sınırım ve üst sınırım aşşağıdaki sayılar olacak yani ilk 4 işlem en az 20+20 en çok 50+50 olacaktır
                alt_sinir = 20;
                ust_sinir = 50;
            }
            else if (islem > 3 && islem <= 6)
            {
                alt_sinir = 50;
                ust_sinir = 100;
            }
            else
            {
                alt_sinir = 150;
                ust_sinir = 300;
            }
            Random rastgele = new Random();
            int sayi_1 = rastgele.Next(alt_sinir, ust_sinir);
            int sayi_2 = rastgele.Next(alt_sinir, ust_sinir);
            int sonuc = sayi_1 + sayi_2;
            int gokyuzundeki_sayi;
            int yeryuzundeki_sayi;
            int denizdeki_sayi;

            int yerlestirme = rastgele.Next();//bunu kullanarak doğru cevabın ve yanlış cevapların nereye gidiceğini belirliyorum

            if (yerlestirme % 3 == 1)
            {
                gokyuzundeki_sayi = sonuc;

                if (alt_sinir == 20)
                {
                    yeryuzundeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 3);
                    denizdeki_sayi = rastgele.Next(alt_sinir * 3, ust_sinir * 2);
                }
                else
                {
                    denizdeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 2);
                    denizdeki_sayi = denizdeki_sayi - (denizdeki_sayi % 10) + (sonuc % 10);
                    yeryuzundeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 2);
                    yeryuzundeki_sayi = yeryuzundeki_sayi - (yeryuzundeki_sayi % 10) + (sonuc % 10);
                    /*işlem zorluğunu arttırmak için belli bir yerden sonra sayıların birler basamağını aynı getiriyorum*/

                }




                /*sayıların birbiriyle eşit olması durumunda farklı bir sayı gelene kadar yazdığım sınırlar arasında rastgele
                 sayı gelmesini sağlıyorum*/

                while (yeryuzundeki_sayi == sonuc || yeryuzundeki_sayi == denizdeki_sayi)
                {
                    yeryuzundeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 2);
                }
                while (denizdeki_sayi == sonuc || denizdeki_sayi == yeryuzundeki_sayi)
                {
                    denizdeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 2);
                }


                gokyuzu_label.Text = Convert.ToString(sonuc);
                yeryuzu_label.Text = Convert.ToString(yeryuzundeki_sayi);
                denizalti_label.Text = Convert.ToString(denizdeki_sayi);
            }
            else if (yerlestirme % 3 == 2)
            {
                yeryuzundeki_sayi = sonuc;

                if (alt_sinir == 20)
                {
                    denizdeki_sayi = rastgele.Next(alt_sinir * 3, ust_sinir * 2);
                    gokyuzundeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 3);
                }
                else
                {
                    gokyuzundeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 2);
                    gokyuzundeki_sayi = gokyuzundeki_sayi - (gokyuzundeki_sayi % 10) + (sonuc % 10);
                    denizdeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 2);
                    denizdeki_sayi = denizdeki_sayi - (denizdeki_sayi % 10) + (sonuc % 10);

                }


                while (gokyuzundeki_sayi == sonuc || gokyuzundeki_sayi == denizdeki_sayi)
                {
                    gokyuzundeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 2);
                }
                while (denizdeki_sayi == sonuc || gokyuzundeki_sayi == denizdeki_sayi)
                {
                    denizdeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 2);
                }


                gokyuzu_label.Text = Convert.ToString(gokyuzundeki_sayi);
                yeryuzu_label.Text = Convert.ToString(sonuc);
                denizalti_label.Text = Convert.ToString(denizdeki_sayi);

            }
            else
            {


                denizdeki_sayi = sonuc;
                if (alt_sinir == 20)
                {
                    yeryuzundeki_sayi = rastgele.Next(alt_sinir * 3, ust_sinir * 2);
                    gokyuzundeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 3);
                }
                else
                {
                    gokyuzundeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 2);
                    gokyuzundeki_sayi = gokyuzundeki_sayi - (gokyuzundeki_sayi % 10) + (sonuc % 10);
                    yeryuzundeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 2);
                    yeryuzundeki_sayi = yeryuzundeki_sayi - (yeryuzundeki_sayi % 10) + (sonuc % 10);

                }


                while (yeryuzundeki_sayi == sonuc || yeryuzundeki_sayi == gokyuzundeki_sayi)
                {
                    yeryuzundeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 2);
                }
                while (gokyuzundeki_sayi == sonuc || yeryuzundeki_sayi == gokyuzundeki_sayi)
                {
                    gokyuzundeki_sayi = rastgele.Next(alt_sinir * 2, ust_sinir * 2);
                }



                gokyuzu_label.Text = Convert.ToString(gokyuzundeki_sayi);
                yeryuzu_label.Text = Convert.ToString(yeryuzundeki_sayi);
                denizalti_label.Text = Convert.ToString(sonuc);
            }

            islem_label.Text = sayi_1 + "+" + sayi_2 + "= ?";
            /*değişkenleri yukarda daha önceden tanımladığım
             * değişkenlere ilerki aşamalarda kullanmak için atıyorum
             */
            sonuc2 = sonuc;
            denizalti_label_sonuc = denizdeki_sayi;
            gokyuzu_label_sonuc = gokyuzundeki_sayi;
            yeryuzu_label_sonuc = yeryuzundeki_sayi;
            

        }
        public void islem_kontrol()
        {

            int y = karakter.Location.Y + karakter.Width / 2;

            if (sonuc2 == denizalti_label_sonuc)
            {
                if (y > denizalti_label.Location.Y)//karakterin doğru alanda olup olmadığını kontrol ediyorum
                {


                    islem++;
                    sayac = 10;
                    bitirilen_islem_sayisi_label.Text = Convert.ToString(islem);
                    islem_olustur();
                    karakter.Location = new Point(karakter.Width / 3, (gokyuzu_label.Height / 8));
                    timer1.Start();
                    

                }
                else
                {//karakter yanlış yerdeyse yapılacak işlemler
                    ses.Stop();
                    MessageBox.Show("Kaybettiniz yapılan işlem sayısı "+ bitirilen_islem_sayisi_label.Text);
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    //kişinin kaç işlem tamamladığını yazdırmak için veri tabanı bağlantısı kurulur.
                    MySqlCommand komut = new MySqlCommand("update canavarOyun set puan='" + bitirilen_islem_sayisi_label.Text.ToString() + "' where okulNo='" + OgrenciBilgileri.okul_no + "'");
                    komut.Connection = connection;
                    komut.ExecuteNonQuery();
                    connection.Close();
                    //listele fonksiyonu ile oyunu oynayan en iyi üç kişinin adları ve bitirdikleri işlem sayısı yazdırılır
                    listele();
                }


            }
            else if (sonuc2 == gokyuzu_label_sonuc)
            {

                if (y < yeryuzu_label.Location.Y)
                {
                    islem++;
                    sayac = 10;
                    bitirilen_islem_sayisi_label.Text = Convert.ToString(islem);
                    islem_olustur();
                    karakter.Location = new Point(karakter.Width / 3, (gokyuzu_label.Height / 8));
                    timer1.Start();
                    



                }
                else
                {
                    ses.Stop();
                    MessageBox.Show("Kaybettiniz yapılan işlem sayısı " + bitirilen_islem_sayisi_label.Text);
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    MySqlCommand komut = new MySqlCommand("update canavarOyun set puan='" + bitirilen_islem_sayisi_label.Text.ToString() + "' where okulNo='" + OgrenciBilgileri.okul_no + "'");
                    komut.Connection = connection;
                    komut.ExecuteNonQuery();
                    connection.Close();
                    listele();
                }
            }
            else if (sonuc2 == yeryuzu_label_sonuc)
            {

                if (y < denizalti_label.Location.Y && y > yeryuzu_label.Location.Y)
                {
                    islem++;
                    sayac = 10;
                    bitirilen_islem_sayisi_label.Text = Convert.ToString(islem);
                    islem_olustur();
                    karakter.Location = new Point(karakter.Width / 3, (gokyuzu_label.Height / 8));
                    timer1.Start();
                    
                }
                else
                {
                    ses.Stop();
                    MessageBox.Show("Kaybettiniz yapılan işlem sayısı " + bitirilen_islem_sayisi_label.Text);
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    MySqlCommand komut = new MySqlCommand("update canavarOyun set puan='" + bitirilen_islem_sayisi_label.Text.ToString() + "' where okulNo='" + OgrenciBilgileri.okul_no + "'");
                    komut.Connection = connection;
                    komut.ExecuteNonQuery();
                    connection.Close();
                    listele();

                }

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            sayac_progressbar_icin = 10 - sayac;//15 Tİ

            if (sayac >= 0)
            {

                progressBar1.Value = sayac_progressbar_icin;
                kalan_sure_label.Text = Convert.ToString(sayac);
                karakter.Left = karakter.Left + ((hareket_alanı_panel.Width / 15));
                sayac--;

            }
            if (kalan_sure_label.Text == "0")
            {
                timer1.Stop();
                //ses.Stop();
                kalan_sure_label.Text = "Süre Doldu";
                if (geri_don_klik!=1)//geri dön butonuna basıldıysa islem_kontrol fonksiyonunun çalışmasını istemiyorum
                    islem_kontrol();

            }


        }

        private void button_basla_Click(object sender, EventArgs e)
        {
            basla_tiklama_sayisi++;
            timer1.Interval = 1000;
            timer1.Start();
            islem = 0;
            button_basla.Text = "Tekrar";
            kalan_sure_label.Text = "10";
            bitirilen_islem_sayisi_label.Text = "0";
            bitirilen_islem_sayisi_label.Text = Convert.ToString(islem);
            islem_olustur();

            yukari_yon_buton.Enabled = true;
            asagi_yon_buton.Enabled = true;
            ses.SoundLocation = "Itsy_Bitsy_Spider_instrumental.wav";
            ses.PlayLooping();

            if (basla_tiklama_sayisi > 1)
            {
                sayac = 10;
                sayac_progressbar_icin = 0;
                ses.Stop();
                ses.PlayLooping();
                timer1.Stop();
                timer1.Start();
                karakter.Location = new Point(karakter.Width / 3, (gokyuzu_label.Height / 8));

            }


        }

        private void yukari_yon_buton_Click(object sender, EventArgs e)
        {
            int y = karakter.Location.Y;
            int x = karakter.Location.X;

            if (karakter.Location.Y + karakter.Height / 2 > yeryuzu_label.Location.Y)
            {
                y -= hareket_alanı_panel.Height / 3;
            }

            karakter.Location = new Point(x, y);

        }

        private void asagi_yon_buton_Click(object sender, EventArgs e)
        {
            int y = karakter.Location.Y;
            int x = karakter.Location.X;


            if (karakter.Location.Y + karakter.Height / 2 < denizalti_label.Location.Y)
            {
                y += hareket_alanı_panel.Height / 3;
            }

            karakter.Location = new Point(x, y);
        }

        private void butonGeriDon_Click(object sender, EventArgs e)
        {
            geri_don_klik = 1;
            ses.Stop();
            oyunlarMenu frm = new oyunlarMenu();
            frm.Show();
            this.Hide();
        }

        private void canavar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    
    }
}

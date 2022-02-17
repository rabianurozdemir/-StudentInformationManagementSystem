using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Ebakus
{
    public partial class oyun_cografya_puzzle : Form
    {
        
        public oyun_cografya_puzzle()
        {
            InitializeComponent();
        }
       
        Image[] resimdizi = new Image[9];

        MySqlConnection connection = Form1.connection;

        public void oyun_cografya_puzzle_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            puzzelyerbelirle();
            haritakucuk.Visible = false;
            puzelicinbosbuton.Visible = false;                       
            puzzle_bitir_buton.Enabled = false;
            puzelbuton_dur.Enabled = false;
            puzzletekrardenebuton.Enabled =false;           
            resmi_goster.Enabled = false;
            timer1.Enabled = false;      
            timer1.Interval = 1000 * 60; //Timer1'in Interval'ini 1000 olarak ayarlıyoruz.1000=1sn

            oyun_cografyaSetting(resimdizi);
            
            puzzlepart1_buton.Enabled = false;
            puzzlepart2_buton.Enabled = false;
            puzzlepart3_buton.Enabled = false;
            puzzlepart4_buton.Enabled = false;
            puzzlepart5_buton.Enabled = false;
            puzzlepart6_buton.Enabled = false;
            puzzlepart7_buton.Enabled = false;
            puzzlepart8_buton.Enabled = false;
            puzzlepart9_buton.Enabled = false;



            Cursor.Current = Cursors.Default;

        }

        public int buyumeMiktari = 100;
        public void puzzelyerbelirle()
        {
            Cursor.Current = Cursors.WaitCursor;
            System.Drawing.Rectangle sayfa = Screen.PrimaryScreen.WorkingArea;
            cpuzzel_panel.Size = new System.Drawing.Size(sayfa.Width / 2, sayfa.Height * 4 / 6);//boyutlar için
            puzzlepart1_buton.Size = new System.Drawing.Size(sayfa.Width / 10, sayfa.Height / 6);
            puzzlepart2_buton.Size = puzzlepart1_buton.Size;
            puzzlepart3_buton.Size = puzzlepart1_buton.Size;
            puzzlepart4_buton.Size = puzzlepart1_buton.Size;
            puzzlepart5_buton.Size = puzzlepart1_buton.Size;
            puzzlepart6_buton.Size = puzzlepart1_buton.Size;
            puzzlepart7_buton.Size = puzzlepart1_buton.Size;
            puzzlepart8_buton.Size = puzzlepart1_buton.Size;
            puzzlepart9_buton.Size = puzzlepart1_buton.Size;

            puzzle_cografya_basla_buton.Location = new Point((((sayfa.Width)) / 8) + (sayfa.Width / 10) * 6, sayfa.Height / 10);
            puzelbuton_dur.Location = new Point((((sayfa.Width)) / 8) + (sayfa.Width / 10) * 6, sayfa.Height / 10 + (sayfa.Height / 6));
            puzzletekrardenebuton.Location = new Point((((sayfa.Width)) / 8) + (sayfa.Width / 10) * 6, sayfa.Height / 10 + (sayfa.Height / 6) * 2);
            resmi_goster.Location = new Point((((sayfa.Width)) / 8) + (sayfa.Width / 10) * 6, sayfa.Height / 10 + (sayfa.Height / 6) * 3);
            
            timer_puzzlelabel1_dk.Location = new Point(sayfa.Width*2/5,sayfa.Height/25);
            cpuzzel_panel.Location = new Point(sayfa.Width / 10, sayfa.Height / 10);//uzaklıklar için

            puzzlepart2_buton.Location = new Point(cpuzzel_panel.Width / 2 - puzzlepart2_buton.Width/2, sayfa.Height / 10);
            puzzlepart5_buton.Location = new Point(cpuzzel_panel.Width / 2 - puzzlepart5_buton.Width/2, sayfa.Height / 10 + sayfa.Height / 6);
            puzzlepart8_buton.Location = new Point(cpuzzel_panel.Width / 2 - puzzlepart8_buton.Width/2, sayfa.Height / 10 + (sayfa.Height / 6) * 2);

            puzzlepart1_buton.Location = new Point(cpuzzel_panel.Width / 2 - puzzlepart2_buton.Width/2 - puzzlepart1_buton.Width, sayfa.Height / 10);
            puzzlepart4_buton.Location = new Point(cpuzzel_panel.Width / 2 - puzzlepart5_buton.Width / 2 - puzzlepart4_buton.Width, sayfa.Height / 10 + sayfa.Height / 6);
            puzzlepart7_buton.Location = new Point(cpuzzel_panel.Width / 2 - puzzlepart8_buton.Width / 2 - puzzlepart7_buton.Width, sayfa.Height / 10 + (sayfa.Height / 6) * 2);

            puzzlepart3_buton.Location = new Point(cpuzzel_panel.Width / 2 - puzzlepart2_buton.Width / 2 + puzzlepart3_buton.Width, sayfa.Height / 10);
            puzzlepart6_buton.Location = new Point(cpuzzel_panel.Width / 2 - puzzlepart5_buton.Width / 2 + puzzlepart6_buton.Width, sayfa.Height / 10 + sayfa.Height / 6);
            puzzlepart9_buton.Location = new Point(cpuzzel_panel.Width / 2 - puzzlepart8_buton.Width / 2 + puzzlepart9_buton.Width, sayfa.Height / 10 + (sayfa.Height / 6) * 2);

            level_icin_label.Location = new Point(5, 5);
            timer_puzzlelabel1_dk.Location = new Point(cpuzzel_panel.Width - timer_puzzlelabel1_dk.Width - 5, 5);

            haritakucuk.Left = (Screen.PrimaryScreen.Bounds.Width - haritakucuk.Width) / 2;
            haritakucuk.Top = (Screen.PrimaryScreen.Bounds.Height - haritakucuk.Height) / 2;
            puzzle_bitir_buton.Location = new Point((((sayfa.Width)) / 8) + (sayfa.Width / 10) * 6, sayfa.Height / 10);

            butonGeriDon.Left = 50;
            butonGeriDon.Top = Screen.PrimaryScreen.Bounds.Height - butonGeriDon.Height - 50;

            Cursor.Current = Cursors.Default;
        }


        public Image [] oyun_cografyaSetting(Image[]resimdizi)
        {//puzzel için resim borut genişlik=480 yüksekli=425
            Cursor.Current = Cursors.WaitCursor;
            System.Drawing.Rectangle sayfa = Screen.PrimaryScreen.WorkingArea;
            ses_alkis.Stop();
            string okul = OgrenciBilgileri.okul_no;
            int level = 1;
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select * from cografya_puzzel where okul_no= " + okul, connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = komut.ExecuteReader();//veri tabanını oku
            while (reader.Read())
            {
                level = Convert.ToInt32(reader["level"]);
            }
            connection.Close();

            if (level==1)
                    {

               
                
                Image orginal = Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\marmara.jpg");
                        var img = orginal;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {

                                var index = i * 3 + j;
                                resimdizi[index] = new Bitmap(sayfa.Width / 10, sayfa.Height / 6);
                                var graphics = Graphics.FromImage(resimdizi[index]);
                                graphics.DrawImage(img, new Rectangle(0, 0, sayfa.Width / 10, sayfa.Height / 6), new Rectangle(i * sayfa.Width / 10, j * sayfa.Height / 6, sayfa.Width / 10, sayfa.Height / 6), GraphicsUnit.Pixel);
                                graphics.Dispose();
                            }


                        }
                puzzlepart1_buton.BackgroundImage = resimdizi[0];
                puzzlepart2_buton.BackgroundImage = resimdizi[3];
                puzzlepart3_buton.BackgroundImage = resimdizi[6];
                puzzlepart4_buton.BackgroundImage = resimdizi[1];
                puzzlepart6_buton.BackgroundImage = resimdizi[5];
                puzzlepart7_buton.BackgroundImage = resimdizi[2];
                puzzlepart8_buton.BackgroundImage = resimdizi[7];
                puzzlepart9_buton.BackgroundImage = resimdizi[4];

            }
            else if (level==2)
                    {

                cpuzzel_panel.BackColor = Color.FromArgb(255, 219, 219);
                puzzlepart1_buton.BackColor= Color.FromArgb(198, 255, 255);
                puzzlepart2_buton.BackColor = Color.FromArgb(198, 255, 255);
                puzzlepart3_buton.BackColor = Color.FromArgb(198, 255, 255);
                puzzlepart4_buton.BackColor = Color.FromArgb(198, 255, 255);
                puzzlepart5_buton.BackColor = Color.FromArgb(198, 255, 255);
                puzzlepart6_buton.BackColor = Color.FromArgb(198, 255, 255);
                puzzlepart7_buton.BackColor = Color.FromArgb(198, 255, 255);
                puzzlepart8_buton.BackColor = Color.FromArgb(198, 255, 255);
                puzzlepart9_buton.BackColor = Color.FromArgb(198, 255, 255);
                level_icin_label.Text = "Level 2: Karadeniz";
                Image orginal = Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\karadeniz.jpg");
                        var img = orginal;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {

                                var index = i * 3 + j;
                                resimdizi[index] = new Bitmap(sayfa.Width / 10, sayfa.Height / 6);
                                var graphics = Graphics.FromImage(resimdizi[index]);
                                graphics.DrawImage(img, new Rectangle(0, 0, sayfa.Width / 10, sayfa.Height / 6), new Rectangle(i * sayfa.Width / 10, j * sayfa.Height / 6, sayfa.Width / 10, sayfa.Height / 6), GraphicsUnit.Pixel);
                                graphics.Dispose();
                            }
                        }
                        //kazanmak için sırasıyla 8,5,2,1 butonlarına basılmalı
                puzzlepart1_buton.BackgroundImage = resimdizi[3];
                puzzlepart2_buton.BackgroundImage = resimdizi[4];
                puzzlepart3_buton.BackgroundImage = resimdizi[6];
                puzzlepart4_buton.BackgroundImage = resimdizi[1];
                puzzlepart5_buton.BackgroundImage = resimdizi[5];
                puzzlepart6_buton.BackgroundImage = resimdizi[7];
                puzzlepart7_buton.BackgroundImage = resimdizi[2];
                puzzlepart8_buton.BackgroundImage = resimdizi[8];
               
            }
            else if (level==3)
                    {

                cpuzzel_panel.BackColor = Color.FromArgb(90,90,132);
                puzzlepart1_buton.BackColor = Color.FromArgb(165,201,192);
                puzzlepart2_buton.BackColor = Color.FromArgb(165, 201, 192);
                puzzlepart3_buton.BackColor = Color.FromArgb(165, 201, 192);
                puzzlepart4_buton.BackColor = Color.FromArgb(165, 201, 192);
                puzzlepart5_buton.BackColor = Color.FromArgb(165, 201, 192);
                puzzlepart6_buton.BackColor = Color.FromArgb(165, 201, 192);
                puzzlepart7_buton.BackColor = Color.FromArgb(165, 201, 192);
                puzzlepart8_buton.BackColor = Color.FromArgb(165, 201, 192);
                puzzlepart9_buton.BackColor = Color.FromArgb(165, 201, 192);
                level_icin_label.Text = "Level 3: İç Anadolu";
                Image orginal = Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\icanadolu.jpg");
                        var img = orginal;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {

                                var index = i * 3 + j;
                                resimdizi[index] = new Bitmap(sayfa.Width / 10, sayfa.Height / 6);
                                var graphics = Graphics.FromImage(resimdizi[index]);
                                graphics.DrawImage(img, new Rectangle(0, 0, sayfa.Width / 10, sayfa.Height / 6), new Rectangle(i * sayfa.Width / 10, j * sayfa.Height / 6, sayfa.Width / 10, sayfa.Height / 6), GraphicsUnit.Pixel);
                                graphics.Dispose();
                            }
                        }
                //kazanmak için sırasıyla 2,5,6,9 butonlarına basılmalı
                puzzlepart2_buton.BackgroundImage = resimdizi[0];
                puzzlepart3_buton.BackgroundImage = resimdizi[6];
                puzzlepart4_buton.BackgroundImage = resimdizi[1];
                puzzlepart5_buton.BackgroundImage = resimdizi[3];
                puzzlepart6_buton.BackgroundImage = resimdizi[4];
                puzzlepart7_buton.BackgroundImage = resimdizi[2];
                puzzlepart8_buton.BackgroundImage = resimdizi[5];
                puzzlepart9_buton.BackgroundImage = resimdizi[7];
            }
            else if (level==4)
            {

                cpuzzel_panel.BackColor = Color.FromArgb(109,160,153);
                puzzlepart1_buton.BackColor = Color.FromArgb(206,206,255);
                puzzlepart2_buton.BackColor = Color.FromArgb(206, 206, 255);
                puzzlepart3_buton.BackColor = Color.FromArgb(206, 206, 255);
                puzzlepart4_buton.BackColor = Color.FromArgb(206, 206, 255);
                puzzlepart5_buton.BackColor = Color.FromArgb(206, 206, 255);
                puzzlepart6_buton.BackColor = Color.FromArgb(206, 206, 255);
                puzzlepart7_buton.BackColor = Color.FromArgb(206, 206, 255);
                puzzlepart8_buton.BackColor = Color.FromArgb(206, 206, 255);
                puzzlepart9_buton.BackColor = Color.FromArgb(206, 206, 255);
                level_icin_label.Text = "Level 4: Ege";
                Image orginal = Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\ege.jpg");
                       

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {

                                var index = i * 3 + j;
                                resimdizi[index] = new Bitmap(sayfa.Width / 10, sayfa.Height / 6);
                                var graphics = Graphics.FromImage(resimdizi[index]);
                                graphics.DrawImage(orginal, new Rectangle(0, 0, sayfa.Width / 10, sayfa.Height / 6), new Rectangle(i * sayfa.Width / 10, j * sayfa.Height / 6, sayfa.Width / 10, sayfa.Height / 6), GraphicsUnit.Pixel);
                                graphics.Dispose();
                            }
                        }
                //kazanmak için sırasıyla 5,4,7,8,9butonlarına basılmalı
                puzzlepart1_buton.BackgroundImage = resimdizi[0];                
                puzzlepart3_buton.BackgroundImage = resimdizi[6];
                puzzlepart4_buton.BackgroundImage = resimdizi[4];
                puzzlepart5_buton.BackgroundImage = resimdizi[3];
                puzzlepart6_buton.BackgroundImage = resimdizi[7];
                puzzlepart7_buton.BackgroundImage = resimdizi[1];
                puzzlepart8_buton.BackgroundImage = resimdizi[2];
                puzzlepart9_buton.BackgroundImage = resimdizi[5];
            }
            else if (level==5)
                    {
                level = 5;
                cpuzzel_panel.BackColor = Color.FromArgb(175, 156,156);
                puzzlepart1_buton.BackColor = Color.FromArgb(167,188,147);
                puzzlepart2_buton.BackColor = Color.FromArgb(167, 188, 147);
                puzzlepart3_buton.BackColor = Color.FromArgb(167, 188, 147);
                puzzlepart4_buton.BackColor = Color.FromArgb(167, 188, 147);
                puzzlepart5_buton.BackColor = Color.FromArgb(167, 188, 147);
                puzzlepart6_buton.BackColor = Color.FromArgb(167, 188, 147);
                puzzlepart7_buton.BackColor = Color.FromArgb(167, 188, 147);
                puzzlepart8_buton.BackColor = Color.FromArgb(167, 188, 147);
                puzzlepart9_buton.BackColor = Color.FromArgb(167, 188, 147);
                level_icin_label.Text = "Level 5: Doğu Anadolu";
                Image orginal = Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\doguanadolu.jpg");
                        var img = orginal;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {

                                var index = i * 3 + j;
                                resimdizi[index] = new Bitmap(sayfa.Width / 10, sayfa.Height / 6);
                                var graphics = Graphics.FromImage(resimdizi[index]);
                                graphics.DrawImage(img, new Rectangle(0, 0, sayfa.Width / 10, sayfa.Height / 6), new Rectangle(i * sayfa.Width / 10, j * sayfa.Height / 6, sayfa.Width / 10, sayfa.Height / 6), GraphicsUnit.Pixel);
                                graphics.Dispose();
                            }
                        }
                //kazanmak için sırasıyla 7,8,5,6,3,2,1butonlarına basılmalı
                puzzlepart1_buton.BackgroundImage = resimdizi[3];
                puzzlepart2_buton.BackgroundImage = resimdizi[6];
                puzzlepart3_buton.BackgroundImage = resimdizi[7];              
                puzzlepart5_buton.BackgroundImage = resimdizi[5];
                puzzlepart6_buton.BackgroundImage = resimdizi[4];
                puzzlepart7_buton.BackgroundImage = resimdizi[1];
                puzzlepart8_buton.BackgroundImage = resimdizi[2];
                puzzlepart9_buton.BackgroundImage = resimdizi[8];
            }
            else if (level==6)
            {

                cpuzzel_panel.BackColor = Color.FromArgb( 211, 165,182);
                puzzlepart1_buton.BackColor = Color.FromArgb(188,133,81);
                puzzlepart2_buton.BackColor = Color.FromArgb(188, 133, 81);
                puzzlepart3_buton.BackColor = Color.FromArgb(188, 133, 81);
                puzzlepart4_buton.BackColor = Color.FromArgb(188, 133, 81);
                puzzlepart5_buton.BackColor = Color.FromArgb(188, 133, 81);
                puzzlepart6_buton.BackColor = Color.FromArgb(188, 133, 81);
                puzzlepart7_buton.BackColor = Color.FromArgb(188, 133, 81);
                puzzlepart8_buton.BackColor = Color.FromArgb(188, 133, 81);
                puzzlepart9_buton.BackColor = Color.FromArgb(188, 133, 81);
               
                level_icin_label.Text = "Level 6: Akdeniz";
                Image orginal = Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\akdeniz.jpg");
                        var img = orginal;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {

                                var index = i * 3 + j;
                                resimdizi[index] = new Bitmap(sayfa.Width / 10, sayfa.Height / 6);
                                var graphics = Graphics.FromImage(resimdizi[index]);
                                graphics.DrawImage(img, new Rectangle(0, 0, sayfa.Width / 10, sayfa.Height / 6), new Rectangle(i * sayfa.Width / 10, j * sayfa.Height / 6, sayfa.Width / 10, sayfa.Height / 6), GraphicsUnit.Pixel);
                                graphics.Dispose();
                            }
                        }
                //kazanmak için sırasıyla 5,8,9,6,3,2butonlarına basılmalı
                puzzlepart1_buton.BackgroundImage = resimdizi[0];
                puzzlepart2_buton.BackgroundImage = resimdizi[6];
                puzzlepart3_buton.BackgroundImage = resimdizi[7];
                puzzlepart4_buton.BackgroundImage = resimdizi[1];
                puzzlepart5_buton.BackgroundImage = resimdizi[8];
                puzzlepart7_buton.BackgroundImage = resimdizi[2];
                puzzlepart8_buton.BackgroundImage = resimdizi[4];
                puzzlepart9_buton.BackgroundImage = resimdizi[5];
            }
            else if (level==7)
                    {
                level = 7;
                cpuzzel_panel.BackColor = Color.FromArgb(184,209,190);
                puzzlepart1_buton.BackColor = Color.FromArgb(233,213,242);
                puzzlepart2_buton.BackColor = Color.FromArgb(233, 213, 242);
                puzzlepart3_buton.BackColor = Color.FromArgb(233, 213, 242);
                puzzlepart4_buton.BackColor = Color.FromArgb(233, 213, 242);
                puzzlepart5_buton.BackColor = Color.FromArgb(233, 213, 242);
                puzzlepart6_buton.BackColor = Color.FromArgb(233, 213, 242);
                puzzlepart7_buton.BackColor = Color.FromArgb(233, 213, 242);
                puzzlepart8_buton.BackColor = Color.FromArgb(233, 213, 242);
                puzzlepart9_buton.BackColor = Color.FromArgb(233, 213, 242);
                level_icin_label.Text = "Level 7: Güneydoğu Anadolu";
                Image orginal = Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\guneydoguanadolu.jpg");
                        var img = orginal;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {

                                var index = i * 3 + j;
                                resimdizi[index] = new Bitmap(sayfa.Width / 10, sayfa.Height / 6);
                                var graphics = Graphics.FromImage(resimdizi[index]);
                                graphics.DrawImage(img, new Rectangle(0, 0, sayfa.Width / 10, sayfa.Height / 6), new Rectangle(i * sayfa.Width / 10, j * sayfa.Height / 6, sayfa.Width / 10, sayfa.Height / 6), GraphicsUnit.Pixel);
                                graphics.Dispose();
                            }
                        }
                //kazanmak için sırasıyla 5,8,9,6,3,2,5,4,1butonlarına basılmalı
                puzzlepart1_buton.BackgroundImage = resimdizi[1];
                puzzlepart2_buton.BackgroundImage = resimdizi[6];
                puzzlepart3_buton.BackgroundImage = resimdizi[7];
                puzzlepart5_buton.BackgroundImage = resimdizi[4];
                puzzlepart6_buton.BackgroundImage = resimdizi[8];
                puzzlepart7_buton.BackgroundImage = resimdizi[2];
                puzzlepart8_buton.BackgroundImage = resimdizi[3];
                puzzlepart9_buton.BackgroundImage = resimdizi[5];
            }
            else
                    {
                ses_alkis.Play();
                cpuzzel_panel.Visible = false;
                level_icin_label.Visible = false;
                puzelbuton_dur.Visible = false;
                puzzletekrardenebuton.Visible = false;
                resmi_goster.Visible = false;
                puzzle_cografya_basla_buton.Visible = false;
                haritakucuk.Visible = true;
                haritakucuk.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\turkiye.png");
                this.BackgroundImage= puzelicinbosbuton.BackgroundImage;
                this.BackColor = Color.Black;
                connection.Open();
                MySqlCommand command = new MySqlCommand("update cografya_puzzel set level='" + 1 +  "' where okul_no= '" + okul +"'");
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("OYUNU BİTİRDİNİZ TEBRİKLER!");

                    }






            //////puzzelın tammen doğru olma durumu
            //puzzlepart1_buton.BackgroundImage = resimdizi[0];
            //puzzlepart2_buton.BackgroundImage = resimdizi[3];
            //puzzlepart3_buton.BackgroundImage = resimdizi[6];
            //puzzlepart4_buton.BackgroundImage = resimdizi[1];
            //puzzlepart5_buton.BackgroundImage = resimdizi[4];
            //puzzlepart6_buton.BackgroundImage = resimdizi[7];
            //puzzlepart7_buton.BackgroundImage = resimdizi[2];
            //puzzlepart8_buton.BackgroundImage = resimdizi[5];
            //puzzlepart9_buton.BackgroundImage = resimdizi[8];


            Cursor.Current = Cursors.Default;
            return resimdizi;
            
        }

        

        int tiklanma_sayisi=0;
        private void resmi_goster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            haritakucuk.Width = 400;
            haritakucuk.Height = 400;
            haritakucuk.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - haritakucuk.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - haritakucuk.Height / 2);
            string okul = OgrenciBilgileri.okul_no;
            int level = 1;
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select * from cografya_puzzel where okul_no= " + okul, connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = komut.ExecuteReader();//veri tabanını oku
            while (reader.Read())
            {
                level = Convert.ToInt32(reader["level"]);
            }
            connection.Close();

            tiklanma_sayisi++;
            if (tiklanma_sayisi == 1)
            {
                resmi_goster.Text = "Kapat";
               
                if (level == 1)
                {
                    haritakucuk.BackgroundImage= Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\marmara.jpg");

                }
                else if (level == 2)
                {
                    haritakucuk.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\karadeniz.jpg");
                }
                else if (level == 3)
                {
                    haritakucuk.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\icanadolu.jpg");
                }
                else if (level == 4)
                {
                    haritakucuk.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\ege.jpg"); 
                }
                else if (level == 5)
                {
                    haritakucuk.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\doguanadolu.jpg");
                }
                else if (level == 6)
                {
                    haritakucuk.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\akdeniz.jpg");
                }
               else if (level == 7)
                {
                    haritakucuk.BackgroundImage =  Image.FromFile(Application.StartupPath.ToString() + @"\puzzleresim\guneydoguanadolu.jpg");
                }
                haritakucuk.Visible = true;
            }
            else if(tiklanma_sayisi==2)
            {
                resmi_goster.Text = "Görüldü";
                haritakucuk.Visible = false;
                resmi_goster.Enabled = false;

            }
            Cursor.Current = Cursors.Default;
        }
       


        private void puzzlepart1_buton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (puzzlepart2_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart2_buton.BackgroundImage = puzzlepart1_buton.BackgroundImage;
                puzzlepart1_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            else if (puzzlepart4_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart4_buton.BackgroundImage = puzzlepart1_buton.BackgroundImage;
                puzzlepart1_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            Cursor.Current = Cursors.Default;
        }

        private void puzzlepart2_buton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (puzzlepart1_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart1_buton.BackgroundImage = puzzlepart2_buton.BackgroundImage;
                puzzlepart2_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            else if (puzzlepart3_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart3_buton.BackgroundImage = puzzlepart2_buton.BackgroundImage;
                puzzlepart2_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            else if(puzzlepart5_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart5_buton.BackgroundImage = puzzlepart2_buton.BackgroundImage;
                puzzlepart2_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            Cursor.Current = Cursors.Default;
        }
        private void puzzlepart3_buton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (puzzlepart2_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart2_buton.BackgroundImage = puzzlepart3_buton.BackgroundImage;
                puzzlepart3_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
            }
            else if (puzzlepart6_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart6_buton.BackgroundImage = puzzlepart3_buton.BackgroundImage;
                puzzlepart3_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
            }

            Cursor.Current = Cursors.Default;
        }
        private void puzzlepart4_buton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (puzzlepart1_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart1_buton.BackgroundImage = puzzlepart4_buton.BackgroundImage;
                puzzlepart4_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            else if (puzzlepart5_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart5_buton.BackgroundImage = puzzlepart4_buton.BackgroundImage;
                puzzlepart4_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            else if(puzzlepart7_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart7_buton.BackgroundImage = puzzlepart4_buton.BackgroundImage;
                puzzlepart4_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
            }
            Cursor.Current = Cursors.Default;
        }      

        private void puzzlepart5_buton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (puzzlepart2_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart2_buton.BackgroundImage = puzzlepart5_buton.BackgroundImage;
                puzzlepart5_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            else if (puzzlepart4_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart4_buton.BackgroundImage = puzzlepart5_buton.BackgroundImage;
                puzzlepart5_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            else if (puzzlepart6_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart6_buton.BackgroundImage = puzzlepart5_buton.BackgroundImage;
                puzzlepart5_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            else if (puzzlepart8_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart8_buton.BackgroundImage = puzzlepart5_buton.BackgroundImage;
                puzzlepart5_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            Cursor.Current = Cursors.Default;
        }

        private void puzzlepart6_buton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (puzzlepart3_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart3_buton.BackgroundImage = puzzlepart6_buton.BackgroundImage;
                puzzlepart6_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            else if (puzzlepart5_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart5_buton.BackgroundImage = puzzlepart6_buton.BackgroundImage;
                puzzlepart6_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            else if (puzzlepart9_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart9_buton.BackgroundImage = puzzlepart6_buton.BackgroundImage;
                puzzlepart6_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
            }
            Cursor.Current = Cursors.Default;
        }

        private void puzzlepart7_buton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (puzzlepart4_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart4_buton.BackgroundImage = puzzlepart7_buton.BackgroundImage;
                puzzlepart7_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
            }
            else if (puzzlepart8_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart8_buton.BackgroundImage = puzzlepart7_buton.BackgroundImage;
                puzzlepart7_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
            }
            Cursor.Current = Cursors.Default;
        }

        private void puzzlepart8_buton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (puzzlepart7_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart7_buton.BackgroundImage = puzzlepart8_buton.BackgroundImage;
                puzzlepart8_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            else if (puzzlepart5_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart5_buton.BackgroundImage = puzzlepart8_buton.BackgroundImage;
                puzzlepart8_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;

            }
            else if (puzzlepart9_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart9_buton.BackgroundImage = puzzlepart8_buton.BackgroundImage;
                puzzlepart8_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
            }
            Cursor.Current = Cursors.Default;
        }
      

        private void puzzlepart9_buton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (puzzlepart8_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart8_buton.BackgroundImage = puzzlepart9_buton.BackgroundImage;
                puzzlepart9_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
            }
            else if (puzzlepart6_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage)
            {
                puzzlepart6_buton.BackgroundImage = puzzlepart9_buton.BackgroundImage;
                puzzlepart9_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
            }

            Cursor.Current = Cursors.Default;
        }

     
        int sayi = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (sayi >= 0)
            {
                timer1.Interval = 1000;
                timer1.Enabled = true;
                int sayac = sayi--;
                timer_puzzlelabel1_dk.Text = sayac.ToString();
            }
            Cursor.Current = Cursors.Default;
        }

        private void puzzletekrardenebuton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string okul = OgrenciBilgileri.okul_no;
            int level = 1;
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select * from cografya_puzzel where okul_no= " + okul, connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = komut.ExecuteReader();//veri tabanını oku
            while (reader.Read())
            {
                level = Convert.ToInt32(reader["level"]);
            }
            connection.Close();
            puzzle_cografya_basla_buton.Visible = true;
            puzzle_cografya_basla_buton.Enabled = true;
            puzzle_bitir_buton.Visible = false;
            puzzle_bitir_buton.Enabled = false;
            puzzle_cografya_basla_buton.Enabled = true;
            puzelbuton_dur.Enabled = false;
            puzzletekrardenebuton.Enabled = false;
            resmi_goster.Text = "Resmi Göster";
            resmi_goster.Enabled = false;
            if (level == 1)
            {
                puzzlepart1_buton.BackgroundImage = resimdizi[0];
                puzzlepart2_buton.BackgroundImage = resimdizi[3];
                puzzlepart3_buton.BackgroundImage = resimdizi[6];
                puzzlepart4_buton.BackgroundImage = resimdizi[1];
                puzzlepart5_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
                puzzlepart6_buton.BackgroundImage = resimdizi[5];
                puzzlepart7_buton.BackgroundImage = resimdizi[2];
                puzzlepart8_buton.BackgroundImage = resimdizi[7];
                puzzlepart9_buton.BackgroundImage = resimdizi[4];
            }
            else if (level == 2)
            {
                puzzlepart1_buton.BackgroundImage = resimdizi[3];
                puzzlepart2_buton.BackgroundImage = resimdizi[4];
                puzzlepart3_buton.BackgroundImage = resimdizi[6];
                puzzlepart4_buton.BackgroundImage = resimdizi[1];
                puzzlepart5_buton.BackgroundImage = resimdizi[5];
                puzzlepart6_buton.BackgroundImage = resimdizi[7];
                puzzlepart7_buton.BackgroundImage = resimdizi[2];
                puzzlepart8_buton.BackgroundImage = resimdizi[8];
                puzzlepart9_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
            }
            else if (level == 3)
            {
                puzzlepart1_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
                puzzlepart2_buton.BackgroundImage = resimdizi[0];
                puzzlepart3_buton.BackgroundImage = resimdizi[6];
                puzzlepart4_buton.BackgroundImage = resimdizi[1];
                puzzlepart5_buton.BackgroundImage = resimdizi[3];
                puzzlepart6_buton.BackgroundImage = resimdizi[4];
                puzzlepart7_buton.BackgroundImage = resimdizi[2];
                puzzlepart8_buton.BackgroundImage = resimdizi[5];
                puzzlepart9_buton.BackgroundImage = resimdizi[7];
            }
            else if (level == 4)
            {
                puzzlepart1_buton.BackgroundImage = resimdizi[0];
                puzzlepart2_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
                puzzlepart3_buton.BackgroundImage = resimdizi[6];
                puzzlepart4_buton.BackgroundImage = resimdizi[4];
                puzzlepart5_buton.BackgroundImage = resimdizi[3];
                puzzlepart6_buton.BackgroundImage = resimdizi[7];
                puzzlepart7_buton.BackgroundImage = resimdizi[1];
                puzzlepart8_buton.BackgroundImage = resimdizi[2];
                puzzlepart9_buton.BackgroundImage = resimdizi[5];

            }
            else if (level == 5)
            {
                puzzlepart1_buton.BackgroundImage = resimdizi[3];
                puzzlepart2_buton.BackgroundImage = resimdizi[6];
                puzzlepart3_buton.BackgroundImage = resimdizi[7];
                puzzlepart4_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
                puzzlepart5_buton.BackgroundImage = resimdizi[5];
                puzzlepart6_buton.BackgroundImage = resimdizi[4];
                puzzlepart7_buton.BackgroundImage = resimdizi[1];
                puzzlepart8_buton.BackgroundImage = resimdizi[2];
                puzzlepart9_buton.BackgroundImage = resimdizi[8];

            }
            else if (level == 6)
            {
                puzzlepart1_buton.BackgroundImage = resimdizi[0];
                puzzlepart2_buton.BackgroundImage = resimdizi[6];
                puzzlepart3_buton.BackgroundImage = resimdizi[7];
                puzzlepart4_buton.BackgroundImage = resimdizi[1];
                puzzlepart5_buton.BackgroundImage = resimdizi[8];
                puzzlepart6_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
                puzzlepart7_buton.BackgroundImage = resimdizi[2];
                puzzlepart8_buton.BackgroundImage = resimdizi[4];
                puzzlepart9_buton.BackgroundImage = resimdizi[5];
            }
            else if (level == 7)
            {
                puzzlepart1_buton.BackgroundImage = resimdizi[1];
                puzzlepart2_buton.BackgroundImage = resimdizi[6];
                puzzlepart3_buton.BackgroundImage = resimdizi[7];
                puzzlepart4_buton.BackgroundImage = puzelicinbosbuton.BackgroundImage;
                puzzlepart5_buton.BackgroundImage = resimdizi[4];
                puzzlepart6_buton.BackgroundImage = resimdizi[8];
                puzzlepart7_buton.BackgroundImage = resimdizi[2];
                puzzlepart8_buton.BackgroundImage = resimdizi[3];
                puzzlepart9_buton.BackgroundImage = resimdizi[5];
            }
            puzzlepart1_buton.Enabled = false;
            puzzlepart2_buton.Enabled = false;
            puzzlepart3_buton.Enabled = false;
            puzzlepart4_buton.Enabled = false;
            puzzlepart5_buton.Enabled = false;
            puzzlepart6_buton.Enabled = false;
            puzzlepart7_buton.Enabled = false;
            puzzlepart8_buton.Enabled = false;
            puzzlepart9_buton.Enabled = false;

            timer1.Enabled = false; //Timer1'ri pasfi hale getiriyoruz.
            timer1.Interval = 1000 * 60; //Timer1'in Interval'ini 1000 olarak ayarlıyoruz.1000=1sn
            timer_puzzlelabel1_dk.Text = "60";
            timer_puzzlelabel1_dk.ForeColor = Color.DarkCyan;
            sayi = 60;
            Cursor.Current = Cursors.Default;
        }

        int tiklanma_sayisi2 = 0;
        private void puzelbuton_dur_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;



            tiklanma_sayisi2++;
            if (tiklanma_sayisi2 % 2 == 1)
            {
                timer_puzzlelabel1_dk.ForeColor = Color.DarkCyan;
              
                puzzlepart1_buton.Enabled = false;
                puzzlepart2_buton.Enabled = false;
                puzzlepart3_buton.Enabled = false;
                puzzlepart4_buton.Enabled = false;
                puzzlepart5_buton.Enabled = false;
                puzzlepart6_buton.Enabled = false;
                puzzlepart7_buton.Enabled = false;
                puzzlepart8_buton.Enabled = false;
                puzzlepart9_buton.Enabled = false;
                timer1.Enabled = false;
                puzzle_bitir_buton.Enabled = false;
                puzelbuton_dur.Text = "Devam Et";
            }
            else
            {
                timer_puzzlelabel1_dk.ForeColor = Color.Linen;
                puzzlepart1_buton.Enabled = true;
                puzzlepart2_buton.Enabled = true;
                puzzlepart3_buton.Enabled = true;
                puzzlepart4_buton.Enabled = true;
                puzzlepart5_buton.Enabled = true;
                puzzlepart6_buton.Enabled = true;
                puzzlepart7_buton.Enabled = true;
                puzzlepart8_buton.Enabled = true;
                puzzlepart9_buton.Enabled = true;
                timer1.Enabled = true;
                puzzle_bitir_buton.Enabled = true;
                puzelbuton_dur.Text = "Dur";
            }
            Cursor.Current = Cursors.Default;
        }

        System.Media.SoundPlayer ses_alkis = new System.Media.SoundPlayer();
        
        public void gecti_gecmedi_kontrol(Image[]resimdizi)
        {
            Cursor.Current = Cursors.WaitCursor;           
            string okul = OgrenciBilgileri.okul_no;
            ses_alkis.SoundLocation = "Alkış-Ses-Efekti-_320-kbps_.wav";
            int level = 1;
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select * from cografya_puzzel where okul_no= " + okul, connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = komut.ExecuteReader();//veri tabanını oku
            while (reader.Read())
            {
                level = Convert.ToInt32(reader["level"]);
            }
            connection.Close();

            if (level==1)
            {
                if (puzzlepart1_buton.BackgroundImage ==resimdizi[0] &&
                puzzlepart2_buton.BackgroundImage == resimdizi[3] &&
                puzzlepart3_buton.BackgroundImage == resimdizi[6] &&
                puzzlepart4_buton.BackgroundImage == resimdizi[1] &&
                puzzlepart5_buton.BackgroundImage == resimdizi[4] &&
                puzzlepart6_buton.BackgroundImage == resimdizi[7] &&
                puzzlepart7_buton.BackgroundImage == resimdizi[2] &&
                puzzlepart8_buton.BackgroundImage == resimdizi[5] &&
                puzzlepart9_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage && Convert.ToInt32(timer_puzzlelabel1_dk.Text) > 0

                   )
                {
                    level += 1;
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("update cografya_puzzel set level='" + level + "' where okul_no='" + okul + "'");
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    connection.Close();
                    ses_alkis.Play();
                    MessageBox.Show("Bu leveli geçtiniz");
                    oyun_cografya_puzzle frm = new oyun_cografya_puzzle();
                    this.Hide();
                    frm.Show();
                 
                }
                else
                {
                    MessageBox.Show("Bu leveli geçemediniz");
                    puzelbuton_dur.Enabled = false;
                }
            }
            
            else if (level == 2)
            {
                if (puzzlepart1_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage &&
                puzzlepart2_buton.BackgroundImage == resimdizi[3]&&
                puzzlepart3_buton.BackgroundImage == resimdizi[6]&&
                puzzlepart4_buton.BackgroundImage == resimdizi[1]&&
                puzzlepart5_buton.BackgroundImage == resimdizi[4]&&
                puzzlepart6_buton.BackgroundImage == resimdizi[7]&&
                puzzlepart7_buton.BackgroundImage == resimdizi[2]&&
                puzzlepart8_buton.BackgroundImage == resimdizi[5]&&
                puzzlepart9_buton.BackgroundImage == resimdizi[8] && Convert.ToInt32(timer_puzzlelabel1_dk.Text) > 0

                   )
                {
                    level += 1;
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("update cografya_puzzel set level='" + level + "' where okul_no='" + okul + "'");
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    connection.Close();
                    ses_alkis.Play();
                    MessageBox.Show("Bu leveli geçtiniz");
                    oyun_cografya_puzzle frm = new oyun_cografya_puzzle();
                    this.Hide();
                    frm.Show();
                    

                }
                else
                {
                    MessageBox.Show("Bu leveli geçemediniz");
                    puzelbuton_dur.Enabled = false;
                }
            }
            else if (level == 3)
            {
                if(

                        puzzlepart1_buton.BackgroundImage ==resimdizi[0]&&
                puzzlepart2_buton.BackgroundImage == resimdizi[3]&&
                puzzlepart3_buton.BackgroundImage == resimdizi[6]&&
                puzzlepart4_buton.BackgroundImage == resimdizi[1]&&
                puzzlepart5_buton.BackgroundImage == resimdizi[4]&&
                puzzlepart6_buton.BackgroundImage == resimdizi[7]&&
                puzzlepart7_buton.BackgroundImage == resimdizi[2]&&
                puzzlepart8_buton.BackgroundImage == resimdizi[5]&&
                puzzlepart9_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage && Convert.ToInt32(timer_puzzlelabel1_dk.Text) > 0)
                {
                    level += 1;
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("update cografya_puzzel set level='" + level + "' where okul_no='" + okul + "'");
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    connection.Close();
                    ses_alkis.Play();
                    MessageBox.Show("Bu leveli geçtiniz");
                    oyun_cografya_puzzle frm = new oyun_cografya_puzzle();
                    this.Hide();
                    frm.Show();
                    

                }
                else
                {
                    MessageBox.Show("Bu leveli geçemediniz");
                    puzelbuton_dur.Enabled = false;
                }
            }
           else if (level == 4)
            {
                if (

                        puzzlepart1_buton.BackgroundImage == resimdizi[0] &&
                puzzlepart2_buton.BackgroundImage == resimdizi[3]&&
                puzzlepart3_buton.BackgroundImage == resimdizi[6] &&
                puzzlepart4_buton.BackgroundImage == resimdizi[1] &&
                puzzlepart5_buton.BackgroundImage == resimdizi[4] &&
                puzzlepart6_buton.BackgroundImage == resimdizi[7] &&
                puzzlepart7_buton.BackgroundImage == resimdizi[2] &&
                puzzlepart8_buton.BackgroundImage == resimdizi[5] &&
                puzzlepart9_buton.BackgroundImage ==puzelicinbosbuton.BackgroundImage && Convert.ToInt32(timer_puzzlelabel1_dk.Text) > 0)
                {
                    level += 1;
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("update cografya_puzzel set level='" + level + "' where okul_no='" + okul + "'");
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    connection.Close();
                    ses_alkis.Play();
                    MessageBox.Show("Bu leveli geçtiniz");
                    oyun_cografya_puzzle frm = new oyun_cografya_puzzle();
                    this.Hide();
                    frm.Show();
                    

                }
                else
                {
                    MessageBox.Show("Bu leveli geçemediniz");
                    puzelbuton_dur.Enabled = false;
                }
            }
            else if (level == 5)
            {

                if (

                        puzzlepart1_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage &&
                puzzlepart2_buton.BackgroundImage == resimdizi[3] &&
                puzzlepart3_buton.BackgroundImage == resimdizi[6] &&
                puzzlepart4_buton.BackgroundImage == resimdizi[1] &&
                puzzlepart5_buton.BackgroundImage == resimdizi[4] &&
                puzzlepart6_buton.BackgroundImage == resimdizi[7] &&
                puzzlepart7_buton.BackgroundImage == resimdizi[2] &&
                puzzlepart8_buton.BackgroundImage == resimdizi[5] &&
                puzzlepart9_buton.BackgroundImage == resimdizi[8]&& Convert.ToInt32(timer_puzzlelabel1_dk.Text) > 0)
                {
                    level += 1;
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("update cografya_puzzel set level='" + level + "' where okul_no='" + okul + "'");
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    connection.Close();
                    ses_alkis.Play();
                    MessageBox.Show("Bu leveli geçtiniz");
                    oyun_cografya_puzzle frm = new oyun_cografya_puzzle();
                    this.Hide();
                    frm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Bu leveli geçemediniz");
                    puzelbuton_dur.Enabled = false;
                }
            }
            else if (level == 6)
            {   if(puzzlepart1_buton.BackgroundImage == resimdizi[0] &&
                puzzlepart2_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage &&
                puzzlepart3_buton.BackgroundImage == resimdizi[6] &&
                puzzlepart4_buton.BackgroundImage == resimdizi[1] &&
                puzzlepart5_buton.BackgroundImage == resimdizi[4] &&
                puzzlepart6_buton.BackgroundImage == resimdizi[7] &&
                puzzlepart7_buton.BackgroundImage == resimdizi[2] &&
                puzzlepart8_buton.BackgroundImage == resimdizi[5] &&
                puzzlepart9_buton.BackgroundImage == resimdizi[8]&& Convert.ToInt32(timer_puzzlelabel1_dk.Text) > 0)
                {
                    level += 1;
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("update cografya_puzzel set level='" + level + "' where okul_no='" + okul + "'");
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    connection.Close();
                    ses_alkis.Play();
                    MessageBox.Show("Bu leveli geçtiniz");
                    oyun_cografya_puzzle frm = new oyun_cografya_puzzle();
                    this.Hide();
                    frm.Show();
                    

                }
                else
                {
                    MessageBox.Show("Bu leveli geçemediniz");
                    puzelbuton_dur.Enabled = false;
                }



            }
            else if (level == 7)
            {
                if (puzzlepart1_buton.BackgroundImage == puzelicinbosbuton.BackgroundImage &&
                   puzzlepart2_buton.BackgroundImage == resimdizi[3] &&
                   puzzlepart3_buton.BackgroundImage == resimdizi[6] &&
                   puzzlepart4_buton.BackgroundImage == resimdizi[1]&&
                   puzzlepart5_buton.BackgroundImage == resimdizi[4] &&
                   puzzlepart6_buton.BackgroundImage == resimdizi[7] &&
                   puzzlepart7_buton.BackgroundImage == resimdizi[2] &&
                   puzzlepart8_buton.BackgroundImage == resimdizi[5] &&
                   puzzlepart9_buton.BackgroundImage == resimdizi[8] && Convert.ToInt32(timer_puzzlelabel1_dk.Text) > 0)
                {
                    level += 1;
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("update cografya_puzzel set level='" + level + "' where okul_no='" + okul + "'");
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    connection.Close();
                    ses_alkis.Play();
                    MessageBox.Show("Bu leveli geçtiniz");
                    oyun_cografya_puzzle frm = new oyun_cografya_puzzle();
                    this.Hide();
                    frm.Show();
                    

                }
                else
                {
                    MessageBox.Show("Bu leveli geçemediniz");
                    puzelbuton_dur.Enabled = false;
                }


            }
            Cursor.Current = Cursors.Default;
        }
      
        public void puzzle_bitir_buton_Click(object sender, EventArgs e)
        {   timer_puzzlelabel1_dk.ForeColor=Color.DarkCyan;
            timer1.Enabled = false;
            gecti_gecmedi_kontrol(resimdizi);          
            puzzle_bitir_buton.Enabled = false;
            puzzle_bitir_buton.Visible = false;
            puzzle_cografya_basla_buton.Visible = true;
            puzzlepart1_buton.Enabled = false;
            puzzlepart2_buton.Enabled = false;
            puzzlepart3_buton.Enabled = false;
            puzzlepart4_buton.Enabled = false;
            puzzlepart5_buton.Enabled = false;
            puzzlepart6_buton.Enabled = false;
            puzzlepart7_buton.Enabled = false;
            puzzlepart8_buton.Enabled = false;
            puzzlepart9_buton.Enabled = false;
        }

        private void oyun_cografya_puzzle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void butonGeriDon_Click(object sender, EventArgs e)
        {            
            ses_alkis.Stop();
            this.Hide();
            oyunlarMenu frm = new oyunlarMenu();
            frm.Show();
        }

        private void puzzle_cografya_basla_buton_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            timer_puzzlelabel1_dk.ForeColor = Color.Linen;
            puzzle_bitir_buton.Visible = true;
            puzzle_bitir_buton.Enabled = true;           
            puzzle_cografya_basla_buton.Enabled = false;
            puzzle_cografya_basla_buton.Visible = false;
            puzzle_bitir_buton.Show();
            puzelbuton_dur.Enabled = true;
            puzzletekrardenebuton.Enabled = true;
            resmi_goster.Enabled = true;


            puzzlepart1_buton.Enabled = true;
            puzzlepart2_buton.Enabled = true;
            puzzlepart3_buton.Enabled = true;
            puzzlepart4_buton.Enabled = true;
            puzzlepart5_buton.Enabled = true;
            puzzlepart6_buton.Enabled = true;
            puzzlepart7_buton.Enabled = true;
            puzzlepart8_buton.Enabled = true;
            puzzlepart9_buton.Enabled = true;

            tiklanma_sayisi = 0;
            timer1.Interval = 1000;
            timer1.Enabled = true;

            Cursor.Current = Cursors.Default;
        }
    }
    }

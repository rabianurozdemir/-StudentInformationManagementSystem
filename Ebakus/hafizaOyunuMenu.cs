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
    public partial class HafizaOyunuMenu : Form
    {
        MySqlConnection connection = Form1.connection;
        public HafizaOyunuMenu()
        {
            InitializeComponent();
            buttonsSettings();

            string okul = OgrenciBilgileri.okul_no;
            int level = 1;
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select * from oyunHafiza where okulNo= " + okul, connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = komut.ExecuteReader();//veri tabanını oku
            while (reader.Read())
            {
                level = Convert.ToInt32(reader["level"]);
            }
            connection.Close();

            if (level<=1)
            {
                butonColors.Enabled = true;
                butonAnimals.Enabled = false;
                butonFruits.Enabled = false;
                butonWeather.Enabled = false;
                butonClothes.Enabled = false;
                butonProfessions.Enabled = false;

                butonAnimals.Image = global::Ebakus.Properties.Resources._lock; //level<=1 ise son beş bölüm kilitli
                butonFruits.Image = global::Ebakus.Properties.Resources._lock;
                butonWeather.Image = global::Ebakus.Properties.Resources._lock;
                butonClothes.Image = global::Ebakus.Properties.Resources._lock;
                butonProfessions.Image = global::Ebakus.Properties.Resources._lock;
            }
            else if (level <= 2)
            {
                butonColors.Enabled = true;
                butonAnimals.Enabled = true;
                butonFruits.Enabled = false;
                butonWeather.Enabled = false;
                butonClothes.Enabled = false;
                butonProfessions.Enabled = false;
                butonFruits.Image = global::Ebakus.Properties.Resources._lock;  //level<=2 ise son dört bölüm kilitli
                butonWeather.Image = global::Ebakus.Properties.Resources._lock;
                butonClothes.Image = global::Ebakus.Properties.Resources._lock;
                butonProfessions.Image = global::Ebakus.Properties.Resources._lock;
            }
            else if (level <= 3)
            {
                butonColors.Enabled = true;
                butonAnimals.Enabled = true;
                butonFruits.Enabled = true;
                butonWeather.Enabled = false;
                butonClothes.Enabled = false;
                butonProfessions.Enabled = false;
                butonWeather.Image = global::Ebakus.Properties.Resources._lock; //level<=3 ise son üç bölüm kilitli
                butonClothes.Image = global::Ebakus.Properties.Resources._lock;
                butonProfessions.Image = global::Ebakus.Properties.Resources._lock;
            }
            else if (level <= 4)
            {
                butonColors.Enabled = true;
                butonAnimals.Enabled = true;
                butonFruits.Enabled = true;
                butonWeather.Enabled = true;
                butonClothes.Enabled = false;
                butonProfessions.Enabled = false;
                butonClothes.Image = global::Ebakus.Properties.Resources._lock; //level<=4 ise son iki bölüm kilitli
                butonProfessions.Image = global::Ebakus.Properties.Resources._lock;
            }
            else if (level <= 5)
            {
                butonColors.Enabled = true;
                butonAnimals.Enabled = true;
                butonFruits.Enabled = true;
                butonWeather.Enabled = true;
                butonClothes.Enabled = true;
                butonProfessions.Enabled = false;
                butonProfessions.Image = global::Ebakus.Properties.Resources._lock; //level<=5 ise sadece son bölüm kilitli
            }
            else if (level <= 6)
            {
                butonColors.Enabled = true;
                butonAnimals.Enabled = true;
                butonFruits.Enabled = true;
                butonWeather.Enabled = true;
                butonClothes.Enabled = true;
                butonProfessions.Enabled = true;
                //level<=6 ise tüm bölümlerin kilidi açık
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void buttonsSettings() //tüm butonların ayarlarını yaptığımız metot
        {
            //program farklı ekranlarda çalıştırıldığında responsive görünüm için butonları oranladık
            butonColors.Top = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * 0.492);
            butonColors.Left = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.262);
            butonAnimals.Top = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * 0.477);
            butonAnimals.Left = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.080);
            butonFruits.Top = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * 0.228);
            butonFruits.Left = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.273);
            butonWeather.Top = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * 0.190);
            butonWeather.Left = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.484);
            butonClothes.Top = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * 0.425);
            butonClothes.Left = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.658);
            butonProfessions.Top = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * 0.457);
            butonProfessions.Left = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.853);

            butonColors.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butonAnimals.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butonFruits.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butonWeather.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butonClothes.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butonProfessions.FlatAppearance.MouseOverBackColor = Color.Transparent;

            butonColors.FlatAppearance.MouseDownBackColor = Color.Transparent;
            butonAnimals.FlatAppearance.MouseDownBackColor = Color.Transparent;
            butonFruits.FlatAppearance.MouseDownBackColor = Color.Transparent;
            butonWeather.FlatAppearance.MouseDownBackColor = Color.Transparent;
            butonClothes.FlatAppearance.MouseDownBackColor = Color.Transparent;
            butonProfessions.FlatAppearance.MouseDownBackColor = Color.Transparent;

            butonGeriDon.Top = Screen.PrimaryScreen.Bounds.Height - butonGeriDon.Height - 50;
            butonGeriDon.Left = 50;

        }

        private void butonAnimals_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            buton.BackColor = Color.Transparent;
            Image[] resimler = //resimler için bir dizi oluşturduk
            {
                Properties.Resources.baykus,
                Properties.Resources.fil,
                Properties.Resources.inek,
                Properties.Resources.koyun,
                Properties.Resources.kurbaga,
                Properties.Resources.maymun,
                Properties.Resources.tilki,
                Properties.Resources.zurafa,
                Properties.Resources.owl,
                Properties.Resources.elephant,
                Properties.Resources.cow,
                Properties.Resources.sheep,
                Properties.Resources.frog,
                Properties.Resources.monkey,
                Properties.Resources.fox,
                Properties.Resources.giraffe
            };
            HafizaOyun form3 = new HafizaOyun(resimler,2);
            form3.Show();
            this.Hide();
        }

        private void butonFruits_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            buton.BackColor = Color.Transparent;
            Image[] resimler = //resimler için bir dizi oluşturduk
            {
                Properties.Resources.havuc,
                Properties.Resources.elma,
                Properties.Resources.armut,
                Properties.Resources.karpuz,
                Properties.Resources.ananas,
                Properties.Resources.portakal,
                Properties.Resources.muz,
                Properties.Resources.limon,
                Properties.Resources.carrot,
                Properties.Resources.apple,
                Properties.Resources.pear,
                Properties.Resources.watermelon,
                Properties.Resources.pineapple,
                Properties.Resources.orange,
                Properties.Resources.banana,
                Properties.Resources.lemon
            };
            HafizaOyun form3 = new HafizaOyun(resimler,3);
            form3.Show();
            this.Hide();
        }

        private void butonWeather_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            buton.BackColor = Color.Transparent;
            Image[] resimler = //resimler için bir dizi oluşturduk
            {
                Properties.Resources.gunesli,
                Properties.Resources.bulutlu,
                Properties.Resources.parcalibulutlu,
                Properties.Resources.yagmurlu,
                Properties.Resources.firtinali,
                Properties.Resources.hortum,
                Properties.Resources.karli,
                Properties.Resources.ruzgarli,
                Properties.Resources.sunny,
                Properties.Resources.cloudy,
                Properties.Resources.partlycloudy,
                Properties.Resources.rainy,
                Properties.Resources.stormy,
                Properties.Resources.tornado,
                Properties.Resources.snowy,
                Properties.Resources.windy
            };
            HafizaOyun form3 = new HafizaOyun(resimler,4);
            form3.Show();
            this.Hide();
        }

        private void butonProfessions_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            buton.BackColor = Color.Transparent;
            Image[] resimler = //resimler için bir dizi oluşturduk
            {
                Properties.Resources.ogretmen,
                Properties.Resources.cerrah,
                Properties.Resources.ciftci,
                Properties.Resources.marangoz,
                Properties.Resources.cankurtaran,
                Properties.Resources.itfaiyeci,
                Properties.Resources.sarkici,
                Properties.Resources.kuafor,
                Properties.Resources.teacher,
                Properties.Resources.surgeon,
                Properties.Resources.farmer,
                Properties.Resources.carpenter,
                Properties.Resources.lifeguard,
                Properties.Resources.fireman,
                Properties.Resources.singer,
                Properties.Resources.hairdresser
            };
            HafizaOyun form3 = new HafizaOyun(resimler,6);
            form3.Show();
            this.Hide();
        }

        private void butonColors_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            buton.BackColor = Color.Transparent;
            Image[] resimler = //resimler için bir dizi oluşturduk
            {
                Properties.Resources.beyaz,
                Properties.Resources.sari,
                Properties.Resources.pembe,
                Properties.Resources.mor,
                Properties.Resources.mavi,
                Properties.Resources.kirmizi,
                Properties.Resources.kahverengi,
                Properties.Resources.siyah,
                Properties.Resources.white,
                Properties.Resources.yellow,
                Properties.Resources.pink,
                Properties.Resources.purple,
                Properties.Resources.blue,
                Properties.Resources.red,
                Properties.Resources.brown,
                Properties.Resources.black
            };
            HafizaOyun form3 = new HafizaOyun(resimler,1);
            form3.Show();
            this.Hide();
        }

        private void butonClothes_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            buton.BackColor = Color.Transparent;
            Image[] resimler = //resimler için bir dizi oluşturduk
            {
                Properties.Resources.kravat,
                Properties.Resources.sapka,
                Properties.Resources.sort,
                Properties.Resources.yuzuk,
                Properties.Resources.elbise,
                Properties.Resources.elcantasi,
                Properties.Resources.kemer,
                Properties.Resources.gunesgozlugu,
                Properties.Resources.necktie,
                Properties.Resources.hat,
                Properties.Resources.shorts,
                Properties.Resources.ring,
                Properties.Resources.dress,
                Properties.Resources.handbag,
                Properties.Resources.belt,
                Properties.Resources.sunglasses
            };
            HafizaOyun form3 = new HafizaOyun(resimler,5);
            form3.Show();
            this.Hide();
        }

        private void butonGeriDon_Click(object sender, EventArgs e) //geri dön butonuna tıklandığında oyunlar menüsüne dön
        {
            oyunlarMenu frm = new oyunlarMenu(); 
            this.Hide();
            frm.Show();
        }
    }
}

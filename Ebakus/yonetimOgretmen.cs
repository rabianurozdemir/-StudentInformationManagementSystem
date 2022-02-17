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
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Collections;

namespace Ebakus
{
    public partial class yonetimOgretmen : Form
    {
        MySqlConnection connection = Form1.connection;
        public yonetimOgretmen()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridView1);
            this.BackColor = Color.FromArgb(245, 245, 220);
            ogrenciListele();
        }

        private void yonetimogrenci_Load(object sender, EventArgs e)
        {
            ogrenciListele();
        }

        void ogrenciListele()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            string isim, soyad, kimlik_no, sinif, mail, cinsiyet, id;

            MySqlCommand command = new MySqlCommand("Select * from ogretmenBilgileri", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Height += 27;
                id = reader["id"].ToString();
                isim = reader["isim"].ToString();
                soyad = reader["soyad"].ToString();
                kimlik_no = reader["kimlik_no"].ToString();
                sinif = reader["sinif"].ToString();
                mail = reader["mail"].ToString();
                cinsiyet = reader["cinsiyet"].ToString();
                dataGridView1.Rows.Add(
                new object[]
                {
                    id,
                    isim,
                    soyad,
                    kimlik_no,
                    sinif,
                    mail,
                    cinsiyet
                }
               );
            }
            connection.Close();
            Cursor.Current = Cursors.Default;
        }

        private void yonetimogrenci_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void DatagridviewSetting(DataGridView datagridview)
        {

            int satir = datagridview.RowCount;
            datagridview.BackgroundColor = Color.FromArgb(245, 245, 220);
            datagridview.Top = 243;
            datagridview.RowHeadersVisible = false;//yan okların görüntüsü gidiyo
            datagridview.Size = new Size(1200, 500);//data grid e en boy verilir750,350
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
            datagridview.MaximumSize= new Size(1200, 400);
            datagridview.ClearSelection();

            datagridview.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            datagridview.DefaultCellStyle.SelectionForeColor = Color.Black;
            datagridview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(221, 221, 221);
            datagridview.DefaultCellStyle.BackColor = Color.FromArgb(238, 216, 174);
            datagridview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridview.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(91, 91, 91); ;
            datagridview.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 17);
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;//header boyunu girilebilir yapar
            datagridview.ColumnHeadersHeight = 58;//Header boyu girilir
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;//border kaldırma
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yonetimpaneli frmyonetim = new yonetimpaneli();
            frmyonetim.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Boolean kontrol1=true, kontrol2 = true;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlCommand cmd = new MySqlCommand("Select * from ogretmenBilgileri", connection);
            MySqlDataReader oku = cmd.ExecuteReader();//veri tabanını oku
            while (oku.Read())
            {
                if (oku["mail"].ToString() == ogretmenEmailtxt.Text)
                {
                    kontrol1 = false;
                    break;
                }
            }
            connection.Close();
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlCommand komut = new MySqlCommand("Select * from ogretmenBilgileri", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader okuyucu = komut.ExecuteReader();//veri tabanını oku
            while (okuyucu.Read())
            {
                if (okuyucu["kimlik_no"].ToString() == ogretmenKimlikNotxt.Text)
                {
                    kontrol2 = false;
                    break;
                }
            }
            connection.Close();
            if (EmailKontrol(ogretmenEmailtxt.Text)==false || kontrol1==false || kontrol2==false)
            {
                if (EmailKontrol(ogretmenEmailtxt.Text) == false)
                {
                    MessageBox.Show("Lütfen geçerli bir mail adresi giriniz");
                }
                else if (kontrol1 == false)
                {
                    MessageBox.Show("Mail adresi daha önce kullanılmış");
                }
                if (kontrol2 == false)
                {
                    MessageBox.Show("Aynı kimlik numarasına sahip bir öğrenci zaten var");
                }
            }
            else
            {

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                MySqlCommand ekle = new MySqlCommand("insert into ogretmenBilgileri (isim,soyad,kimlik_no,mail,cinsiyet,sinif) values ('" + ogretmenAditxt.Text + "','" + ogretmenSoyaditxt.Text +  "','" + ogretmenKimlikNotxt.Text +  "','" + ogretmenEmailtxt.Text + "','" + cinsiyetbox.Text + "','" + sinifbox.Text + "')", connection);
                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery();
                connection.Close();
                if (sonuc != null)
                {
                    try
                    {
                        MailGonder(ogretmenAditxt.Text, ogretmenEmailtxt.Text, ogretmenKimlikNotxt.Text, Convert.ToString(ogretmenAditxt.Text + ogretmenKimlikNotxt.Text.Substring(0, 2) + ogretmenSoyaditxt.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Kişi eklendi fakat mail gönderilirken bir hata oluştu");
                    }
                   
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    MySqlCommand Ekle = new MySqlCommand("insert into ogretmenGiris(kullanici_adi,sifre) values ('" + ogretmenKimlikNotxt.Text + "','" + Convert.ToString(ogretmenAditxt.Text + ogretmenKimlikNotxt.Text.Substring(0, 2) + ogretmenSoyaditxt.Text) + "')", connection);
                    sonuc = Ekle.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("İşlem başarılı");
                }
                ogrenciListele();
            }
            Cursor.Current = Cursors.Default;
        }

        static bool EmailKontrol(string inputEmail)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return (new Regex(strRegex)).IsMatch(inputEmail);
        }

        public static void MailGonder(string ad,string mail, string kullaniciadi, string sifre)
        {
            Cursor.Current = Cursors.WaitCursor;
            MailMessage eposta = new MailMessage();
            string msj = " Kullanıcı adı: " + kullaniciadi + "\n Şifre: " + sifre;
            eposta.From = new MailAddress("ebakus@outlook.com");
            eposta.To.Add(mail);
            eposta.Subject = " Kayıt Bilgileriniz";
            eposta.Body = " Merhaba "+ ad+ " EBAKÜS ailesine hoşgeldin!\n Aşağıdaki giriş bilgileriyle sistemimize giriş yapabilirsin! \n" + msj;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("ebakus@outlook.com", "777sifre777");
            smtp.Host = "smtp.live.com";//smtp.gmail.com
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(eposta);
            Cursor.Current = Cursors.Default;
        }

        
        private void guncelle_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int k = 0;
                string[] ogretmen = new String[7];
                string id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                for (int j = 0; j < dataGridView1.ColumnCount-1; j++)
                {

                    ogretmen[k] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    k++;

                }
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                MySqlCommand komut = new MySqlCommand("update ogretmenBilgileri set isim='" + ogretmen[1] + "', soyad='" + ogretmen[2] + "', kimlik_no='" + ogretmen[3] + "', sinif='" + ogretmen[4] + "', mail='" + ogretmen[5] + "', cinsiyet='" + ogretmen[6] + "' where id='" + id + "'");
                komut.Connection = connection;
                komut.ExecuteNonQuery();
                connection.Close();

            }
            MessageBox.Show("İşlem başarılı");
            ogrenciListele();
            Cursor.Current = Cursors.Default;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ArrayList secili = new ArrayList();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[7].Value) == true) //checkbox seçiliyse 
                {
                    string id = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    secili.Add(id); //seçiliyse listeye ekle
                }
            }
            connection.Open();
            foreach (string sec in secili) //çoklu silme işlemi gerçekleşiyor
            {
                MySqlCommand komut = new MySqlCommand("DELETE FROM ogretmenBilgileri where kimlik_no='" + sec + "'");
                komut.Connection = connection;
                komut.ExecuteNonQuery();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM ogretmenGiris where kullanici_adi='" + sec + "'");
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
            }
            connection.Close();
            MessageBox.Show("İşlem başarılı");
            ogrenciListele();
            Cursor.Current = Cursors.Default;

            
        }

    }
}

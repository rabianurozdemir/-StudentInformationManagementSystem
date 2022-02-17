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
    public partial class yonetimkutuphane : Form
    {
        MySqlConnection connection = Form1.connection;
        public yonetimkutuphane()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridView1);
            this.BackColor = Color.FromArgb(245, 245, 220);
        }
        

        private void yonetim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void kitapListele()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            string kitap_adi, kitapozet, kitapno;
            string yazar_adi;
            int basim_yili;
            string ketegori;
            MySqlCommand command = new MySqlCommand("Select * from kutuphane", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                kitap_adi = reader["kitap_adi"].ToString();
                yazar_adi = reader["yazar"].ToString();
                basim_yili = Convert.ToInt32(reader["basim_yili"]);
                ketegori = reader["kategori"].ToString();
                kitapozet = reader["kitap_ozet"].ToString();
                kitapno = reader["kitap_no"].ToString();
                dataGridView1.Rows.Add(
                new object[]
                {
                    kitapno,
                    kitap_adi,
                    yazar_adi,
                    basim_yili,
                    ketegori,
                    kitapozet
                }
               );
            }
            connection.Close();
            Cursor.Current = Cursors.Default;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Random rastgele = new Random();
            string oncekiId="";
            int sayi= rastgele.Next(10000, 99999); ;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlCommand command = new MySqlCommand("Select * from kutuphane", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku
            while (reader.Read())
            {
                oncekiId = reader["id"].ToString();  
            }
            connection.Close();
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            string kitapNo = oncekiId + sayi;
            MySqlCommand ekle = new MySqlCommand("insert into kutuphane (kitap_adi,basim_yili,yazar,kategori,kitap_ozet,kitap_no) values ('" + kitapaditxt.Text + "','" + basimyilitxt.Text + "','" + yazaraditxt.Text + "','" + kategoribox.Text + "','" + kitapozettxt.Text + "','" + kitapNo + "')", connection);
            object sonuc = null;
            sonuc = ekle.ExecuteNonQuery();
            if (sonuc != null)
            {
                MessageBox.Show("Sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            kitapListele();
            connection.Close();
            Cursor.Current = Cursors.Default;
        }

        private void yonetimkutuphane_Load(object sender, EventArgs e)
        {
            kitapListele();
        }


        public void DatagridviewSetting(DataGridView datagridview)
        {

            int satir = datagridview.RowCount;
            datagridview.BackgroundColor = Color.FromArgb(245, 245, 220);
            datagridview.Left = 80;
            datagridview.Top = 243;
            datagridview.RowHeadersVisible = false;//yan okların görüntüsü gidiyo
            datagridview.Size = new Size(1200, 500);//data grid e en boy verilir750,350
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview.EnableHeadersVisualStyles = false;
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//HEADERDAN VE SATIRIN TAMAMINI SECMEYİ SAĞLIYOR
            datagridview.BorderStyle = BorderStyle.None;

            datagridview.AllowUserToAddRows = false;//datagrid altındaki boş satır silinir.
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


        private void guncelle_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int k = 0;
                string[] notlar = new String[6];
                string kitapNo = dataGridView1.Rows[i].Cells[0].Value.ToString();
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {

                    notlar[k] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    k++;

                }
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                MySqlCommand komut = new MySqlCommand("update kutuphane set kitap_adi='" + notlar[1] + "', basim_yili='" + notlar[3] + "', yazar='" + notlar[2] + "', kategori='" + notlar[4] + "', kitap_ozet='" + notlar[5]  + "' where kitap_no='" + kitapNo + "'");
                komut.Connection = connection;
                komut.ExecuteNonQuery();
                connection.Close();
                //dataGridView1.DataSource = yenile();

            }
            MessageBox.Show("İşlem başarılı");
            kitapListele();
            Cursor.Current = Cursors.Default;
        }

        string seciliKitapNo;
        public void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
              //seciliKitapNo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlCommand komut = new MySqlCommand("DELETE FROM kutuphane where kitap_no='" + seciliKitapNo + "'");
            komut.Connection = connection;
            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("İşlem başarılı");
            kitapListele();
            Cursor.Current = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yonetimpaneli frmyonetim = new yonetimpaneli();
            frmyonetim.Show();
            this.Hide();
        }

        private void basimyilitxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

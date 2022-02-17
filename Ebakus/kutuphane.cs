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
    public partial class kutuphane : Form
    {
        public kutuphane()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridView1);
        }

         MySqlConnection connection = Form1.connection; 

        public void DatagridviewSetting(DataGridView datagridview)
        {   
            datagridview.RowHeadersVisible = false;//yan okların görüntüsü gidiyo
            datagridview.DefaultCellStyle.Font = new Font("Consolas", 14);
           
            datagridview.DefaultCellStyle.ForeColor = Color.Navy;
            datagridview.DefaultCellStyle.BackColor = Color.Azure;
            datagridview.DefaultCellStyle.SelectionForeColor = Color.Indigo;
            datagridview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 209, 209);

            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.LavenderBlush;
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.Indigo;
            datagridview.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 17);
            datagridview.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 209, 209);
            datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;//header boyunu girilebilir yapar
            datagridview.ColumnHeadersHeight = 58;//Header boyu girilir
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;//border kaldırma

            datagridview.BackgroundColor = Color.Azure;
            datagridview.Size =new Size (750,350);//data grid e en boy verilir
           
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagridview.EnableHeadersVisualStyles = false;
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//HEADERDAN VE SATIRIN TAMAMINI SECMEYİ SAĞLIYOR
            datagridview.AllowUserToAddRows = false;//datagrid altındaki boş satır silinir.
            datagridview.ReadOnly = true;//kullanıcının içindeki yazıyı değiştirmesini engelleme
            datagridview.MultiSelect = false;//birden fazla satır seçme engelleme
            datagridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//satırın genişliğiyle oynamayı durdurur
        }

        public void yerbelirle()
        {          
            
            aranankitapbulunamadı_textbox.Left= (Screen.PrimaryScreen.Bounds.Width - aranankitapbulunamadı_textbox.Width) / 2;
            kutuphanearama_textbox.Left = (Screen.PrimaryScreen.Bounds.Width - dataGridView1.Width) / 2 / 5;
            kutuphanekitaparamabutonudur.Left= (Screen.PrimaryScreen.Bounds.Width - dataGridView1.Width) / 2 / 5;
            kutuphanegeridonbutonu.Left = 50;
            kutuphanegeridonbutonu.Top = Screen.PrimaryScreen.Bounds.Height - kutuphanegeridonbutonu.Height - 50;
            dataGridView1.Left = (Screen.PrimaryScreen.Bounds.Width + kutuphanegeridonbutonu.Width + kutuphanegeridonbutonu.Left - dataGridView1.Width) / 2 ;
            kitapozet_textbox.Left = dataGridView1.Left;
            kitaplarıhepsini_listele_buton.Left = (Screen.PrimaryScreen.Bounds.Width + kutuphanegeridonbutonu.Width + kutuphanegeridonbutonu.Left - dataGridView1.Width) / 2;
            romanlar_listele_buton.Left = dataGridView1.Left + dataGridView1.Width - romanlar_listele_buton.Width;
            masallar_listele_buton.Left = kitaplarıhepsini_listele_buton.Left + kitaplarıhepsini_listele_buton.Width + ((dataGridView1.Width - (4 * kitaplarıhepsini_listele_buton.Width))) / 3;
            hikayeler_listele.Left = masallar_listele_buton.Left + ((dataGridView1.Width - (4 * kitaplarıhepsini_listele_buton.Width))) / 3;
            hikayeler_listele.Left = masallar_listele_buton.Left + masallar_listele_buton.Width + ((dataGridView1.Width - (4 * kitaplarıhepsini_listele_buton.Width))) / 3;
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            yerbelirle();

            aranankitapbulunamadı_textbox.Visible = false;            
            
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            string kitap_adi;
            string yazar_adi;
            int basim_yili;
            string kategori;
            string kitap_ozet;
                       
            MySqlCommand command = new MySqlCommand("Select * from kutuphane", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku

            while (reader.Read())
            {
                kitap_adi = reader["kitap_adi"].ToString();
                yazar_adi = reader["yazar"].ToString();
                basim_yili = Convert.ToInt32(reader["basim_yili"]);
                kategori = reader["kategori"].ToString();
                kitap_ozet= reader["kitap_ozet"].ToString();

                dataGridView1.Rows.Add(//datagridview ekleme fonk
                new object[]
                {
                    kitap_adi,
                    yazar_adi,
                    basim_yili,                   
                    kategori,
                    kitap_ozet
                  
                }
              );
                
            }

            this.dataGridView1.Columns["kitap_ozet"].Visible = false;//kitap özet datagridde olmasına rağmen gözükmesini istemiyorum sadece
                                                                     //üzerine tıklanınca kitao_ozet textbox ta çıkmalı.
            
            connection.Close();
            Cursor.Current = Cursors.Default;
        }      

        private void kitaplarıhepsini_listele_buton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            aranankitapbulunamadı_textbox.Visible = false;
            dataGridView1.Rows.Clear();

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            dataGridView1.ColumnHeadersVisible = true;
            string kitap_adi;
            string yazar_adi;
            int basim_yili;
            string kategori;
            string kitap_ozet;

            MySqlCommand command = new MySqlCommand("Select * from kutuphane", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku

            while (reader.Read())
            {
                kitap_adi = reader["kitap_adi"].ToString();
                yazar_adi = reader["yazar"].ToString();
                basim_yili = Convert.ToInt32(reader["basim_yili"]);
                kategori = reader["kategori"].ToString();
                kitap_ozet = reader["kitap_ozet"].ToString();

                dataGridView1.Rows.Add(//datagridview ekleme fonk
                    new object[]
                    {
                    kitap_adi,
                    yazar_adi,
                    basim_yili,
                    kategori,
                    kitap_ozet
                    }
                  );

            }

            connection.Close();
            Cursor.Current = Cursors.Default;
        }

        private void hikayeler_listele_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            aranankitapbulunamadı_textbox.Visible = false;
            dataGridView1.Rows.Clear();

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            dataGridView1.ColumnHeadersVisible = true;

            string kitap_adi;
            string yazar_adi;
            int basim_yili;
            string kategori;
            string kitap_ozet;
           
            MySqlCommand command = new MySqlCommand("Select * from kutuphane", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku

            while (reader.Read())
            {
                kitap_adi = reader["kitap_adi"].ToString();
                yazar_adi = reader["yazar"].ToString();
                basim_yili = Convert.ToInt32(reader["basim_yili"]);
                kategori = reader["kategori"].ToString();
                kitap_ozet = reader["kitap_ozet"].ToString();

                if (kategori == "Hikaye")
                {
                    dataGridView1.Rows.Add(//datagridview ekleme fonk
                    new object[]
                    {
                    kitap_adi,
                    yazar_adi,
                    basim_yili,
                    kategori,
                    kitap_ozet
                    }
                  );
                }
            }

            connection.Close();
            Cursor.Current = Cursors.Default;
        }

        private void romanlar_listele_buton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            aranankitapbulunamadı_textbox.Visible = false;
            dataGridView1.Rows.Clear();

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            dataGridView1.ColumnHeadersVisible = true;

            string kitap_adi;
            string yazar_adi;
            int basim_yili;
            string kategori;
            string kitap_ozet;
            
            MySqlCommand command = new MySqlCommand("Select * from kutuphane", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku

            while (reader.Read())
            {
                kitap_adi = reader["kitap_adi"].ToString();
                yazar_adi = reader["yazar"].ToString();
                basim_yili = Convert.ToInt32(reader["basim_yili"]);
                kategori = reader["kategori"].ToString();
                kitap_ozet = reader["kitap_ozet"].ToString(); 
                if (kategori == "Roman")
                {
                    dataGridView1.Rows.Add(//datagridview ekleme fonk
                    new object[]
                    {
                    kitap_adi,
                    yazar_adi,
                    basim_yili,
                    kategori,
                    kitap_ozet
                    }
                  );
                }
            }

            connection.Close();
            Cursor.Current = Cursors.Default;
        }

        private void masallar_listele_buton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            aranankitapbulunamadı_textbox.Visible = false;
            dataGridView1.Rows.Clear();

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            dataGridView1.ColumnHeadersVisible = true;

            string kitap_adi;
            string yazar_adi;
            int basim_yili;
            string kategori;
            string kitap_ozet;

            MySqlCommand command = new MySqlCommand("Select * from kutuphane", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku

            while (reader.Read())
            {
                kitap_adi = reader["kitap_adi"].ToString();
                yazar_adi = reader["yazar"].ToString();
                basim_yili = Convert.ToInt32(reader["basim_yili"]);
                kategori = reader["kategori"].ToString();
                kitap_ozet = reader["kitap_ozet"].ToString();
                if (kategori == "Masal")
                {
                    dataGridView1.Rows.Add(//datagridview ekleme fonk
                    new object[]
                    {
                    kitap_adi,
                    yazar_adi,
                    basim_yili,
                    kategori,
                    kitap_ozet
                    }
                  );
                }
            }

            connection.Close();
            Cursor.Current = Cursors.Default;
        }
                           
        private void kutuphanekitaparamabutonudur_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridView1.Rows.Clear();

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            
            string kitap_adi;
            string yazar_adi;
            int basim_yili;
            string kategori;
            string kitap_ozet;

            MySqlCommand command = new MySqlCommand("Select * from kutuphane", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku

            while (reader.Read())
            {
                kitap_adi = reader["kitap_adi"].ToString();
                yazar_adi = reader["yazar"].ToString();
                basim_yili = Convert.ToInt32(reader["basim_yili"]);
                kategori = reader["kategori"].ToString();
                kitap_ozet = reader["kitap_ozet"].ToString();

                if (kitap_adi== kutuphanearama_textbox.Text)
                {
                    aranankitapbulunamadı_textbox.Visible = false;
                    dataGridView1.ColumnHeadersVisible = true;
                    dataGridView1.Rows.Add(//datagridview ekleme fonk
                    new object[]
                    {
                    kitap_adi,
                    yazar_adi,
                    basim_yili,
                    kategori,
                    kitap_ozet
                    }
                  );
                    break;
                }
                else
                {

                    dataGridView1.ColumnHeadersVisible = false;//sütun başlıklarını gizleme
                    aranankitapbulunamadı_textbox.Enabled = false;
                    aranankitapbulunamadı_textbox.Visible = true;


                }
                
            }

            connection.Close();
            Cursor.Current = Cursors.Default;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            kitapozet_textbox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString()+ ":";
            kitapozet_textbox.Text += "\t\t\t\t"+ dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void kutuphane_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kutuphanegeridonbutonu_Click(object sender, EventArgs e)
        {
            if (OgrenciBilgileri.okul_no==null)
            {
                ogretmenMenu frm = new ogretmenMenu();
                this.Hide();
                frm.Show();
            }
            else
            {
                ogrenciMenu frm = new ogrenciMenu();
                this.Hide();
                frm.Show();
            }
        }
    }
  
}
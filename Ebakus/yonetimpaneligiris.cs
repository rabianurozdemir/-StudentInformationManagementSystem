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
    public partial class yonetimpaneligiris : Form
    {
        MySqlConnection connection = Form1.connection;
        public yonetimpaneligiris()
        {
            InitializeComponent();
        }

        private void yonetimpaneli_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void yoneticigiris_Click(object sender, EventArgs e)
        {
            Boolean basarili = true;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            MySqlCommand command = new MySqlCommand("Select * from yoneticiGiris", connection);//ogretmenGiris tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku
            while (reader.Read())
            {
                string dogru_kullanici_adi = reader["kullanici_adi"].ToString();
                string dogru_sifre = reader["sifre"].ToString();
                string kullanici_adi = yoneticikullaniciadi.Text;
                string sifre = yoneticisifre.Text;
                if (kullanici_adi == dogru_kullanici_adi && sifre == dogru_sifre)
                {
                    basarili = true;
                    break;
                }
                else
                {
                    
                    basarili = false;
                }
            }
            if (basarili == false)
            {
                girisbilgileriyanlis.Show();
                connection.Close();
            }
            else
            {
                girisbilgileriyanlis.Hide();
                connection.Close();
                yonetimpaneli frmyonetim = new yonetimpaneli();
                frmyonetim.Show();
                this.Hide();

            }
            
        }


        private void yonetimpaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Ebakus 
{
    public class HayatBilgisiNot : IOgretmenNot
    {
        MySqlConnection connection = Form1.connection;

        public void notGoster(DataGridView dataGridView1, string sinif)
        {
            int numara;
            string ad;
            string soyad;
            double not1;
            double not2;
            double notDavranis;
            double notOrtalama;
            
            connection.Open();

            MySqlCommand command = new MySqlCommand("Select *from notOgrenci where sinif= " + sinif, connection);//notOgrenci tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku

            dataGridView1.Rows.Clear();
            dataGridView1.Height = 36;
            while (reader.Read())
            {
                dataGridView1.Height += 27;
                numara = Convert.ToInt32(reader["numara"]);
                ad = reader["isim"].ToString();
                soyad = reader["soyisim"].ToString();
                not1 = Convert.ToDouble(reader["notHayatBilgisiBir"]);
                not2 = Convert.ToDouble(reader["notHayatBilgisiIki"]);
                notDavranis = Convert.ToDouble(reader["notHayatBilgisiDavranis"]);
                notOrtalama = Convert.ToDouble(reader["notHayatBilgisiOrtalama"]);
                dataGridView1.Rows.Add(//datagridview ekleme fonk
                new object[]
                {
                    numara,
                    ad,
                    soyad,
                    not1,
                    not2,
                    notDavranis,
                    notOrtalama
                }
              );

            }
            connection.Close();
        }

        public void notGuncelle(string[] notlar, string numara)
        {
            int notOrtalama = (Convert.ToInt32(notlar[0]) + Convert.ToInt32(notlar[1]) + Convert.ToInt32(notlar[2])) / 3;
            connection.Open();
            MySqlCommand komut = new MySqlCommand("update notOgrenci set notHayatBilgisiBir='" + notlar[0] + "', notHayatBilgisiIki='" + notlar[1] + "', notHayatBilgisiDavranis='" + notlar[2] + "', notHayatBilgisiOrtalama='" + notOrtalama.ToString() + "' where numara='" + numara + "'");
            komut.Connection = connection;
            komut.ExecuteNonQuery();
            connection.Close();
        }
    }
}

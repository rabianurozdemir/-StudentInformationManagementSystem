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
    public partial class ogrenciNot: Form
    {
        static private MySqlConnection connection = new MySqlConnection("SERVER=remotemysql.com;PORT=3306;DATABASE=dJ66FYlFxK;UID=dJ66FYlFxK;PWD=4n9TcIA0tV;");

        public ogrenciNot()
        {
            InitializeComponent();
            datagridviewSetting(dataGridView1);
            butonGeriDon.Left = 50;
            butonGeriDon.Top = Screen.PrimaryScreen.Bounds.Height - butonGeriDon.Height - 50;

        }


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void datagridviewSetting(DataGridView datagridview)
        {
            datagridview.BorderStyle = BorderStyle.None;
            datagridview.EnableHeadersVisualStyles = false;
            datagridview.DefaultCellStyle.SelectionBackColor = Color.SandyBrown;
            datagridview.DefaultCellStyle.SelectionForeColor = Color.Black;
            datagridview.DefaultCellStyle.Font = new Font("Consolas", 15);
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.Chocolate;
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.Wheat;
            datagridview.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SandyBrown;
            datagridview.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 15);
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagridview.RowHeadersVisible = false;
            datagridview.AllowUserToAddRows = false;
            datagridview.ColumnHeadersHeight = 36;
            datagridview.Height = 36;
            datagridview.Width = 775;
            datagridview.RowTemplate.Height = 30;
            datagridview.Left = (Screen.PrimaryScreen.Bounds.Width - datagridview.Width) / 2;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            notGoster();
        }

        void notGoster()
        {
            Cursor.Current = Cursors.WaitCursor;
            double[] not1 = new double[6];
            double[] not2 = new double[6];
            double[] notDavranis = new double[6];
            double[] notOrtalama = new double[6];
            string[] dersler = new string[] {"Türkçe", "Matematik", "Hayat Bilgisi", "Müzik" , "Yabancı Dil", "Beden Eğitimi" };

            connection.Open();
            MySqlCommand command = new MySqlCommand("Select *from notOgrenci where numara = "+ OgrenciBilgileri.okul_no, connection);//notOgrenci tablosundan veri çek
            MySqlDataReader reader = command.ExecuteReader();//veri tabanını oku

            datagridviewSetting(dataGridView1);
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {

                not1[0] = Convert.ToInt32(reader["notTurkceBir"]);
                not2[0] = Convert.ToInt32(reader["notTurkceIki"]);
                notDavranis[0] = Convert.ToInt32(reader["notTurkceDavranis"]); 
                notOrtalama[0] = Convert.ToInt32(reader["notTurkceOrtalama"]); 
                not1[1] = Convert.ToInt32(reader["notMatematikBir"]); 
                not2[1] = Convert.ToInt32(reader["notMatematikIki"]); 
                notDavranis[1] = Convert.ToInt32(reader["notMatematikDavranis"]); 
                notOrtalama[1] = Convert.ToInt32(reader["notMatematikOrtalama"]); 
                not1[2] = Convert.ToInt32(reader["notHayatBilgisiBir"]); 
                not2[2] = Convert.ToInt32(reader["notHayatBilgisiIki"]); 
                notDavranis[2] = Convert.ToInt32(reader["notHayatBilgisiDavranis"]); 
                notOrtalama[2] = Convert.ToInt32(reader["notHayatBilgisiOrtalama"]); 
                not1[3] = Convert.ToInt32(reader["notMuzikBir"]); 
                not2[3] = Convert.ToInt32(reader["notMuzikIki"]); 
                notDavranis[3] = Convert.ToInt32(reader["notMuzikDavranis"]); 
                notOrtalama[3] = Convert.ToInt32(reader["notMuzikOrtalama"]); 
                not1[4] = Convert.ToInt32(reader["notYabanciDilBir"]); 
                not2[4] = Convert.ToInt32(reader["notYabanciDilIki"]); 
                notDavranis[4] = Convert.ToInt32(reader["notYabanciDilDavranis"]); 
                notOrtalama[4] = Convert.ToInt32(reader["notYabanciDilOrtalama"]); 
                not1[5] = Convert.ToInt32(reader["notBedenEgitimiBir"]); 
                not2[5] = Convert.ToInt32(reader["notBedenEgitimiIki"]); 
                notDavranis[5] = Convert.ToInt32(reader["notBedenEgitimiDavranis"]); 
                notOrtalama[5] = Convert.ToInt32(reader["notBedenEgitimiOrtalama"]); 
            }
            for (int i = 0; i < 6; i++)
            {
                dataGridView1.Height += 27;
                dataGridView1.Rows.Add(//datagridview ekleme fonk
            new object[]
            {
                    dersler[i],
                    not1[i],
                    not2[i],
                    notDavranis[i],
                    notOrtalama[i]
            });
            }
            connection.Close();
            Cursor.Current = Cursors.Default;
        }


        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 3|| dataGridView1.CurrentCell.ColumnIndex == 4 || dataGridView1.CurrentCell.ColumnIndex == 5) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void butonGeriDon_Click(object sender, EventArgs e)
        {
            ogrenciMenu form = new ogrenciMenu();
            form.Show();
            this.Hide();
        }
    }
    }






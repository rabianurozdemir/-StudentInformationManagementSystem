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
    public partial class ogretmenNot : Form
    {
        MySqlConnection connection = Form1.connection;
        IOgretmenNot iogretmenNot;

        public ogretmenNot(IOgretmenNot ogretmenNot)
        {

            InitializeComponent();
            datagridviewSetting(dataGridView1);
            butonGeriDon.Left = 50;
            butonGeriDon.Top = Screen.PrimaryScreen.Bounds.Height - butonGeriDon.Height - 50;
            butonKaydet.Left = butonGeriDon.Left + butonGeriDon.Width + 50;
            butonKaydet.Top = butonGeriDon.Top;
            iogretmenNot = ogretmenNot;
            ogretmenNot.notGoster(dataGridView1, OgrenciBilgileri.sinif);

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
            datagridview.Width = 1001;
            datagridview.RowTemplate.Height = 30;
            datagridview.Left = (Screen.PrimaryScreen.Bounds.Width - datagridview.Width) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            for (int i=0; i< dataGridView1.RowCount; i++)
            {
                int k = 0;
                string[] notlar = new String[4];
                string numara = dataGridView1.Rows[i].Cells[0].Value.ToString();
                for (int j=3; j< dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString() == "")
                    {
                        notlar[k] = "0";
                    }
                    else
                    {
                        notlar[k] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                    k++;
                }
                iogretmenNot.notGuncelle(notlar, numara);

            }
            MessageBox.Show("İşlem başarılı");


            iogretmenNot.notGoster(dataGridView1, OgretmenBilgileri.sinif.ToString());
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
            ogretmenDersler form2 = new ogretmenDersler();
            form2.Show();
            this.Hide();
        }
    }
    }






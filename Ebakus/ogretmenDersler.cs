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
    public partial class ogretmenDersler : Form
    {

        public ogretmenDersler()
        {
            InitializeComponent();
            this.IsMdiContainer = true; //Form içinde form açma
            buttonsSettings(butonmatematik,0);
            buttonsSettings(butonmuzik, 0);
            buttonsSettings(butonhayatbilgisi, butonmatematik.Width + 100);
            buttonsSettings(butonturkce, - butonturkce.Width - 100);
            buttonsSettings(butonyabancidil, -butonyabancidil.Width - 100);
            butonGeriDon.Left = 50;
            butonGeriDon.Top = Screen.PrimaryScreen.Bounds.Height - butonGeriDon.Height - 50;
            buttonsSettings(butonbedenegitimi, butonmuzik.Width + 100);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        public static void buttonsSettings(Button buton,int konum)
        {
            buton.Left = ((Screen.PrimaryScreen.Bounds.Width - buton.Width) / 2) + konum;
            
        }

        private void butonGeriDon_Click(object sender, EventArgs e)
        {
            ogretmenMenu frm = new ogretmenMenu();
            this.Hide();
            frm.Show();
            
        }
        private void butonturkce_Click(object sender, EventArgs e)
        {
            ogretmenNot form3 = new ogretmenNot(new TurkceNot());
            form3.Show(); //Button'a tıkladığımız zaman form2'ye geçmesini sağlıyoruz
            this.Hide(); //Form2 açıldıktan sonra Form1'i gizliyoruz.
        }

        private void butonmatematik_Click(object sender, EventArgs e)
        {
            ogretmenNot form3 = new ogretmenNot(new MatematikNot());
            form3.Show(); //Button'a tıkladığımız zaman form2'ye geçmesini sağlıyoruz
            this.Hide(); //Form2 açıldıktan sonra Form1'i gizliyoruz.
        }

        private void butonhayatbilgisi_Click(object sender, EventArgs e)
        {
            ogretmenNot form3 = new ogretmenNot(new HayatBilgisiNot());
            form3.Show(); //Button'a tıkladığımız zaman form2'ye geçmesini sağlıyoruz
            this.Hide(); //Form2 açıldıktan sonra Form1'i gizliyoruz.
        }

        private void butonyabancidil_Click(object sender, EventArgs e)
        {
            ogretmenNot form3 = new ogretmenNot(new YabanciDilNot());
            form3.Show(); //Button'a tıkladığımız zaman form2'ye geçmesini sağlıyoruz
            this.Hide(); //Form2 açıldıktan sonra Form1'i gizliyoruz.
        }

        private void butonmuzik_Click(object sender, EventArgs e)
        {
            ogretmenNot form3 = new ogretmenNot(new MuzikNot());
            form3.Show(); //Button'a tıkladığımız zaman form2'ye geçmesini sağlıyoruz
            this.Hide(); //Form2 açıldıktan sonra Form1'i gizliyoruz.
        }

        private void butonbedenegitimi_Click(object sender, EventArgs e)
        {
            ogretmenNot form3 = new ogretmenNot(new BedenEgitimiNot());
            form3.Show(); //Button'a tıkladığımız zaman form2'ye geçmesini sağlıyoruz
            this.Hide(); //Form2 açıldıktan sonra Form1'i gizliyoruz.
        }

        private void ogretmenDersler_Load(object sender, EventArgs e)
        {

        }
    }
}

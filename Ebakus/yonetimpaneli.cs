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
    public partial class yonetimpaneli : Form
    {
        public yonetimpaneli()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(245, 245, 220);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            yonetimkutuphane frmyonetim = new yonetimkutuphane();
            frmyonetim.Show();
            this.Hide();
        }

        private void yonetimpaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ogrenciislemleri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            yonetimogrenci frmyonetim = new yonetimogrenci();
            frmyonetim.Show();
            this.Hide();
        }

        private void yonetimpaneli_Load(object sender, EventArgs e)
        {
            pictureBox1.Left = (Screen.PrimaryScreen.Bounds.Width - pictureBox1.Width) / 2;
            pictureBox1.Top = 30;
            label1.Left = (Screen.PrimaryScreen.Bounds.Width - label1.Width) / 2;
            label1.Top = pictureBox1.Top + pictureBox1.Height + 10;
            ogrenciislemleri.Left = (Screen.PrimaryScreen.Bounds.Width - ogrenciislemleri.Width) / 2;
            ogrenciislemleri.Top = label1.Top + label1.Height + 40;
            ogretmenislemleri.Left = (Screen.PrimaryScreen.Bounds.Width - ogretmenislemleri.Width) / 2;
            ogretmenislemleri.Top = ogrenciislemleri.Top + ogrenciislemleri.Height + 20;
            kutuphaneislemleri.Left = (Screen.PrimaryScreen.Bounds.Width - kutuphaneislemleri.Width) / 2;
            kutuphaneislemleri.Top = ogretmenislemleri.Top + ogretmenislemleri.Height + 20;
            cikis.Left = (Screen.PrimaryScreen.Bounds.Width - cikis.Width) / 2;
            cikis.Top = kutuphaneislemleri.Top + kutuphaneislemleri.Height + 20;
        }

        private void cikis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void ogretmenislemleri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            yonetimOgretmen frmyonetim = new yonetimOgretmen();
            frmyonetim.Show();
            this.Hide();
        }
    }
}

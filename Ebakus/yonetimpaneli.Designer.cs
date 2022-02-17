
namespace Ebakus
{
    partial class yonetimpaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.kutuphaneislemleri = new System.Windows.Forms.LinkLabel();
            this.ogrenciislemleri = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cikis = new System.Windows.Forms.LinkLabel();
            this.ogretmenislemleri = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(187, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "EBAKÜS Yönetim Paneline Hoşgeldiniz";
            // 
            // kutuphaneislemleri
            // 
            this.kutuphaneislemleri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kutuphaneislemleri.AutoSize = true;
            this.kutuphaneislemleri.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kutuphaneislemleri.Location = new System.Drawing.Point(298, 186);
            this.kutuphaneislemleri.Name = "kutuphaneislemleri";
            this.kutuphaneislemleri.Size = new System.Drawing.Size(238, 24);
            this.kutuphaneislemleri.TabIndex = 2;
            this.kutuphaneislemleri.TabStop = true;
            this.kutuphaneislemleri.Text = "Kütüphane İşlemleri";
            this.kutuphaneislemleri.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ogrenciislemleri
            // 
            this.ogrenciislemleri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ogrenciislemleri.AutoSize = true;
            this.ogrenciislemleri.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciislemleri.Location = new System.Drawing.Point(316, 254);
            this.ogrenciislemleri.Name = "ogrenciislemleri";
            this.ogrenciislemleri.Size = new System.Drawing.Size(214, 24);
            this.ogrenciislemleri.TabIndex = 3;
            this.ogrenciislemleri.TabStop = true;
            this.ogrenciislemleri.Text = "Öğrenci işlemleri";
            this.ogrenciislemleri.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ogrenciislemleri_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::Ebakus.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(350, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cikis
            // 
            this.cikis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cikis.AutoSize = true;
            this.cikis.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.Location = new System.Drawing.Point(316, 278);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(70, 24);
            this.cikis.TabIndex = 4;
            this.cikis.TabStop = true;
            this.cikis.Text = "Çıkış";
            this.cikis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cikis_LinkClicked);
            // 
            // ogretmenislemleri
            // 
            this.ogretmenislemleri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ogretmenislemleri.AutoSize = true;
            this.ogretmenislemleri.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogretmenislemleri.Location = new System.Drawing.Point(307, 230);
            this.ogretmenislemleri.Name = "ogretmenislemleri";
            this.ogretmenislemleri.Size = new System.Drawing.Size(226, 24);
            this.ogretmenislemleri.TabIndex = 5;
            this.ogretmenislemleri.TabStop = true;
            this.ogretmenislemleri.Text = "Öğretmen İşlemleri";
            this.ogretmenislemleri.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ogretmenislemleri_LinkClicked);
            // 
            // yonetimpaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.ogretmenislemleri);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.ogrenciislemleri);
            this.Controls.Add(this.kutuphaneislemleri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "yonetimpaneli";
            this.Text = "yonetimpaneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.yonetimpaneli_FormClosing);
            this.Load += new System.EventHandler(this.yonetimpaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel kutuphaneislemleri;
        private System.Windows.Forms.LinkLabel ogrenciislemleri;
        private System.Windows.Forms.LinkLabel cikis;
        private System.Windows.Forms.LinkLabel ogretmenislemleri;
    }
}
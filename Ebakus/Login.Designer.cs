
namespace Ebakus
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.linkogrenci = new System.Windows.Forms.LinkLabel();
            this.panelogretmen = new System.Windows.Forms.Panel();
            this.pictureBoxogretmen = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ogretmensifre = new System.Windows.Forms.TextBox();
            this.ogretmenGirisButon = new System.Windows.Forms.Button();
            this.ogretmenkullaniciadi = new System.Windows.Forms.TextBox();
            this.panelogrenci = new System.Windows.Forms.Panel();
            this.pictureBoxogrenci = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ogrencisifre = new System.Windows.Forms.TextBox();
            this.ogrenciGirisButon = new System.Windows.Forms.Button();
            this.ogrencikullaniciadi = new System.Windows.Forms.TextBox();
            this.linkogretmen = new System.Windows.Forms.LinkLabel();
            this.logincikisbutton = new System.Windows.Forms.Button();
            this.girisbilgileriyanlis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelogretmen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxogretmen)).BeginInit();
            this.panelogrenci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxogrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkogrenci
            // 
            this.linkogrenci.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkogrenci.AutoSize = true;
            this.linkogrenci.BackColor = System.Drawing.Color.Transparent;
            this.linkogrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkogrenci.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.linkogrenci.Location = new System.Drawing.Point(36, 402);
            this.linkogrenci.Name = "linkogrenci";
            this.linkogrenci.Size = new System.Drawing.Size(103, 20);
            this.linkogrenci.TabIndex = 21;
            this.linkogrenci.TabStop = true;
            this.linkogrenci.Text = "Öğrenci Girişi";
            this.linkogrenci.Visible = false;
            this.linkogrenci.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkogrenci_LinkClicked);
            // 
            // panelogretmen
            // 
            this.panelogretmen.BackColor = System.Drawing.Color.Transparent;
            this.panelogretmen.Controls.Add(this.pictureBoxogretmen);
            this.panelogretmen.Controls.Add(this.label2);
            this.panelogretmen.Controls.Add(this.ogretmensifre);
            this.panelogretmen.Controls.Add(this.ogretmenGirisButon);
            this.panelogretmen.Controls.Add(this.ogretmenkullaniciadi);
            this.panelogretmen.ForeColor = System.Drawing.Color.Transparent;
            this.panelogretmen.Location = new System.Drawing.Point(135, 125);
            this.panelogretmen.Name = "panelogretmen";
            this.panelogretmen.Size = new System.Drawing.Size(180, 204);
            this.panelogretmen.TabIndex = 20;
            this.panelogretmen.Visible = false;
            // 
            // pictureBoxogretmen
            // 
            this.pictureBoxogretmen.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxogretmen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxogretmen.Image")));
            this.pictureBoxogretmen.Location = new System.Drawing.Point(58, 3);
            this.pictureBoxogretmen.Name = "pictureBoxogretmen";
            this.pictureBoxogretmen.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxogretmen.TabIndex = 8;
            this.pictureBoxogretmen.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Öğretmen girişi";
            // 
            // ogretmensifre
            // 
            this.ogretmensifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.ogretmensifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ogretmensifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ogretmensifre.ForeColor = System.Drawing.Color.Silver;
            this.ogretmensifre.Location = new System.Drawing.Point(0, 115);
            this.ogretmensifre.Margin = new System.Windows.Forms.Padding(2);
            this.ogretmensifre.Name = "ogretmensifre";
            this.ogretmensifre.ShortcutsEnabled = false;
            this.ogretmensifre.Size = new System.Drawing.Size(180, 19);
            this.ogretmensifre.TabIndex = 5;
            this.ogretmensifre.Text = "Şifre";
            this.ogretmensifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ogretmensifre.Enter += new System.EventHandler(this.ogretmensifre_Enter);
            this.ogretmensifre.Leave += new System.EventHandler(this.ogretmensifre_Leave);
            // 
            // ogretmenGirisButon
            // 
            this.ogretmenGirisButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.ogretmenGirisButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogretmenGirisButon.FlatAppearance.BorderSize = 0;
            this.ogretmenGirisButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogretmenGirisButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogretmenGirisButon.ForeColor = System.Drawing.SystemColors.Control;
            this.ogretmenGirisButon.Location = new System.Drawing.Point(50, 154);
            this.ogretmenGirisButon.Margin = new System.Windows.Forms.Padding(2);
            this.ogretmenGirisButon.Name = "ogretmenGirisButon";
            this.ogretmenGirisButon.Size = new System.Drawing.Size(80, 39);
            this.ogretmenGirisButon.TabIndex = 1;
            this.ogretmenGirisButon.Text = "GİRİŞ";
            this.ogretmenGirisButon.UseVisualStyleBackColor = false;
            this.ogretmenGirisButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // ogretmenkullaniciadi
            // 
            this.ogretmenkullaniciadi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ogretmenkullaniciadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.ogretmenkullaniciadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ogretmenkullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ogretmenkullaniciadi.ForeColor = System.Drawing.Color.Silver;
            this.ogretmenkullaniciadi.Location = new System.Drawing.Point(0, 92);
            this.ogretmenkullaniciadi.Margin = new System.Windows.Forms.Padding(2);
            this.ogretmenkullaniciadi.Name = "ogretmenkullaniciadi";
            this.ogretmenkullaniciadi.Size = new System.Drawing.Size(180, 19);
            this.ogretmenkullaniciadi.TabIndex = 4;
            this.ogretmenkullaniciadi.Text = "Kullanıcı Adı";
            this.ogretmenkullaniciadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ogretmenkullaniciadi.Enter += new System.EventHandler(this.ogretmenkullaniciadi_Enter);
            this.ogretmenkullaniciadi.Leave += new System.EventHandler(this.ogretmenkullaniciadi_Leave);
            // 
            // panelogrenci
            // 
            this.panelogrenci.BackColor = System.Drawing.Color.Transparent;
            this.panelogrenci.Controls.Add(this.pictureBoxogrenci);
            this.panelogrenci.Controls.Add(this.label1);
            this.panelogrenci.Controls.Add(this.ogrencisifre);
            this.panelogrenci.Controls.Add(this.ogrenciGirisButon);
            this.panelogrenci.Controls.Add(this.ogrencikullaniciadi);
            this.panelogrenci.ForeColor = System.Drawing.Color.Transparent;
            this.panelogrenci.Location = new System.Drawing.Point(135, 125);
            this.panelogrenci.Name = "panelogrenci";
            this.panelogrenci.Size = new System.Drawing.Size(180, 204);
            this.panelogrenci.TabIndex = 19;
            // 
            // pictureBoxogrenci
            // 
            this.pictureBoxogrenci.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxogrenci.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxogrenci.Image")));
            this.pictureBoxogrenci.Location = new System.Drawing.Point(58, 3);
            this.pictureBoxogrenci.Name = "pictureBoxogrenci";
            this.pictureBoxogrenci.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxogrenci.TabIndex = 8;
            this.pictureBoxogrenci.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Öğrenci girişi";
            // 
            // ogrencisifre
            // 
            this.ogrencisifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.ogrencisifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ogrencisifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ogrencisifre.ForeColor = System.Drawing.Color.Silver;
            this.ogrencisifre.Location = new System.Drawing.Point(0, 115);
            this.ogrencisifre.Margin = new System.Windows.Forms.Padding(2);
            this.ogrencisifre.Name = "ogrencisifre";
            this.ogrencisifre.ShortcutsEnabled = false;
            this.ogrencisifre.Size = new System.Drawing.Size(180, 19);
            this.ogrencisifre.TabIndex = 5;
            this.ogrencisifre.Text = "Şifre";
            this.ogrencisifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ogrencisifre.Enter += new System.EventHandler(this.ogrencisifre_Enter_1);
            this.ogrencisifre.Leave += new System.EventHandler(this.ogrencisifre_Leave);
            // 
            // ogrenciGirisButon
            // 
            this.ogrenciGirisButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.ogrenciGirisButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogrenciGirisButon.FlatAppearance.BorderSize = 0;
            this.ogrenciGirisButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrenciGirisButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ogrenciGirisButon.ForeColor = System.Drawing.SystemColors.Control;
            this.ogrenciGirisButon.Location = new System.Drawing.Point(50, 154);
            this.ogrenciGirisButon.Margin = new System.Windows.Forms.Padding(2);
            this.ogrenciGirisButon.Name = "ogrenciGirisButon";
            this.ogrenciGirisButon.Size = new System.Drawing.Size(80, 39);
            this.ogrenciGirisButon.TabIndex = 1;
            this.ogrenciGirisButon.Text = "GİRİŞ";
            this.ogrenciGirisButon.UseVisualStyleBackColor = false;
            this.ogrenciGirisButon.Click += new System.EventHandler(this.button2_Click);
            // 
            // ogrencikullaniciadi
            // 
            this.ogrencikullaniciadi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ogrencikullaniciadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.ogrencikullaniciadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ogrencikullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ogrencikullaniciadi.ForeColor = System.Drawing.Color.Silver;
            this.ogrencikullaniciadi.Location = new System.Drawing.Point(0, 92);
            this.ogrencikullaniciadi.Margin = new System.Windows.Forms.Padding(2);
            this.ogrencikullaniciadi.Name = "ogrencikullaniciadi";
            this.ogrencikullaniciadi.Size = new System.Drawing.Size(180, 19);
            this.ogrencikullaniciadi.TabIndex = 4;
            this.ogrencikullaniciadi.Text = "Kullanıcı Adı";
            this.ogrencikullaniciadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ogrencikullaniciadi.Enter += new System.EventHandler(this.ogrencikullaniciadi_Enter);
            this.ogrencikullaniciadi.Leave += new System.EventHandler(this.ogrencikullaniciadi_Leave);
            // 
            // linkogretmen
            // 
            this.linkogretmen.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkogretmen.AutoSize = true;
            this.linkogretmen.BackColor = System.Drawing.Color.Transparent;
            this.linkogretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkogretmen.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.linkogretmen.Location = new System.Drawing.Point(36, 402);
            this.linkogretmen.Name = "linkogretmen";
            this.linkogretmen.Size = new System.Drawing.Size(119, 20);
            this.linkogretmen.TabIndex = 18;
            this.linkogretmen.TabStop = true;
            this.linkogretmen.Text = "Öğretmen Girişi";
            this.linkogretmen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkogretmen_LinkClicked);
            // 
            // logincikisbutton
            // 
            this.logincikisbutton.BackColor = System.Drawing.Color.Transparent;
            this.logincikisbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logincikisbutton.BackgroundImage")));
            this.logincikisbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logincikisbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logincikisbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.logincikisbutton.FlatAppearance.BorderSize = 0;
            this.logincikisbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logincikisbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logincikisbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logincikisbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.logincikisbutton.Location = new System.Drawing.Point(386, 51);
            this.logincikisbutton.Name = "logincikisbutton";
            this.logincikisbutton.Size = new System.Drawing.Size(33, 33);
            this.logincikisbutton.TabIndex = 17;
            this.logincikisbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logincikisbutton.UseVisualStyleBackColor = false;
            this.logincikisbutton.Click += new System.EventHandler(this.logincikisbutton_Click);
            // 
            // girisbilgileriyanlis
            // 
            this.girisbilgileriyanlis.AutoSize = true;
            this.girisbilgileriyanlis.BackColor = System.Drawing.Color.Transparent;
            this.girisbilgileriyanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbilgileriyanlis.ForeColor = System.Drawing.Color.Red;
            this.girisbilgileriyanlis.Location = new System.Drawing.Point(107, 332);
            this.girisbilgileriyanlis.Name = "girisbilgileriyanlis";
            this.girisbilgileriyanlis.Size = new System.Drawing.Size(235, 20);
            this.girisbilgileriyanlis.TabIndex = 22;
            this.girisbilgileriyanlis.Text = "Kullanıcı adı veya şifre yanlış";
            this.girisbilgileriyanlis.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.ogrenciGirisButon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ebakus.Properties.Resources.ebakus4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 490);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.girisbilgileriyanlis);
            this.Controls.Add(this.linkogrenci);
            this.Controls.Add(this.panelogretmen);
            this.Controls.Add(this.panelogrenci);
            this.Controls.Add(this.linkogretmen);
            this.Controls.Add(this.logincikisbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            this.panelogretmen.ResumeLayout(false);
            this.panelogretmen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxogretmen)).EndInit();
            this.panelogrenci.ResumeLayout(false);
            this.panelogrenci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxogrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkogrenci;
        private System.Windows.Forms.Panel panelogretmen;
        private System.Windows.Forms.PictureBox pictureBoxogretmen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ogretmensifre;
        private System.Windows.Forms.Button ogretmenGirisButon;
        private System.Windows.Forms.TextBox ogretmenkullaniciadi;
        private System.Windows.Forms.Panel panelogrenci;
        private System.Windows.Forms.PictureBox pictureBoxogrenci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ogrencisifre;
        private System.Windows.Forms.Button ogrenciGirisButon;
        private System.Windows.Forms.TextBox ogrencikullaniciadi;
        private System.Windows.Forms.LinkLabel linkogretmen;
        private System.Windows.Forms.Button logincikisbutton;
        private System.Windows.Forms.Label girisbilgileriyanlis;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
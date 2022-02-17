
namespace Ebakus
{
    partial class yonetimOgretmen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.ogretmenAditxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ogretmenSoyaditxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ogretmenKimlikNotxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ogretmenEmailtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cinsiyetbox = new System.Windows.Forms.ComboBox();
            this.sinifbox = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimlik_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secim = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.isim,
            this.soyad,
            this.kimlik_no,
            this.sinif,
            this.mail,
            this.cinsiyet,
            this.secim});
            this.dataGridView1.Location = new System.Drawing.Point(62, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(746, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(80, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Geri Dön";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.CadetBlue;
            this.guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelle.FlatAppearance.BorderSize = 0;
            this.guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.guncelle.Location = new System.Drawing.Point(80, 210);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(75, 23);
            this.guncelle.TabIndex = 16;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.DarkRed;
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnsil.Location = new System.Drawing.Point(160, 210);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 17;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // ogretmenAditxt
            // 
            this.ogretmenAditxt.Location = new System.Drawing.Point(616, 45);
            this.ogretmenAditxt.Name = "ogretmenAditxt";
            this.ogretmenAditxt.Size = new System.Drawing.Size(100, 20);
            this.ogretmenAditxt.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(561, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(530, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Soy İsim";
            // 
            // ogretmenSoyaditxt
            // 
            this.ogretmenSoyaditxt.Location = new System.Drawing.Point(616, 81);
            this.ogretmenSoyaditxt.Name = "ogretmenSoyaditxt";
            this.ogretmenSoyaditxt.Size = new System.Drawing.Size(100, 20);
            this.ogretmenSoyaditxt.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1029, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sınıf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(726, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kimlik Numarası";
            // 
            // ogretmenKimlikNotxt
            // 
            this.ogretmenKimlikNotxt.Location = new System.Drawing.Point(864, 48);
            this.ogretmenKimlikNotxt.Name = "ogretmenKimlikNotxt";
            this.ogretmenKimlikNotxt.Size = new System.Drawing.Size(100, 20);
            this.ogretmenKimlikNotxt.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1001, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(790, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "E-mail";
            // 
            // ogretmenEmailtxt
            // 
            this.ogretmenEmailtxt.Location = new System.Drawing.Point(864, 85);
            this.ogretmenEmailtxt.Name = "ogretmenEmailtxt";
            this.ogretmenEmailtxt.Size = new System.Drawing.Size(100, 20);
            this.ogretmenEmailtxt.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(1205, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cinsiyetbox
            // 
            this.cinsiyetbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinsiyetbox.FormattingEnabled = true;
            this.cinsiyetbox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyetbox.Location = new System.Drawing.Point(1086, 84);
            this.cinsiyetbox.Name = "cinsiyetbox";
            this.cinsiyetbox.Size = new System.Drawing.Size(100, 21);
            this.cinsiyetbox.TabIndex = 31;
            // 
            // sinifbox
            // 
            this.sinifbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sinifbox.FormattingEnabled = true;
            this.sinifbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.sinifbox.Location = new System.Drawing.Point(1086, 49);
            this.sinifbox.Name = "sinifbox";
            this.sinifbox.Size = new System.Drawing.Size(100, 21);
            this.sinifbox.TabIndex = 32;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // isim
            // 
            this.isim.HeaderText = "İsim";
            this.isim.Name = "isim";
            // 
            // soyad
            // 
            this.soyad.HeaderText = "Soy isim";
            this.soyad.Name = "soyad";
            // 
            // kimlik_no
            // 
            this.kimlik_no.HeaderText = "Kimlik Numarası";
            this.kimlik_no.Name = "kimlik_no";
            // 
            // sinif
            // 
            this.sinif.HeaderText = "Sınıf";
            this.sinif.Name = "sinif";
            // 
            // mail
            // 
            this.mail.HeaderText = "E-mail";
            this.mail.Name = "mail";
            // 
            // cinsiyet
            // 
            this.cinsiyet.HeaderText = "Cinsiyet";
            this.cinsiyet.Name = "cinsiyet";
            // 
            // secim
            // 
            this.secim.HeaderText = "";
            this.secim.Name = "secim";
            // 
            // yonetimOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 450);
            this.Controls.Add(this.sinifbox);
            this.Controls.Add(this.cinsiyetbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ogretmenEmailtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ogretmenKimlikNotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ogretmenSoyaditxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ogretmenAditxt);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "yonetimOgretmen";
            this.Text = "yonetimogrenci";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.yonetimogrenci_FormClosing);
            this.Load += new System.EventHandler(this.yonetimogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox ogretmenAditxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ogretmenSoyaditxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ogretmenKimlikNotxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ogretmenEmailtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cinsiyetbox;
        private System.Windows.Forms.ComboBox sinifbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimlik_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinif;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn secim;
    }
}

namespace Ebakus
{
    partial class kutuphane
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
            this.kitap_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basim_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_ozet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hikayeler_listele = new System.Windows.Forms.Button();
            this.romanlar_listele_buton = new System.Windows.Forms.Button();
            this.masallar_listele_buton = new System.Windows.Forms.Button();
            this.kitaplarıhepsini_listele_buton = new System.Windows.Forms.Button();
            this.kutuphanearama_textbox = new System.Windows.Forms.TextBox();
            this.kitapozet_textbox = new System.Windows.Forms.TextBox();
            this.kutuphanekitaparamabutonudur = new System.Windows.Forms.Button();
            this.aranankitapbulunamadı_textbox = new System.Windows.Forms.TextBox();
            this.kutuphanegeridonbutonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeight = 57;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitap_adi,
            this.yazar_adi,
            this.basim_tarihi,
            this.kategori,
            this.kitap_ozet});
            this.dataGridView1.Location = new System.Drawing.Point(692, 174);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(665, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // kitap_adi
            // 
            this.kitap_adi.FillWeight = 361.4973F;
            this.kitap_adi.HeaderText = "Kitap Adı";
            this.kitap_adi.MinimumWidth = 160;
            this.kitap_adi.Name = "kitap_adi";
            this.kitap_adi.Width = 438;
            // 
            // yazar_adi
            // 
            this.yazar_adi.FillWeight = 10.23637F;
            this.yazar_adi.HeaderText = "Yazar Adı";
            this.yazar_adi.MinimumWidth = 160;
            this.yazar_adi.Name = "yazar_adi";
            this.yazar_adi.Width = 160;
            // 
            // basim_tarihi
            // 
            this.basim_tarihi.FillWeight = 12.03363F;
            this.basim_tarihi.HeaderText = "Basım Tarihi";
            this.basim_tarihi.MinimumWidth = 160;
            this.basim_tarihi.Name = "basim_tarihi";
            this.basim_tarihi.Width = 160;
            // 
            // kategori
            // 
            this.kategori.FillWeight = 16.23268F;
            this.kategori.HeaderText = "Kategori";
            this.kategori.MinimumWidth = 160;
            this.kategori.Name = "kategori";
            this.kategori.Width = 160;
            // 
            // kitap_ozet
            // 
            this.kitap_ozet.HeaderText = "özet";
            this.kitap_ozet.MinimumWidth = 6;
            this.kitap_ozet.Name = "kitap_ozet";
            this.kitap_ozet.Width = 125;
            // 
            // hikayeler_listele
            // 
            this.hikayeler_listele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.hikayeler_listele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hikayeler_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hikayeler_listele.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.hikayeler_listele.ForeColor = System.Drawing.Color.Navy;
            this.hikayeler_listele.Location = new System.Drawing.Point(1089, 74);
            this.hikayeler_listele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hikayeler_listele.Name = "hikayeler_listele";
            this.hikayeler_listele.Size = new System.Drawing.Size(149, 71);
            this.hikayeler_listele.TabIndex = 1;
            this.hikayeler_listele.Text = "Hikayeler";
            this.hikayeler_listele.UseVisualStyleBackColor = false;
            this.hikayeler_listele.Click += new System.EventHandler(this.hikayeler_listele_Click);
            // 
            // romanlar_listele_buton
            // 
            this.romanlar_listele_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.romanlar_listele_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.romanlar_listele_buton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.romanlar_listele_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.romanlar_listele_buton.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.romanlar_listele_buton.ForeColor = System.Drawing.Color.Navy;
            this.romanlar_listele_buton.Location = new System.Drawing.Point(1307, 74);
            this.romanlar_listele_buton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.romanlar_listele_buton.Name = "romanlar_listele_buton";
            this.romanlar_listele_buton.Size = new System.Drawing.Size(145, 71);
            this.romanlar_listele_buton.TabIndex = 2;
            this.romanlar_listele_buton.Text = "Romanlar";
            this.romanlar_listele_buton.UseVisualStyleBackColor = false;
            this.romanlar_listele_buton.Click += new System.EventHandler(this.romanlar_listele_buton_Click);
            // 
            // masallar_listele_buton
            // 
            this.masallar_listele_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.masallar_listele_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.masallar_listele_buton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.masallar_listele_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masallar_listele_buton.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.masallar_listele_buton.ForeColor = System.Drawing.Color.Navy;
            this.masallar_listele_buton.Location = new System.Drawing.Point(641, 74);
            this.masallar_listele_buton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.masallar_listele_buton.Name = "masallar_listele_buton";
            this.masallar_listele_buton.Size = new System.Drawing.Size(149, 71);
            this.masallar_listele_buton.TabIndex = 3;
            this.masallar_listele_buton.Text = "Masallar";
            this.masallar_listele_buton.UseVisualStyleBackColor = false;
            this.masallar_listele_buton.Click += new System.EventHandler(this.masallar_listele_buton_Click);
            // 
            // kitaplarıhepsini_listele_buton
            // 
            this.kitaplarıhepsini_listele_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.kitaplarıhepsini_listele_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitaplarıhepsini_listele_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitaplarıhepsini_listele_buton.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.kitaplarıhepsini_listele_buton.ForeColor = System.Drawing.Color.Navy;
            this.kitaplarıhepsini_listele_buton.Location = new System.Drawing.Point(875, 74);
            this.kitaplarıhepsini_listele_buton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kitaplarıhepsini_listele_buton.Name = "kitaplarıhepsini_listele_buton";
            this.kitaplarıhepsini_listele_buton.Size = new System.Drawing.Size(149, 71);
            this.kitaplarıhepsini_listele_buton.TabIndex = 17;
            this.kitaplarıhepsini_listele_buton.Text = "Hepsi";
            this.kitaplarıhepsini_listele_buton.UseVisualStyleBackColor = false;
            this.kitaplarıhepsini_listele_buton.Click += new System.EventHandler(this.kitaplarıhepsini_listele_buton_Click);
            // 
            // kutuphanearama_textbox
            // 
            this.kutuphanearama_textbox.BackColor = System.Drawing.Color.Azure;
            this.kutuphanearama_textbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kutuphanearama_textbox.ForeColor = System.Drawing.Color.Navy;
            this.kutuphanearama_textbox.Location = new System.Drawing.Point(131, 46);
            this.kutuphanearama_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kutuphanearama_textbox.Multiline = true;
            this.kutuphanearama_textbox.Name = "kutuphanearama_textbox";
            this.kutuphanearama_textbox.ShortcutsEnabled = false;
            this.kutuphanearama_textbox.Size = new System.Drawing.Size(279, 77);
            this.kutuphanearama_textbox.TabIndex = 21;
            // 
            // kitapozet_textbox
            // 
            this.kitapozet_textbox.BackColor = System.Drawing.Color.Azure;
            this.kitapozet_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kitapozet_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.kitapozet_textbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapozet_textbox.ForeColor = System.Drawing.Color.Navy;
            this.kitapozet_textbox.Location = new System.Drawing.Point(641, 626);
            this.kitapozet_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kitapozet_textbox.Multiline = true;
            this.kitapozet_textbox.Name = "kitapozet_textbox";
            this.kitapozet_textbox.Size = new System.Drawing.Size(1013, 185);
            this.kitapozet_textbox.TabIndex = 22;
            // 
            // kutuphanekitaparamabutonudur
            // 
            this.kutuphanekitaparamabutonudur.BackColor = System.Drawing.Color.Transparent;
            this.kutuphanekitaparamabutonudur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kutuphanekitaparamabutonudur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kutuphanekitaparamabutonudur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kutuphanekitaparamabutonudur.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.kutuphanekitaparamabutonudur.ForeColor = System.Drawing.Color.Azure;
            this.kutuphanekitaparamabutonudur.Location = new System.Drawing.Point(131, 146);
            this.kutuphanekitaparamabutonudur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kutuphanekitaparamabutonudur.Name = "kutuphanekitaparamabutonudur";
            this.kutuphanekitaparamabutonudur.Size = new System.Drawing.Size(277, 52);
            this.kutuphanekitaparamabutonudur.TabIndex = 23;
            this.kutuphanekitaparamabutonudur.Text = "KİTAP ADI ARA";
            this.kutuphanekitaparamabutonudur.UseVisualStyleBackColor = false;
            this.kutuphanekitaparamabutonudur.Click += new System.EventHandler(this.kutuphanekitaparamabutonudur_Click);
            // 
            // aranankitapbulunamadı_textbox
            // 
            this.aranankitapbulunamadı_textbox.BackColor = System.Drawing.Color.Azure;
            this.aranankitapbulunamadı_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aranankitapbulunamadı_textbox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aranankitapbulunamadı_textbox.ForeColor = System.Drawing.Color.Navy;
            this.aranankitapbulunamadı_textbox.Location = new System.Drawing.Point(781, 309);
            this.aranankitapbulunamadı_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aranankitapbulunamadı_textbox.Multiline = true;
            this.aranankitapbulunamadı_textbox.Name = "aranankitapbulunamadı_textbox";
            this.aranankitapbulunamadı_textbox.Size = new System.Drawing.Size(501, 81);
            this.aranankitapbulunamadı_textbox.TabIndex = 24;
            this.aranankitapbulunamadı_textbox.Text = "Aranan kitap bulunamadı!";
            this.aranankitapbulunamadı_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kutuphanegeridonbutonu
            // 
            this.kutuphanegeridonbutonu.BackColor = System.Drawing.Color.Transparent;
            this.kutuphanegeridonbutonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kutuphanegeridonbutonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kutuphanegeridonbutonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kutuphanegeridonbutonu.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.kutuphanegeridonbutonu.ForeColor = System.Drawing.Color.Azure;
            this.kutuphanegeridonbutonu.Location = new System.Drawing.Point(131, 721);
            this.kutuphanegeridonbutonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kutuphanegeridonbutonu.Name = "kutuphanegeridonbutonu";
            this.kutuphanegeridonbutonu.Size = new System.Drawing.Size(177, 55);
            this.kutuphanegeridonbutonu.TabIndex = 25;
            this.kutuphanegeridonbutonu.Text = "GERİ DÖN";
            this.kutuphanegeridonbutonu.UseVisualStyleBackColor = false;
            this.kutuphanegeridonbutonu.Click += new System.EventHandler(this.kutuphanegeridonbutonu_Click);
            // 
            // kutuphane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = global::Ebakus.Properties.Resources.kutuphanearkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.masallar_listele_buton;
            this.ClientSize = new System.Drawing.Size(1487, 836);
            this.Controls.Add(this.kutuphanegeridonbutonu);
            this.Controls.Add(this.aranankitapbulunamadı_textbox);
            this.Controls.Add(this.kutuphanekitaparamabutonudur);
            this.Controls.Add(this.kitapozet_textbox);
            this.Controls.Add(this.kutuphanearama_textbox);
            this.Controls.Add(this.kitaplarıhepsini_listele_buton);
            this.Controls.Add(this.masallar_listele_buton);
            this.Controls.Add(this.romanlar_listele_buton);
            this.Controls.Add(this.hikayeler_listele);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Azure;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "kutuphane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kutuphane_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button hikayeler_listele;
        private System.Windows.Forms.Button romanlar_listele_buton;
        private System.Windows.Forms.Button masallar_listele_buton;
        private System.Windows.Forms.Button kitaplarıhepsini_listele_buton;
        private System.Windows.Forms.TextBox kutuphanearama_textbox;
        private System.Windows.Forms.TextBox kitapozet_textbox;
        private System.Windows.Forms.Button kutuphanekitaparamabutonudur;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazar_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn basim_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_ozet;
        private System.Windows.Forms.TextBox aranankitapbulunamadı_textbox;
        private System.Windows.Forms.Button kutuphanegeridonbutonu;
    }
}


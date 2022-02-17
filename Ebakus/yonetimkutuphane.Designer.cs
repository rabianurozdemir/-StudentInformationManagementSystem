
namespace Ebakus
{
    partial class yonetimkutuphane
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
            this.button1 = new System.Windows.Forms.Button();
            this.kitapaditxt = new System.Windows.Forms.TextBox();
            this.yazaraditxt = new System.Windows.Forms.TextBox();
            this.basimyilitxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kategoribox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitap_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basim_yili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitap_ozet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guncelle = new System.Windows.Forms.Button();
            this.kitapozettxt = new System.Windows.Forms.RichTextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kitapaditxt
            // 
            this.kitapaditxt.Location = new System.Drawing.Point(588, 45);
            this.kitapaditxt.Name = "kitapaditxt";
            this.kitapaditxt.Size = new System.Drawing.Size(100, 20);
            this.kitapaditxt.TabIndex = 1;
            // 
            // yazaraditxt
            // 
            this.yazaraditxt.Location = new System.Drawing.Point(588, 77);
            this.yazaraditxt.Name = "yazaraditxt";
            this.yazaraditxt.Size = new System.Drawing.Size(100, 20);
            this.yazaraditxt.TabIndex = 2;
            // 
            // basimyilitxt
            // 
            this.basimyilitxt.Location = new System.Drawing.Point(783, 45);
            this.basimyilitxt.Name = "basimyilitxt";
            this.basimyilitxt.Size = new System.Drawing.Size(100, 20);
            this.basimyilitxt.TabIndex = 3;
            this.basimyilitxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.basimyilitxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(513, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(507, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yazar Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(700, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Basım Yılı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(711, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kategori";
            // 
            // kategoribox
            // 
            this.kategoribox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategoribox.FormattingEnabled = true;
            this.kategoribox.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Masal"});
            this.kategoribox.Location = new System.Drawing.Point(783, 77);
            this.kategoribox.Name = "kategoribox";
            this.kategoribox.Size = new System.Drawing.Size(100, 21);
            this.kategoribox.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitap_no,
            this.kitap_adi,
            this.yazar_adi,
            this.basim_yili,
            this.kategori,
            this.kitap_ozet});
            this.dataGridView1.Location = new System.Drawing.Point(52, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(654, 500);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            // 
            // kitap_no
            // 
            this.kitap_no.HeaderText = "Kitap No";
            this.kitap_no.Name = "kitap_no";
            this.kitap_no.ReadOnly = true;
            // 
            // kitap_adi
            // 
            this.kitap_adi.HeaderText = "Kitap Adı";
            this.kitap_adi.Name = "kitap_adi";
            // 
            // yazar_adi
            // 
            this.yazar_adi.HeaderText = "Yazar Adı";
            this.yazar_adi.Name = "yazar_adi";
            // 
            // basim_yili
            // 
            this.basim_yili.HeaderText = "Basım Yılı";
            this.basim_yili.Name = "basim_yili";
            // 
            // kategori
            // 
            this.kategori.HeaderText = "Kategori";
            this.kategori.Name = "kategori";
            // 
            // kitap_ozet
            // 
            this.kitap_ozet.HeaderText = "Kitap Özeti";
            this.kitap_ozet.Name = "kitap_ozet";
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
            this.guncelle.TabIndex = 11;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // kitapozettxt
            // 
            this.kitapozettxt.Location = new System.Drawing.Point(1000, 43);
            this.kitapozettxt.Name = "kitapozettxt";
            this.kitapozettxt.Size = new System.Drawing.Size(186, 60);
            this.kitapozettxt.TabIndex = 12;
            this.kitapozettxt.Text = "";
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
            this.btnsil.TabIndex = 13;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
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
            this.button2.TabIndex = 14;
            this.button2.Text = "Geri Dön";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(942, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Özet";
            // 
            // yonetimkutuphane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 954);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.kitapozettxt);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kategoribox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basimyilitxt);
            this.Controls.Add(this.yazaraditxt);
            this.Controls.Add(this.kitapaditxt);
            this.Controls.Add(this.button1);
            this.Name = "yonetimkutuphane";
            this.Text = "yonetim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.yonetim_FormClosing);
            this.Load += new System.EventHandler(this.yonetimkutuphane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kitapaditxt;
        private System.Windows.Forms.TextBox yazaraditxt;
        private System.Windows.Forms.TextBox basimyilitxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox kategoribox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.RichTextBox kitapozettxt;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazar_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn basim_yili;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitap_ozet;
    }
}
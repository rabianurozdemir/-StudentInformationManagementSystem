
namespace Ebakus
{
    partial class yonetimpaneligiris
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
            this.yoneticikullaniciadi = new System.Windows.Forms.TextBox();
            this.yoneticisifre = new System.Windows.Forms.TextBox();
            this.yoneticigiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.girisbilgileriyanlis = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yoneticikullaniciadi
            // 
            this.yoneticikullaniciadi.Location = new System.Drawing.Point(100, 3);
            this.yoneticikullaniciadi.Name = "yoneticikullaniciadi";
            this.yoneticikullaniciadi.Size = new System.Drawing.Size(132, 20);
            this.yoneticikullaniciadi.TabIndex = 0;
            // 
            // yoneticisifre
            // 
            this.yoneticisifre.Location = new System.Drawing.Point(100, 40);
            this.yoneticisifre.Name = "yoneticisifre";
            this.yoneticisifre.PasswordChar = '*';
            this.yoneticisifre.Size = new System.Drawing.Size(132, 20);
            this.yoneticisifre.TabIndex = 1;
            // 
            // yoneticigiris
            // 
            this.yoneticigiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yoneticigiris.Location = new System.Drawing.Point(81, 91);
            this.yoneticigiris.Name = "yoneticigiris";
            this.yoneticigiris.Size = new System.Drawing.Size(75, 23);
            this.yoneticigiris.TabIndex = 2;
            this.yoneticigiris.Text = "Giriş";
            this.yoneticigiris.UseVisualStyleBackColor = true;
            this.yoneticigiris.Click += new System.EventHandler(this.yoneticigiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // girisbilgileriyanlis
            // 
            this.girisbilgileriyanlis.AutoSize = true;
            this.girisbilgileriyanlis.BackColor = System.Drawing.Color.Transparent;
            this.girisbilgileriyanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbilgileriyanlis.ForeColor = System.Drawing.Color.Red;
            this.girisbilgileriyanlis.Location = new System.Drawing.Point(1, 117);
            this.girisbilgileriyanlis.Name = "girisbilgileriyanlis";
            this.girisbilgileriyanlis.Size = new System.Drawing.Size(235, 20);
            this.girisbilgileriyanlis.TabIndex = 23;
            this.girisbilgileriyanlis.Text = "Kullanıcı adı veya şifre yanlış";
            this.girisbilgileriyanlis.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.yoneticikullaniciadi);
            this.panel1.Controls.Add(this.yoneticigiris);
            this.panel1.Controls.Add(this.girisbilgileriyanlis);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.yoneticisifre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(132, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 140);
            this.panel1.TabIndex = 24;
            // 
            // yonetimpaneligiris
            // 
            this.AcceptButton = this.yoneticigiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "yonetimpaneligiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yonetimpaneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.yonetimpaneli_FormClosed);
            this.Load += new System.EventHandler(this.yonetimpaneli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox yoneticikullaniciadi;
        private System.Windows.Forms.TextBox yoneticisifre;
        private System.Windows.Forms.Button yoneticigiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label girisbilgileriyanlis;
        public System.Windows.Forms.Panel panel1;
    }
}
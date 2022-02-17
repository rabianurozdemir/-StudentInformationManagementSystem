
namespace Ebakus
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AcilisYuklaniyor = new System.Windows.Forms.Label();
            this.AcilisEbakus = new System.Windows.Forms.Label();
            this.AcilisPictureBox = new System.Windows.Forms.PictureBox();
            this.timeryukleniyor = new System.Windows.Forms.Timer(this.components);
            this.bospanel = new System.Windows.Forms.Panel();
            this.paneldolu = new System.Windows.Forms.Panel();
            this.paneldolu2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AcilisPictureBox)).BeginInit();
            this.bospanel.SuspendLayout();
            this.paneldolu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcilisYuklaniyor
            // 
            this.AcilisYuklaniyor.AutoSize = true;
            this.AcilisYuklaniyor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AcilisYuklaniyor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.AcilisYuklaniyor.Location = new System.Drawing.Point(87, 215);
            this.AcilisYuklaniyor.Name = "AcilisYuklaniyor";
            this.AcilisYuklaniyor.Size = new System.Drawing.Size(126, 24);
            this.AcilisYuklaniyor.TabIndex = 5;
            this.AcilisYuklaniyor.Text = "Yükleniyor...";
            // 
            // AcilisEbakus
            // 
            this.AcilisEbakus.AutoSize = true;
            this.AcilisEbakus.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcilisEbakus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.AcilisEbakus.Location = new System.Drawing.Point(104, 48);
            this.AcilisEbakus.Name = "AcilisEbakus";
            this.AcilisEbakus.Size = new System.Drawing.Size(92, 27);
            this.AcilisEbakus.TabIndex = 4;
            this.AcilisEbakus.Text = "EBAKÜS";
            // 
            // AcilisPictureBox
            // 
            this.AcilisPictureBox.Image = global::Ebakus.Properties.Resources.acilis100x100;
            this.AcilisPictureBox.Location = new System.Drawing.Point(100, 95);
            this.AcilisPictureBox.Name = "AcilisPictureBox";
            this.AcilisPictureBox.Size = new System.Drawing.Size(100, 100);
            this.AcilisPictureBox.TabIndex = 3;
            this.AcilisPictureBox.TabStop = false;
            // 
            // timeryukleniyor
            // 
            this.timeryukleniyor.Enabled = true;
            this.timeryukleniyor.Interval = 1;
            this.timeryukleniyor.Tick += new System.EventHandler(this.timeryukleniyor_Tick);
            // 
            // bospanel
            // 
            this.bospanel.BackColor = System.Drawing.Color.Transparent;
            this.bospanel.Controls.Add(this.paneldolu);
            this.bospanel.Location = new System.Drawing.Point(0, 252);
            this.bospanel.Name = "bospanel";
            this.bospanel.Size = new System.Drawing.Size(300, 21);
            this.bospanel.TabIndex = 6;
            // 
            // paneldolu
            // 
            this.paneldolu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.paneldolu.Controls.Add(this.paneldolu2);
            this.paneldolu.Location = new System.Drawing.Point(0, 0);
            this.paneldolu.Name = "paneldolu";
            this.paneldolu.Size = new System.Drawing.Size(2, 21);
            this.paneldolu.TabIndex = 7;
            // 
            // paneldolu2
            // 
            this.paneldolu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(79)))), ((int)(((byte)(61)))));
            this.paneldolu2.Location = new System.Drawing.Point(0, 0);
            this.paneldolu2.Name = "paneldolu2";
            this.paneldolu2.Size = new System.Drawing.Size(2, 21);
            this.paneldolu2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.bospanel);
            this.Controls.Add(this.AcilisYuklaniyor);
            this.Controls.Add(this.AcilisEbakus);
            this.Controls.Add(this.AcilisPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.AcilisPictureBox)).EndInit();
            this.bospanel.ResumeLayout(false);
            this.paneldolu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AcilisYuklaniyor;
        private System.Windows.Forms.Label AcilisEbakus;
        private System.Windows.Forms.PictureBox AcilisPictureBox;
        private System.Windows.Forms.Timer timeryukleniyor;
        private System.Windows.Forms.Panel bospanel;
        private System.Windows.Forms.Panel paneldolu;
        private System.Windows.Forms.Panel paneldolu2;
    }
}


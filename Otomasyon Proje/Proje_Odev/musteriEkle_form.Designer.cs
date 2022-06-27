namespace Proje_Odev
{
    partial class musteriEkle_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriEkle_form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.musteriAdi_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.musteriSoyadi_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.musteriBorc_txt = new System.Windows.Forms.TextBox();
            this.musteriTelefon_txt = new System.Windows.Forms.MaskedTextBox();
            this.musteriEkle_button = new System.Windows.Forms.Button();
            this.geriGit_button = new System.Windows.Forms.Button();
            this.cikis_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1348, 721);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Müşteri Adı :";
            // 
            // musteriAdi_txt
            // 
            this.musteriAdi_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriAdi_txt.Location = new System.Drawing.Point(465, 230);
            this.musteriAdi_txt.Multiline = true;
            this.musteriAdi_txt.Name = "musteriAdi_txt";
            this.musteriAdi_txt.Size = new System.Drawing.Size(465, 45);
            this.musteriAdi_txt.TabIndex = 16;
            this.musteriAdi_txt.WordWrap = false;
            this.musteriAdi_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.musteriAdi_txt_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 45);
            this.label2.TabIndex = 19;
            this.label2.Text = "Müşteri Soyadı :";
            // 
            // musteriSoyadi_txt
            // 
            this.musteriSoyadi_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriSoyadi_txt.Location = new System.Drawing.Point(465, 300);
            this.musteriSoyadi_txt.Multiline = true;
            this.musteriSoyadi_txt.Name = "musteriSoyadi_txt";
            this.musteriSoyadi_txt.Size = new System.Drawing.Size(465, 45);
            this.musteriSoyadi_txt.TabIndex = 18;
            this.musteriSoyadi_txt.WordWrap = false;
            this.musteriSoyadi_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.musteriSoyadi_txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 45);
            this.label3.TabIndex = 21;
            this.label3.Text = "Teefon Numarası :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(168, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 45);
            this.label4.TabIndex = 23;
            this.label4.Text = "Güncel Borç :";
            // 
            // musteriBorc_txt
            // 
            this.musteriBorc_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriBorc_txt.Location = new System.Drawing.Point(465, 440);
            this.musteriBorc_txt.Multiline = true;
            this.musteriBorc_txt.Name = "musteriBorc_txt";
            this.musteriBorc_txt.Size = new System.Drawing.Size(465, 45);
            this.musteriBorc_txt.TabIndex = 22;
            this.musteriBorc_txt.WordWrap = false;
            this.musteriBorc_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.musteriBorc_txt_KeyPress_1);
            // 
            // musteriTelefon_txt
            // 
            this.musteriTelefon_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriTelefon_txt.Location = new System.Drawing.Point(466, 370);
            this.musteriTelefon_txt.Mask = "(999) 000-0000";
            this.musteriTelefon_txt.Name = "musteriTelefon_txt";
            this.musteriTelefon_txt.Size = new System.Drawing.Size(465, 45);
            this.musteriTelefon_txt.TabIndex = 24;
            // 
            // musteriEkle_button
            // 
            this.musteriEkle_button.BackColor = System.Drawing.Color.White;
            this.musteriEkle_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.musteriEkle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriEkle_button.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriEkle_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.musteriEkle_button.Location = new System.Drawing.Point(595, 510);
            this.musteriEkle_button.Name = "musteriEkle_button";
            this.musteriEkle_button.Size = new System.Drawing.Size(186, 53);
            this.musteriEkle_button.TabIndex = 25;
            this.musteriEkle_button.Text = "Müşteri Ekle";
            this.musteriEkle_button.UseVisualStyleBackColor = false;
            this.musteriEkle_button.Click += new System.EventHandler(this.musteriEkle_button_Click);
            // 
            // geriGit_button
            // 
            this.geriGit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.geriGit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geriGit_button.BackgroundImage")));
            this.geriGit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geriGit_button.FlatAppearance.BorderSize = 0;
            this.geriGit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriGit_button.Location = new System.Drawing.Point(12, 12);
            this.geriGit_button.Name = "geriGit_button";
            this.geriGit_button.Size = new System.Drawing.Size(50, 50);
            this.geriGit_button.TabIndex = 27;
            this.geriGit_button.UseVisualStyleBackColor = false;
            this.geriGit_button.Click += new System.EventHandler(this.geriGit_button_Click);
            // 
            // cikis_button
            // 
            this.cikis_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.cikis_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikis_button.BackgroundImage")));
            this.cikis_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikis_button.FlatAppearance.BorderSize = 0;
            this.cikis_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis_button.Location = new System.Drawing.Point(1286, 12);
            this.cikis_button.Name = "cikis_button";
            this.cikis_button.Size = new System.Drawing.Size(50, 50);
            this.cikis_button.TabIndex = 26;
            this.cikis_button.UseVisualStyleBackColor = false;
            this.cikis_button.Click += new System.EventHandler(this.cikis_button_Click);
            // 
            // musteriEkle_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.geriGit_button);
            this.Controls.Add(this.cikis_button);
            this.Controls.Add(this.musteriEkle_button);
            this.Controls.Add(this.musteriTelefon_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.musteriBorc_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.musteriSoyadi_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.musteriAdi_txt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "musteriEkle_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "musteriEkle_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox musteriAdi_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox musteriSoyadi_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox musteriBorc_txt;
        private System.Windows.Forms.MaskedTextBox musteriTelefon_txt;
        private System.Windows.Forms.Button musteriEkle_button;
        private System.Windows.Forms.Button geriGit_button;
        private System.Windows.Forms.Button cikis_button;
    }
}
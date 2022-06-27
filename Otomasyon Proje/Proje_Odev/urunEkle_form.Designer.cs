namespace Proje_Odev
{
    partial class urunEkle_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunEkle_form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cikis_button = new System.Windows.Forms.Button();
            this.geriGit_button = new System.Windows.Forms.Button();
            this.kategori_cbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.turAdi_txt = new System.Windows.Forms.TextBox();
            this.turAdi_lbl = new System.Windows.Forms.Label();
            this.kilo_txt = new System.Windows.Forms.TextBox();
            this.kilo_lbl = new System.Windows.Forms.Label();
            this.alisFiyat_txt = new System.Windows.Forms.TextBox();
            this.alisFiyat_lbl = new System.Windows.Forms.Label();
            this.satisFiyat_lbl = new System.Windows.Forms.Label();
            this.satisFiyat_txt = new System.Windows.Forms.TextBox();
            this.urunEkle_button = new System.Windows.Forms.Button();
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
            this.cikis_button.TabIndex = 2;
            this.cikis_button.UseVisualStyleBackColor = false;
            this.cikis_button.Click += new System.EventHandler(this.cikis_button_Click);
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
            this.geriGit_button.TabIndex = 10;
            this.geriGit_button.UseVisualStyleBackColor = false;
            this.geriGit_button.Click += new System.EventHandler(this.geriGit_button_Click);
            // 
            // kategori_cbox
            // 
            this.kategori_cbox.DisplayMember = "Bir kategori seçiniz...";
            this.kategori_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategori_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategori_cbox.FormattingEnabled = true;
            this.kategori_cbox.Items.AddRange(new object[] {
            "MEYVE",
            "SEBZE"});
            this.kategori_cbox.Location = new System.Drawing.Point(448, 230);
            this.kategori_cbox.Name = "kategori_cbox";
            this.kategori_cbox.Size = new System.Drawing.Size(465, 46);
            this.kategori_cbox.TabIndex = 12;
            this.kategori_cbox.SelectedIndexChanged += new System.EventHandler(this.kategori_cbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kategori :";
            // 
            // turAdi_txt
            // 
            this.turAdi_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turAdi_txt.Location = new System.Drawing.Point(448, 300);
            this.turAdi_txt.Multiline = true;
            this.turAdi_txt.Name = "turAdi_txt";
            this.turAdi_txt.Size = new System.Drawing.Size(465, 45);
            this.turAdi_txt.TabIndex = 14;
            this.turAdi_txt.Visible = false;
            this.turAdi_txt.WordWrap = false;
            this.turAdi_txt.TextChanged += new System.EventHandler(this.turAdi_txt_TextChanged);
            // 
            // turAdi_lbl
            // 
            this.turAdi_lbl.AutoSize = true;
            this.turAdi_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.turAdi_lbl.Font = new System.Drawing.Font("Century Gothic", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turAdi_lbl.ForeColor = System.Drawing.Color.White;
            this.turAdi_lbl.Location = new System.Drawing.Point(72, 300);
            this.turAdi_lbl.Name = "turAdi_lbl";
            this.turAdi_lbl.Size = new System.Drawing.Size(363, 45);
            this.turAdi_lbl.TabIndex = 15;
            this.turAdi_lbl.Text = "Meyve Adı Giriniz :";
            this.turAdi_lbl.Visible = false;
            // 
            // kilo_txt
            // 
            this.kilo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kilo_txt.Location = new System.Drawing.Point(448, 370);
            this.kilo_txt.Multiline = true;
            this.kilo_txt.Name = "kilo_txt";
            this.kilo_txt.Size = new System.Drawing.Size(465, 45);
            this.kilo_txt.TabIndex = 16;
            this.kilo_txt.Visible = false;
            this.kilo_txt.WordWrap = false;
            this.kilo_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kilo_txt_KeyPress);
            // 
            // kilo_lbl
            // 
            this.kilo_lbl.AutoSize = true;
            this.kilo_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.kilo_lbl.Font = new System.Drawing.Font("Century Gothic", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kilo_lbl.ForeColor = System.Drawing.Color.White;
            this.kilo_lbl.Location = new System.Drawing.Point(242, 370);
            this.kilo_lbl.Name = "kilo_lbl";
            this.kilo_lbl.Size = new System.Drawing.Size(191, 45);
            this.kilo_lbl.TabIndex = 17;
            this.kilo_lbl.Text = "Kaç Kilo :";
            this.kilo_lbl.Visible = false;
            // 
            // alisFiyat_txt
            // 
            this.alisFiyat_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alisFiyat_txt.Location = new System.Drawing.Point(448, 440);
            this.alisFiyat_txt.Multiline = true;
            this.alisFiyat_txt.Name = "alisFiyat_txt";
            this.alisFiyat_txt.Size = new System.Drawing.Size(465, 45);
            this.alisFiyat_txt.TabIndex = 18;
            this.alisFiyat_txt.Visible = false;
            this.alisFiyat_txt.WordWrap = false;
            this.alisFiyat_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alisFiyat_txt_KeyPress);
            // 
            // alisFiyat_lbl
            // 
            this.alisFiyat_lbl.AutoSize = true;
            this.alisFiyat_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.alisFiyat_lbl.Font = new System.Drawing.Font("Century Gothic", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alisFiyat_lbl.ForeColor = System.Drawing.Color.White;
            this.alisFiyat_lbl.Location = new System.Drawing.Point(223, 440);
            this.alisFiyat_lbl.Name = "alisFiyat_lbl";
            this.alisFiyat_lbl.Size = new System.Drawing.Size(210, 45);
            this.alisFiyat_lbl.TabIndex = 19;
            this.alisFiyat_lbl.Text = "Alış Fiyatı :";
            this.alisFiyat_lbl.Visible = false;
            // 
            // satisFiyat_lbl
            // 
            this.satisFiyat_lbl.AutoSize = true;
            this.satisFiyat_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.satisFiyat_lbl.Font = new System.Drawing.Font("Century Gothic", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisFiyat_lbl.ForeColor = System.Drawing.Color.White;
            this.satisFiyat_lbl.Location = new System.Drawing.Point(200, 510);
            this.satisFiyat_lbl.Name = "satisFiyat_lbl";
            this.satisFiyat_lbl.Size = new System.Drawing.Size(233, 45);
            this.satisFiyat_lbl.TabIndex = 21;
            this.satisFiyat_lbl.Text = "Satış Fiyatı :";
            this.satisFiyat_lbl.Visible = false;
            // 
            // satisFiyat_txt
            // 
            this.satisFiyat_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisFiyat_txt.Location = new System.Drawing.Point(448, 510);
            this.satisFiyat_txt.Multiline = true;
            this.satisFiyat_txt.Name = "satisFiyat_txt";
            this.satisFiyat_txt.Size = new System.Drawing.Size(465, 45);
            this.satisFiyat_txt.TabIndex = 20;
            this.satisFiyat_txt.Visible = false;
            this.satisFiyat_txt.WordWrap = false;
            this.satisFiyat_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.satisFiyat_txt_KeyPress);
            // 
            // urunEkle_button
            // 
            this.urunEkle_button.BackColor = System.Drawing.Color.White;
            this.urunEkle_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.urunEkle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunEkle_button.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunEkle_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.urunEkle_button.Location = new System.Drawing.Point(595, 580);
            this.urunEkle_button.Name = "urunEkle_button";
            this.urunEkle_button.Size = new System.Drawing.Size(186, 53);
            this.urunEkle_button.TabIndex = 22;
            this.urunEkle_button.Text = "Ürünü Ekle";
            this.urunEkle_button.UseVisualStyleBackColor = false;
            this.urunEkle_button.Visible = false;
            this.urunEkle_button.Click += new System.EventHandler(this.urunEkle_button_Click);
            // 
            // urunEkle_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.urunEkle_button);
            this.Controls.Add(this.satisFiyat_lbl);
            this.Controls.Add(this.satisFiyat_txt);
            this.Controls.Add(this.alisFiyat_lbl);
            this.Controls.Add(this.alisFiyat_txt);
            this.Controls.Add(this.kilo_lbl);
            this.Controls.Add(this.kilo_txt);
            this.Controls.Add(this.turAdi_lbl);
            this.Controls.Add(this.turAdi_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kategori_cbox);
            this.Controls.Add(this.geriGit_button);
            this.Controls.Add(this.cikis_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "urunEkle_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urunEkle_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cikis_button;
        private System.Windows.Forms.Button geriGit_button;
        private System.Windows.Forms.ComboBox kategori_cbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox turAdi_txt;
        private System.Windows.Forms.Label turAdi_lbl;
        private System.Windows.Forms.TextBox kilo_txt;
        private System.Windows.Forms.Label kilo_lbl;
        private System.Windows.Forms.TextBox alisFiyat_txt;
        private System.Windows.Forms.Label alisFiyat_lbl;
        private System.Windows.Forms.Label satisFiyat_lbl;
        private System.Windows.Forms.TextBox satisFiyat_txt;
        private System.Windows.Forms.Button urunEkle_button;
    }
}
namespace Proje_Odev
{
    partial class urunleriGoster_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunleriGoster_form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunEkle_button = new System.Windows.Forms.Button();
            this.urunSil_button = new System.Windows.Forms.Button();
            this.urunGuncelle_button = new System.Windows.Forms.Button();
            this.urunArama_button = new System.Windows.Forms.Button();
            this.urunArama_txt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.geriGit_button = new System.Windows.Forms.Button();
            this.cikis_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.dataGridView1.Location = new System.Drawing.Point(263, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(830, 304);
            this.dataGridView1.TabIndex = 1;
            // 
            // urunEkle_button
            // 
            this.urunEkle_button.BackColor = System.Drawing.Color.White;
            this.urunEkle_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.urunEkle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunEkle_button.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunEkle_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.urunEkle_button.Location = new System.Drawing.Point(374, 571);
            this.urunEkle_button.Name = "urunEkle_button";
            this.urunEkle_button.Size = new System.Drawing.Size(186, 53);
            this.urunEkle_button.TabIndex = 24;
            this.urunEkle_button.Text = "Ürün Ekle";
            this.urunEkle_button.UseVisualStyleBackColor = false;
            this.urunEkle_button.Click += new System.EventHandler(this.urunEkle_button_Click);
            // 
            // urunSil_button
            // 
            this.urunSil_button.BackColor = System.Drawing.Color.White;
            this.urunSil_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.urunSil_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunSil_button.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunSil_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.urunSil_button.Location = new System.Drawing.Point(772, 571);
            this.urunSil_button.Name = "urunSil_button";
            this.urunSil_button.Size = new System.Drawing.Size(186, 53);
            this.urunSil_button.TabIndex = 25;
            this.urunSil_button.Text = "Ürün Sil";
            this.urunSil_button.UseVisualStyleBackColor = false;
            this.urunSil_button.Click += new System.EventHandler(this.urunSil_button_Click);
            // 
            // urunGuncelle_button
            // 
            this.urunGuncelle_button.BackColor = System.Drawing.Color.White;
            this.urunGuncelle_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.urunGuncelle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunGuncelle_button.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunGuncelle_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.urunGuncelle_button.Location = new System.Drawing.Point(566, 571);
            this.urunGuncelle_button.Name = "urunGuncelle_button";
            this.urunGuncelle_button.Size = new System.Drawing.Size(200, 53);
            this.urunGuncelle_button.TabIndex = 26;
            this.urunGuncelle_button.Text = "Ürün Güncelle";
            this.urunGuncelle_button.UseVisualStyleBackColor = false;
            this.urunGuncelle_button.Click += new System.EventHandler(this.urunGuncelle_button_Click);
            // 
            // urunArama_button
            // 
            this.urunArama_button.BackColor = System.Drawing.Color.White;
            this.urunArama_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.urunArama_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunArama_button.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunArama_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.urunArama_button.Location = new System.Drawing.Point(673, 178);
            this.urunArama_button.Name = "urunArama_button";
            this.urunArama_button.Size = new System.Drawing.Size(200, 45);
            this.urunArama_button.TabIndex = 27;
            this.urunArama_button.Text = "Ara";
            this.urunArama_button.UseVisualStyleBackColor = false;
            this.urunArama_button.Click += new System.EventHandler(this.urunArama_button_Click);
            // 
            // urunArama_txt
            // 
            this.urunArama_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.urunArama_txt.Location = new System.Drawing.Point(317, 178);
            this.urunArama_txt.Multiline = true;
            this.urunArama_txt.Name = "urunArama_txt";
            this.urunArama_txt.Size = new System.Drawing.Size(350, 45);
            this.urunArama_txt.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(263, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 45);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
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
            this.geriGit_button.TabIndex = 31;
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
            this.cikis_button.TabIndex = 30;
            this.cikis_button.UseVisualStyleBackColor = false;
            this.cikis_button.Click += new System.EventHandler(this.cikis_button_Click);
            // 
            // urunleriGoster_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.geriGit_button);
            this.Controls.Add(this.cikis_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.urunArama_txt);
            this.Controls.Add(this.urunArama_button);
            this.Controls.Add(this.urunGuncelle_button);
            this.Controls.Add(this.urunSil_button);
            this.Controls.Add(this.urunEkle_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "urunleriGoster_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urunleriGoster_form";
            this.Load += new System.EventHandler(this.urunleriGoster_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button urunEkle_button;
        private System.Windows.Forms.Button urunSil_button;
        private System.Windows.Forms.Button urunGuncelle_button;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button urunArama_button;
        private System.Windows.Forms.TextBox urunArama_txt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button geriGit_button;
        private System.Windows.Forms.Button cikis_button;
    }
}
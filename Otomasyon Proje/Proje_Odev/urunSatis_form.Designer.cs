namespace Proje_Odev
{
    partial class urunSatis_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunSatis_form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uyeKayitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.urunArama_txt = new System.Windows.Forms.TextBox();
            this.urunArama_button = new System.Windows.Forms.Button();
            this.kilo_txt = new System.Windows.Forms.TextBox();
            this.kiloLbl = new System.Windows.Forms.Label();
            this.ekleButton = new System.Windows.Forms.Button();
            this.toplamFiyat_lbl = new System.Windows.Forms.Label();
            this.toplamFiyat_lbl2 = new System.Windows.Forms.Label();
            this.satıs_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toplam_satis = new System.Windows.Forms.Label();
            this.geriGit_button = new System.Windows.Forms.Button();
            this.cikis_button = new System.Windows.Forms.Button();
            this.dtpSales = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeKayitDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // uyeKayitDataSet
            // 
           
            // 
            // uyeKayitDataSetBindingSource
            // 
            this.uyeKayitDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(141)))), ((int)(((byte)(20)))));
            this.dataGridView1.Location = new System.Drawing.Point(45, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(705, 304);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(141)))), ((int)(((byte)(20)))));
            this.dataGridView2.Location = new System.Drawing.Point(756, 199);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(552, 304);
            this.dataGridView2.TabIndex = 2;
            // 
            // urunArama_txt
            // 
            this.urunArama_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.urunArama_txt.Location = new System.Drawing.Point(99, 148);
            this.urunArama_txt.Multiline = true;
            this.urunArama_txt.Name = "urunArama_txt";
            this.urunArama_txt.Size = new System.Drawing.Size(350, 45);
            this.urunArama_txt.TabIndex = 30;
            this.urunArama_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urunArama_txt_KeyPress);
            // 
            // urunArama_button
            // 
            this.urunArama_button.BackColor = System.Drawing.Color.White;
            this.urunArama_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.urunArama_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunArama_button.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunArama_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(141)))), ((int)(((byte)(20)))));
            this.urunArama_button.Location = new System.Drawing.Point(455, 148);
            this.urunArama_button.Name = "urunArama_button";
            this.urunArama_button.Size = new System.Drawing.Size(200, 45);
            this.urunArama_button.TabIndex = 29;
            this.urunArama_button.Text = "Ara";
            this.urunArama_button.UseVisualStyleBackColor = false;
            this.urunArama_button.Click += new System.EventHandler(this.urunArama_button_Click);
            // 
            // kilo_txt
            // 
            this.kilo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.kilo_txt.Location = new System.Drawing.Point(339, 516);
            this.kilo_txt.Multiline = true;
            this.kilo_txt.Name = "kilo_txt";
            this.kilo_txt.Size = new System.Drawing.Size(219, 45);
            this.kilo_txt.TabIndex = 31;
            this.kilo_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kilo_txt_KeyPress);
            // 
            // kiloLbl
            // 
            this.kiloLbl.AutoSize = true;
            this.kiloLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(141)))), ((int)(((byte)(20)))));
            this.kiloLbl.Font = new System.Drawing.Font("Century Gothic", 22.8F);
            this.kiloLbl.ForeColor = System.Drawing.Color.White;
            this.kiloLbl.Location = new System.Drawing.Point(37, 515);
            this.kiloLbl.Name = "kiloLbl";
            this.kiloLbl.Size = new System.Drawing.Size(280, 45);
            this.kiloLbl.TabIndex = 32;
            this.kiloLbl.Text = "Satılacak Kilo:";
            // 
            // ekleButton
            // 
            this.ekleButton.BackColor = System.Drawing.Color.White;
            this.ekleButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ekleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleButton.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.ekleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(141)))), ((int)(((byte)(20)))));
            this.ekleButton.Location = new System.Drawing.Point(564, 516);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(186, 45);
            this.ekleButton.TabIndex = 33;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.UseVisualStyleBackColor = false;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // toplamFiyat_lbl
            // 
            this.toplamFiyat_lbl.AutoSize = true;
            this.toplamFiyat_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(141)))), ((int)(((byte)(20)))));
            this.toplamFiyat_lbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamFiyat_lbl.ForeColor = System.Drawing.Color.White;
            this.toplamFiyat_lbl.Location = new System.Drawing.Point(334, 568);
            this.toplamFiyat_lbl.Name = "toplamFiyat_lbl";
            this.toplamFiyat_lbl.Size = new System.Drawing.Size(171, 30);
            this.toplamFiyat_lbl.TabIndex = 35;
            this.toplamFiyat_lbl.Text = "Toplam Fiyat:";
            // 
            // toplamFiyat_lbl2
            // 
            this.toplamFiyat_lbl2.AutoSize = true;
            this.toplamFiyat_lbl2.Location = new System.Drawing.Point(1109, 568);
            this.toplamFiyat_lbl2.Name = "toplamFiyat_lbl2";
            this.toplamFiyat_lbl2.Size = new System.Drawing.Size(0, 17);
            this.toplamFiyat_lbl2.TabIndex = 36;
            // 
            // satıs_button
            // 
            this.satıs_button.BackColor = System.Drawing.Color.White;
            this.satıs_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.satıs_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satıs_button.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.satıs_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(141)))), ((int)(((byte)(20)))));
            this.satıs_button.Location = new System.Drawing.Point(957, 515);
            this.satıs_button.Name = "satıs_button";
            this.satıs_button.Size = new System.Drawing.Size(186, 45);
            this.satıs_button.TabIndex = 37;
            this.satıs_button.Text = "SAT";
            this.satıs_button.UseVisualStyleBackColor = false;
            this.satıs_button.Click += new System.EventHandler(this.satıs_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(45, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 45);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // toplam_satis
            // 
            this.toplam_satis.AutoSize = true;
            this.toplam_satis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(141)))), ((int)(((byte)(20)))));
            this.toplam_satis.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplam_satis.ForeColor = System.Drawing.Color.White;
            this.toplam_satis.Location = new System.Drawing.Point(501, 570);
            this.toplam_satis.Name = "toplam_satis";
            this.toplam_satis.Size = new System.Drawing.Size(0, 30);
            this.toplam_satis.TabIndex = 40;
            // 
            // geriGit_button
            // 
            this.geriGit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(141)))), ((int)(((byte)(20)))));
            this.geriGit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geriGit_button.BackgroundImage")));
            this.geriGit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geriGit_button.FlatAppearance.BorderSize = 0;
            this.geriGit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriGit_button.Location = new System.Drawing.Point(12, 12);
            this.geriGit_button.Name = "geriGit_button";
            this.geriGit_button.Size = new System.Drawing.Size(50, 50);
            this.geriGit_button.TabIndex = 42;
            this.geriGit_button.UseVisualStyleBackColor = false;
            this.geriGit_button.Click += new System.EventHandler(this.geriGit_button_Click);
            // 
            // cikis_button
            // 
            this.cikis_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(141)))), ((int)(((byte)(20)))));
            this.cikis_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikis_button.BackgroundImage")));
            this.cikis_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikis_button.FlatAppearance.BorderSize = 0;
            this.cikis_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis_button.Location = new System.Drawing.Point(1286, 12);
            this.cikis_button.Name = "cikis_button";
            this.cikis_button.Size = new System.Drawing.Size(50, 50);
            this.cikis_button.TabIndex = 41;
            this.cikis_button.UseVisualStyleBackColor = false;
            this.cikis_button.Click += new System.EventHandler(this.cikis_button_Click);
            // 
            // dtpSales
            // 
            this.dtpSales.Location = new System.Drawing.Point(1018, 134);
            this.dtpSales.Name = "dtpSales";
            this.dtpSales.Size = new System.Drawing.Size(215, 22);
            this.dtpSales.TabIndex = 45;
            this.dtpSales.ValueChanged += new System.EventHandler(this.dtpSales_ValueChanged);
            // 
            // urunSatis_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.dtpSales);
            this.Controls.Add(this.geriGit_button);
            this.Controls.Add(this.cikis_button);
            this.Controls.Add(this.toplam_satis);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.satıs_button);
            this.Controls.Add(this.toplamFiyat_lbl2);
            this.Controls.Add(this.toplamFiyat_lbl);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.kiloLbl);
            this.Controls.Add(this.kilo_txt);
            this.Controls.Add(this.urunArama_txt);
            this.Controls.Add(this.urunArama_button);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "urunSatis_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urunSatis_form";
            this.Load += new System.EventHandler(this.urunSatis_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeKayitDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource uyeKayitDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox urunArama_txt;
        private System.Windows.Forms.Button urunArama_button;
        private System.Windows.Forms.TextBox kilo_txt;
        private System.Windows.Forms.Label kiloLbl;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Label toplamFiyat_lbl;
        private System.Windows.Forms.Label toplamFiyat_lbl2;
        private System.Windows.Forms.Button satıs_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label toplam_satis;
        private System.Windows.Forms.Button geriGit_button;
        private System.Windows.Forms.Button cikis_button;
        private System.Windows.Forms.DateTimePicker dtpSales;
    }
}
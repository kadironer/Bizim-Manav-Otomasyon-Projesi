namespace Proje_Odev
{
    partial class anaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaSayfa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.girisYap_button = new System.Windows.Forms.Button();
            this.kayitOl_button = new System.Windows.Forms.Button();
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
            // girisYap_button
            // 
            this.girisYap_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(50)))), ((int)(((byte)(130)))));
            this.girisYap_button.FlatAppearance.BorderSize = 0;
            this.girisYap_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisYap_button.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYap_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(196)))), ((int)(((byte)(20)))));
            this.girisYap_button.Location = new System.Drawing.Point(254, 333);
            this.girisYap_button.Name = "girisYap_button";
            this.girisYap_button.Size = new System.Drawing.Size(355, 78);
            this.girisYap_button.TabIndex = 1;
            this.girisYap_button.Text = "Giriş Yap";
            this.girisYap_button.UseVisualStyleBackColor = false;
            this.girisYap_button.Click += new System.EventHandler(this.girisYap_button_Click);
            // 
            // kayitOl_button
            // 
            this.kayitOl_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(141)))), ((int)(((byte)(20)))));
            this.kayitOl_button.FlatAppearance.BorderSize = 0;
            this.kayitOl_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitOl_button.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitOl_button.ForeColor = System.Drawing.Color.White;
            this.kayitOl_button.Location = new System.Drawing.Point(254, 474);
            this.kayitOl_button.Name = "kayitOl_button";
            this.kayitOl_button.Size = new System.Drawing.Size(355, 78);
            this.kayitOl_button.TabIndex = 2;
            this.kayitOl_button.Text = "Kayıt Ol";
            this.kayitOl_button.UseVisualStyleBackColor = false;
            this.kayitOl_button.Click += new System.EventHandler(this.kayitOl_button_Click);
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
            this.cikis_button.TabIndex = 3;
            this.cikis_button.UseVisualStyleBackColor = false;
            this.cikis_button.Click += new System.EventHandler(this.cikis_button_Click);
            // 
            // anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.cikis_button);
            this.Controls.Add(this.kayitOl_button);
            this.Controls.Add(this.girisYap_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "anaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button girisYap_button;
        private System.Windows.Forms.Button kayitOl_button;
        private System.Windows.Forms.Button cikis_button;
    }
}


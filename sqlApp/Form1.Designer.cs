
namespace sqlApp
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
            this.label_Ad = new System.Windows.Forms.Label();
            this.label_soyad = new System.Windows.Forms.Label();
            this.label_numara = new System.Windows.Forms.Label();
            this.textbox_ad = new System.Windows.Forms.TextBox();
            this.textbox_soyad = new System.Windows.Forms.TextBox();
            this.textbox_numara = new System.Windows.Forms.TextBox();
            this.buton_kaydet = new System.Windows.Forms.Button();
            this.buton_aramafrm = new System.Windows.Forms.Button();
            this.buton_update = new System.Windows.Forms.Button();
            this.buton_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Ad
            // 
            this.label_Ad.AutoSize = true;
            this.label_Ad.Location = new System.Drawing.Point(176, 100);
            this.label_Ad.Name = "label_Ad";
            this.label_Ad.Size = new System.Drawing.Size(38, 13);
            this.label_Ad.TabIndex = 0;
            this.label_Ad.Text = "Adınız:";
            // 
            // label_soyad
            // 
            this.label_soyad.AutoSize = true;
            this.label_soyad.Location = new System.Drawing.Point(176, 132);
            this.label_soyad.Name = "label_soyad";
            this.label_soyad.Size = new System.Drawing.Size(55, 13);
            this.label_soyad.TabIndex = 1;
            this.label_soyad.Text = "Soyadınız:";
            // 
            // label_numara
            // 
            this.label_numara.AutoSize = true;
            this.label_numara.Location = new System.Drawing.Point(176, 164);
            this.label_numara.Name = "label_numara";
            this.label_numara.Size = new System.Drawing.Size(60, 13);
            this.label_numara.TabIndex = 2;
            this.label_numara.Text = "Numaranız:";
            // 
            // textbox_ad
            // 
            this.textbox_ad.Location = new System.Drawing.Point(249, 93);
            this.textbox_ad.MaxLength = 50;
            this.textbox_ad.Name = "textbox_ad";
            this.textbox_ad.Size = new System.Drawing.Size(100, 20);
            this.textbox_ad.TabIndex = 3;
            // 
            // textbox_soyad
            // 
            this.textbox_soyad.Location = new System.Drawing.Point(249, 125);
            this.textbox_soyad.MaxLength = 75;
            this.textbox_soyad.Name = "textbox_soyad";
            this.textbox_soyad.Size = new System.Drawing.Size(100, 20);
            this.textbox_soyad.TabIndex = 4;
            // 
            // textbox_numara
            // 
            this.textbox_numara.Location = new System.Drawing.Point(249, 157);
            this.textbox_numara.MaxLength = 10;
            this.textbox_numara.Name = "textbox_numara";
            this.textbox_numara.Size = new System.Drawing.Size(100, 20);
            this.textbox_numara.TabIndex = 5;
            // 
            // buton_kaydet
            // 
            this.buton_kaydet.Location = new System.Drawing.Point(225, 196);
            this.buton_kaydet.Name = "buton_kaydet";
            this.buton_kaydet.Size = new System.Drawing.Size(75, 23);
            this.buton_kaydet.TabIndex = 6;
            this.buton_kaydet.Text = "kaydet";
            this.buton_kaydet.UseVisualStyleBackColor = true;
            this.buton_kaydet.Click += new System.EventHandler(this.buton_kaydet_Click);
            // 
            // buton_aramafrm
            // 
            this.buton_aramafrm.Location = new System.Drawing.Point(297, 255);
            this.buton_aramafrm.Name = "buton_aramafrm";
            this.buton_aramafrm.Size = new System.Drawing.Size(75, 58);
            this.buton_aramafrm.TabIndex = 7;
            this.buton_aramafrm.Text = "Arama Formu Git";
            this.buton_aramafrm.UseVisualStyleBackColor = true;
            this.buton_aramafrm.Click += new System.EventHandler(this.buton_aramafrm_Click);
            // 
            // buton_update
            // 
            this.buton_update.Location = new System.Drawing.Point(205, 255);
            this.buton_update.Name = "buton_update";
            this.buton_update.Size = new System.Drawing.Size(75, 58);
            this.buton_update.TabIndex = 8;
            this.buton_update.Text = "Güncelle";
            this.buton_update.UseVisualStyleBackColor = true;
            this.buton_update.Click += new System.EventHandler(this.buton_update_Click);
            // 
            // buton_sil
            // 
            this.buton_sil.Location = new System.Drawing.Point(400, 255);
            this.buton_sil.Name = "buton_sil";
            this.buton_sil.Size = new System.Drawing.Size(75, 58);
            this.buton_sil.TabIndex = 9;
            this.buton_sil.Text = "Sil";
            this.buton_sil.UseVisualStyleBackColor = true;
            this.buton_sil.Click += new System.EventHandler(this.buton_sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 361);
            this.Controls.Add(this.buton_sil);
            this.Controls.Add(this.buton_update);
            this.Controls.Add(this.buton_aramafrm);
            this.Controls.Add(this.buton_kaydet);
            this.Controls.Add(this.textbox_numara);
            this.Controls.Add(this.textbox_soyad);
            this.Controls.Add(this.textbox_ad);
            this.Controls.Add(this.label_numara);
            this.Controls.Add(this.label_soyad);
            this.Controls.Add(this.label_Ad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Ad;
        private System.Windows.Forms.Label label_soyad;
        private System.Windows.Forms.Label label_numara;
        private System.Windows.Forms.Button buton_kaydet;
        private System.Windows.Forms.Button buton_aramafrm;
        public System.Windows.Forms.TextBox textbox_ad;
        public System.Windows.Forms.TextBox textbox_soyad;
        public System.Windows.Forms.TextBox textbox_numara;
        private System.Windows.Forms.Button buton_update;
        private System.Windows.Forms.Button buton_sil;
    }
}


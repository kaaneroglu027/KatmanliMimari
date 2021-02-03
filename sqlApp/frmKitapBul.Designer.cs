
namespace sqlApp
{
    partial class frmKitapBul
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_ogrencino = new System.Windows.Forms.Label();
            this.textbox_ogrencino = new System.Windows.Forms.TextBox();
            this.buton_ogrencibul = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buton_ogrencibul);
            this.groupBox1.Controls.Add(this.textbox_ogrencino);
            this.groupBox1.Controls.Add(this.label_ogrencino);
            this.groupBox1.Location = new System.Drawing.Point(35, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogrenci Arama Ekranı";
            // 
            // label_ogrencino
            // 
            this.label_ogrencino.AutoSize = true;
            this.label_ogrencino.Location = new System.Drawing.Point(23, 72);
            this.label_ogrencino.Name = "label_ogrencino";
            this.label_ogrencino.Size = new System.Drawing.Size(95, 13);
            this.label_ogrencino.TabIndex = 0;
            this.label_ogrencino.Text = "Ögrenci No Giriniz:";
            // 
            // textbox_ogrencino
            // 
            this.textbox_ogrencino.Location = new System.Drawing.Point(141, 69);
            this.textbox_ogrencino.Name = "textbox_ogrencino";
            this.textbox_ogrencino.Size = new System.Drawing.Size(100, 20);
            this.textbox_ogrencino.TabIndex = 1;
            // 
            // buton_ogrencibul
            // 
            this.buton_ogrencibul.Location = new System.Drawing.Point(104, 119);
            this.buton_ogrencibul.Name = "buton_ogrencibul";
            this.buton_ogrencibul.Size = new System.Drawing.Size(75, 23);
            this.buton_ogrencibul.TabIndex = 2;
            this.buton_ogrencibul.Text = "Ara";
            this.buton_ogrencibul.UseVisualStyleBackColor = true;
            this.buton_ogrencibul.Click += new System.EventHandler(this.buton_ogrencibul_Click);
            // 
            // frmOgrenciBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 287);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgrenciBul";
            this.Text = "frmOgrenciBul";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buton_ogrencibul;
        private System.Windows.Forms.TextBox textbox_ogrencino;
        private System.Windows.Forms.Label label_ogrencino;
    }
}
namespace XML_Serialization_Deserialization
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
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.saveFileOgrenci = new System.Windows.Forms.SaveFileDialog();
            this.openFileXml = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIc = new System.Windows.Forms.Button();
            this.btnDis = new System.Windows.Forms.Button();
            this.lstBoxOgrenci = new System.Windows.Forms.ListBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(135, 136);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpDogumTarihi.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(135, 40);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 1;
            // 
            // openFileXml
            // 
            this.openFileXml.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Doğum Tarihi";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(37, 206);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 33);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIc
            // 
            this.btnIc.Location = new System.Drawing.Point(283, 298);
            this.btnIc.Name = "btnIc";
            this.btnIc.Size = new System.Drawing.Size(113, 68);
            this.btnIc.TabIndex = 4;
            this.btnIc.Text = "İçe Aktar (Deserialization)";
            this.btnIc.UseVisualStyleBackColor = true;
            this.btnIc.Click += new System.EventHandler(this.btnIc_Click);
            // 
            // btnDis
            // 
            this.btnDis.Location = new System.Drawing.Point(283, 206);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(113, 64);
            this.btnDis.TabIndex = 4;
            this.btnDis.Text = "Dışa Aktar (Serialization)";
            this.btnDis.UseVisualStyleBackColor = true;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // lstBoxOgrenci
            // 
            this.lstBoxOgrenci.FormattingEnabled = true;
            this.lstBoxOgrenci.Location = new System.Drawing.Point(436, 24);
            this.lstBoxOgrenci.Name = "lstBoxOgrenci";
            this.lstBoxOgrenci.Size = new System.Drawing.Size(264, 342);
            this.lstBoxOgrenci.TabIndex = 5;
            this.lstBoxOgrenci.SelectedIndexChanged += new System.EventHandler(this.lstBoxOgrenci_SelectedIndexChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(135, 88);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 448);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lstBoxOgrenci);
            this.Controls.Add(this.btnDis);
            this.Controls.Add(this.btnIc);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.SaveFileDialog saveFileOgrenci;
        private System.Windows.Forms.OpenFileDialog openFileXml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIc;
        private System.Windows.Forms.Button btnDis;
        private System.Windows.Forms.ListBox lstBoxOgrenci;
        private System.Windows.Forms.TextBox txtSoyad;
    }
}


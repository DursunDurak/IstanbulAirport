namespace IstanbulAirport
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.txtBox_günlükkalkan_ucaksayisi_min = new System.Windows.Forms.TextBox();
            this.lbl_günlükkalkan_ucaksayisi = new System.Windows.Forms.Label();
            this.lbl_günlükinen_ucaksayisi_örn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_kötühava_kalkisiptal = new System.Windows.Forms.Label();
            this.lbl_kötühava_inisiptal = new System.Windows.Forms.Label();
            this.lbl_aydakigünsayisi = new System.Windows.Forms.Label();
            this.lbl_aylikkalkan_ucaksayisi = new System.Windows.Forms.Label();
            this.lbl_aylikinen_ucaksayisi = new System.Windows.Forms.Label();
            this.txtBox_günlükinen_ucaksayisi_min = new System.Windows.Forms.TextBox();
            this.txtBox_günlükkalkan_ucaksayisi_max = new System.Windows.Forms.TextBox();
            this.txtBox_günlükinen_ucaksayisi_max = new System.Windows.Forms.TextBox();
            this.lbl_kötühava_olmasansi = new System.Windows.Forms.Label();
            this.lbl_günlükkalkan_ucaksayisi_örn = new System.Windows.Forms.Label();
            this.lbl_kötühava_olmasansi_orani = new System.Windows.Forms.Label();
            this.lbl_kötühava_kalkisiptal_örn = new System.Windows.Forms.Label();
            this.lbl_kötühava_inisiptal_örn = new System.Windows.Forms.Label();
            this.txtBox_kötühava_kalkisiptal_orani = new System.Windows.Forms.TextBox();
            this.txtBox_kötühava_inisiptal_orani = new System.Windows.Forms.TextBox();
            this.txtBox_aydakigünsayisi = new System.Windows.Forms.TextBox();
            this.txtBox_kötühava_olmaorani = new System.Windows.Forms.TextBox();
            this.lbl_aydakigünsayisi_örn = new System.Windows.Forms.Label();
            this.lbl_aylikkalkan_ucaksayisi_tahmini = new System.Windows.Forms.Label();
            this.lbl_aylikinen_ucaksayisi_tahmini = new System.Windows.Forms.Label();
            this.lbl_günlükkalkan_ucaksayisi_belirlenen = new System.Windows.Forms.Label();
            this.lbl_günlükinen_ucaksayisi_belirlenen = new System.Windows.Forms.Label();
            this.lbl_günlükinen_ucaksayisi_gerceklesen = new System.Windows.Forms.Label();
            this.lbl_günlükkalkan_ucaksayisi_gerceklesen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(38, 397);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(318, 95);
            this.btn_hesapla.TabIndex = 0;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // txtBox_günlükkalkan_ucaksayisi_min
            // 
            this.txtBox_günlükkalkan_ucaksayisi_min.Location = new System.Drawing.Point(294, 40);
            this.txtBox_günlükkalkan_ucaksayisi_min.Name = "txtBox_günlükkalkan_ucaksayisi_min";
            this.txtBox_günlükkalkan_ucaksayisi_min.Size = new System.Drawing.Size(100, 22);
            this.txtBox_günlükkalkan_ucaksayisi_min.TabIndex = 1;
            // 
            // lbl_günlükkalkan_ucaksayisi
            // 
            this.lbl_günlükkalkan_ucaksayisi.AutoSize = true;
            this.lbl_günlükkalkan_ucaksayisi.Location = new System.Drawing.Point(13, 40);
            this.lbl_günlükkalkan_ucaksayisi.Name = "lbl_günlükkalkan_ucaksayisi";
            this.lbl_günlükkalkan_ucaksayisi.Size = new System.Drawing.Size(262, 16);
            this.lbl_günlükkalkan_ucaksayisi.TabIndex = 2;
            this.lbl_günlükkalkan_ucaksayisi.Text = "Günlük Tahmini Kalkan Uçak Sayısı Aralığı:";
            // 
            // lbl_günlükinen_ucaksayisi_örn
            // 
            this.lbl_günlükinen_ucaksayisi_örn.AutoSize = true;
            this.lbl_günlükinen_ucaksayisi_örn.Location = new System.Drawing.Point(531, 95);
            this.lbl_günlükinen_ucaksayisi_örn.Name = "lbl_günlükinen_ucaksayisi_örn";
            this.lbl_günlükinen_ucaksayisi_örn.Size = new System.Drawing.Size(77, 16);
            this.lbl_günlükinen_ucaksayisi_örn.TabIndex = 3;
            this.lbl_günlükinen_ucaksayisi_örn.Text = "(Örn: 50-70 )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Günlük Tahmini İnen Uçak Sayısı Aralığı:";
            // 
            // lbl_kötühava_kalkisiptal
            // 
            this.lbl_kötühava_kalkisiptal.AutoSize = true;
            this.lbl_kötühava_kalkisiptal.Location = new System.Drawing.Point(12, 152);
            this.lbl_kötühava_kalkisiptal.Name = "lbl_kötühava_kalkisiptal";
            this.lbl_kötühava_kalkisiptal.Size = new System.Drawing.Size(221, 16);
            this.lbl_kötühava_kalkisiptal.TabIndex = 5;
            this.lbl_kötühava_kalkisiptal.Text = "Kötü Hava Nedeni Kalkış İptal Oranı:";
            // 
            // lbl_kötühava_inisiptal
            // 
            this.lbl_kötühava_inisiptal.AutoSize = true;
            this.lbl_kötühava_inisiptal.Location = new System.Drawing.Point(12, 206);
            this.lbl_kötühava_inisiptal.Name = "lbl_kötühava_inisiptal";
            this.lbl_kötühava_inisiptal.Size = new System.Drawing.Size(205, 16);
            this.lbl_kötühava_inisiptal.TabIndex = 6;
            this.lbl_kötühava_inisiptal.Text = "Kötü Hava Nedeni İniş İptal Oranı:";
            // 
            // lbl_aydakigünsayisi
            // 
            this.lbl_aydakigünsayisi.AutoSize = true;
            this.lbl_aydakigünsayisi.Location = new System.Drawing.Point(12, 306);
            this.lbl_aydakigünsayisi.Name = "lbl_aydakigünsayisi";
            this.lbl_aydakigünsayisi.Size = new System.Drawing.Size(119, 16);
            this.lbl_aydakigünsayisi.TabIndex = 7;
            this.lbl_aydakigünsayisi.Text = "Aydaki Gün Sayısı:";
            // 
            // lbl_aylikkalkan_ucaksayisi
            // 
            this.lbl_aylikkalkan_ucaksayisi.AutoSize = true;
            this.lbl_aylikkalkan_ucaksayisi.Location = new System.Drawing.Point(501, 397);
            this.lbl_aylikkalkan_ucaksayisi.Name = "lbl_aylikkalkan_ucaksayisi";
            this.lbl_aylikkalkan_ucaksayisi.Size = new System.Drawing.Size(209, 16);
            this.lbl_aylikkalkan_ucaksayisi.TabIndex = 8;
            this.lbl_aylikkalkan_ucaksayisi.Text = "Aylık Kalkan Uçan Sayısı Tahmini:";
            // 
            // lbl_aylikinen_ucaksayisi
            // 
            this.lbl_aylikinen_ucaksayisi.AutoSize = true;
            this.lbl_aylikinen_ucaksayisi.Location = new System.Drawing.Point(501, 462);
            this.lbl_aylikinen_ucaksayisi.Name = "lbl_aylikinen_ucaksayisi";
            this.lbl_aylikinen_ucaksayisi.Size = new System.Drawing.Size(193, 16);
            this.lbl_aylikinen_ucaksayisi.TabIndex = 9;
            this.lbl_aylikinen_ucaksayisi.Text = "Aylık İnen Uçan Sayısı Tahmini:";
            // 
            // txtBox_günlükinen_ucaksayisi_min
            // 
            this.txtBox_günlükinen_ucaksayisi_min.Location = new System.Drawing.Point(294, 95);
            this.txtBox_günlükinen_ucaksayisi_min.Name = "txtBox_günlükinen_ucaksayisi_min";
            this.txtBox_günlükinen_ucaksayisi_min.Size = new System.Drawing.Size(100, 22);
            this.txtBox_günlükinen_ucaksayisi_min.TabIndex = 10;
            // 
            // txtBox_günlükkalkan_ucaksayisi_max
            // 
            this.txtBox_günlükkalkan_ucaksayisi_max.Location = new System.Drawing.Point(413, 37);
            this.txtBox_günlükkalkan_ucaksayisi_max.Name = "txtBox_günlükkalkan_ucaksayisi_max";
            this.txtBox_günlükkalkan_ucaksayisi_max.Size = new System.Drawing.Size(100, 22);
            this.txtBox_günlükkalkan_ucaksayisi_max.TabIndex = 11;
            // 
            // txtBox_günlükinen_ucaksayisi_max
            // 
            this.txtBox_günlükinen_ucaksayisi_max.Location = new System.Drawing.Point(413, 95);
            this.txtBox_günlükinen_ucaksayisi_max.Name = "txtBox_günlükinen_ucaksayisi_max";
            this.txtBox_günlükinen_ucaksayisi_max.Size = new System.Drawing.Size(100, 22);
            this.txtBox_günlükinen_ucaksayisi_max.TabIndex = 12;
            // 
            // lbl_kötühava_olmasansi
            // 
            this.lbl_kötühava_olmasansi.AutoSize = true;
            this.lbl_kötühava_olmasansi.Location = new System.Drawing.Point(12, 252);
            this.lbl_kötühava_olmasansi.Name = "lbl_kötühava_olmasansi";
            this.lbl_kötühava_olmasansi.Size = new System.Drawing.Size(241, 16);
            this.lbl_kötühava_olmasansi.TabIndex = 13;
            this.lbl_kötühava_olmasansi.Text = "Günlük Kötü Hava Olma Şans Oranı:   %";
            // 
            // lbl_günlükkalkan_ucaksayisi_örn
            // 
            this.lbl_günlükkalkan_ucaksayisi_örn.AutoSize = true;
            this.lbl_günlükkalkan_ucaksayisi_örn.Location = new System.Drawing.Point(531, 40);
            this.lbl_günlükkalkan_ucaksayisi_örn.Name = "lbl_günlükkalkan_ucaksayisi_örn";
            this.lbl_günlükkalkan_ucaksayisi_örn.Size = new System.Drawing.Size(77, 16);
            this.lbl_günlükkalkan_ucaksayisi_örn.TabIndex = 14;
            this.lbl_günlükkalkan_ucaksayisi_örn.Text = "(Örn: 50-70 )";
            // 
            // lbl_kötühava_olmasansi_orani
            // 
            this.lbl_kötühava_olmasansi_orani.AutoSize = true;
            this.lbl_kötühava_olmasansi_orani.Location = new System.Drawing.Point(429, 249);
            this.lbl_kötühava_olmasansi_orani.Name = "lbl_kötühava_olmasansi_orani";
            this.lbl_kötühava_olmasansi_orani.Size = new System.Drawing.Size(59, 16);
            this.lbl_kötühava_olmasansi_orani.TabIndex = 15;
            this.lbl_kötühava_olmasansi_orani.Text = "(Örn: 30 )";
            // 
            // lbl_kötühava_kalkisiptal_örn
            // 
            this.lbl_kötühava_kalkisiptal_örn.AutoSize = true;
            this.lbl_kötühava_kalkisiptal_örn.Location = new System.Drawing.Point(429, 152);
            this.lbl_kötühava_kalkisiptal_örn.Name = "lbl_kötühava_kalkisiptal_örn";
            this.lbl_kötühava_kalkisiptal_örn.Size = new System.Drawing.Size(59, 16);
            this.lbl_kötühava_kalkisiptal_örn.TabIndex = 15;
            this.lbl_kötühava_kalkisiptal_örn.Text = "(Örn: 60 )";
            // 
            // lbl_kötühava_inisiptal_örn
            // 
            this.lbl_kötühava_inisiptal_örn.AutoSize = true;
            this.lbl_kötühava_inisiptal_örn.Location = new System.Drawing.Point(429, 206);
            this.lbl_kötühava_inisiptal_örn.Name = "lbl_kötühava_inisiptal_örn";
            this.lbl_kötühava_inisiptal_örn.Size = new System.Drawing.Size(59, 16);
            this.lbl_kötühava_inisiptal_örn.TabIndex = 16;
            this.lbl_kötühava_inisiptal_örn.Text = "(Örn: 40 )";
            // 
            // txtBox_kötühava_kalkisiptal_orani
            // 
            this.txtBox_kötühava_kalkisiptal_orani.Location = new System.Drawing.Point(294, 146);
            this.txtBox_kötühava_kalkisiptal_orani.Name = "txtBox_kötühava_kalkisiptal_orani";
            this.txtBox_kötühava_kalkisiptal_orani.Size = new System.Drawing.Size(100, 22);
            this.txtBox_kötühava_kalkisiptal_orani.TabIndex = 17;
            // 
            // txtBox_kötühava_inisiptal_orani
            // 
            this.txtBox_kötühava_inisiptal_orani.Location = new System.Drawing.Point(294, 203);
            this.txtBox_kötühava_inisiptal_orani.Name = "txtBox_kötühava_inisiptal_orani";
            this.txtBox_kötühava_inisiptal_orani.Size = new System.Drawing.Size(100, 22);
            this.txtBox_kötühava_inisiptal_orani.TabIndex = 18;
            // 
            // txtBox_aydakigünsayisi
            // 
            this.txtBox_aydakigünsayisi.Location = new System.Drawing.Point(294, 300);
            this.txtBox_aydakigünsayisi.Name = "txtBox_aydakigünsayisi";
            this.txtBox_aydakigünsayisi.Size = new System.Drawing.Size(100, 22);
            this.txtBox_aydakigünsayisi.TabIndex = 19;
            // 
            // txtBox_kötühava_olmaorani
            // 
            this.txtBox_kötühava_olmaorani.Location = new System.Drawing.Point(294, 246);
            this.txtBox_kötühava_olmaorani.Name = "txtBox_kötühava_olmaorani";
            this.txtBox_kötühava_olmaorani.Size = new System.Drawing.Size(100, 22);
            this.txtBox_kötühava_olmaorani.TabIndex = 20;
            // 
            // lbl_aydakigünsayisi_örn
            // 
            this.lbl_aydakigünsayisi_örn.AutoSize = true;
            this.lbl_aydakigünsayisi_örn.Location = new System.Drawing.Point(428, 303);
            this.lbl_aydakigünsayisi_örn.Name = "lbl_aydakigünsayisi_örn";
            this.lbl_aydakigünsayisi_örn.Size = new System.Drawing.Size(59, 16);
            this.lbl_aydakigünsayisi_örn.TabIndex = 21;
            this.lbl_aydakigünsayisi_örn.Text = "(Örn: 30 )";
            // 
            // lbl_aylikkalkan_ucaksayisi_tahmini
            // 
            this.lbl_aylikkalkan_ucaksayisi_tahmini.AutoSize = true;
            this.lbl_aylikkalkan_ucaksayisi_tahmini.Location = new System.Drawing.Point(736, 397);
            this.lbl_aylikkalkan_ucaksayisi_tahmini.Name = "lbl_aylikkalkan_ucaksayisi_tahmini";
            this.lbl_aylikkalkan_ucaksayisi_tahmini.Size = new System.Drawing.Size(14, 16);
            this.lbl_aylikkalkan_ucaksayisi_tahmini.TabIndex = 22;
            this.lbl_aylikkalkan_ucaksayisi_tahmini.Text = "0";
            // 
            // lbl_aylikinen_ucaksayisi_tahmini
            // 
            this.lbl_aylikinen_ucaksayisi_tahmini.AutoSize = true;
            this.lbl_aylikinen_ucaksayisi_tahmini.Location = new System.Drawing.Point(736, 462);
            this.lbl_aylikinen_ucaksayisi_tahmini.Name = "lbl_aylikinen_ucaksayisi_tahmini";
            this.lbl_aylikinen_ucaksayisi_tahmini.Size = new System.Drawing.Size(14, 16);
            this.lbl_aylikinen_ucaksayisi_tahmini.TabIndex = 23;
            this.lbl_aylikinen_ucaksayisi_tahmini.Text = "0";
            // 
            // lbl_günlükkalkan_ucaksayisi_belirlenen
            // 
            this.lbl_günlükkalkan_ucaksayisi_belirlenen.AutoSize = true;
            this.lbl_günlükkalkan_ucaksayisi_belirlenen.Location = new System.Drawing.Point(646, 43);
            this.lbl_günlükkalkan_ucaksayisi_belirlenen.Name = "lbl_günlükkalkan_ucaksayisi_belirlenen";
            this.lbl_günlükkalkan_ucaksayisi_belirlenen.Size = new System.Drawing.Size(14, 16);
            this.lbl_günlükkalkan_ucaksayisi_belirlenen.TabIndex = 24;
            this.lbl_günlükkalkan_ucaksayisi_belirlenen.Text = "0";
            // 
            // lbl_günlükinen_ucaksayisi_belirlenen
            // 
            this.lbl_günlükinen_ucaksayisi_belirlenen.AutoSize = true;
            this.lbl_günlükinen_ucaksayisi_belirlenen.Location = new System.Drawing.Point(646, 98);
            this.lbl_günlükinen_ucaksayisi_belirlenen.Name = "lbl_günlükinen_ucaksayisi_belirlenen";
            this.lbl_günlükinen_ucaksayisi_belirlenen.Size = new System.Drawing.Size(14, 16);
            this.lbl_günlükinen_ucaksayisi_belirlenen.TabIndex = 25;
            this.lbl_günlükinen_ucaksayisi_belirlenen.Text = "0";
            // 
            // lbl_günlükinen_ucaksayisi_gerceklesen
            // 
            this.lbl_günlükinen_ucaksayisi_gerceklesen.AutoSize = true;
            this.lbl_günlükinen_ucaksayisi_gerceklesen.Location = new System.Drawing.Point(750, 98);
            this.lbl_günlükinen_ucaksayisi_gerceklesen.Name = "lbl_günlükinen_ucaksayisi_gerceklesen";
            this.lbl_günlükinen_ucaksayisi_gerceklesen.Size = new System.Drawing.Size(14, 16);
            this.lbl_günlükinen_ucaksayisi_gerceklesen.TabIndex = 27;
            this.lbl_günlükinen_ucaksayisi_gerceklesen.Text = "0";
            // 
            // lbl_günlükkalkan_ucaksayisi_gerceklesen
            // 
            this.lbl_günlükkalkan_ucaksayisi_gerceklesen.AutoSize = true;
            this.lbl_günlükkalkan_ucaksayisi_gerceklesen.Location = new System.Drawing.Point(750, 43);
            this.lbl_günlükkalkan_ucaksayisi_gerceklesen.Name = "lbl_günlükkalkan_ucaksayisi_gerceklesen";
            this.lbl_günlükkalkan_ucaksayisi_gerceklesen.Size = new System.Drawing.Size(14, 16);
            this.lbl_günlükkalkan_ucaksayisi_gerceklesen.TabIndex = 26;
            this.lbl_günlükkalkan_ucaksayisi_gerceklesen.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = " Planlanan Uçuş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(702, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Gerçekleşen Uçuş";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 601);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_günlükinen_ucaksayisi_gerceklesen);
            this.Controls.Add(this.lbl_günlükkalkan_ucaksayisi_gerceklesen);
            this.Controls.Add(this.lbl_günlükinen_ucaksayisi_belirlenen);
            this.Controls.Add(this.lbl_günlükkalkan_ucaksayisi_belirlenen);
            this.Controls.Add(this.lbl_aylikinen_ucaksayisi_tahmini);
            this.Controls.Add(this.lbl_aylikkalkan_ucaksayisi_tahmini);
            this.Controls.Add(this.lbl_aydakigünsayisi_örn);
            this.Controls.Add(this.txtBox_kötühava_olmaorani);
            this.Controls.Add(this.txtBox_aydakigünsayisi);
            this.Controls.Add(this.txtBox_kötühava_inisiptal_orani);
            this.Controls.Add(this.txtBox_kötühava_kalkisiptal_orani);
            this.Controls.Add(this.lbl_kötühava_inisiptal_örn);
            this.Controls.Add(this.lbl_kötühava_kalkisiptal_örn);
            this.Controls.Add(this.lbl_kötühava_olmasansi_orani);
            this.Controls.Add(this.lbl_günlükkalkan_ucaksayisi_örn);
            this.Controls.Add(this.lbl_kötühava_olmasansi);
            this.Controls.Add(this.txtBox_günlükinen_ucaksayisi_max);
            this.Controls.Add(this.txtBox_günlükkalkan_ucaksayisi_max);
            this.Controls.Add(this.txtBox_günlükinen_ucaksayisi_min);
            this.Controls.Add(this.lbl_aylikinen_ucaksayisi);
            this.Controls.Add(this.lbl_aylikkalkan_ucaksayisi);
            this.Controls.Add(this.lbl_aydakigünsayisi);
            this.Controls.Add(this.lbl_kötühava_inisiptal);
            this.Controls.Add(this.lbl_kötühava_kalkisiptal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_günlükinen_ucaksayisi_örn);
            this.Controls.Add(this.lbl_günlükkalkan_ucaksayisi);
            this.Controls.Add(this.txtBox_günlükkalkan_ucaksayisi_min);
            this.Controls.Add(this.btn_hesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.TextBox txtBox_günlükkalkan_ucaksayisi_min;
        private System.Windows.Forms.Label lbl_günlükkalkan_ucaksayisi;
        private System.Windows.Forms.Label lbl_günlükinen_ucaksayisi_örn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_kötühava_kalkisiptal;
        private System.Windows.Forms.Label lbl_kötühava_inisiptal;
        private System.Windows.Forms.Label lbl_aydakigünsayisi;
        private System.Windows.Forms.Label lbl_aylikkalkan_ucaksayisi;
        private System.Windows.Forms.Label lbl_aylikinen_ucaksayisi;
        private System.Windows.Forms.TextBox txtBox_günlükinen_ucaksayisi_min;
        private System.Windows.Forms.TextBox txtBox_günlükkalkan_ucaksayisi_max;
        private System.Windows.Forms.TextBox txtBox_günlükinen_ucaksayisi_max;
        private System.Windows.Forms.Label lbl_kötühava_olmasansi;
        private System.Windows.Forms.Label lbl_günlükkalkan_ucaksayisi_örn;
        private System.Windows.Forms.Label lbl_kötühava_olmasansi_orani;
        private System.Windows.Forms.Label lbl_kötühava_kalkisiptal_örn;
        private System.Windows.Forms.Label lbl_kötühava_inisiptal_örn;
        private System.Windows.Forms.TextBox txtBox_kötühava_kalkisiptal_orani;
        private System.Windows.Forms.TextBox txtBox_kötühava_inisiptal_orani;
        private System.Windows.Forms.TextBox txtBox_aydakigünsayisi;
        private System.Windows.Forms.TextBox txtBox_kötühava_olmaorani;
        private System.Windows.Forms.Label lbl_aydakigünsayisi_örn;
        private System.Windows.Forms.Label lbl_aylikkalkan_ucaksayisi_tahmini;
        private System.Windows.Forms.Label lbl_aylikinen_ucaksayisi_tahmini;
        private System.Windows.Forms.Label lbl_günlükkalkan_ucaksayisi_belirlenen;
        private System.Windows.Forms.Label lbl_günlükinen_ucaksayisi_belirlenen;
        private System.Windows.Forms.Label lbl_günlükinen_ucaksayisi_gerceklesen;
        private System.Windows.Forms.Label lbl_günlükkalkan_ucaksayisi_gerceklesen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


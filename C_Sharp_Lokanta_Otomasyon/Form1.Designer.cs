namespace C_Sharp_Lokanta_Otomasyon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCorba = new System.Windows.Forms.ComboBox();
            this.cmbYemek = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKofte = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPide = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIcecek = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSalata = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTatli = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKasa = new System.Windows.Forms.Label();
            this.labelToplam = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnÖde = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.cmbTatli);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbSalata);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbIcecek);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbPide);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbKofte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbYemek);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCorba);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yemek Seçiniz :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(469, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 329);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menü :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btnTemizle);
            this.groupBox3.Controls.Add(this.btnÖde);
            this.groupBox3.Controls.Add(this.btnHesapla);
            this.groupBox3.Controls.Add(this.lblKasa);
            this.groupBox3.Controls.Add(this.labelToplam);
            this.groupBox3.Location = new System.Drawing.Point(783, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 329);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödeme :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çorba Çeşitleri :";
            // 
            // cmbCorba
            // 
            this.cmbCorba.FormattingEnabled = true;
            this.cmbCorba.Items.AddRange(new object[] {
            "Ezogelin",
            "Mercimek",
            "Yayla",
            "İşkembe",
            "Paça"});
            this.cmbCorba.Location = new System.Drawing.Point(181, 52);
            this.cmbCorba.Name = "cmbCorba";
            this.cmbCorba.Size = new System.Drawing.Size(231, 31);
            this.cmbCorba.TabIndex = 1;
            // 
            // cmbYemek
            // 
            this.cmbYemek.FormattingEnabled = true;
            this.cmbYemek.Items.AddRange(new object[] {
            "Etli Kuru Fasulye",
            "Etli Nohut",
            "Etli Taze Fasulye",
            "Etli Türlü",
            "Fırında Güveç",
            "Biber Dolması",
            "Yaprak Sarma",
            "İmambayıldı",
            "Karnıyarık",
            "Ispanak",
            "Tas Kebabı",
            "Orman Kebabı",
            "Cağ Kebabı",
            "İskender",
            "Haşlanmış Tavuk",
            "Tavuk Üstü Pilav",
            "Mantı"});
            this.cmbYemek.Location = new System.Drawing.Point(181, 89);
            this.cmbYemek.Name = "cmbYemek";
            this.cmbYemek.Size = new System.Drawing.Size(231, 31);
            this.cmbYemek.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yemek Çeşitleri :";
            // 
            // cmbKofte
            // 
            this.cmbKofte.FormattingEnabled = true;
            this.cmbKofte.Items.AddRange(new object[] {
            "İnegöl",
            "Kadınbudu",
            "İzmir",
            "Izgara",
            "Tekirdağ",
            "Çiftlik"});
            this.cmbKofte.Location = new System.Drawing.Point(181, 126);
            this.cmbKofte.Name = "cmbKofte";
            this.cmbKofte.Size = new System.Drawing.Size(231, 31);
            this.cmbKofte.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Köfte Çeşitleri :";
            // 
            // cmbPide
            // 
            this.cmbPide.FormattingEnabled = true;
            this.cmbPide.Items.AddRange(new object[] {
            "Kıymalı",
            "Patatesli",
            "Kaşarlı",
            "Yumurtalı",
            "Kavurmalı",
            "Tavuklu",
            "Sebzeli",
            "Karadeniz"});
            this.cmbPide.Location = new System.Drawing.Point(181, 163);
            this.cmbPide.Name = "cmbPide";
            this.cmbPide.Size = new System.Drawing.Size(231, 31);
            this.cmbPide.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pide Çeşitleri :";
            // 
            // cmbIcecek
            // 
            this.cmbIcecek.FormattingEnabled = true;
            this.cmbIcecek.Items.AddRange(new object[] {
            "Su",
            "Çay",
            "Ayran",
            "Kola",
            "Light Kola",
            "Fanta",
            "Gazoz",
            "Kahve",
            "Sahlep",
            "Meyve Suyu",
            "Limonata",
            "Sade Soda",
            "Meyveli Soda"});
            this.cmbIcecek.Location = new System.Drawing.Point(181, 200);
            this.cmbIcecek.Name = "cmbIcecek";
            this.cmbIcecek.Size = new System.Drawing.Size(231, 31);
            this.cmbIcecek.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "İçecek Çeşitleri :";
            // 
            // cmbSalata
            // 
            this.cmbSalata.FormattingEnabled = true;
            this.cmbSalata.Items.AddRange(new object[] {
            "Çoban",
            "Mevsim",
            "Yeşillik"});
            this.cmbSalata.Location = new System.Drawing.Point(181, 237);
            this.cmbSalata.Name = "cmbSalata";
            this.cmbSalata.Size = new System.Drawing.Size(231, 31);
            this.cmbSalata.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Salata Çeşitleri :";
            // 
            // cmbTatli
            // 
            this.cmbTatli.FormattingEnabled = true;
            this.cmbTatli.Items.AddRange(new object[] {
            "Fırın Sütlaç",
            "Supangle",
            "Puding",
            "Kadayıf",
            "Künefe",
            "Şekerpare",
            "Baklava",
            "Trileçe"});
            this.cmbTatli.Location = new System.Drawing.Point(181, 274);
            this.cmbTatli.Name = "cmbTatli";
            this.cmbTatli.Size = new System.Drawing.Size(231, 31);
            this.cmbTatli.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tatlı Çeşitleri :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-7, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(-7, 535);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 53);
            this.panel2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(284, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Çorba: 5TL (İşkembe - Paça: 8 TL)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(298, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Yemek: 15 TL (Kebap Türleri: 20 TL)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Köfte: 18 TL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(300, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Pide: 8 TL (Karadeniz Pidesi: 10 TL)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(272, 23);
            this.label13.TabIndex = 5;
            this.label13.Text = "İçecek: 4 TL (Su: 2 TL - Çay: 3 TL)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 23);
            this.label14.TabIndex = 6;
            this.label14.Text = "Salata: 5 TL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 23);
            this.label15.TabIndex = 7;
            this.label15.Text = "Tatlı: 12 TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Brush Script MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(575, 79);
            this.label8.TabIndex = 0;
            this.label8.Text = "Gökhan Esnaf Lokantası";
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.Location = new System.Drawing.Point(95, 277);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(123, 23);
            this.lblKasa.TabIndex = 4;
            this.lblKasa.Text = "Günlük Kasa :";
            // 
            // labelToplam
            // 
            this.labelToplam.AutoSize = true;
            this.labelToplam.Location = new System.Drawing.Point(95, 52);
            this.labelToplam.Name = "labelToplam";
            this.labelToplam.Size = new System.Drawing.Size(82, 23);
            this.labelToplam.TabIndex = 3;
            this.labelToplam.Text = "Toplam: ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(79, 112);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(157, 40);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnÖde
            // 
            this.btnÖde.Location = new System.Drawing.Point(79, 166);
            this.btnÖde.Name = "btnÖde";
            this.btnÖde.Size = new System.Drawing.Size(157, 40);
            this.btnÖde.TabIndex = 6;
            this.btnÖde.Text = "ÖDE";
            this.btnÖde.UseVisualStyleBackColor = true;
            this.btnÖde.Click += new System.EventHandler(this.btnÖde_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(79, 223);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(157, 40);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTatli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSalata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbIcecek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKofte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYemek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCorba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnÖde;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Label labelToplam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTemizle;
    }
}


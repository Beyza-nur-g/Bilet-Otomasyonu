namespace PROLAB2._1
{
    partial class Firma
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
            this.buttonAnaEkran = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lstAraclar = new System.Windows.Forms.ListBox();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.cmbYakitTur = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVehicleId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYakitUcreti = new System.Windows.Forms.TextBox();
            this.buttonAracEkle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbYolcuSayisi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSeferNo = new System.Windows.Forms.ComboBox();
            this.listBoxSeferler = new System.Windows.Forms.ListBox();
            this.buttonSeferSil = new System.Windows.Forms.Button();
            this.comboBoxAraclar = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSeferEkle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxSeferGunu = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAnaEkran
            // 
            this.buttonAnaEkran.Location = new System.Drawing.Point(1030, 72);
            this.buttonAnaEkran.Name = "buttonAnaEkran";
            this.buttonAnaEkran.Size = new System.Drawing.Size(145, 92);
            this.buttonAnaEkran.TabIndex = 1;
            this.buttonAnaEkran.Text = "Ana Ekran";
            this.buttonAnaEkran.UseVisualStyleBackColor = true;
            this.buttonAnaEkran.Click += new System.EventHandler(this.buttonAnaEkran_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lstAraclar);
            this.groupBox1.Controls.Add(this.cmbVehicleType);
            this.groupBox1.Controls.Add(this.cmbYakitTur);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtVehicleId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtYakitUcreti);
            this.groupBox1.Controls.Add(this.buttonAracEkle);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbYolcuSayisi);
            this.groupBox1.Location = new System.Drawing.Point(30, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 353);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araçlar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Arac Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstAraclar
            // 
            this.lstAraclar.FormattingEnabled = true;
            this.lstAraclar.HorizontalScrollbar = true;
            this.lstAraclar.ItemHeight = 16;
            this.lstAraclar.Location = new System.Drawing.Point(626, 35);
            this.lstAraclar.Name = "lstAraclar";
            this.lstAraclar.Size = new System.Drawing.Size(229, 276);
            this.lstAraclar.TabIndex = 27;
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "Otobüs",
            "Uçak",
            "Tren"});
            this.cmbVehicleType.Location = new System.Drawing.Point(176, 35);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(121, 24);
            this.cmbVehicleType.TabIndex = 35;
            // 
            // cmbYakitTur
            // 
            this.cmbYakitTur.FormattingEnabled = true;
            this.cmbYakitTur.Items.AddRange(new object[] {
            "Benzin ",
            "Motorin",
            "Elektirk",
            "Gaz"});
            this.cmbYakitTur.Location = new System.Drawing.Point(176, 202);
            this.cmbYakitTur.Name = "cmbYakitTur";
            this.cmbYakitTur.Size = new System.Drawing.Size(121, 24);
            this.cmbYakitTur.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "yakıt türü";
            // 
            // txtVehicleId
            // 
            this.txtVehicleId.Location = new System.Drawing.Point(176, 87);
            this.txtVehicleId.Name = "txtVehicleId";
            this.txtVehicleId.Size = new System.Drawing.Size(121, 22);
            this.txtVehicleId.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Arac Id";
            // 
            // txtYakitUcreti
            // 
            this.txtYakitUcreti.Location = new System.Drawing.Point(176, 259);
            this.txtYakitUcreti.Name = "txtYakitUcreti";
            this.txtYakitUcreti.Size = new System.Drawing.Size(58, 22);
            this.txtYakitUcreti.TabIndex = 28;
            // 
            // buttonAracEkle
            // 
            this.buttonAracEkle.Location = new System.Drawing.Point(432, 97);
            this.buttonAracEkle.Name = "buttonAracEkle";
            this.buttonAracEkle.Size = new System.Drawing.Size(89, 35);
            this.buttonAracEkle.TabIndex = 23;
            this.buttonAracEkle.Text = "Arac ekle";
            this.buttonAracEkle.UseVisualStyleBackColor = true;
            this.buttonAracEkle.Click += new System.EventHandler(this.buttonAracEkle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "yakıt ücreti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Yolcu Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 32);
            this.label7.TabIndex = 22;
            this.label7.Text = "Arac Türü\r\n\r\n";
            // 
            // cmbYolcuSayisi
            // 
            this.cmbYolcuSayisi.FormattingEnabled = true;
            this.cmbYolcuSayisi.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "30"});
            this.cmbYolcuSayisi.Location = new System.Drawing.Point(176, 146);
            this.cmbYolcuSayisi.Name = "cmbYolcuSayisi";
            this.cmbYolcuSayisi.Size = new System.Drawing.Size(121, 24);
            this.cmbYolcuSayisi.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Sefer No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxSeferNo);
            this.groupBox2.Controls.Add(this.listBoxSeferler);
            this.groupBox2.Controls.Add(this.buttonSeferSil);
            this.groupBox2.Controls.Add(this.comboBoxAraclar);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.buttonSeferEkle);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.comboBoxSeferGunu);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(30, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(890, 268);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seferler";
            // 
            // comboBoxSeferNo
            // 
            this.comboBoxSeferNo.FormattingEnabled = true;
            this.comboBoxSeferNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxSeferNo.Location = new System.Drawing.Point(176, 189);
            this.comboBoxSeferNo.Name = "comboBoxSeferNo";
            this.comboBoxSeferNo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSeferNo.TabIndex = 42;
            // 
            // listBoxSeferler
            // 
            this.listBoxSeferler.FormattingEnabled = true;
            this.listBoxSeferler.HorizontalScrollbar = true;
            this.listBoxSeferler.ItemHeight = 16;
            this.listBoxSeferler.Location = new System.Drawing.Point(626, 37);
            this.listBoxSeferler.Name = "listBoxSeferler";
            this.listBoxSeferler.Size = new System.Drawing.Size(229, 212);
            this.listBoxSeferler.TabIndex = 41;
            // 
            // buttonSeferSil
            // 
            this.buttonSeferSil.Location = new System.Drawing.Point(432, 157);
            this.buttonSeferSil.Name = "buttonSeferSil";
            this.buttonSeferSil.Size = new System.Drawing.Size(89, 35);
            this.buttonSeferSil.TabIndex = 35;
            this.buttonSeferSil.Text = "Sefer Sil";
            this.buttonSeferSil.UseVisualStyleBackColor = true;
            this.buttonSeferSil.Click += new System.EventHandler(this.buttonSeferSil_Click);
            // 
            // comboBoxAraclar
            // 
            this.comboBoxAraclar.FormattingEnabled = true;
            this.comboBoxAraclar.Location = new System.Drawing.Point(176, 66);
            this.comboBoxAraclar.Name = "comboBoxAraclar";
            this.comboBoxAraclar.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAraclar.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Araclar";
            // 
            // buttonSeferEkle
            // 
            this.buttonSeferEkle.Location = new System.Drawing.Point(432, 87);
            this.buttonSeferEkle.Name = "buttonSeferEkle";
            this.buttonSeferEkle.Size = new System.Drawing.Size(89, 35);
            this.buttonSeferEkle.TabIndex = 23;
            this.buttonSeferEkle.Text = "Sefer Ekle";
            this.buttonSeferEkle.UseVisualStyleBackColor = true;
            this.buttonSeferEkle.Click += new System.EventHandler(this.buttonSeferEkle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Sefer Günü";
            // 
            // comboBoxSeferGunu
            // 
            this.comboBoxSeferGunu.FormattingEnabled = true;
            this.comboBoxSeferGunu.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.comboBoxSeferGunu.Location = new System.Drawing.Point(176, 123);
            this.comboBoxSeferGunu.Name = "comboBoxSeferGunu";
            this.comboBoxSeferGunu.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSeferGunu.TabIndex = 19;
            // 
            // Firma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 677);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAnaEkran);
            this.Name = "Firma";
            this.Text = "Firma";
            this.Load += new System.EventHandler(this.Firma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAnaEkran;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAracEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbYolcuSayisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYakitUcreti;
        private System.Windows.Forms.ComboBox cmbYakitTur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVehicleId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxAraclar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSeferEkle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxSeferGunu;
        private System.Windows.Forms.Button buttonSeferSil;
        private System.Windows.Forms.ListBox lstAraclar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxSeferler;
        private System.Windows.Forms.ComboBox comboBoxSeferNo;
    }
}
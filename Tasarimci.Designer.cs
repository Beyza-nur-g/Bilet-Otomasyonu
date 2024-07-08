namespace PROLAB2._1
{
    partial class Tasarimci
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
            this.buttonListele = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxFirmaAdi = new System.Windows.Forms.TextBox();
            this.buttonFirmaEkle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.textBoxHizmet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAnaEkran
            // 
            this.buttonAnaEkran.Location = new System.Drawing.Point(1073, 200);
            this.buttonAnaEkran.Name = "buttonAnaEkran";
            this.buttonAnaEkran.Size = new System.Drawing.Size(145, 92);
            this.buttonAnaEkran.TabIndex = 2;
            this.buttonAnaEkran.Text = "Ana Ekran";
            this.buttonAnaEkran.UseVisualStyleBackColor = true;
            this.buttonAnaEkran.Click += new System.EventHandler(this.buttonAnaEkran_Click_1);
            // 
            // buttonListele
            // 
            this.buttonListele.Location = new System.Drawing.Point(670, 391);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(148, 42);
            this.buttonListele.TabIndex = 3;
            this.buttonListele.Text = "firmaları Listele\r\n";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(192, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(386, 340);
            this.listBox1.TabIndex = 4;
            // 
            // textBoxFirmaAdi
            // 
            this.textBoxFirmaAdi.Location = new System.Drawing.Point(753, 118);
            this.textBoxFirmaAdi.Name = "textBoxFirmaAdi";
            this.textBoxFirmaAdi.Size = new System.Drawing.Size(159, 22);
            this.textBoxFirmaAdi.TabIndex = 5;
            // 
            // buttonFirmaEkle
            // 
            this.buttonFirmaEkle.Location = new System.Drawing.Point(670, 224);
            this.buttonFirmaEkle.Name = "buttonFirmaEkle";
            this.buttonFirmaEkle.Size = new System.Drawing.Size(148, 44);
            this.buttonFirmaEkle.TabIndex = 6;
            this.buttonFirmaEkle.Text = "Firma Ekle";
            this.buttonFirmaEkle.UseVisualStyleBackColor = true;
            this.buttonFirmaEkle.Click += new System.EventHandler(this.buttonFirmaEkle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(670, 304);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(148, 43);
            this.buttonSil.TabIndex = 7;
            this.buttonSil.Text = "Firma Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // textBoxHizmet
            // 
            this.textBoxHizmet.Location = new System.Drawing.Point(753, 165);
            this.textBoxHizmet.Name = "textBoxHizmet";
            this.textBoxHizmet.Size = new System.Drawing.Size(159, 22);
            this.textBoxHizmet.TabIndex = 9;
            this.textBoxHizmet.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Firma Adı\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hizmet Bedeli";
            // 
            // Tasarimci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHizmet);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonFirmaEkle);
            this.Controls.Add(this.textBoxFirmaAdi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.buttonAnaEkran);
            this.Name = "Tasarimci";
            this.Text = "Tasarimci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnaEkran;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxFirmaAdi;
        private System.Windows.Forms.Button buttonFirmaEkle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.TextBox textBoxHizmet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace PROLAB2._1
{
    partial class GirisEkrani
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAnaEkran = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SifreTextBox = new System.Windows.Forms.TextBox();
            this.KullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonAnaEkran);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SifreTextBox);
            this.panel1.Controls.Add(this.KullaniciAdiTextBox);
            this.panel1.Location = new System.Drawing.Point(188, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 414);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // buttonAnaEkran
            // 
            this.buttonAnaEkran.Location = new System.Drawing.Point(530, 41);
            this.buttonAnaEkran.Name = "buttonAnaEkran";
            this.buttonAnaEkran.Size = new System.Drawing.Size(175, 125);
            this.buttonAnaEkran.TabIndex = 0;
            this.buttonAnaEkran.Text = "Ana Ekran";
            this.buttonAnaEkran.UseVisualStyleBackColor = true;
            this.buttonAnaEkran.Click += new System.EventHandler(this.buttonAnaEkran_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // SifreTextBox
            // 
            this.SifreTextBox.Location = new System.Drawing.Point(206, 129);
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.Size = new System.Drawing.Size(139, 22);
            this.SifreTextBox.TabIndex = 2;
            // 
            // KullaniciAdiTextBox
            // 
            this.KullaniciAdiTextBox.Location = new System.Drawing.Point(206, 67);
            this.KullaniciAdiTextBox.Name = "KullaniciAdiTextBox";
            this.KullaniciAdiTextBox.Size = new System.Drawing.Size(139, 22);
            this.KullaniciAdiTextBox.TabIndex = 1;
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 570);
            this.Controls.Add(this.panel1);
            this.Name = "GirisEkrani";
            this.Text = "GirisEkrani";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAnaEkran;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SifreTextBox;
        private System.Windows.Forms.TextBox KullaniciAdiTextBox;
    }
}
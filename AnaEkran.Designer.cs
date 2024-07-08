namespace PROLAB2._1
{
    partial class AnaEkran
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
            this.buttonFirmaGiris = new System.Windows.Forms.Button();
            this.buttonTasarimciGiris = new System.Windows.Forms.Button();
            this.buttonKullanici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFirmaGiris
            // 
            this.buttonFirmaGiris.Location = new System.Drawing.Point(367, 68);
            this.buttonFirmaGiris.Name = "buttonFirmaGiris";
            this.buttonFirmaGiris.Size = new System.Drawing.Size(176, 74);
            this.buttonFirmaGiris.TabIndex = 1;
            this.buttonFirmaGiris.Text = "Firma Giriş\r\n";
            this.buttonFirmaGiris.UseVisualStyleBackColor = true;
            this.buttonFirmaGiris.Click += new System.EventHandler(this.buttonFirmaGiris_Click);
            // 
            // buttonTasarimciGiris
            // 
            this.buttonTasarimciGiris.Location = new System.Drawing.Point(367, 179);
            this.buttonTasarimciGiris.Name = "buttonTasarimciGiris";
            this.buttonTasarimciGiris.Size = new System.Drawing.Size(176, 73);
            this.buttonTasarimciGiris.TabIndex = 3;
            this.buttonTasarimciGiris.Text = "Admin Giriş\r\n";
            this.buttonTasarimciGiris.UseVisualStyleBackColor = true;
            this.buttonTasarimciGiris.Click += new System.EventHandler(this.buttonTasarimciGiris_Click);
            // 
            // buttonKullanici
            // 
            this.buttonKullanici.Location = new System.Drawing.Point(367, 312);
            this.buttonKullanici.Name = "buttonKullanici";
            this.buttonKullanici.Size = new System.Drawing.Size(176, 73);
            this.buttonKullanici.TabIndex = 4;
            this.buttonKullanici.Text = "Bilet Ara";
            this.buttonKullanici.UseVisualStyleBackColor = true;
            this.buttonKullanici.Click += new System.EventHandler(this.buttonKullanici_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 497);
            this.Controls.Add(this.buttonKullanici);
            this.Controls.Add(this.buttonTasarimciGiris);
            this.Controls.Add(this.buttonFirmaGiris);
            this.Name = "AnaEkran";
            this.Text = "AnaEkran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFirmaGiris;
        private System.Windows.Forms.Button buttonTasarimciGiris;
        private System.Windows.Forms.Button buttonKullanici;
    }
}
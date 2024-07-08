using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROLAB2._1
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void buttonAnaEkran_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = KullaniciAdiTextBox.Text;
            string sifre= SifreTextBox.Text;

                Admin admin = new Admin{ KullaniciAdi = "admin", KullaniciSifre = "12345" };
               
                if (admin.KimlikDogrula(kullaniciAdi, sifre))
                {
                    Tasarimci tasarimci = new Tasarimci();
                    tasarimci.Show();
                    this.Hide();
                }
                else 
                {
                foreach (FirmaOlustur firma in Admin.Instance.firmalar)
                {
                    if (firma.FirmaAdi == kullaniciAdi && firma.FirmaSifre == sifre)
                    {
                        Firma fa = new Firma();
                        fa.Show();
                        return;
                    }
                }

                MessageBox.Show("Geçersiz kullanıcı adı veya şifre");
            
                }
        }

    }
}

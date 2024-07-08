using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROLAB2._1
{
    public partial class Tasarimci : Form
    {
        Admin admin = Admin.Instance;
        public Tasarimci()
        {
            InitializeComponent();
        }
        private void buttonAnaEkran_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Close();
        }
        private void buttonListele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var firma in admin.firmalar)
            {
                listBox1.Items.Add(firma);
            }
        }
        private void buttonFirmaEkle_Click(object sender, EventArgs e)
        {
            string fAdi = textBoxFirmaAdi.Text.Trim();
            decimal fhizmet;
            string fsifre = fAdi + "123";

            if (decimal.TryParse(textBoxHizmet.Text, out fhizmet))
            {
                admin.FirmaEkle(fAdi, fhizmet,fsifre);
                listBox1.Items.Clear();
                foreach (var firma in admin.firmalar)
                {
                    listBox1.Items.Add(firma.ToString());
                }
            }
            else
            {
                MessageBox.Show("Geçersiz Hizmet Bedeli formatı.");
            }
        }
        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < admin.firmalar.Count)
            {
                admin.FirmaSil(listBox1.SelectedIndex);
                MessageBox.Show("Firma silindi.");
                listBox1.Items.Clear();
                foreach (var firma in admin.firmalar)
                {
                    listBox1.Items.Add(firma.ToString());
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek firmayı seçin.");
            }
        }
        private void buttonAnaEkran_Click_1(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Close();
        }
    }
}
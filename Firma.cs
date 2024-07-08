using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROLAB2._1
{
    public partial class Firma : Form
    {
        AnaEkran anaEkran = new AnaEkran();
        Company company = Company.Instance;
        public Firma()
        {
            InitializeComponent();
        }
        private void buttonAnaEkran_Click(object sender, EventArgs e)
        {
            anaEkran.Show();
            this.Close();
        }
        private void buttonAracEkle_Click(object sender, EventArgs e)
        {
            Vehicle vehicle;
            if (cmbVehicleType.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir araç türü seçiniz.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // İleri işlemleri durdur
            }
            else
            {
                if (cmbVehicleType.SelectedItem.ToString() == "Otobüs")
                {
                    vehicle = new Bus();
                    
                }
                else if (cmbVehicleType.SelectedItem.ToString() == "Tren")
                {
                    vehicle = new Train();
                }
                else
                {
                    vehicle = new Airplane(); 
                }
            }
            if (string.IsNullOrEmpty(txtVehicleId.Text))
            {
                MessageBox.Show("Lütfen Araç Kimliği giriniz.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else vehicle.VehicleId = txtVehicleId.Text;

            if (cmbYakitTur.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir Yakıt Türü seçiniz.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else vehicle.YakitTur = cmbYakitTur.SelectedItem.ToString();

            if (!decimal.TryParse(txtYakitUcreti.Text, out decimal yakitUcreti))
            {
                MessageBox.Show("Lütfen geçerli bir Yakıt Ücreti giriniz.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else vehicle.YakitUcreti = decimal.Parse(txtYakitUcreti.Text);

            if (cmbYolcuSayisi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir Yolcu Sayısı seçiniz.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else vehicle.YolcuSayisi = int.Parse(cmbYolcuSayisi.SelectedItem.ToString());

            company.AracEkle(vehicle);

            lstAraclar.Items.Clear();
            foreach (var vh in company.vehicles)
            {
                lstAraclar.Items.Add(vh.ToString());
            }
            ComboBoxAracIdGönderme();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedIndex >= 0 && lstAraclar.SelectedIndex < company.vehicles.Count)
            {
                company.AracSil(lstAraclar.SelectedIndex);
                lstAraclar.Items.Clear();
                foreach (var vh in company.vehicles)
                {
                    lstAraclar.Items.Add(vh.ToString());
                }
                ComboBoxAracIdGönderme();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek firmayı seçin.");
            }
        }
        private void ComboBoxAracIdGönderme()
        {
            comboBoxAraclar.Items.Clear();
            foreach (Vehicle arac in company.vehicles)
            {
                comboBoxAraclar.Items.Add(arac.VehicleId);
            }
            if (comboBoxAraclar.Items.Count > 0)
            {
                comboBoxAraclar.SelectedIndex = 0;
            }
        }
        private void Firma_Load(object sender, EventArgs e)
        {
           
        }
        private void buttonSeferEkle_Click(object sender, EventArgs e)
        {
            Trip trip = new Trip();
            if (comboBoxAraclar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Arac ıd seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else trip.AracId = comboBoxAraclar.SelectedItem.ToString();

            if (comboBoxSeferGunu.SelectedItem == null)
            {
                MessageBox.Show("Lütfen sefer gününü seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else trip.Gun = comboBoxSeferGunu.SelectedItem.ToString();

            if (comboBoxSeferNo.SelectedItem == null)
            {
                MessageBox.Show("Lütfen sefer gününü seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else trip.SeferNo = Int32.Parse(comboBoxSeferNo.SelectedItem.ToString());

            company.SeferEkle(trip);

            listBoxSeferler.Items.Clear();
            foreach (var sf in company.Seferler)
            {
                listBoxSeferler.Items.Add(sf.ToString());
            }
        }

        private void buttonSeferSil_Click(object sender, EventArgs e)
        {
            if (listBoxSeferler.SelectedIndex >= 0 && listBoxSeferler.SelectedIndex < company.Seferler.Count)
            {
                company.SeferSil(listBoxSeferler.SelectedIndex);
                listBoxSeferler.Items.Clear();
                foreach (var sf in company.Seferler)
                {
                    listBoxSeferler.Items.Add(sf.ToString());
                }

            }
            else
            {
                MessageBox.Show("Lütfen silinecek seferi seçin.");
            }
        }
    }
}

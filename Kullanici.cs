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
    public partial class Kullanici : Form
    {
        Customer customer = new Customer();
        Transport transport;
        Company company = Company.Instance;
        Trip mevcutSefer;

        int fiyat = 0;
        int yolcuSayisi;
        public Kullanici()
        {
            InitializeComponent();
        }
        private void buttonAnaEkran_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Close();
        }

        private void buttonBliletAra_Click(object sender, EventArgs e)
        {
            listBoxSeferler.Items.Clear();
            Route rota = new Route(" ", " ");
            Trip trip = new Trip();
            FiyatMatrisleri fiyatMatrisleri = new FiyatMatrisleri();
            string varisSehri;
            string kalkisSehri;
            string SeferGunu;

            if (comboBoxNereden.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kalkış şehri seçiniz.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else
            {
                kalkisSehri = comboBoxNereden.SelectedItem.ToString();
                rota.KalkisSehri = kalkisSehri;
            }
            if (comboBoxNereye.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir varış şehri seçiniz.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else
            {
                varisSehri = comboBoxNereye.SelectedItem.ToString();
                rota.VarisSehri = varisSehri;
            }
            if (comboBoxSeferGunu.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir günseçiniz.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else
            {
                SeferGunu = comboBoxSeferGunu.SelectedItem.ToString();
                trip.Gun = SeferGunu;
            }
            if (!Int32.TryParse(textyolcuSayisi.Text, out yolcuSayisi))
            {
                MessageBox.Show("Lütfen geçerli bir yolcu sayısı giriniz.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else
            {
                yolcuSayisi = Int32.Parse(textyolcuSayisi.Text);
            }
            for (int i = 1; i < 7; i++)
            {
                List<string> sehirler = rota.SeferSehirleri(i);
                if (sehirler != null && sehirler.Contains(kalkisSehri) && sehirler.Contains(varisSehri))
                {

                    if ((i == 1 || i == 2) && fiyatMatrisleri.KarayoluFiyatMatrisi.ContainsKey(kalkisSehri) && fiyatMatrisleri.KarayoluFiyatMatrisi[kalkisSehri].ContainsKey(varisSehri))
                    {
                        fiyat = fiyatMatrisleri.KarayoluFiyatMatrisi[kalkisSehri][varisSehri];
                    }
                    else if ((i == 3 || i == 4) && fiyatMatrisleri.DemiryoluFiyatMatrisi.ContainsKey(kalkisSehri) && fiyatMatrisleri.DemiryoluFiyatMatrisi[kalkisSehri].ContainsKey(varisSehri))
                    {
                        fiyat = fiyatMatrisleri.DemiryoluFiyatMatrisi[kalkisSehri][varisSehri];
                    }
                    else if ((i == 5 || i == 6) && fiyatMatrisleri.HavayoluFiyatMatrisi.ContainsKey(kalkisSehri) && fiyatMatrisleri.HavayoluFiyatMatrisi[kalkisSehri].ContainsKey(varisSehri))
                    {
                        fiyat = fiyatMatrisleri.HavayoluFiyatMatrisi[kalkisSehri][varisSehri];
                    }

                    List<Trip> seyahatListesi = new List<Trip>();

                    rota = new Route(kalkisSehri, varisSehri);
                    Trip seyahat = new Trip
                    {
                        SeferNo = i,
                        Rota = rota,
                        Fiyat = fiyat,
                        Gun = SeferGunu
                    };
                    mevcutSefer = company.Seferler.FirstOrDefault(t => t.SeferNo == i && t.Gun == SeferGunu);
                    if (mevcutSefer != null)
                    {
                        listBoxSeferler.Items.Add(mevcutSefer);
                    }
                }
            }
        }
        private void comboBoxNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenSehir = comboBoxNereden.SelectedItem?.ToString();
            if (comboBoxNereye.SelectedItem != null && comboBoxNereye.SelectedItem.ToString() == secilenSehir)
            {
                MessageBox.Show("Aynı şehiri seçemezsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxNereye.SelectedIndex = 1; 
            }
        }
        private void comboBoxNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenSehir = comboBoxNereye.SelectedItem?.ToString();
            if (comboBoxNereden.SelectedItem != null && comboBoxNereden.SelectedItem.ToString() == secilenSehir)
            { 
                MessageBox.Show("Aynı şehiri seçemezsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxNereden.SelectedIndex = 0; 
            }
        }
        private void Kullanici_Load(object sender, EventArgs e)
        {
            Route rota = new Route(" ", " ");
            for (int j = 0; j < 6; j++)
            {
                List<string> sehirler = rota.SeferSehirleri(j);
                if (sehirler != null)
                {
                    for (int i = 0; i < sehirler.Count; i++)
                    {
                        if (!comboBoxNereden.Items.Contains(sehirler[i]))
                        {
                            comboBoxNereden.Items.Add(sehirler[i]);
                        }
                        if (!comboBoxNereye.Items.Contains(sehirler[i]))
                        {
                            comboBoxNereye.Items.Add(sehirler[i]);
                        }

                    }
                }
            }
        }
        int koltukSayisi = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxSeferler.SelectedIndex != -1)
            {
                Trip selectedTrip = (Trip)listBoxSeferler.SelectedItem;
                foreach (Vehicle arac in company.vehicles)
                {
                    if (arac.VehicleId == selectedTrip.AracId)
                    {
                        koltukSayisi = arac.YolcuSayisi;
                        break;
                    }
                }
            }
            transport = new Transport(koltukSayisi);
            if (yolcuSayisi > 0 && yolcuSayisi <= transport.KoltukDurumu.Length)
            {
                CreateSeatLayout();
            }
            else
            {
                MessageBox.Show("Yeterli boş koltuk bulunmuyor. Lütfen uygun bir sayı girin.");
            }
        }
        private void CreateSeatLayout()
        {
            fpanel.Controls.Clear();
            for (int i = 1; i <= koltukSayisi; i++)
            {
                Label label = new Label
                {
                    Text = i.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new System.Drawing.Size(40, 40),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(4),
                    Cursor = Cursors.Hand
                };
                label.Name = $"labelSeat_{i}";
                fpanel.Controls.Add(label);
                label.Click += KoltukLabel_Click;
            }

        }
        int yolcuKontrol = 0;
        private void KoltukLabel_Click(object sender, EventArgs e)
        {
            Label selectedSeatLabel = (Label)sender;
            int selectedSeatNumber = int.Parse(selectedSeatLabel.Text);
            
            if (yolcuKontrol == yolcuSayisi)
            {
                MessageBox.Show("Zaten yolcu sayısı kadar koltuk seçtiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (transport.KoltukDurumu[selectedSeatNumber - 1])
            {
                transport.RezervasyonuIptalEt(selectedSeatNumber);
                selectedSeatLabel.BackColor = System.Drawing.SystemColors.Control;
                yolcuKontrol--;

            }
            else
            {
                transport.KoltukRezervasyonuYap(selectedSeatNumber);
                selectedSeatLabel.BackColor = System.Drawing.Color.Black;
                yolcuKontrol++;
            }
        }
        private void buttonRezervasyon_Click(object sender, EventArgs e)
        {
            listBoxRezervasyonlar.Items.Clear();
            if (customer != null && customer.Rezervasyonlar.Count > 0)
            {
                foreach (var rezervasyon in customer.Rezervasyonlar)
                {
                    listBoxRezervasyonlar.Items.Add(rezervasyon);
                }
            }
            else
            {
                MessageBox.Show("Müşterinin rezervasyonu bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonbilgiKaydet_Click(object sender, EventArgs e)
        {
            BilgiAlma();
        }
        public void BilgiAlma()
        {
            Passenger passenger = new Passenger();

            if (string.IsNullOrEmpty(textBoxAd.Text))
            {
                MessageBox.Show("Lütfen yolcu adını  giriniz.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else passenger.Ad = textBoxAd.Text.Trim();

            if (string.IsNullOrEmpty(textBoxSoyAd.Text))
            {
                MessageBox.Show("Lütfen yolcunun Soyadı giriniz.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else passenger.Soyad = textBoxSoyAd.Text.Trim();

            if (!double.TryParse(textBoxTC.Text, out double tc))
            {
                MessageBox.Show("Lütfen yolcu TC giriniz.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else passenger.TC = double.Parse(textBoxTC.Text);

            if (string.IsNullOrEmpty(textBoxTarih.Text))
            {
                MessageBox.Show("Lütfen yolcu için doğum tarihi giriniz.", "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else passenger.DogumTarihi = textBoxTarih.Text.Trim();
            
            customer.RezervasyonYap(passenger, transport);
        }
        private void buttonSonrakiYolcu_Click(object sender, EventArgs e)
        {
            textBoxAd.Clear();
            textBoxSoyAd.Clear();
            textBoxTarih.Clear();
            textBoxTC.Clear();
        }
    }
}
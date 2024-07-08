using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROLAB2._1
{
    internal class Class1
    {
    }
   public interface ILoginable 
    {
         string KullaniciAdi { get; set; }
         string KullaniciSifre { get; set; }
        bool KimlikDogrula(string girilenKullaniciAdi, string girilenSifre);
    }
   public interface IProfitable 
    {

    }
   public interface IReservable // koltuk
    {
        void KoltukRezervasyonuYap(int koltukNumarasi);
        void RezervasyonuIptalEt(int koltukNumarasi);
    }

    public abstract class User : ILoginable
    {
        public string KullaniciAdi { get; set ; }
        public string KullaniciSifre { get ; set ; }
        public virtual bool KimlikDogrula(string girilenKullaniciAdi, string girilenSifre)
        {
            return KullaniciAdi == girilenKullaniciAdi && KullaniciSifre == girilenSifre;
        }
    }
    public class FirmaOlustur: Admin
    {
        public string FirmaAdi { get; set; }
        public string FirmaSifre { get; set; }
        public decimal HizmetUcreti { get; set; }
        public override string ToString()
        {
            return $"Firma Adı: {FirmaAdi}, Hizmet Ücreti: {HizmetUcreti}";
        }
    }
    public class Admin : User
    {
        private static Admin instance;

        public static Admin Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Admin();
                }
                return instance;
            }
        }
        public List<FirmaOlustur> firmalar = new List<FirmaOlustur>();
        public void FirmaEkle(string firmaAdi, decimal hizmetUcreti,string firmaSifre)
        {
            if (!string.IsNullOrEmpty(firmaAdi))
            {
                FirmaOlustur yeniFirma = new FirmaOlustur { FirmaAdi = firmaAdi, HizmetUcreti = hizmetUcreti, FirmaSifre=firmaSifre };
                firmalar.Add(yeniFirma);
            }
            else
            {
                MessageBox.Show("Firma adını giriniz.");
            }
        }
        public void FirmaSil(int index)
        {
            firmalar.RemoveAt(index);
           
        }
    }

   public class Company : User , IProfitable
    {
        private static Company instance;

        public static Company Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Company();
                }
                return instance;
            }
        }
        public List<Vehicle> vehicles;
        public List<Route> Rotalar { get; set; }
        public List<Trip> Seferler { get; set; }

        public Company()
        {
            vehicles = new List<Vehicle>();
            Rotalar = new List<Route>();
            Seferler = new List<Trip>();
        }

        public void AracEkle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void AracSil(int index)
        {
            vehicles.RemoveAt(index);

        }
        public void RotaEkle(Route rota)
        {
            Rotalar.Add(rota);
        }
        public void RotaSil(int index)
        {
            Rotalar.RemoveAt(index);
        }
        public void SeferEkle(Trip sefer)
        {
            Seferler.Add(sefer);
        }
        public void SeferSil(int index)
        {
            Seferler.RemoveAt(index);
        }
    }

    public abstract class Vehicle
    {
        public string VehicleType { get; set; }
        public string VehicleId { get; set; }
        public string YakitTur { get; set; }
        public decimal YakitUcreti { get; set; }
        public int YolcuSayisi { get; set; }
        public List<Personel> KullananPersoneller { get; set; }
        public List<Personel> HizmetVerenPersoneller { get; set; }
        public abstract decimal CalculateHarcananPara();
        public override string ToString()
        {
            return $"{VehicleType} -  ID: {VehicleId}";
        }

    }
    public class Bus : Vehicle
    {
        public Bus()
        {
            VehicleType = "Otobüs";
        }

        public override decimal CalculateHarcananPara()
        {
            return YakitUcreti; 
        }
    }
    public class Train : Vehicle
    {
        public Train()
        {
            VehicleType = "Tren";
        }
        public override decimal CalculateHarcananPara()
        {
           // Tren için özel alınan yol hesaplaması burada yapılır.
            return YakitUcreti; // Örnek amaçlı 0 döndürüldü.
        }
    }
    public class Airplane : Vehicle
    {
        public Airplane()
        {
            VehicleType = "Uçak";
        }
        public override decimal CalculateHarcananPara()
        {
            return YakitUcreti; 
        }
    }
    public class Trip
    {
        private static Trip instance;
        public static Trip Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Trip();
                }
                return instance;
            }
        }
        public int SeferNo { get; set; }
        public string AracId{ get; set; }
        public Route Rota { get; set; }
        public string Gun { get; set; }
        public int Fiyat { get; set; }
        public override string ToString()
        {
            return $"Sefer Numarası: {SeferNo}, Araç ID: {AracId}, Fiyat: {Fiyat}, Gün: {Gun}";
        }
    }
    public class Route
    {
        public string KalkisSehri { get; set; }
        public string VarisSehri { get; set; }

        public  List<List<string>> seferNo;
        public Route(string kalkisSehri, string varisSehri)
        {
            
            KalkisSehri = kalkisSehri;
            VarisSehri = varisSehri;

            seferNo = new List<List<string>>();
            
            seferNo.Add(new List<string> { "Istanbul", "Kocaeli", "Bilecik", "Eskisehir", "Ankara", "Eskisehir", "Bilecik", "Kocaeli", "Istanbul" });
            seferNo.Add(new List<string> { "Istanbul", "Kocaeli", "Bilecik", "Eskisehir", "Konya", "Eskisehir", "Bilecik", "Kocaeli", "Istanbul" });
            seferNo.Add(new List<string> { "Istanbul", "Kocaeli", "Ankara", "Kocaeli", "Istanbul", "Kocaeli", "Ankara", "Kocaeli", "Istanbul" });
            seferNo.Add(new List<string> { "Istanbul", "Kocaeli", "Eskisehir", "Konya", "Eskisehir", "Kocaeli", "Istanbul" });
            seferNo.Add(new List<string> { "Istanbul", "Konya", "Istanbul" });
            seferNo.Add(new List<string> { "Istanbul", "Ankara", "Istanbul" });
        }
        public List<string> SeferSehirleri(int no)
        {
            if (no >= 1 && no <= seferNo.Count)
            {
                return seferNo[no - 1];
            }
            return null; 
        }
        public override string ToString()
        {
            return $"";
        }
    }
    public class FiyatMatrisleri
    {
        public Dictionary<string, Dictionary<string, int>> KarayoluFiyatMatrisi { get; set; }
        public Dictionary<string, Dictionary<string, int>> DemiryoluFiyatMatrisi { get; set; }
        public Dictionary<string, Dictionary<string, int>> HavayoluFiyatMatrisi { get; set; }

        public FiyatMatrisleri()
        {
            KarayoluFiyatMatrisi = new Dictionary<string, Dictionary<string, int>>
        {
            {"Istanbul", new Dictionary<string, int> {{"Kocaeli", 50}, {"Ankara", 300}, {"Eskisehir", 150}, {"Konya", 300}}},
            {"Kocaeli", new Dictionary<string, int> {{"Istanbul", 50}, {"Ankara", 400}, {"Eskisehir", 100}, {"Konya", 250}}},
            {"Ankara", new Dictionary<string, int> {{"Istanbul", 300}, {"Kocaeli", 400}}},
            {"Eskisehir", new Dictionary<string, int> {{"Istanbul", 150}, {"Kocaeli", 100},  {"Konya", 150}}},
            {"Konya", new Dictionary<string, int> {{"Istanbul", 300}, { "Kocaeli", 250 } ,{ "Eskisehir", 150},}},
            
        };

            DemiryoluFiyatMatrisi = new Dictionary<string, Dictionary<string, int>>
        {
            {"Istanbul", new Dictionary<string, int> {{"Kocaeli", 50}, { "Bilecik", 150 }, { "Ankara", 250}, {"Eskisehir", 200}, {"Konya", 300}}},
            {"Kocaeli", new Dictionary<string, int> {{"Istanbul", 50}, { "Bilecik", 50 }, { "Ankara", 150}, {"Eskisehir", 100}, {"Konya", 250}}},
            {"Bilecik", new Dictionary<string, int> {{"Istanbul", 150}, {"Ankara", 150}, {"Eskisehir", 50}, {"Konya", 200}}},
           {"Ankara", new Dictionary<string, int> {{"˙Istanbul", 250}, {"Kocaeli", 200},{ "Bilecik", 150 },{ "Eskisehir", 100 }}},
            {"Eskisehir", new Dictionary<string, int> {{"Istanbul", 200}, {"Kocaeli", 100}, { "Bilecik", 50 },  { "Konya", 150}}},
            {"Konya", new Dictionary<string, int> {{"Istanbul", 300}, { "Kocaeli", 250 }, { "Bilecik", 200 }, { "Eskisehir", 150},}},
        };

            HavayoluFiyatMatrisi = new Dictionary<string, Dictionary<string, int>>
        {
            {"Istanbul", new Dictionary<string, int> {{"Ankara", 1000}, {"Konya", 1200}}},
            {"Ankara", new Dictionary<string, int> {{"Istanbul", 1000}}},
           {"Konya", new Dictionary<string, int> {{"Istanbul", 1200}}},
        };
        }
    }
    public class YolMatrisleri
    {
        public Dictionary<string, Dictionary<string, int>> KarayoluKMMatrisi { get; set; }
        public Dictionary<string, Dictionary<string, int>> DemiryoluKMMatrisi { get; set; }
        public Dictionary<string, Dictionary<string, int>> HavayoluKMMatrisi { get; set; }

        public YolMatrisleri()
        {
            KarayoluKMMatrisi = new Dictionary<string, Dictionary<string, int>>
        {
            {"Istanbul", new Dictionary<string, int> {{"Kocaeli", 100}, {"Ankara", 500}, {"Eskisehir", 300}, {"Konya", 600}}},
            {"Kocaeli", new Dictionary<string, int> {{"Istanbul", 100}, {"Ankara", 400}, {"Eskisehir", 200}, {"Konya", 500}}},
            {"Ankara", new Dictionary<string, int> { { "Istanbul", 500 }, {"Kocaeli", 400}}},
            {"Eskisehir", new Dictionary<string, int> {{"Istanbul", 300}, {"Kocaeli", 200},  {"Konya", 300}}},
            {"Konya", new Dictionary<string, int> {{"Istanbul", 600}, { "Kocaeli", 500 } ,{ "Eskisehir", 300},}},

        };

            DemiryoluKMMatrisi = new Dictionary<string, Dictionary<string, int>>
        {
            {"Istanbul", new Dictionary<string, int> {{"Kocaeli", 75}, { "Bilecik", 225 }, { "Ankara", 375}, {"Eskisehir", 300}, {"Konya", 450}}},
            {"Kocaeli", new Dictionary<string, int> {{"Istanbul", 75}, { "Bilecik", 75 }, { "Ankara", 300}, {"Eskisehir", 150}, {"Konya", 350}}},
            {"Bilecik", new Dictionary<string, int> {{"Istanbul", 225},{ "Kocaeli" ,75}, {"Ankara", 150}, {"Eskisehir", 50}, {"Konya", 200}}},
           {"Ankara", new Dictionary<string, int> {{"˙Istanbul", 375}, {"Kocaeli", 300},{ "Bilecik", 225 },{ "Eskisehir", 150 }}},
            {"Eskisehir", new Dictionary<string, int> {{"Istanbul", 300}, {"Kocaeli", 100}, { "Bilecik", 150 },{ "Ankara" ,150},  { "Konya", 225}}},
            {"Konya", new Dictionary<string, int> {{"Istanbul", 450}, { "Kocaeli", 350 }, { "Bilecik", 300 }, { "Eskisehir", 225},}},
        };

            HavayoluKMMatrisi = new Dictionary<string, Dictionary<string, int>>
        {
            {"Istanbul", new Dictionary<string, int> {{"Ankara", 250}, {"Konya", 300}}},
            {"Ankara", new Dictionary<string, int> {{"Istanbul", 250}}},
           {"Konya", new Dictionary<string, int> {{"Istanbul", 300}}},
        };
        }
    }
    public abstract class Person
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
    public class Personel : Person
    {
        public double Maas { get; set; }

        public Personel(string ad, string soyad, double maas)
        {
            Ad = ad;
            Soyad = soyad;
            Maas = maas;
        }
    }
    public class Passenger : Person
    {
        public double TC { get; set; }
        public string DogumTarihi { get; set; }
        public override string ToString()
        {
            return $"Yolcu: {Ad} {Soyad} - TC :{TC} - DG:{DogumTarihi}";
        }
    }
    public class Customer
    {
        public List<Reservation> Rezervasyonlar{ get; set; }
        public Customer()
        {
            Rezervasyonlar = new List<Reservation>();
        }
        public void RezervasyonYap(Passenger passenger, Transport transport)
        {
            Reservation reservation = new Reservation
            {
                YolcuBilgisi = passenger,
                UlasimBilgisi = transport,
            };
           // transport.KoltukRezervasyonuYap(koltukNumarasi);
            Rezervasyonlar.Add(reservation);
        }
    }
    public class Reservation
    {
        public Passenger YolcuBilgisi { get; set; }
        public Transport UlasimBilgisi { get; set; }
        public int KoltukNumarasi { get; set; }
        public override string ToString()
        {
            return $"{YolcuBilgisi} {UlasimBilgisi}";
        }
    }
    public class Transport : IReservable
    {
        public List<Admin> Sirketler { get; set; }
        public List<Trip> Seyahatler { get; set; }
        public bool[] KoltukDurumu { get; set; }
        public int SecilenKoltuk { get; set; }
        public Transport( int koltukSayisi)
        {
            Sirketler = new List<Admin>();
            KoltukDurumu = new bool[koltukSayisi];
            Seyahatler = new List<Trip>();
        }
        public void KoltukRezervasyonuYap(int koltukNumarasi)
        {
            if (koltukNumarasi >= 1 && koltukNumarasi <= KoltukDurumu.Length)
            {
                if (!KoltukDurumu[koltukNumarasi - 1])
                {
                    KoltukDurumu[koltukNumarasi - 1] = true;
                    MessageBox.Show($"Koltuk {koltukNumarasi} başarıyla rezerve edildi.");
                    SecilenKoltuk = koltukNumarasi;
                }
                else
                {
                    MessageBox.Show($"Koltuk {koltukNumarasi} zaten rezerve edilmiş.");
                }
            }
            else
            {
                MessageBox.Show("Geçersiz koltuk numarası.");
            }
        }

        public void RezervasyonuIptalEt(int koltukNumarasi)
        {
            if (koltukNumarasi >= 1 && koltukNumarasi <= KoltukDurumu.Length)
            {
                if (KoltukDurumu[koltukNumarasi - 1])
                {
                    KoltukDurumu[koltukNumarasi - 1] = false;
                     MessageBox.Show($"Koltuk {koltukNumarasi} için rezervasyon başarıyla iptal edildi.");
                }
                else
                {
                    MessageBox.Show($"Koltuk {koltukNumarasi} zaten rezerve edilmemiş.");
                }
            }
            else
            {
                MessageBox.Show("Geçersiz koltuk numarası.");
            }
        }
        public override string ToString()
        {
            return $"koltuk: {SecilenKoltuk} ";
        }
    }
    
}

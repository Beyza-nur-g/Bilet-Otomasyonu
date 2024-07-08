using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROLAB2._1
{
     class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Admin admin = Admin.Instance;
            Company myCompany = Company.Instance;

            admin.FirmaEkle("a", 1000, "a123");
            admin.FirmaEkle("b", 1000, "b123");
            admin.FirmaEkle("c", 1000, "c123");
            admin.FirmaEkle("d", 1000, "d123");
            admin.FirmaEkle("f", 1000, "f123");

            Bus A1Otobus = new Bus
            {
                VehicleId = "A Otobüs 1",
                YakitTur = "Benzin",
                YakitUcreti = 10,
                YolcuSayisi = 20
            };
            Bus A2Otobus = new Bus
            {
                VehicleId = "A Otobüs 2",
                YakitTur = "Benzin",
                YakitUcreti = 10,
                YolcuSayisi = 15
            };
            Bus B1Otobus = new Bus
            {
                VehicleId = " B Otobüs 1",
                YakitTur = "Motorin",
                YakitUcreti = 5,
                YolcuSayisi = 15
            };
            Bus B2Otobus = new Bus
            {
                VehicleId = " B Otobüs 2",
                YakitTur = "Motorin",
                YakitUcreti = 5,
                YolcuSayisi = 20
            };
            Bus C1Otobus = new Bus
            {
                VehicleId = " C Otobüs 1",
                YakitTur = "Motorin",
                YakitUcreti = 6,
                YolcuSayisi = 20
            };
            Airplane C1Ucak = new Airplane
            {
                VehicleId = "C Uçak 1",
                YakitTur = "Gaz",
                YakitUcreti = 25,
                YolcuSayisi = 30
            };
            Airplane C2Ucak = new Airplane
            {
                VehicleId = "C Uçak 2",
                YakitTur = "Gaz",
                YakitUcreti = 25,
                YolcuSayisi = 30
            };
            Train D1Tren = new Train
            {
                VehicleId = "D Tren 1",
                YakitTur = "Elektrik",
                YakitUcreti = 3,
                YolcuSayisi = 25
            };
            Train D2Tren = new Train
            {
                VehicleId = "D Tren 2",
                YakitTur = "Elektrik",
                YakitUcreti = 3,
                YolcuSayisi = 25
            };
            Train D3Tren = new Train
            {
                VehicleId = "D Tren 3",
                YakitTur = "Elektrik",
                YakitUcreti = 3,
                YolcuSayisi = 25
            };
            Airplane F1Ucak = new Airplane
            {
                VehicleId = "F Uçak 1",
                YakitTur = "Gaz",
                YakitUcreti = 25,
                YolcuSayisi = 30
            };
            Airplane F2Ucak = new Airplane
            {
                VehicleId = "F Uçak 2",
                YakitTur = "Gaz",
                YakitUcreti = 20,
                YolcuSayisi = 30
            };

            myCompany.AracEkle(A1Otobus);
            myCompany.AracEkle(A2Otobus);
            myCompany.AracEkle(B1Otobus);
            myCompany.AracEkle(B2Otobus);
            myCompany.AracEkle(C1Otobus);
            myCompany.AracEkle(C2Ucak);
            myCompany.AracEkle(C1Ucak);
            myCompany.AracEkle(D1Tren);
            myCompany.AracEkle(D2Tren);
            myCompany.AracEkle(D3Tren);
            myCompany.AracEkle(F1Ucak);
            myCompany.AracEkle(F2Ucak);
            

            Route route1 = new Route("Istanbul", "Ankara");
            Route route2 = new Route("Istanbul", "Eskisehir");
            Route route3 = new Route("Istanbul", "Konya");


            myCompany.RotaEkle(route1);
            myCompany.RotaEkle(route2);
            myCompany.RotaEkle(route3);
            
            Trip trip1 = new Trip
            {
                AracId = "A Otobüs 1",
                Rota = route1,
                SeferNo = 3,
                Gun = "Pazartesi",
                Fiyat = 300
            };
            myCompany.SeferEkle(trip1);

            Trip trip2 = new Trip
            {
                AracId = "A Otobüs 2",
                Rota = route3,
                SeferNo = 3,
                Gun = "Pazartesi",
                Fiyat = 300
            };
            myCompany.SeferEkle(trip2);

            Trip trip3 = new Trip
            {
                AracId = "B Otobüs 1",
                Rota = route3,
                SeferNo = 3,
                Gun = "Pazartesi",
                Fiyat = 300
            };
            myCompany.SeferEkle(trip3);

            Trip trip4 = new Trip
            {
                AracId = "B Otobüs 2",
                Rota = route2,
                SeferNo = 4,
                Gun = "Salı",
                Fiyat = 150
            };
            myCompany.SeferEkle(trip4);

            Trip trip5 = new Trip
            {
                AracId = "C Otobüs 1",
                Rota = route2,
                SeferNo = 4,
                Gun = "Salı",
                Fiyat = 150
            };
            myCompany.SeferEkle(trip5);

            Trip trip6 = new Trip
            {
                AracId = "C Uçak 1",
                Rota = route3,
                SeferNo = 5,
                Gun = "Salı",
                Fiyat = 1200
            };
            myCompany.SeferEkle(trip6);

            Trip trip7 = new Trip
            {
                AracId = "C Uçak 2",
                Rota = route1,
                SeferNo = 5,
                Gun = "Pazartesi",
                Fiyat = 1000
            };
            myCompany.SeferEkle(trip7);

            Trip trip8 = new Trip
            {
                AracId = "D Tren 1",
                Rota = route1,
                SeferNo = 1,
                Gun = "Pazartesi",
                Fiyat = 250
            };
            myCompany.SeferEkle(trip8);

            Trip trip9 = new Trip
            {
                AracId = "D Tren 2",
                Rota = route2,
                SeferNo = 2,
                Gun = "Pazartesi",
                Fiyat = 200
            };
            myCompany.SeferEkle(trip9);

            Trip trip10 = new Trip
            {
                AracId = "D Tren 3",
                Rota = route2,
                SeferNo = 2,
                Gun = "Salı",
                Fiyat = 200
            };
            myCompany.SeferEkle(trip10);

            Trip trip11 = new Trip
            {
                AracId = "F Uçak 1",
                Rota = route1,
                SeferNo = 6,
                Gun = "Pazartesi",
                Fiyat = 1000
            };
            myCompany.SeferEkle(trip11);

            Trip trip12 = new Trip
            {
                AracId = "F Uçak 2",
                Rota = route3,
                SeferNo = 6,
                Gun = "Salı",
                Fiyat = 1200
            };
            myCompany.SeferEkle(trip12);
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaEkran());
        }


    }
}

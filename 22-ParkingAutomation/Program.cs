
using Newtonsoft.Json;

namespace _22_OtoparkOtomasyon
{

    /*         
    --- Otopark Otomasyon Programı ---
    Arap plakası, Giriş saati, Araç tipi
    Çıkış saati, Ücret

    //01/01/2001 15:15

    Fiyat tarifesi


    Otomobil
    0-1 saat 80tl
    1-2 saat 110tl
    .

    Minübüs
    0-1 saat 160tl
    1-2 saat 220tl
    .



    fiyatları bir listeye kaydet
    araçBilgileri adında bir sınıf oluştur.

    Menu hazırla
        araç giriş, araç çıkış, otoparktaki araçlar, z raporu, çıkış

    Araç Giriş
        plaka al, araç tipleri al, giriş saati al, json dosyasına kaydet

    Araç Çıkış
        plaka al, çıkış saati al, ücret hesapla, json dosyasına kaydet

    Otoparktaki araçlar
        çıkış yapmamış araçlar listesini getir

    Z raporu
        günlük giriş çıkış yapmış araç bilgilerini saat ve ücretlerle getir


    */


    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
        }

        private static void Menu()
        {
            Console.WriteLine("Lütfen bir işlem seçiniz \n1- Araç Giriş \n2- Araç Çıkış \n3- Otoparktaki Araçlar \n4- Z-Raporu \n5- Çıkış");
            int menuSecimi;
            while (!int.TryParse(Console.ReadLine(), out menuSecimi))
            {
                Console.WriteLine("Lütfen sayısal bir tuşlama yapınız");
            }

            switch (menuSecimi)
            {
                case 1:
                    AracGiris();
                    break;
                case 2:
                    AracCikis();
                    break;
                case 3:
                    OtoparktakiAraclar();
                    break;
                case 4:
                    Rapor();
                    break;
            }
        }

        static List<string> GirenAracPlakalari = new List<string>();
        static List<DateTime> GirisSaatleri = new List<DateTime>();
        static List<DateTime> CikisSaatleri = new List<DateTime>();
        static List<int> AracTipleri = new List<int>();
        static List<string> CikanAracPlakalari = new List<string>();

        private static void Rapor()
        {
            throw new NotImplementedException();
        }

        private static void OtoparktakiAraclar()
        {
            if (GirenAracPlakalari.Count == 0)
            {
                Console.WriteLine("Şu anda otoparkta araç bulunmamaktadır.");
                return;
            }

            Console.WriteLine("Otoparktaki Araçlar:");

            for (int i = 0; i < GirenAracPlakalari.Count; i++)
            {
                if (!CikanAracPlakalari.Contains(GirenAracPlakalari[i]))
                {
                    Console.WriteLine($"Plaka: {GirenAracPlakalari[i]}, Giriş Saati: {GirisSaatleri[i]:MM/dd/yyyy HH:mm}");
                }
            }
        }

        private static void AracGiris()
        {
            Console.Write("Araç plakasını giriniz: ");
            string girenAracPlakasi = Console.ReadLine();
            GirenAracPlakalari.Add(girenAracPlakasi);

            Console.Write("Giriş saatini giriniz: [MM/dd/yyyy HH:mm] ");
            DateTime girisSaati = DateTime.Parse(Console.ReadLine());
            GirisSaatleri.Add(girisSaati);

            Console.Write("Araç tipini seçiniz: \n1- Otomobil \n2- Minibüs \n3- Otobüs \n4- Motosiklet ");
            int aracTipi = int.Parse(Console.ReadLine());
            AracTipleri.Add(aracTipi);

            KaydetJSON();
            Console.WriteLine("Bilgiler başarıyla kaydedildi!");
        }

        private static void AracCikis()
        {
            Console.Write("Araç plakasını giriniz: ");
            string cikanAracPlakasi = Console.ReadLine();
            CikanAracPlakalari.Add(cikanAracPlakasi);

            int index = GirenAracPlakalari.IndexOf(cikanAracPlakasi);
            if (index == -1)
            {
                Console.WriteLine("Bu plakaya sahip bir araç otoparkta bulunamadı.");
                return;
            }

            Console.Write("Çıkış saatini giriniz: [MM/dd/yyyy HH:mm] ");
            DateTime cikisSaati;
            while (!DateTime.TryParse(Console.ReadLine(), out cikisSaati))
            {
                Console.Write("Geçersiz format! Lütfen tekrar giriş yapınız: ");
            }

            CikisSaatleri.Add(cikisSaati);

            DateTime girisSaati = GirisSaatleri[index];
            TimeSpan sure = cikisSaati - girisSaati;

            double ucret = UcretHesapla(AracTipleri[index], sure);

            Console.WriteLine($"Araç içeride {sure.Hours} saat {sure.Minutes} dakika kaldı. Ödenecek Ücret: {ucret} TL");

            GirenAracPlakalari.RemoveAt(index);
            GirisSaatleri.RemoveAt(index);
            AracTipleri.RemoveAt(index);

            KaydetJSON();
            Console.WriteLine("Bilgiler başarıyla güncellendi");
        }

        private static double UcretHesapla(int aracTipi, TimeSpan sure)
        {
            double[] fiyatlar;

            switch (aracTipi)
            {
                case 1: // Otomobil
                    fiyatlar = new double[] { 80, 110, 140, 170, 300 };
                    break;
                case 2: // Minibüs
                    fiyatlar = new double[] { 160, 220, 280, 340, 600 };
                    break;
                case 3: // Otobüs
                    fiyatlar = new double[] { 250, 350, 450, 550, 900 };
                    break;
                case 4: // Motosiklet
                    fiyatlar = new double[] { 40, 55, 70, 85, 150 };
                    break;
                default:
                    Console.WriteLine("Geçersiz araç tipi!");
                    return 0;
            }

            if (sure.TotalHours <= 1)
                return fiyatlar[0];
            if (sure.TotalHours <= 2)
                return fiyatlar[1];
            if (sure.TotalHours <= 3)
                return fiyatlar[2];
            if (sure.TotalHours <= 4)
                return fiyatlar[3];

            return fiyatlar[4];
        }

        private static void KaydetJSON()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "veriler.json");
            var aracBilgileri = new List<Dictionary<string, object>>();

            for (int i = 0; i < GirenAracPlakalari.Count; i++)
            {
                aracBilgileri.Add(new Dictionary<string, object>
            {
                {"Plaka", GirenAracPlakalari[i] },
                {"GirisSaati", GirisSaatleri[i] },
                {"AracTipi", AracTipleri[i] }
            });
            }

            string json = JsonConvert.SerializeObject(aracBilgileri, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}

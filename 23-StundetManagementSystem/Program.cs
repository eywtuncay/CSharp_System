using Newtonsoft.Json;
using System;

namespace _01_StundetManagementSystem
{
    class program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
        }

        /// <summary>
        /// Menü Kontrolü
        /// </summary>
        private static void Menu()
        {
            try
            {
                Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
                Console.WriteLine("1- Tüm Öğrencileri Listele");
                Console.WriteLine("2- Yeni Öğrenci Ekle");
                Console.WriteLine("3- Öğrenci Sil");
                Console.WriteLine("4- Soyadına Göre Öğrenci Ara");
                Console.WriteLine("5- Çıkış");
                Console.WriteLine("------------------------------------");

                Console.Write("Seçiminiz: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int gelenDeger))
                {
                    switch (gelenDeger)
                    {
                        case 1: TumOgrencileriListele(); break;
                        case 2: YeniOgrenciEkle(); break;
                        case 3: OgrenciSil(); break;
                        case 4: SoyadınaGoreOgrenciAra(); break;
                        case 5:
                            Console.WriteLine("Çıkış yapılıyor...");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçim yaptınız. Lütfen tekrar deneyin.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }


        /// <summary>
        /// Tüm öğrencileri listeleme
        /// </summary>
        private static void TumOgrencileriListele()
        {
            Console.WriteLine("Tüm Öğrencilerin Listesi");
            TumOgrencilerinListesi();

        }


        /// <summary>
        /// Tüm öğrencilerin listesi
        /// </summary>
        private static void TumOgrencilerinListesi()
        {
            if (OgrenciListesi.Count == 0)
            {
                Console.WriteLine("Liste boştur.");
                return;
            }

            foreach (var item in OgrenciListesi)
            {
                Console.WriteLine($"Öğrenci No: {item.ogrenciNo}");
                Console.WriteLine($"Öğrenci Adı: {item.ad}");
                Console.WriteLine($"Öğrenci Soyadı: {item.soyad}");
                Console.WriteLine($"Öğrenci Yaşı: {item.yas}");
                Console.WriteLine($"Öğrenci Not Ortalaması: {item.notOrtalamasi}");
                Console.WriteLine("------------------------------------");
            }
        }


        public static List<Ogrenciler> OgrenciListesi = new List<Ogrenciler>();

        /// <summary>
        /// Yeni öğrenci ekleme
        /// </summary>
        private static void YeniOgrenciEkle()
        {
            //Öğrenci sınıfından yeni bir öğrenci oluşturma
            Ogrenciler ogrenci = new Ogrenciler();

            //Öğrenci numarasını alma
            ogrenci.ogrenciNo = AlOgrenciNo();

            //Öğrencinin adını alma
            ogrenci.ad = AlOgrenciAdi();

            //Öğrencinin soyadını alma
            ogrenci.soyad = AlOgrenciSoyadi();

            //Öğrencinin yaşını alma
            ogrenci.yas = AlOgrenciYas();

            //Öğrencinin not ortalamasını alma
            ogrenci.notOrtalamasi = AlOgrenciNotOrtalamasi();

            // Listeye ekle
            OgrenciListesi.Add(ogrenci);

            // Json dosyasına kaydetme
            OgrenciListesiKaydetJson();

            Console.WriteLine("Öğrenci Kaydı başarıyla tamamlandı. \n");

        }



        static string jsonFilePath = "ogrenciKayitVerileri.json";
        private static void OgrenciListesiKaydetJson()
        {
            string json = JsonConvert.SerializeObject(OgrenciListesi, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }

        /// <summary>
        /// Öğrenci numarası alma
        /// </summary>
        /// <returns></returns>
        private static int AlOgrenciNo()
        {
            while (true)
            {
                Console.Write("Öğrenci Numarasını Giriniz (4 hane): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int ogrenciNo) && input.Length == 4)
                {
                    if (!OgrenciListesi.Any(o => o.ogrenciNo == ogrenciNo))
                    {
                        return ogrenciNo;
                    }
                    else
                    {
                        Console.WriteLine("Bu öğrenci numarası zaten mevcut. Lütfen farklı bir numara giriniz.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz öğrenci numarası.");
                }
            }
        }


        // Kayıtlı öğrencileri json dosyasından okuma
        /// <summary>
        /// Kayıtlı öğrencileri json dosyasından okuma
        /// </summary>
        private static void OgrenciListesiOkuJson()
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                OgrenciListesi = JsonConvert.DeserializeObject<List<Ogrenciler>>(json);
            }
        }


        // Ekstra : Not ortalaması 50'den küçük olan öğrencileri listele ve yeni bir json dosyasına kaydet
        /// <summary>
        /// Not ortalaması 50'den küçük olan öğrencileri listeler ve yeni bir json dosyasına kaydeder
        /// </summary>
        private static void NotOrtalamasi50denKucukOlanOgrencileriListeleVeJsonDosyasinaKaydet()
        {
            var ogrenciler = OgrenciListesi.Where(o => o.notOrtalamasi < 50).ToList();
            if (ogrenciler.Any())
            {
                //Listeleme
                Console.WriteLine("Not Ortalaması 50'den küçük olan öğrenciler:");
                foreach (var ogrenci in ogrenciler)
                {
                    Console.WriteLine($"Öğrenci No: {ogrenci.ogrenciNo}");
                    Console.WriteLine($"Öğrenci Adı: {ogrenci.ad}");
                    Console.WriteLine($"Öğrenci Soyadı: {ogrenci.soyad}");
                    Console.WriteLine($"Öğrenci Yaşı: {ogrenci.yas}");
                    Console.WriteLine($"Öğrenci Not Ortalaması: {ogrenci.notOrtalamasi}");
                    Console.WriteLine("------------------------------------");
                }

                //Json dosyasına kaydetme
                string json = JsonConvert.SerializeObject(ogrenciler, Formatting.Indented);
                File.WriteAllText("NotOrtalamasi50denKucukOlanOgrenciler.json", json);
                Console.WriteLine("Not ortalaması 50'den küçük olan öğrenciler başarıyla kaydedildi.");
            }
            else
            {
                Console.WriteLine("Not ortalaması 50'den küçük olan öğrenci bulunamadı.");
            }
        }


        /// <summary>
        /// Öğrenci Not Ortalamasını alma
        /// </summary>
        /// <returns></returns>
        private static double AlOgrenciNotOrtalamasi()
        {
            double ogrenciNotOrtalamasi;
            while (true)
            {
                Console.Write("Öğrenci Not Ortalamasını Giriniz: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out ogrenciNotOrtalamasi))
                {
                    return ogrenciNotOrtalamasi;
                }
                else
                {
                    Console.WriteLine("Geçersiz Not Ortalamasını. Lütfen tekrar deneyin.");
                }
            }
        }


        /// <summary>
        /// Öğrenci yaşını alma
        /// </summary>
        /// <returns></returns>
        private static int AlOgrenciYas()
        {
            int ogrenciYas;
            while (true)
            {
                Console.Write("Öğrenci Yaşı Giriniz: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out ogrenciYas))
                {
                    return ogrenciYas;
                }
                else
                {
                    Console.WriteLine("Geçersiz Öğrenci Yaşı. Lütfen tekrar deneyin.");
                }
            }
            

        }


        /// <summary>
        /// Öğrenci soyadını alma
        /// </summary>
        /// <returns></returns>
        private static string AlOgrenciSoyadi()
        {
            while (true)
            {
                Console.WriteLine("Öğrencinin Soyadını Giriniz: ");
                string ogrenciSoyadi = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(ogrenciSoyadi))
                {
                    return ogrenciSoyadi;
                }
                else
                {
                    Console.WriteLine("Öğrenci Soyadı boş geçilemez. Lütfen geçerli bir Soyad giriniz.");
                }
            }
        }


        /// <summary>
        /// Öğrenci adını alma
        /// </summary>
        /// <returns></returns>
        private static string AlOgrenciAdi()
        {
            while (true)
            {
                Console.WriteLine("Öğrencinin Adını Giriniz: ");
                string ogrenciAdi = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(ogrenciAdi))
                {
                    return ogrenciAdi;
                }
                else
                {
                    Console.WriteLine("Öğrenci adı boş geçilemez. Lütfen geçerli bir ad giriniz.");
                }
            }
        }



        /// <summary>
        /// Öğrenci silme
        /// </summary>
        private static void OgrenciSil()
        {
            
            TumOgrencileriListele();

            Console.WriteLine("Silmek istediğiniz öğrencinin numarasını giriniz: ");
            if (int.TryParse(Console.ReadLine(), out int ogrenciNo))
            {
                OgrenciNumarasinaGoreOgrenciSil(ogrenciNo);
            }
            else
            {
                Console.WriteLine("Geçersiz öğrenci numarası. Lütfen tekrar deneyin.");
            }
        }


        /// <summary>
        /// Öğrenci numarasına göre öğrenci silme
        /// </summary>
        /// <param name="ogrenciNo">Öğrenci Numarası</param>
        private static void OgrenciNumarasinaGoreOgrenciSil(int ogrenciNo)
        {
            var ogrenci = OgrenciListesi.FirstOrDefault(value => value.ogrenciNo == ogrenciNo);
            if (ogrenci != null)
            {
                OgrenciListesi.Remove(ogrenci);
                Console.WriteLine("Öğrenci başarıyla silindi.");
                OgrenciListesiKaydetJson();
            }
            else
            {
                Console.WriteLine("Öğrenci bulunamadı.");
            }
        }


        /// <summary>
        /// Soyadına göre öğrenci arama
        /// </summary>
        private static void SoyadınaGoreOgrenciAra()
        {
            Console.WriteLine("Aramak istediğiniz öğrencinin soyadını giriniz: ");
            string soyad = Console.ReadLine();

            var eslesenOgrenciler = OgrenciListesi.Where(o => o.soyad.Equals(soyad, StringComparison.OrdinalIgnoreCase)).ToList();

            if (eslesenOgrenciler.Any())
            {
                Console.WriteLine("Eşleşen Öğrenciler:");
                foreach (var ogrenci in eslesenOgrenciler)
                {
                    Console.WriteLine($"Öğrenci No: {ogrenci.ogrenciNo}");
                    Console.WriteLine($"Öğrenci Adı: {ogrenci.ad}");
                    Console.WriteLine($"Öğrenci Soyadı: {ogrenci.soyad}");
                    Console.WriteLine($"Öğrenci Yaşı: {ogrenci.yas}");
                    Console.WriteLine($"Öğrenci Not Ortalaması: {ogrenci.notOrtalamasi}");
                    Console.WriteLine("------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Bu soyada sahip öğrenci bulunamadı.");
            }
        }

    }
}


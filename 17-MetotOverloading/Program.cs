


using static System.Net.Mime.MediaTypeNames;

namespace _17_MetotOverloading
{
    internal class Program
    {


        #region Örnek: mail oluşturma

        //MailOluştur isminde metotlar yazınız.
        // string isim
        // isim, soyisim alsın aralarına nokta konulsun
        // isim, soyisim, domain alsın.



        //Erişim belirleyicileri: public, internal, protected, private
        //static void Main(string[] args)
        //{
        //    //Method Overloading (Metot Aşırı Yükleme) bir metodun adının aynı imzalarının (parametrelerin) farklı olduğu
        //    // bir çok kullanım gerçekleştirebiliriz.

        //    Console.WriteLine(MailOlustur("tuncay"));
        //    Console.WriteLine(MailOlustur("tuncay", "albayrak"));
        //    Console.WriteLine(MailOlustur("tuncay", "albayrak", "bilgeadam.com"));

        //}

        //static int EkranaYaz(int yas)
        //{
        //    Console.WriteLine("Merhaba yaşınız: ");
        //    return 1;
        //}

        //static void EkranaYaz()
        //{
        //    Console.WriteLine("Merhaba Dünya");
        //}

        //static void EkranaYaz(string ad)
        //{
        //    Console.WriteLine("Merhaba " + ad);
        //}


        ////Ad ve Soyad alan versiyon.
        //static void EkranaYaz(string ad, string soyAd)
        //{
        //    Console.WriteLine("Merhaba " + ad);
        //}

        ////3 ayrı metot yaz
        //static string MailOlustur(string ad)
        //{
        //    return ad + "@bilgeadam.com";

        //}
        //static string MailOlustur(string ad, string soyad)
        //{
        //    return ad + "." + soyad + "@bilgeadam.com";
        //}
        //static string MailOlustur(string ad, string soyad, string domain)
        //{
        //    return ad + "." + soyad + "@" + domain;
        //}






        #endregion


        #region Ödev 1: Türkçe Karakter Convert

        //Ödev: Türkçe karakterler ingilizceye dönecek. Türkçe karakterleri ingilizceye çeviren metot yazılacak.

        //static void Main()
        //{

        //    Console.Write("Bir metin girin: ");
        //    string input = Console.ReadLine();

        //    string dondurulmusMetin = TurkceKaraktereDonustur(input);

        //    Console.WriteLine("Dönüştürülmüş metin: " + dondurulmusMetin);
        //}

        //static string TurkceKaraktereDonustur(string metin)
        //{

        //    char[] turkceKarakterler = { 'ç', 'ğ', 'ı', 'ö', 'ş', 'ü', 'Ç', 'Ğ', 'İ', 'Ö', 'Ş', 'Ü' };
        //    char[] ingilizceKarakterler = { 'c', 'g', 'i', 'o', 's', 'u', 'C', 'G', 'I', 'O', 'S', 'U' };

        //    for (int i = 0; i < turkceKarakterler.Length; i++)
        //    {
        //        metin = metin.Replace(turkceKarakterler[i], ingilizceKarakterler[i]);
        //    }

        //    return metin;
        //}



        #endregion


        #region Ödev 2: Tc No Kontrol


        //Ödev: Tc no göndereceğiz. doğru mu yanlış mı kontrol et. Kuralları kontrol et.
        /*
        
            Uzunluk kontrolü 11 hane olmalı.
            Sadece rakam içermeli
            İlk hane 0 olamaz, son hane çift olmalıdır.
            
        */


        static void Main()
        {
            Console.Write("TC Kimlik Numaranızı Girin: ");
            string tcKimlikNo = Console.ReadLine();

            if (TcKimlikNoDogrula(tcKimlikNo))
            {
                Console.WriteLine("Geçerli bir TC Kimlik Numarası.");
            }
            else
            {
                Console.WriteLine("Geçersiz TC Kimlik Numarası!");
            }
        }

        static bool TcKimlikNoDogrula(string tcKimlikNo)
        {
            return GecerliUzunluktaMi(tcKimlikNo) &&
                   SadeceRakamMi(tcKimlikNo) &&
                   IlkRakamSifirDegilMi(tcKimlikNo) &&
                   SonRakamCiftMi(tcKimlikNo) &&
                   OnHaneKontrolu(tcKimlikNo) &&
                   OnbirHaneKontrolu(tcKimlikNo);
        }

        static bool GecerliUzunluktaMi(string tcKimlikNo)
        {
            return tcKimlikNo.Length == 11;
        }

        static bool SadeceRakamMi(string tcKimlikNo)
        {
            return long.TryParse(tcKimlikNo, out _);
        }

        static bool IlkRakamSifirDegilMi(string tcKimlikNo)
        {
            return tcKimlikNo[0] != '0';
        }

        static bool SonRakamCiftMi(string tcKimlikNo)
        {
            return (tcKimlikNo[10] - '0') % 2 == 0;
        }

        static bool OnHaneKontrolu(string tcKimlikNo)
        {
            int[] rakamlar = RakamlarıDönüştür(tcKimlikNo);
            int toplam1 = (rakamlar[0] + rakamlar[2] + rakamlar[4] + rakamlar[6] + rakamlar[8]) * 7;
            int toplam2 = rakamlar[1] + rakamlar[3] + rakamlar[5] + rakamlar[7];
            return (toplam1 - toplam2) % 10 == rakamlar[9];
        }

        static bool OnbirHaneKontrolu(string tcKimlikNo)
        {
            int[] rakamlar = RakamlarıDönüştür(tcKimlikNo);
            int ilk10HaneToplami = 0;
            foreach (int rakam in rakamlar.Take(10))
            {
                ilk10HaneToplami += rakam;
            }
            return ilk10HaneToplami % 10 == rakamlar[10];
        }

        static int[] RakamlarıDönüştür(string tcKimlikNo)
        {
            int[] rakamlar = new int[11];
            for (int i = 0; i < 11; i++)
            {
                rakamlar[i] = tcKimlikNo[i] - '0';
            }
            return rakamlar;
        }


        #endregion


        

    }
}

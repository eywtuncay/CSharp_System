
/*

Sınıfların ya da struct içerisinde metotları kullanıyor.
Bir kere yazıp çok kere kullanmak amacıyla
*/



// Parametreli Metot değer döndüren (int, bool, Datetime, string, class) 
//bool result = int.TryParse("123", out int sayi);
//DateTime d = DateTime.Parse("");
//short s = Convert.ToInt16("");
//int s1 = Array.IndexOf(new int[6], 3);
//bool b1 = "".Contains("");
//double d1 = Math.Pow(2, 4);


//////Parametreli metot değer döndürmeyen (void)
//Array.Sort(new int[4]);
//Array.Copy(new int[4], new int[8], 2);
//Console.WriteLine("");
//new List<int>().Add(4);
//Console.Beep(12, 200);


////Parametresiz Metot değer döndüren
//string m1 = "".ToUpper();
//string m2 = Console.ReadLine();
//int s2 = new Random().Next();


////Parametresiz Metot değer döndürmeyen
//Console.WriteLine();
//Console.Clear();
//Console.Beep();



#region MetotOrnekerli



namespace _13_Metotlar
{


    public class Program
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("Tuncay.");
            EkranaYaziYaz();
            EkranaIsimYaz("tuncay", 24);
            string fullName = AdSoyadBirlestir();

            string[] mailler = Ayristirici("tuncay.albayrak.65@outlook.com", "tuncay.albayrak@bilgeadamakademi.com";"denem@deneme.com");
        }


        #region Metot Tanımlama


        /*
        
            Metotlar sınıf içerisinde tanımlanır.

            Syntax;
            ErişimBelirleyicisi(public-private-internal-protected) Niteleyici(varsa)(static) DönüşTipi (void, int, bool, char....) MetotAdı(parametre varsa))
            {
                Metot çağırıldığında işleyecek kodlar.
            }
        
            
            Metot Çağırma;
            MetotAdi(parametre(varsa));


            1) Eişim belirleyicisi (Acces modifier): Metot'a kullanım yetkisi verir.
            Metotların default erişim belirleyicisi private'dir.

            private : Bu metoda sadece bu sınıf içerisinden ulaşılabilir.
            public : Bu metoda projenin herhangi bir yerinde kullanabilirsiniz. Umumi

            2) Niteleyici (static) : static anahtar kelimesini kısaca açıklamak gerekirse - oluşturduğumuz metodu bellekte sabit hale getirir.

            3) Dönüş Tipi : Metodun çalışması sonucu kendisinin bir bilgi verip vermeyeceğini belirlediğimiz yerdir.

            Eğer bir bilgi döndüreceksek; int, string, double, bool, class gibi değerler alacak. Geriye değer döndürmeyecekse void anahtar kelimesini alır.

            4) Metot ismi : metot çağrılırken kullanılacak isimdir.

        */



        #endregion

        // Geriye değer döndürmeyen parametresiz metot

        private static void EkranaYaziYaz()
        {
            //Çalıştırılacak kod.
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World!");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        // Geriye değer döndürmeyen Parametreli metot
        private static void EkranaIsimYaz(string isim, int yas)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(isim);
            Console.WriteLine("Yaş: " + yas);
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Geriye değer döndüren Parametresiz metot
        private static string AdSoyadBirlestir()
        {
            return "Tuncay " + "Albayrak";
        }

        // Geriye değer döndüren Parametreli metot
        private static string[] Ayristirici(string mailAdresleri)
        {
            return mailAdresleri.Split(',', ';');
        }



        // 1) Topla isminde bir metot oluştur. 2 tane int tipinde parametre alsın. geriye int döndürsün.

        private static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }


        // 2) Bölme isminde bir metot oluştur. İçerisine double tipinde iki parametre alsın ve double döndürsün.

        private static double Bolme(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }


        // 3) CiftMi isimnde int parametre alan bir metot oluştur. geriye bool döndürsün

        private static bool ciftMi(int sayi)
        {
            return sayi % 2 == 0;

        }
    }


}


#endregion

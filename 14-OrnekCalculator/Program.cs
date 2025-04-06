// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


//Hesap Makinesi


/*

Moduler şekilde tekrardan yaz.
Main içerisinde DoWhile ile tekrardan hesaplama yapması için kullan.
Sayıların alındığı yerlerde DoWhile ile değerleri kontrol et.
Sayıları almayı da hesaplamayı da metotla yap
Sordevammı diye metot da var.



namespace altında class Program var
adltında void Hesapla metodu var.
altında Bilgi();
double sayi1 = SayiAl();

switch (islem)
{
    case "+" :
        Console.WeiteLine("Sonuç : " + Toplam(sayi1, sayi2));
        break;
    case "-" :
            Console.WeiteLine("Sonuç : " + Toplam(sayi1, sayi2));
            break;
    
}
    
switch (islem)
    case "-" : Console.WeiteLine("Sonuç : " + Cikar(sayi1, sayi2));
    break;
switch (islem)
    case "*" : Console.WeiteLine("Sonuç : " + Carp(sayi1, sayi2));
    break;
switch (islem)
    case "/" : Console.WeiteLine("Sonuç : " + Bol(sayi1, sayi2));
    break;

 
*/


namespace _14_HesapMakinesi
{
    public class Program
    {


        

        public static void Main(string[] args)
        {


            //Console.Write("Birinci sayıyı giriniz: ");
            //if (!(int.TryParse(Console.ReadLine(), out int sayi1)))
            //{
            //    Console.WriteLine("Lütfen sayısal bir değer giriniz.");
            //}

            //Console.Write("İkinci sayıyı giriniz: ");
            //if (!(int.TryParse(Console.ReadLine(), out int sayi2)))
            //{
            //    Console.WriteLine("Lütfen sayısal bir değer giriniz.");
            //}

            //Console.WriteLine("Lütfen işlem seçiniz: [+] - [-] - [*] - [/] ");
            //char islem = char.Parse(Console.ReadLine());


            //switch(islem)
            //{
            //    case '+':
            //        Console.WriteLine(Topla(sayi1, sayi2));
            //        break;
            //    case '-':
            //        Console.WriteLine(Cikar(sayi1, sayi2));
            //        break;
            //    case '*':
            //        Console.WriteLine(Carp(sayi1, sayi2));
            //        break;
            //    case '/':
            //        Console.WriteLine(Bol(sayi1, sayi2));
            //        break;
            //    default:
            //        Console.WriteLine("Lütfen geçerli bir işlem seçiniz");
            //        break;
            //}

            
        }

       

        private static void Main()
        {
            throw new NotImplementedException();
        }

        private static int Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }

        private static int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        private static int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        private static int Bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }

    }






}

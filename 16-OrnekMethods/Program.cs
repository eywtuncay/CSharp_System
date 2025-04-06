// See https://aka.ms/new-console-template for more information



using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!");



namespace _16_MetotOrnekleri
{
    class Program
    {

        static void Main(string[] args)
        {

            // Bir metot yazın. paremetresiz olarak bir sayı dizisi alsın ve bu dizideki en büyük sayıyı döndürsün.


            int[] sayilar = { 2, 3, 5 };
            SayiDizisiAl(sayilar);



            // Bir metot yazın. paremetresiz olarak bir cümle ve bir harf alsın. Bu cümledeki belirtilen harflerin kaç kez geçtiğini döndürsün.
            string cümle = "LoremIpsum";
            char karakter = 'a';
            TekrarSayisi(cümle, karakter);




            // Evde yap: Bir metot yazın. paremetre olarak bir dizi alıp bu dizinin elemanlarını ters çevirip yeni bir dizi döndürsün.


        }


        // Bir metot yazın. paremetresiz olarak bir sayı dizisi alsın ve bu dizideki en büyük sayıyı döndürsün.
        private static int SayiDizisiAl(int[] sayilar)
        {
            int enBuyuk = sayilar[0];


            foreach (int num in sayilar)
            {
                if (num > enBuyuk)
                {
                    enBuyuk = num;
                }
            }

            return enBuyuk;

        }


        // Bir metot yazın. paremetresiz olarak bir cümle ve bir harf alsın. Bu cümledeki belirtilen harflerin kaç kez geçtiğini döndürsün.
        private static int TekrarSayisi(string cümle, char harf)
        {
            int tekrar = 0;
            foreach (char c in cümle)
            {
                
                if (char.ToLower(c) == char.ToLower(harf))
                {
                    tekrar++;
                }
            }
            return tekrar;
        }


    }
}

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");



namespace _15_LocalFunction
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] sayilar1 = { 11, 222, 3123 };


            Console.WriteLine(KarekokHesapla(sayilar1));





            double KarekokHesapla(int[] sayilar)
            {
                int topla = 0;

                for (int i = 0; i < sayilar.Length; i++)
                {
                    topla += sayilar[i];
                }
                return Math.Sqrt(topla);

            }


        }


    }

}

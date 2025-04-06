
namespace _18_MethodOverLoadingLab
{
    internal class Program
    {

        static void Main(string[] args)
        {

            /*

             Çalışanlar isminde string bir dizi oluştur. içerisinde 5-6 isim yaz.
             Maaşlar isminde 5 eleman alabilecek dizi yaz.

            */

            string[] calisanlar = { "tuncay", "ali", "ahmet" };
            double[] maaslar = new double[5];

            for (int i = 0; i < calisanlar.Length; i++)
            {
                Console.WriteLine($"{i} - {calisanlar[i]} ");
            }

            Console.Write("Maaşını hesaplamak istediğin kullanıcının numarasını seç:");
            int index = int.Parse(Console.ReadLine());

            //Çalışma Saatini girsin
            Console.Write("Maaş - " + calisanlar[index]+" : ");
            Console.WriteLine("Çalışma saati : ");
            int calismaSaati = int.Parse(Console.ReadLine());


            //saatlik ücretini girsin
            Console.Write("Saatlik ücretini gir : ");
            int saatlikUcreti = int.Parse(Console.ReadLine());

            //Çalışma saati 270'den az ise MaasHEsapla metodunun 2 paremetrelisi çalışsın
            if (calismaSaati <= 270)
                maaslar[index] = MaasHesapla(calismaSaati, saatlikUcreti);
            else
            {
                double mesai = MesaiHesapla(calismaSaati);
                maaslar[index] = MaasHesapla(calismaSaati, saatlikUcreti, mesai);
            }

            Console.WriteLine("\n**************************************");

            // Devam etmek istiyor musun?(E/H) şeklinde Do-While döngüsü ekle buraya.

        }

        private static double MesaiHesapla(int calismaSaati, double mesaiUcreti = 550)
        {
            double saat = calismaSaati - 270;
            return saat * mesaiUcreti;
        }

        private static double MaasHesapla(int calismaSaati, int saatlikUcreti, double mesai)
        {
            return MaasHesapla(calismaSaati, saatlikUcreti) + mesai;
        }

        private static double MaasHesapla(int calismaSaati, int saatlikUcreti)
        {
            if (calismaSaati >= 0)
                return calismaSaati * saatlikUcreti;
            else
                throw new Exception("Çalışma saati 0'dan küçük olamaz.");
        }
    }
}

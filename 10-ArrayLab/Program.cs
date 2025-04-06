

#region Maaş Hesapla


/* 

Maaş hesapla
kaç kişinin maaşını girmek istiyorsunuz.
dizinin boyutu o olacak
isimleri tutcağız başka bir dizide
ücretleri de ayrı bir dizide tutacağız. (double olabilir)
int olarak da çalışma saatlerini al.


adını, ücretini, çalışma saatlerini 
alacağız ve dizide tutacağız

Ekrana yazmak ister misiniz diye soracağız.(evet-Hayır)

evet derse ekrana yazdıracağız.

 */


//do
//{
//    Console.Write("Kaç kişinin maaşını girmek istiyorsunuz: ");
//} while (!int.TryParse(Console));


//Console.Write("Kaç kişinin maaşını girmek istiyorsunuz: ");
//int kisiSayisi = int.Parse(Console.ReadLine());

//string[] kisiler = new string[kisiSayisi];
//int[] maaslar = new int[kisiSayisi];
//int[] calismaSaatleri = new int[kisiSayisi];

//for (int i = 0; i < kisiler.Length; i++)
//{
//    Console.Write($"{i + 1}. Kişinin adını giriniz: ");
//    kisiler[i] = Console.ReadLine().Trim();

//    do
//    {
//        Console.Write($"{i + 1}. Kişinin maaşını giriniz: ");
//    } while (!int.TryParse(Console.ReadLine(), out maaslar[i]));

//    do
//    {
//        Console.Write($"{i + 1}. Kişinin çalışma saatini giriniz: ");

//    } while (!int.TryParse(Console.ReadLine(), out calismaSaatleri[i]));

//}

//Console.WriteLine("Ekrana yazdırmak ister misin(E/H)");
//char soru = char.Parse(Console.ReadLine());
//if (Console.ReadLine().ToLower() == "e")
//{
//    for (int i = 0; i < kisiSayisi; i++)
//    {
//        Console.WriteLine($"{i + 1}. Personelin adı: {kisiler[i]} \t Ücreti: {maaslar[i]} \t Çalışma saati: {calismaSaatleri[i]}");
//    }
//}



#endregion



#region NBoyutlu Dizi

//int[] vizeler = { 15, 52, 64, 87, 87, 69 };
//int[] finaller = { 51, 42, 63, 47, 84, 19 };


//int[,] tumSinavlar = new int[6,2] { {15,51},{52,42}, {64,63},{87,47}, {87,84},{69,19} };

//Console.WriteLine(tumSinavlar[4, 1]);   //84


//for (int i = 0; i < length; i++)
//{

//}

#endregion





/*

Tek boyutlu bir int dizi oluşturulacak. Dışarıdan gelecek adete göre veri alınacak ve sınav notları tutulacak.
En son ekrana yazdırılacak. Ortalaması da ekranda yazdırılacak.
 
*/



//Console.Write("Kaç adet sınav notu gireceksin? ");
//int notSayisi = int.Parse(Console.ReadLine());

//int[] sinavNotlari = new int[notSayisi];


//for (int i = 0; i < notSayisi; i++)
//{
//    Console.Write($"{i + 1}. Sınav notunu girin: ");
//    sinavNotlari[i] = int.Parse(Console.ReadLine());
//}


//Console.WriteLine("\nSınav Notları:");
//int toplam = 0;
//foreach (int notu in sinavNotlari)
//{
//    Console.WriteLine(notu);
//    toplam += notu;
//}

//double ortalama = (double)toplam / notSayisi;
//Console.WriteLine($"\nSınav Notlarının Ortalaması: {ortalama:F2}");









/*

Rastgele üretilen 15 adet sayıyı bir dizide tutunuz. Büyükten küçüğe doğru alt alta gösteriniz. Bubble Short
 
*/





Random rnd = new Random();

int[] sayilar = new int[15];

for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = rnd.Next(1, 101);
}

// metot kullanarak kısa yoldan yapılabilir
//Array.Sort(sayilar);
//Array.Reverse(sayilar);


for (int i = 0; i < sayilar.Length - 1; i++)
{
    for (int j = 0; j < sayilar.Length - 1 - i; j++)
    {
        if (sayilar[j] < sayilar[j + 1]) // Büyükten küçüğe sıralama
        {

            int temp = sayilar[j];
            sayilar[j] = sayilar[j + 1];
            sayilar[j + 1] = temp;

        }
    }
}


Console.WriteLine("Rastgele Sayılar (Büyükten Küçüğe):");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}


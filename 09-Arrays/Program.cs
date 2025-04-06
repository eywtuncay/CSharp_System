




#region Tanımlama

// Birden fazla aynı tipteki nesneyi bir arada tutabilmeyi sağlayan nesnelerdir.

//System.NullReferenceException hatası
//System.IndexOutOFRangeException hatası



string[] isimler;

isimler = new string[5];

string[] soyisimler = new string[5];

int[] yaslar = { 2, 5, 6, 7 };

#endregion


#region DiziErişimleri

string[] arabalar = { "Mercedes", "Bmw", "Togg", "Ford", "Renault", "Honda" };

for (int i = 0; i < arabalar.Length; i++)
{
    Console.WriteLine(arabalar[i]);
}

Console.WriteLine(new string('*', 50));     //Karışmaması için Ayraç


foreach (string araba in arabalar)
{
    Console.WriteLine(araba);
}


//Sadece Togg'u kırmızı ile yazsın.

foreach (string araba in arabalar)
{
    Console.ForegroundColor = araba == "Togg" ? ConsoleColor.Red : ConsoleColor.White;  //Ternery if

    Console.WriteLine(araba);
}



Console.WriteLine(new string('*', 50));     //Karışmaması için Ayraç

object[] nesneler = { "Tuncay", 2165, 1.65, DateTime.Now, 'A', 12.55m, 44.88f, new DateTime(2022, 5, 4) };

foreach (object o in nesneler)
{
    Console.WriteLine(o);
}



#endregion


#region Ornek1

// 8 tane tamsayı girilecek ve forech ile ekrana çiftleri kırmızı yazdır ve tekleri yazdır.


//int[] sayilar = new int[8];
//Console.Write("8 tane sayı girin: ");

//for (int i = 0; i < sayilar.Length; i++)
//{
//    sayilar[i] = int.Parse(Console.ReadLine());
//}

//foreach (int sayi in sayilar)
//{ 
//    if (sayi % 2 == 0)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine(sayi);
//    }
//    else
//    {
//        Console.ResetColor();
//        Console.WriteLine(sayi);
//    }
//}



// Random olarak 8 sayı atamak istiyorum 1-100 arasında

//int[] sayilar = new int[8];

//Random rnd = new Random();      // new Random() ile yeni bir random nesnesi oluşturdum.

//for (int i = 0; i < sayilar.Length; i++)
//{
//    sayilar[i] = rnd.Next(1, 101);  // [1, 101)
//}

//foreach (int sayi in sayilar)
//{
//    Console.WriteLine(sayi);
//}



/*

SAYISAL LOTO ÖDEVİ;

kullanıcı kaç kolon oynayacağını seçecek. 8 kolonu aşamayacak. 0 da olamayacak.
her kolonda 6 sayı olacak
sayılar 1-49 arasında olacak
her kolondaki 6 sayıda birbirinden farklı olacak
kolonların çıktısı

Biz kullanıcıdan sadece kaç kolon oynayacağını alacağız. Daha sonra makine kendi oynayacak
1. kolon numaralar
2. kolon numaralar
.
.

*/



Console.Write("Kaç kolon oynamak istiyorsun? (1-8): ");
int kolonSayisi;

while (!int.TryParse(Console.ReadLine(), out kolonSayisi) || kolonSayisi < 1 || kolonSayisi > 8)
{
    Console.Write("Hata! Lütfen 1 ile 8 arasında bir sayı gir: ");
}

Console.WriteLine("Sayısal Loto Sonuçlarınız:\n");

Random rnd = new Random();


for (int i = 1; i <= kolonSayisi; i++)
{
    int[] kolon = new int[6];
    int index = 0;

    while (index < 6)
    {
        int randomSayi = rnd.Next(1, 50); 
        bool tekrarFlag = false;


        for (int j = 0; j < index; j++)
        {
            if (kolon[j] == randomSayi)
            {
                tekrarFlag = true;
                break;
            }
        }

        if (!tekrarFlag)
        {
            kolon[index] = randomSayi;
            index++;
        }
    }

    Array.Sort(kolon);

    Console.WriteLine($"{i}. Kolon: {string.Join(" - ", kolon)}");
}




#endregion





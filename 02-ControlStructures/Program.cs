

#region Örnek 1: Haftanın günlerini seç

/*
    Kullanıcıdan 1 ile 7 arasında bir sayı alın. Girilen değere göre haftanın gününü ekrana yazdırın.
*/

//Console.Write("Lütfen (1-7) arasında bir sayı giriniz: ");

//if(int.TryParse(Console.ReadLine(), out int sayi))
//{
//    if (sayi == 1)
//    {
//        Console.WriteLine("Bugün günlerden Pazartesi");
//    }
//    else if (sayi == 2)
//    {
//        Console.WriteLine("Bugün günlerden Salı");
//    }
//    else if (sayi == 3)
//    {
//        Console.WriteLine("Bugün günlerden Çarşamba");
//    }
//    else if (sayi == 4)
//    {
//        Console.WriteLine("Bugün günlerden Perşembe");
//    }
//    else if (sayi == 5)
//    {
//        Console.WriteLine("Bugün günlerden Cuma");
//    }
//    else if (sayi == 6)
//    {
//        Console.WriteLine("Bugün günlerden Cumartesi");
//    }
//    else if (sayi == 7)
//    {
//        Console.WriteLine("Bugün günlerden Pazar");
//    }
//    else
//    {
//        Console.WriteLine("Lütfen 1-7 arasında bir sayı giriniz.");
//    }
//}
//else
//{
//    Console.WriteLine("Lütfen bir sayı giriniz");
//}


#endregion


#region Örnek 2: Kullanıcının yaşını kontrol et

/*

    Kullanıcıdan yaşını 0-100 arasında olacak şekilde al.
    Yaş 0-100 arasında değilse geçersiz yaş şeklinde uyar.
    Aralıktaysa geçerli diye bilgilendir.

*/


//Console.Write("Yaşınızı 0-100 arasında olacak şekilde giriniz: ");
//int yas = int.Parse(Console.ReadLine());

//if(yas < 100 && yas > 0)
//{
//    Console.WriteLine("Geçerli yaş.");
//}
//else
//{
//    Console.WriteLine("Geçersiz yaş.");
//}

#endregion


#region Örnek 3: Vize-Final harf notlarını hesaplama

/*
 
******* tekrar et *******

Kullanıcıdan vize ve final notlarını alın. vizenini %30 finalin %70 olarak hesaplayıp sonucu bulun.
sonuç 0-30 arasında ise ekrana FF yaz.
sonuç 30-50 arasında ise ekrana CC yaz.
sonuç 50-70 arasında ise ekrana BB yaz.
sonuç 70-100 arasında ise ekrana AA yaz.
Bunların dışında ise hatalı veri diye çıktı ver.



 */


//Console.Write("Vize notunuzu giriniz: ");
//if(!(double.TryParse(Console.ReadLine(),out double vize)))
//{
//    Console.WriteLine("Lütfen sayısal bir vize giriniz");
//}

//Console.Write("Final notunuzu giriniz: ");
//if(!(double.TryParse(Console.ReadLine(), out double final)))
//{
//    Console.WriteLine("Lütfen sayısal bir final giriniz");
//}


//double not = ((vize * 0.3) + (final * 0.7));

//if (vize < 0 || vize > 100 || final < 0 || final > 100)
//{
//    Console.WriteLine("Hatalı veri!");
//}
//else
//{

//    if (not >= 0 && not < 30)
//    {
//        Console.WriteLine($"Notunuz: {not} - Harf Notunuz: FF");
//    }
//    else if (not >= 30 && not < 50)
//    {
//        Console.WriteLine($"Notunuz: {not} - Harf Notunuz: CC");
//    }
//    else if (not >= 50 && not < 70)
//    {
//        Console.WriteLine($"Notunuz: {not} - Harf Notunuz: BB");
//    }
//    else if (not >= 70 && not <= 100)
//    {
//        Console.WriteLine($"Notunuz: {not} - Harf Notunuz: AA");
//    }

//}



#endregion


#region Ternary if

/*

Ternary if, C#'ta kısa ve okunaklı bir if-else ifadesi yazmak için kullanılan bir operatördür.


    koşul ? DoğruysaÇalışacakKod : YanlışsaÇalışacakKod;


int sayi1 = 5;
int sayi2 = 10;
string sonuc = sayi1 > sayi2 ? "sayı 1 büyüktür." : "Sayı 2 büyüktür.";
Console.WriteLine(sonuc);

Console.WriteLine(sayi1>50 ? "50'den Büyüktür." : "50'den küçüktür.");

*/


#region Örnek 4: Değer girdiyse ekranda göster. girmediyse "default" yaz. - Ternery if

/*
    Eğer kullanıcı bir değer girdiyse ekranda göster. girmediyse "default" yaz.
*/

//Console.Write("Lütfen bir değer giriniz: ");
//string deger = Console.ReadLine();

//Console.WriteLine(deger.Length > 0 ? deger : "Default");


#endregion


#region Örnek 5: Girilen sayı tek mi çift mi? - Ternert if

/*
    Girilen sayı tek mi çift mi yazdır.
*/

//Console.WriteLine("Bir sayı giriniz");
//int sayi = int.Parse(Console.ReadLine());

//Console.WriteLine(sayi % 2 == 0 ? "Çift" : "Tek");


#endregion


#region Örnek 6: Not ortalamasına göre harflendirme - Ternery if

/*

Kullanıcıdan not ortalamasını al. ortalama 90 dan büyükse "AA". 80'den büyükse "BB". 70'den büyükse "CC".
geri kalan sonuçlarda "kaldınız" yazsın.
 
*/

//Console.Write("Not ortalamanızı giriniz: ");
//if(int.TryParse(Console.ReadLine(), out int ortalama))
//{
//    string harfNotu = ortalama > 101 || ortalama < 0 ? "Lütfen geçerli bir değer giriniz." :
//                      ortalama >= 90 && ortalama <= 100 ? "AA" :
//                      ortalama >= 80 && ortalama < 90 ? "BB" :
//                      ortalama >= 70 && ortalama < 80 ? "CC" :
//                      "Kaldınız";

//    Console.WriteLine(harfNotu); 
//}
//else
//{
//    Console.WriteLine("Lütfen geçerli bir değer giriniz.");
//}


#endregion


#endregion


#region Switch-Case

/*
 
switch-case, bir değişkenin belirli değerlere sahip olup olmadığını kontrol eden alternatif bir karar yapısıdır.
İç içe if-else yerine daha okunaklı bir yapı sunar.


Sözdizimi:

switch(Değişken)
   {
    case Değer1 :
        Çalışacak Kodlar;
        break;

    case Değer2 :
        Çalışacak Kodlar;
        break;

    default :
        Eşleşme Olmazsa Çalışacak Kodlar;
        break;
   }

 */


#region Örnek 6: Dışarıdan girilen mevsime göre ayları yazdır.


//Console.Write("Mevsim giriniz: ");
//string mevsim = Console.ReadLine().ToLower();


//switch (mevsim)
//{
//    case "kış":
//        Console.WriteLine("Aralık-Ocak-Şubat");
//       break;
//    case "ilkbahar":
//        Console.WriteLine("Mart-Nisan-Mayıs");
//        break;
//    case "yaz":
//        Console.WriteLine("Haziran-Temmuz-Ağustos");
//        break;
//    case "sonbahar":
//        Console.WriteLine("Eylül-Ekim-Kasım");
//        break;
//    default:
//        Console.WriteLine("Lütfen geçerli bir mevsim giriniz.");
//        break;
//}


#endregion


#region Örnek 7: Kullanıcı tipine göre hoşgeldiniz mesajı

/*

Kullanıcıdan kullanıcı tipi alınsın,
Eğer kullanıcı admin, yönetici, ceo ise "Yönetim paneline hoşgeldiniz yazsın".
eğer üye ise "Anasayfaya hoşgeldiniz" yazsın.
hiçbiri ise "yetkiniz yok yazsın."
 
*/

//Console.Write("Kullanıcı tipinizi yazınız: ");
//string kullaniciTipi = Console.ReadLine().ToLower();

//switch(kullaniciTipi)
//{
//    case "admin":
//    case "yönetici":
//    case "ceo":
//        Console.WriteLine("Yönetim paneline hoşgeldiniz");
//        break;

//    case "üye":
//        Console.WriteLine("Anasayfaya hoşgeldiniz");
//        break;
//    default:
//        Console.WriteLine("Yetkiniz yok.");
//        break;
//}

#endregion


#endregion



// Döngüler: for, while, do while


#region For Döngüsü

/*


For döngüsü, belirli bir sayıda çalıştırılması gereken işlemleri gerçekleştirmek için kullanılır.

Genel Kullanım (Syntax)

for (başlangıç; koşul; artırma/azaltma)
{
    Çalıştırılacak kodlar
}
.

.
for (int değişkenAdı = başlangıçDeğeri ; koşul; artırma/azaltma)
{
    // Döngü bloğu (Çalıştırılacak kodlar)
}

 
*/


#region Örnek 1: 1'den 10'a kadar yazdırma.

//for(int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

#endregion


#region Örnek 2: 1'den 10'a kadar çiftleri yazdırma.

//for(int i = 1; i <= 10; i++)
//{
//    if(i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

#endregion


#region Örnek 3: Sayılardan piramit oluşturma - iç içe for döngüsü

/*

1
12
123
1234
12345
123456
1234567
12345678
123456789
12345678910

*/


//for (int j = 1; j <= 10; j++)
//{
//    for (int i = 1; i <= j; i++)
//    {
//        Console.Write(i);
//    }
//    Console.WriteLine("");
//}

#endregion


#region Örnek 4: Çarpım Tablosu - iç içe for döngüsü

/*
    1 den 5 lere kadar çarpım tablosunu oluştur. 
*/


//for (int j = 1; j <= 10; j++)
//{
//    Console.WriteLine("-----------");
//    for (int i = 1; i <= 5; i++)
//    {
//        int sonuc = i * j;
//        Console.WriteLine(i + " x " + j + " = " + sonuc);

//    }
//}


#endregion


#region Örnek 5: Yıldızlardan dik üçgen - iç içe for döngüsü

/*

*
* *
* * *
* * * *
* * * * *
 
*/

//int n = 5;
//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}


#endregion


#region Örnek 6: 2'den başlayıp 2'şer 2'şer 1000'e kadar ileri ve geri yazdırma.

/*
    2'den başlayıp 2'şer 2'şer 1000'e kadar yazdırma.
*/

//for (int i = 2; i<=1000; i=i+2)
//{
//    Console.WriteLine(i);
//}


/*
    1000'den başlayıp 2'şer 2'şer 1'e kadar yazdırma.
*/

//for(int i = 1000; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}


#endregion


#region Örnek 7: 1'den 1000'e kadar tek sayıları yazdırma.

//for(int i = 1; i < 1000; i++)
//{
//    if(i % 2 == 1)
//    {
//        Console.WriteLine(i);
//    }
//}


#endregion


#region Örnek 8: A-Z arasındaki karakterleri yazdırma.

//for(char i = 'a'; i <= 'z'; i++)
//{
//    Console.WriteLine(i);
//}

#endregion


#region Örnek 9: 1-100 arasındaki sayıların toplamını yazdırma.

//int toplam = 0;

//for (int i = 1; i <= 100; i++)
//{
//    toplam = toplam + i;
//}

//Console.WriteLine(toplam);

#endregion


#region Örnek 10: 1-100 arasındaki çiflerin toplamıyla teklerin toplamının farklarının karesi.

//int ciftlerToplami = 0;
//int teklerToplami = 0;
//int sonuc = 0;

//for(int i = 1; i <= 100; i++)
//{
//    if(i % 2 == 0)
//    {
//        ciftlerToplami += i;
//    }
//    else if (i % 2 == 1)
//    {
//        teklerToplami += i;
//    }
//}

//sonuc = (ciftlerToplami-teklerToplami) * (ciftlerToplami - teklerToplami);
//Console.WriteLine(sonuc);

#endregion


#region Örnek 11: 1945-Günümüz arasındaki yılları ekrana yaz. 1990 ve 1992 kırmızı olsun.


//for(int i = 1945; i <= DateTime.Now.Year; i++)
//{
//    if(i == 1990 || i == 1992)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine(i);
//        Console.ResetColor();

//    }
//    Console.WriteLine(i);
//}


#endregion


#region Örnek 12: Kullanıcıdan alınan 10 adet sayının toplamını ekrana yazdırma.

//int toplam = 0;

//for (int i = 1; i <= 10; i++)
//{
//    try
//    {
//        Console.Write($"{i}. Sayıyı giriniz: ");
//        toplam += int.Parse(Console.ReadLine());
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Geçerli bir sayı giriniz. "+ex.Message);
//    }
//}

//Console.WriteLine($"Girilen sayılrın toplamı: {toplam}");

#endregion


#endregion



#region While Döngüsü

/*

While Döngüsü, koşul doğru olduğu sürece belirli bir işlemi sürekli olarak çalıştırmak için kullanılır.
While --> içerisi True oldukça döner.

while (koşul)
{
    // Çalıştırılacak kodlar
}

*/



#region Örnek 1: 1'den 10'a kadar sayıları yazdır.

//int sayi = 1;

//while(sayi <= 10)
//{
//    Console.WriteLine(sayi++);
//}

#endregion


#region Örnek 2: 100'den 1'e doğru çiftleri ekrana yazdır.

//int sayi = 100;

//while (sayi >= 1)
//{
//    Console.WriteLine(sayi);
//    sayi -= 2;
//}


#endregion


#region Örnek 3: 1-100 arasındaki çiflerin toplamı ile teklerin toplamının farklarının karesi.

//int sayac = 1;
//int teklerToplami = 0;
//int ciftlerToplami = 0;
//int sonuc = 0;

//while(sayac <= 100)
//{
//    if(sayac % 2 == 0)
//    {
//        ciftlerToplami += sayac;
//    }
//    else
//    {
//        teklerToplami += sayac;
//    }
//    sayac++;
//}
//sonuc = ((ciftlerToplami) - (teklerToplami)) * ((ciftlerToplami) - (teklerToplami));
//Console.WriteLine(sonuc);

#endregion


#region Örnek 4: Kullanıcıdan alınan 10 adet sayının toplamını ekrana yazdır.

//int adet = 1;
//int toplam = 0;

//while (adet <= 10)
//{
//    Console.Write($"{adet}. Sayıyı giriniz: ");
//    if (int.TryParse(Console.ReadLine(), out int sayi))
//    {
//        toplam += sayi;
//        adet++;  
//    }
//    else
//    {
//        Console.WriteLine("Lütfen geçerli bir sayısal değer giriniz.");
//    }
//}

//Console.WriteLine($"Toplam: {toplam}");



#endregion



#endregion



#region Do-While Döngüsü

/*

Do-While döngüsü, while döngüsünün farklı bir versiyonudur.
Bu döngüde, koşul kontrolü döngünün sonunda yapılır, yani döngü en az bir kez çalışır.

While döngüsünde önce koşul kontrol edilir, eğer koşul sağlanıyorsa işlem yapılır.
Do-While döngüsünde önce işlem yapılır, sonra koşul kontrol edilir.
While ile arasındaki fark Do-While en az bir kere çalışır.


do
{
    
    Çalıştırılacak kodlar

} while (koşul);
 


*/


#region Örnek 1: 1'de 10'a kadar olan sayılaarı ekrana yazdır.  do-while ile

//int sayi = 1;
//do
//{
//    Console.WriteLine(sayi);
//    sayi++;
//} while (sayi <= 10);


#endregion

#region Örnek 2: 1'den 100'e kadar olan sayıların toplamını yazdır. do-while ile

//int sayac = 0;
//int toplam = 0;

//do
//{
//    toplam += sayac;
//    sayac++;
//} while (sayac <= 100);

//Console.WriteLine(toplam);

#endregion

#region Örnek 3: Login olma. do-while ile

/*

Kullanıcıdan kullanıcı adı ve şifre alınız.
Kullanıcı adı "admin". şifre "123" ise  "Giriş Başarılı" yazsın.
Doğru değilse tekrar istemeye devam etsin.

*/

//string kullaniciAdi = "";
//string sifre = "";

//do
//{
//    Console.Write("Kullanıcı adı: ");
//    kullaniciAdi = Console.ReadLine();

//    Console.Write("Şifre: ");
//    sifre = Console.ReadLine();

//    if (kullaniciAdi != "admin" || sifre != "123")
//    {
//        Console.WriteLine("Yanlış kullanıcı adı veya şifre");
//    }
//}
//while (kullaniciAdi != "admin" || sifre != "123");

//Console.WriteLine("Giriş Başarılı");




#endregion

#region Örnek 4: İki sayı alıp toplamını veren program. Sayı girmemişse tekrar iste. do-while ile




#endregion


#endregion





// Doğum tarihi girilen kişinin yaşını hesaplayın

//DateTime dogumTarihi;


//Console.Write("Doğum tarihinizi (GG/AA/YYYY) şeklinde girin: ");
//while (!DateTime.TryParse(Console.ReadLine(), out dogumTarihi))
//{
//    Console.WriteLine("Geçersiz tarih formatı. Lütfen doğru formatta girin.");
//    Console.Write("Doğum tarihinizi (GG/AA/YYYY) formatında girin: ");
//}

//DateTime bugun = DateTime.Now;
//int yas = bugun.Year - dogumTarihi.Year;

//Console.WriteLine(yas);











// Klavyeden girilen 25 adet sayı içerisinden negatif olanların toplamını,
// Çift sayıların çarpımını, 7 ye eşit olanların adetini bulup ekrana yazdıran program


//int negatifToplam = 0;
//int ciftSayiCarpimi = 1;
//int yediyeEsitAdet = 0;

//Console.WriteLine("25 adet sayı giriniz:");

//for (int i = 0; i < 5; i++)
//{
//    Console.Write($"Sayı {i + 1}: ");
//    int sayi = Convert.ToInt32(Console.ReadLine());

//    if (sayi < 0)
//        negatifToplam += sayi;

//    if (sayi % 2 == 0)
//        ciftSayiCarpimi *= sayi;

//    if (sayi == 7)
//        yediyeEsitAdet++;
//}

//Console.WriteLine(negatifToplam);
//Console.WriteLine(ciftSayiCarpimi);
//Console.WriteLine(yediyeEsitAdet);












// çarpma işlemini toplama kullanarak bulun programı yazısınız. Değerler kullanıcılardan alınacaktır.


//Console.Write("Birinci sayıyı girin: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("İkinci sayıyı girin: ");
//int b = Convert.ToInt32(Console.ReadLine());

//int sonuc = 0;
//int sayi = b;


//for (int i = 0; i < sayi; i++)
//{
//    sonuc += a;
//}

////if (b < 0)
////{
////    sonuc =- sonuc;
////}

//Console.WriteLine($"{a} * {b} = {sonuc}");



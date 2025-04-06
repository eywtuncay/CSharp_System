
/*
    Veri tipleri, Değer ve Referans tipleri, Tür Dönüşümleri, Kaçış karakterleri
*/


#region ReadLine() ve ReadKey() farkı

/*

Console.ReadLine() --> Kullanıcının bir satır metin (string) girmesini bekler.
                       Kullanıcı Enter tuşuna basana kadar giriş işlemi tamamlanmaz.
                       Girdiği tüm metni string olarak döndürür.

Console.ReadKey() ---> Tek bir tuşa basılmasını bekler.
                       Tuşa basıldığında hemen döner, Enter tuşuna basmaya gerek yoktur.
                       ConsoleKeyInfo tipinde bir nesne döndürür, yani hangi tuşa basıldığını öğrenebilirsin.

Özetle:
Bir satır giriş almak için → ReadLine() --> Kullanıcıdan tam bir değer almak istiyorsam.
Tek bir tuş algılamak için → ReadKey()

*/

#endregion


#region Örnek 1: Kullanıcıdan alınan sayının karesini alma

/*

//1.Başla
//2.Kullanıcıdan sayı iste
//3.Değişken tanımla
//4.Kullanıcıdan alınan değeri değişkene ata
//5.Değişkenin karesini al
//6.Ekrana sonucu yazdır
//7.Bitir

*/


//Console.WriteLine("Lütfen bir sayı giriniz:");

//int sayi = Convert.ToInt16(Console.ReadLine());

//Console.WriteLine(sayi*sayi);



#endregion


#region Veri Tipleri

/*

byte     -->     0 ile 255 arasındaki tamsayıları tutar.
short    -->     -32768 ile 32767 arasındaki tamsayıları tutar.
int      -->     -2,147,483,648 ile 2,147,483,647 arasındaki tamsayıları tutar.

double   -->     Ondalıklı sayıları tutar.(15 basamaklı) - (2.15)
float    -->     Ondalıklı sayıları tutar.(7 basamaklı) - (2.15f) - (Sonuna f koymalıyız)
 
char     -->     Tek bir karakteri tutmak için kullanılır. Tek tırnak ile kullanılır. Her karakter tutulabilir.
string   -->     Metinleri tutmak için kullanılır.

bool     -->     True ya da False değerleri tutar.

object   -->     Tüm veri tiplerini içerisinde tutabilir.

var      -->     Derleyicinin değişkenin türünü otomatik olarak belirlemesini sağlayan bir anahtar kelimedir.
                 Türü belirtmek yerine, değişkene atanan değere göre tür belirlenir.

DateTime -->    tarih ve saat bilgilerini temsil eden bir yapıdır (struct). Yaygın bir veri tipidir..


 */



#endregion


#region Value Type - Reference Type --> Null olabilme

/*

REFERANS TİPLERİ: (string, object, class, interface, dynamic, array, delegate)
null olabilir çünkü bu değişkenler heap bölgesinde saklanan bir nesnenin adresini tutar.

string isim = null;
object nesne = null;


DEĞER TİPLERİ: (int, double, bool, char, struct vb.)
null olamaz çünkü bellekte doğrudan bir değer taşırlar.
Ancak, nullable value types (null yapılabilir değer tipleri) kullanarak değer tiplerine null atanabilir.
Eğer bir değer tipine null değeri atanabilir hale getirmek istiyorsak ? (nullable operator) kullanabiliriz.

int? yas = null;
double? maas = null;
bool? aktifMi = null;
 
*/

#endregion


#region Tür Dönüşümleri - Type Conversion

// (int).sayi1 - Convert.ToInt32(sayi1) - int.Parse(sayi1) - int.TryParse(metin, out int sayi1)

/*

C#’ta bir veri türünü başka bir veri türüne çevirmeye Tür Dönüşümü (Type Conversion) denir.

Tür dönüşümleri ikiye ayrılır:
Bilinçsiz (Implicit) Dönüşüm – Otomatik gerçekleşir, veri kaybı olmaz.
Bilinçli (Explicit) Dönüşüm – Manuel olarak yapılır, veri kaybı veya hata olabilir.

----------------------------------------
1) Bilinçsiz (Implicit) Tür Dönüşümü
   Küçük veri türleri, büyük veri türlerine dönüşebilir. Veri kaybı olmaz, dönüşüm otomatik yapılır.

Örnek:
int   --> long,       // long'un kapsamı int'den büyüktür. Veri kaybı olmaz.
float --> double      // float'ın kapsamı double'dan büyüktür. Veri kaybı olmaz.

int sayi = 100;
long uzunSayi = sayi;


----------------------------------------
2) Bilinçli (Implicit) Tür Dönüşümü (Cast işlemi)
   Büyük bir türü küçük bir türe çevirmek için açık dönüşüm (type) gerekir. Veri kaybı olabilir.

Örnek:
double  --> int,     // dobule'ın virgülden sonraki basamağı int'de yoktur. Veri kaybı olabilir..
long    --> int      // long'un kapsamı int'den büyüktür. Veri kaybı olabilir.

double pi = 3.14;
int tamSayi = (int)pi;  //Kesir kısmı kaybolur --> tamSayi 3 olur 


----------------------------------------
3) Convert Sınıfı ile Tür Dönüşümü
   System.Convert sınıfı, farklı türler arasında dönüşüm yapmak için kullanılır. Güvenlidir, hata kontrolü yapabilir.

string metin = "123";
int sayi = Convert.ToInt32(metin);  //Başarıyla çevrildi.

Dikkat: Eğer string değeri sayı değilse, FormatException hatası alınır! Çünkü metni sayıya çevirmeye çalışır.


----------------------------------------
4) Parse ve TryParse Kullanımı


int.Parse() --> Dönüştürme Başarısız Olursa Hata Verir.

string metin = "100";
int sayi = int.Parse(metin);            //Çalışır

string hataliMetin = "abc";
int sonuc = int.Parse(hataliMetin);     //Hata: FormatException


int.TryParse() --> Hata Vermez, bool Döner. ---- if ile direkt kontrol edebiliriz.

string metin = "200";
if (int.TryParse(metin, out int sayi))
{
    Console.WriteLine($"Dönüşüm başarılı: {sayi}");
}
else
{
    Console.WriteLine("Dönüşüm başarısız!");
}

TryParse(), hata vermez, dönüşüm başarılı olup olmadığını bool şeklinde True-False olarak döndürür.


*/


#endregion


#region Kaçış Karakterleri - Escape Sequances

/*

C#’ta bazı özel karakterleri string içinde doğrudan yazamazsın.
Örneğin, "Merhaba "Dünya"" yazarsan hata alırsın.
Bunu çözmek için kaçış karakterleri (escape sequences) kullanılır.

\n  --> Yeni satır (alt satıra geçme)
\t  --> Tab (Boşluk)
\"  --> Çift tırnak
\'  --> Tek tırnak


Escape Sequances --> \ \
string ciftTirnakliMesaj = "Bilge Adam: \"Bilge Adam\" ";   //Çıktı: Bilge Adam: "Bilge Adam"


*/


#endregion


#region Örnek 2: Kullanıcıdan aldığın 2 sayının kareleri toplamı

/*

    Kullanıcıdan iki sayı isteyiniz. iki sayının karelerinin toplamını ekrana yazdırınız

*/

//Console.Write("1. Sayıyı giriniz: ");
//int sayi1 = int.Parse(Console.ReadLine());

//Console.WriteLine("2. Sayıyı giriniz: ");
//int sayi2 = int.Parse(Console.ReadLine());

//Console.WriteLine($"İki sayının toplamı: {sayi1 + sayi2}");

#endregion


#region Örnek 3: Kullanıcıdan aldığın id ve şifreleri ekrana yazdırma

/*

Kullanıcıdan Kullanıcı Adı ve Şifre isteyiniz. Bunları tek bir mesajda alt alta yazdırınız.
 
*/

//Console.Write("Kullanıcı adınızı giriniz: ");
//string id = Console.ReadLine();

//Console.Write("Şifrenizi Grininiz: ");
//string sifre = Console.ReadLine();

//Console.WriteLine($"Kullanıcının kullanıdı adı: {id} \nKullanıcının Şifresi: {sifre}");


#endregion


#region Örnek 4: Kullanıcıdan alınan 3 sayının ortalaması

/*

Kullanıcında aldığımız 3 sayının ortalamasını veren program.
 
*/


//Console.Write("Birinici sayıyı giriniz: ");
//double sayi1 = int.Parse(Console.ReadLine());

//Console.Write("İkinci sayıyı giriniz: ");
//double sayi2 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Üçüncü sayıyı giriniz: ");
//double sayi3 = int.Parse(Console.ReadLine());

//double ortalama = ((sayi1 + sayi2 + sayi3) / 3);

//Console.WriteLine($"Üç sayının ortalaması: {ortalama}");

#endregion


#region Öneri İkonları

/*

------ Öneri İkonları ------

1. Mor Küp (Class veya Type)
Anlamı: Bu genellikle class veya struct gibi bir türü temsil eder.
Mor renkli bir ikon, önerilen öğenin bir tip (class, struct, enum, vb.) olduğunu gösterir.
Bu ikon, üzerinde işlem yapmak için oluşturulmuş bir tür olduğunu anlatır.


2. El Anahtarı (Property veya Field)
Anlamı: Bu ikon, bir özellik (property) veya alan (field) olduğunu gösterir.
Property, bir nesnenin veri üyelerini almak veya ayarlamak için kullanılan bir üyedir.
El anahtarı simgesi, genellikle get ve set metotlarına sahip olan özellikleri veya alanları ifade eder.


3. Şimşek (Method veya Event)
Anlamı: Şimşek simgesi, bir metod veya olay (event) olduğunu gösterir.
Bu ikon, bir işlevin veya olaya abone olabileceğiniz bir üyeyi ifade eder.
Şimşek ikonu, genellikle bir eylem gerçekleştiren veya bir event tetikleyen metotlar için kullanılır.


*/

#endregion


// PascalCase : class, Metot, property
// camelCase : degiskenAdi







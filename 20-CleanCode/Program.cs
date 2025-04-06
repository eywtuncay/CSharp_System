#region Hata Yönetimi


/*

----- CLEAN CODE -----

Mantıklı isimlendirme
camelCase, PascalCase
Metotlara ayırma
Class'lara ayırma
Yorum satırı kullanma
Summary kullanmak
Boşluk kullanımı
hata yönetimi



1- İsimlendirme
Değişken ve metot isimleri kısa ve anlamı olmalıdır.

int a = 10              //kötü
int OgrenciSayisi = 10  //güzel



2- Metot Uzunluğu
Metotları olabildiğince kısa tutalım. Birinci sorumluluk üzerine odaklanın.


3- Yorumlar
Kodun hedefine odaklanan yorumlar yazın.


4- Boşluk Kullanımı
for(int i=0;i<5;i++) --> böyle yazma


5- Hata Yönetimi

//Kötü versiyon
try
{
    // istisna fırlatılacak kodlarımız.
}
catch(Exception ex)
{
    // özel bir işlem olmadan tüm istisnaları yakalar.
}


Sadece hata olabilecek yerleri try-catch'de tutmalıyız.

//İyi versiyon
try
{
    // sadece hata olabilecek kodlarımız.
}
catch(OverFlowException ex)
{
    // belirli durumlarda hata fırlatır.
}
catch(FormatException ex)
{
    // belirli durumlarda hata fırlatır.
}
catch(NullReferenceException ex)
{
    // belirli durumlarda hata fırlatır.
}
catch(DivideByZeroException ex)
{
    // belirli durumlarda hata fırlatır.
}
catch(Exception ex)
{
    // belirli durumlarda hata fırlatır.
}


*/




#endregion


#region Best Practices

//53. soru sanırım
namespace _20_CleanCode
{
    public class Program
    {
        static void Main(string[] args)
        {

            int sayi, sayac = 0, maksimumSayi = 0, ciftMaksimumSayi = 0;

            bool sayiMi = KulllanicidanSayiAl(out sayi);

            if (sayiMi && sayi >= 0 && sayi != 1)
            {
                DegerleriBul(out ciftMaksimumSayi, out maksimumSayi, sayi, out sayac);
                DegerleriEkranaYaz(maksimumSayi, ciftMaksimumSayi, sayac);
            }
            else if (!sayiMi)
                Console.WriteLine("Girilen değer bir sayı değildir.");
            else if (sayi < 0)
                Console.WriteLine("Sayı negatif");
            else if (sayi == 1)
                Console.WriteLine("Sayı 1'e eşit olamaz");


            // summary ekle --> 3 tane /// ile ekleniyor. main ile metotları kontrol et.
            // metodun üstüne gelip ne işe yaradığını okumaya yarar.


            static void DegerleriEkranaYaz(int maksimumSayi, int ciftMaksimumSayi, int sayac)
            {
                throw new NotImplementedException();
            }



            /// <summary>
            /// Girilen sayıları ekrana yazdırır.
            /// </summary>
            /// <param name="ciftMaksimumSayi">Bulunan maksimum sayı.</param>
            /// <param name="maksimumSayi">Bulunan çift maksimum sayı.</param>
            /// <param name="sayi">Sayı degerini alır</param>
            /// <param name="sayac">Sayac degerini alır.</param>
            static void DegerleriBul(out int ciftMaksimumSayi, out int maksimumSayi,  int sayi, out int sayac)
            {
                ciftMaksimumSayi = maksimumSayi = sayac = 0;
                while(sayi >= 2)
                {
                    sayac++;

                    if(sayi % 2 == 1)
                    {
                        sayi = (sayi * 3) + 1;
                        sayac++;
                        ciftMaksimumSayi = 0;
                    }

                    ciftMaksimumSayi = ciftMaksimumSayi < sayi ? sayi : ciftMaksimumSayi;
                    sayi /= 2;
                }

            }

            static bool KulllanicidanSayiAl(out int sayi)
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
                return int.TryParse(Console.ReadLine(), out sayi);
            }



        }
    }
}




#endregion

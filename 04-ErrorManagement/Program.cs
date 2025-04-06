

#region Try - Catch - Finaly

/*

       C#’da hata yakalamak (exception handling) için try-catch-finally yapısı kullanılır.
    -> try:     Hata oluşabilecek kodlar buraya yazılır.
    -> catch:   Hata yakalandığında çalışacak kodlar buraya yazılır. - catch (Exception ex)
    -> finally: Hata olsa da olmasa da çalışacak kodlar buraya yazılır (opsiyoneldir).
 
*/

//Basla:

//try
//{
//    Console.Write("Bir sayı giriniz: ");            //Metin gireceğim ve hata verecek. (FormatException)
//    int sayi = int.Parse(Console.ReadLine());
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Hata Mesajı --> " + ex.Message);

//}
//finally
//{
//    Console.WriteLine("Bu kod bloğu her zaman çalışır.");
//}

//goto Basla;


#endregion


#region Hata Türleri


/*

-------------- HATALAR --------------


1. Derleme Zamanı Hatası (Compile Time Error)
Bu tür hatalar, kod derlenirken (build edilirken) oluşur.
Yani program daha çalıştırılmadan önce, derleyici (compiler) hataları fark eder ve geliştiriciye bildirir.

int x = "Merhaba";      //String bir değer, int değişkenine atanamaz.



2. Çalışma Zamanı Hatası (Runtime Exception)
Program derleme sırasında hatasız gözükse de, çalıştırıldığında hatalar oluşabilir.
Bu hatalar genellikle kullanıcı girişlerinden veya sistemden kaynaklanır. - try-catch kullanarak hataları yönet.

int sayi1 = 10;
int sayi2 = 0;
int sonuc = sayi1 / sayi2;  // Çalışma zamanı hatası: "System.DivideByZeroException"



3. Mantıksal Hatalar (Logical Errors)
Bu hatalar derleyici tarafından tespit edilemez ve çalışma zamanı hatası vermez.
Ancak program beklenen sonucu vermez ve yanlış çalışır.

int toplam = 5 + 5 * 2; // Beklenen: 20, Gerçekte: 15 (Öncelik sırası unutulmuş!)




HATA TÜRÜ	                    AÇIKLAMA
Derleme Hataları	            Yazım (syntax) veya veri türü hataları.
Çalışma Zamanı Hataları	        Kullanıcıdan gelen hatalı veri veya sıfıra bölme hatası.
Mantıksal Hatalar	            Yanlış algoritma, yanlış hesaplama.
Bellek Hataları	                Sonsuz döngü, bellek taşması (OutOfMemoryException).
Donanım & Sistem Hataları	    Dosya, ağ veya disk erişim hataları (IOException).
Dış Kaynak Hataları	            API, veritabanı veya internet bağlantı hataları.



*/


#endregion



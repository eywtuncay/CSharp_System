


Console.WriteLine("Hello, World!");




/*
 
List<T> içerisinde (T) verilen tipe bürünerek o tipte bir koleksiyon oluşturmamıza olanak sağlayan dizi çeşididir.
Dahan önceki ilkel diziler gibi ekleme sınırı olmadan eleman ekleyebildiğimiz yapılardır.

 */



//List<int> sayilar = new List<int>();

//sayilar.Add(150);
//sayilar.Add(546);

//Console.WriteLine(sayilar[0]);
//Console.WriteLine(sayilar[1]);

//// Tüm listeyi yazdırma.
//sayilar.ForEach(sayi => Console.WriteLine(sayi));



//List<string> meyveler = new List<string>() { "ayva","elma" };

//meyveler.ForEach(m => Console.WriteLine(m));





//Şehir isimlerini tutan bir liste oluştur.
//Eskişehir bu listenin içinde var mı yok mu kontrol edip ekrana var ya da yok yazdır.

List<string> sehirler = new List<string>() { "istanbul", "ankara", "kocaeli", "eskişehir" };

Console.WriteLine(sehirler.Contains("eskişehir") ? "var" : "yok");




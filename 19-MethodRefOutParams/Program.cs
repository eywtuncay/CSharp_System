
// ref, out, params


#region Ref


// ref metotlara veya metotlardan değer tiplerin referanslarını iletmek veya döndürmek için kullanılır.

// Diğer bir değişle referans yoluyla iletilen bir değerde yapılan herhangi bir değişikliğin yalnızca taşıdığı değeri değil
// adresteki (referans) değerini de değiştirdiğiniz için bu değişiklik yansıtacağı anlamına gelir.


//Metota gönderdiğim değer value type'mi reference type'mi. yani değiştirebiliyor muyum değiştiremiyor muyum.


//int a = 10, b = 12;

//Console.WriteLine($"İşlem öncesi a değişkeni : {a}"); //10
//Console.WriteLine($"İşlem öncesi b değişkeni : {b}"); //12



//ToplamDeger(a);

//// a değişkeni işlem sonrası
//Console.WriteLine($"İşlem sonrası a değişkeni : {a}"); //10



//FarkDeger(ref b);

//// b değişkeni işlem sonrası
//Console.WriteLine($"İşlem sonrası b değişkeni : {b}"); //7


//int[] sayilar = new int[2];
//Array.Resize(ref sayilar, sayilar.Length + 1);



//int ToplamDeger(int a)
//{
//    return a += 10;
//}



////ref parametreli metot
//void FarkDeger(ref int b)
//{
//    b -= 5;
//}

#endregion

#region Out

/*

out ile bir metottan birden fazla değer döndürürüz.

*/



//int i = -10, j = -20;

//Toplam(out i, out j);

//Console.WriteLine("Toplam Değer i : "+i);
//Console.WriteLine("Toplam Değer j : "+j);


//void Toplam(out int p, out int q)
//{
//    p = 30;
//    q = 40;
//    p += q;
//    q += q;
//}




/*

Soru1: Fark isminde bir metot oluşturun. Metot iki tane değer göndersin.
metottan ilk parametre 60, ikinci parametre 90, geri dönüş değeri de 30 gelsin
 
*/


//int Fark(out int sayi1, out int sayi2)
//{
//    sayi1 = 60;
//    sayi2 = 90;
//    return 30;
//}





/*

Soru2: Bolum isminde bir metot yazın. İki sayı alsın. bolumu double olarak parametre ile döndürsün.
kalan varsa onu da return etsin.

*/


//double Bolum(int sayi1, int sayi2, out double bolum)
//{
//    bolum = (double)sayi1 / sayi2;
//    return sayi1 % sayi2;
//}



#endregion

#region Params

/*

"".Split(',', '.', ';')
 
*/


//int donenDeger1 = Topla(2, 32, 123, 2131);
//int donenDeger2 = Topla(23, 312, 3123, 341);
//int donenDeger3 = Topla(523, 312, 34123, 1341);

//int Topla(params int[] sayilar)
//{
//    int toplam = 0;
//	for (int i = 0; i < sayilar.Length; i++)
//	{
//		toplam += sayilar[i];
//	}
//	return toplam;
//}





//kelimelerin aralarına boşluk bıraktır.	// tekrar bak


//string BoslukBiraktir(params string[] kelimeler)
//{
//	string sonuc = string.Empty;
//	for (int i = 0; i < kelimeler.Length; i++)
//	{
//        sonuc += kelimeler[i];
//    }
//	return sonuc;
//}




#endregion

#region Recursive Metot

/*

5! = 5.4.3.2.1

5.4!
5.4.3!
5.4.3.2!
5.4.3.2.1!
5.4.3.2.1.0!
5.4.3.2.1.1

 
*/


//Kendini çağıran metot;

//Faktoriyel(5);

//int Faktoriyel(int n)
//{
//    if (n <= 1)
//        return 1;
//    return n * Faktoriyel(n - 1);
//}


#endregion


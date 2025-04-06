


//Console.WriteLine("Hello, World!");



//int[] numbers = { 1, 2, 3, 4, 5, 6 };

//int elemanSayisi = numbers.Length;

//int[] hedef =  {10, 20, 30, 40};

//Array.Copy(numbers, hedef, 2);

//foreach(int h in hedef)
//{
//    Console.WriteLine(h);
//}


//Console.WriteLine("-------------------------------------------------");

//Array.Sort(numbers);

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}


//Console.WriteLine("-------------------------------------------------");

//Array.Reverse(numbers);

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

//Console.WriteLine("-------------------------------------------------");


//LastIndexOf
//int lastIndex = Array.LastIndexOf(numbers, 11);
//Console.WriteLine(lastIndex);


//Resize
//Array.Resize(ref numbers, numbers.Length + 1);

//numbers[numbers.Length - 1] = 777;

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}




/*

Kullanıcı Öğrenci Adı, Doğum Tarihi, Final Notu girecek. Kaç öğrenci gireceği başlangıçta belli değil. ilgili veri tiplerine göre bu 3 veriyi her öğrenci için tutacağınız ve en son ekrana yazacağınız uygulamayı yazınız.
 
*/


//Console.Write("Kaç öğrenci gireceksiniz: ");
//int ogrenciSayisi = int.Parse(Console.ReadLine());


//string[] ogrenciler = new string[ogrenciSayisi];
//DateTime[] dogumTarihleri = new DateTime[ogrenciSayisi];
//double[] finalNotlari = new double[ogrenciSayisi];


//for (int i = 0; i < ogrenciSayisi; i++)
//{



//    Console.Write($"\n{i + 1}. Öğrencinin Adı: ");
//    ogrenciler[i] = Console.ReadLine();


//    Console.Write($"\n{i + 1}. Öğrencinin (gg.aa.yyyy): ");
//    DateTime dogumTarihi;
//    while (!DateTime.TryParse(Console.ReadLine(), out dogumTarihi))
//    {
//        Console.Write(" gg.aa.yyyy şeklinde girin ");
//    }
//    dogumTarihleri[i] = dogumTarihi;


//    Console.Write($"\n{i + 1}. Öğrencinin Notu: ");
//    double finalNotu;
//    while (!double.TryParse(Console.ReadLine(), out finalNotu))
//    {
//        Console.Write("Sayısal bir not giriniz.");
//    }
//    finalNotlari[i] = finalNotu;

//}


//for (int i = 0; i < ogrenciSayisi; i++)
//{
//    Console.WriteLine($"{i + 1}. Öğrenci:");
//    Console.WriteLine($"Adı: {ogrenciler[i]}");
//    Console.WriteLine($"Doğum Tarihi: {dogumTarihleri[i].ToString("dd.MM.yyyy")}");
//    Console.WriteLine($"Final Notu: {finalNotlari[i]}\n");
//}


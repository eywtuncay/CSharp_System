


Basla:

int sayi1, sayi2;
string mathOp;

try
{
    Console.WriteLine("Basit bir C# hesap makinesi");
    Console.WriteLine("İşlem seçiniz: [+], [-], [*], [/] Çıkış yapmak için boş bırakınız.");


    Console.Write("Sayı 1: ");
    sayi1 = int.Parse(Console.ReadLine());
    //System.FormatException: 'The input string 'tuncay' was not in a correct format.' -- tuncay girdim sayı1'e

    Console.Write("Sayı 2: ");
    sayi2 = int.Parse(Console.ReadLine());

    Console.Write("İşlem: ");
    mathOp = Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    goto Basla;
}


if (mathOp != string.Empty)
{
    switch (mathOp)
    {
        case "+": Console.WriteLine($"Toplam: {sayi1 + sayi2}"); break;
        case "-": Console.WriteLine($"Çıkarma: {sayi1 - sayi2}"); break;
        case "*": Console.WriteLine($"Çarpım: {sayi1 * sayi2}"); break;
        case "/":
            try
            {
                Console.WriteLine($"Bölüm: {sayi1 / sayi2}"); break;
                //System.DivideByZeroException: 'Attempted to divide by zero.'
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Basla;
            }

        default:
            throw new Exception("Yanlış bir işlem seçtiniz");
            break;
    }
}
else
    Console.WriteLine("İşlem Boş Geçildiği İçin devam edilemedi.");


Console.WriteLine("Devam etmek ister misin? E / H");
string result = Console.ReadLine();

if (result == "E" || result == "e")
    goto Basla;

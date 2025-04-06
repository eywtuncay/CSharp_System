


// String, Datetime, Math


/*

    String Metotları
 
*/

// 1. Length
string metin = "Merhaba";
Console.WriteLine("Length: " + metin.Length); // 7

// 2. Substring
string altDize = metin.Substring(0, 4);
Console.WriteLine("Substring: " + altDize); // "Merh"

// 3. IndexOf
int indeks = metin.IndexOf("aba");
Console.WriteLine("IndexOf: " + indeks); // 3

// 4. ToUpper
string buyukHarf = metin.ToUpper();
Console.WriteLine("ToUpper: " + buyukHarf); // "MERHABA"

// 5. ToLower
string kucukHarf = metin.ToLower();
Console.WriteLine("ToLower: " + kucukHarf); // "merhaba"

// 6. Trim
string trimli = "  Merhaba  ".Trim();
Console.WriteLine("Trim: '" + trimli + "'"); // "Merhaba"

// 7. TrimStart
string trimStart = "  Merhaba  ".TrimStart();
Console.WriteLine("TrimStart: '" + trimStart + "'"); // "Merhaba  "

// 8. TrimEnd
string trimEnd = "  Merhaba  ".TrimEnd();
Console.WriteLine("TrimEnd: '" + trimEnd + "'"); // "  Merhaba"

// 9. Replace
string yeniMetin = "Merhaba Dünya".Replace("Dünya", "Cevren");
Console.WriteLine("Replace: " + yeniMetin); // "Merhaba Cevren"

// 10. Split
string[] parcalar = "Merhaba,Dünya,CSharp".Split(',');
Console.WriteLine("Split: " + string.Join(", ", parcalar)); // "Merhaba, Dünya, CSharp"

// 11. Contains
bool varMi = "Merhaba Dünya".Contains("Dünya");
Console.WriteLine("Contains: " + varMi); // true

// 12. StartsWith
bool basliyor = "Merhaba Dünya".StartsWith("Merhaba");
Console.WriteLine("StartsWith: " + basliyor); // true

// 13. EndsWith
bool bitiyor = "Merhaba Dünya".EndsWith("Dünya");
Console.WriteLine("EndsWith: " + bitiyor); // true

// 14. PadLeft
string soldanPad = "Merhaba".PadLeft(10, '*');
Console.WriteLine("PadLeft: " + soldanPad); // "***Merhaba"

// 15. PadRight
string sagdanPad = "Merhaba".PadRight(10, '*');
Console.WriteLine("PadRight: " + sagdanPad); // "Merhaba***"

// 16. Equals
bool esitMi = "Merhaba".Equals("Merhaba");
Console.WriteLine("Equals: " + esitMi); // true

// 17. Insert
string yeniMetinInsert = "Merhaba".Insert(6, " Dünya");
Console.WriteLine("Insert: " + yeniMetinInsert); // "Merhaba Dünya"

// 18. Join
string[] kelimeler = { "Merhaba", "Dünya", "CSharp" };
string birlesmisMetin = string.Join(", ", kelimeler);
Console.WriteLine("Join: " + birlesmisMetin); // "Merhaba, Dünya, CSharp"

// 19. Format
int yas = 30;
string formatliMetin = string.Format("Yaşınız: {0}", yas);
Console.WriteLine("Format: " + formatliMetin); // "Yaşınız: 30"

// 20. Concat
string concatMetin = string.Concat("Merhaba", " ", "Dünya");
Console.WriteLine("Concat: " + concatMetin); // "Merhaba Dünya"



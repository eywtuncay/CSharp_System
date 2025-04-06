// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



// 1. Now
DateTime simdi = DateTime.Now;
Console.WriteLine("Now: " + simdi); // Örneğin: "21.02.2025 15:30:45"

// 2. UtcNow
DateTime utcSimdi = DateTime.UtcNow;
Console.WriteLine("UtcNow: " + utcSimdi); // Örneğin: "21.02.2025 12:30:45"

// 3. Today
DateTime bugun = DateTime.Today;
Console.WriteLine("Today: " + bugun); // Örneğin: "21.02.2025 00:00:00"

// 4. AddDays
DateTime yeniTarih = bugun.AddDays(5);
Console.WriteLine("AddDays: " + yeniTarih); // 5 gün sonrası

// 5. AddMonths
DateTime yeniTarihAy = bugun.AddMonths(2);
Console.WriteLine("AddMonths: " + yeniTarihAy); // 2 ay sonrası

// 6. AddYears
DateTime yeniTarihYil = bugun.AddYears(1);
Console.WriteLine("AddYears: " + yeniTarihYil); // 1 yıl sonrası

// 7. AddHours
DateTime yeniTarihSaat = bugun.AddHours(5);
Console.WriteLine("AddHours: " + yeniTarihSaat); // 5 saat sonrası

// 8. AddMinutes
DateTime yeniTarihDakika = bugun.AddMinutes(30);
Console.WriteLine("AddMinutes: " + yeniTarihDakika); // 30 dakika sonrası

// 9. AddSeconds
DateTime yeniTarihSaniye = bugun.AddSeconds(120);
Console.WriteLine("AddSeconds: " + yeniTarihSaniye); // 120 saniye sonrası

// 10. AddMilliseconds
DateTime yeniTarihMilisaniye = bugun.AddMilliseconds(500);
Console.WriteLine("AddMilliseconds: " + yeniTarihMilisaniye); // 500 milisaniye sonrası

// 11. Subtract
DateTime tarih1 = new DateTime(2025, 02, 21);
DateTime tarih2 = new DateTime(2025, 01, 21);
TimeSpan fark = tarih1.Subtract(tarih2);
Console.WriteLine("Subtract: " + fark.Days + " gün fark"); // 31 gün fark

// 12. Compare
DateTime tarihA = new DateTime(2025, 02, 21);
DateTime tarihB = new DateTime(2025, 02, 22);
int karsilastir = DateTime.Compare(tarihA, tarihB);
Console.WriteLine("Compare: " + (karsilastir < 0 ? "TarihA daha önce" : "TarihB daha önce"));

// 13. ToString (Farklı formatlarda tarih döndürme)
string tarihString = bugun.ToString("yyyy-MM-dd");
Console.WriteLine("ToString: " + tarihString); // "2025-02-21"

// 14. Parse
string tarihString2 = "2025-02-21";
DateTime parsedTarih = DateTime.Parse(tarihString2);
Console.WriteLine("Parse: " + parsedTarih); // "2025-02-21 00:00:00"

// 15. TryParse
string tarihString3 = "2025-02-21";
DateTime tryParsedTarih;
bool parseSonuc = DateTime.TryParse(tarihString3, out tryParsedTarih);
Console.WriteLine("TryParse: " + (parseSonuc ? tryParsedTarih.ToString() : "Geçersiz tarih")); // "2025-02-21 00:00:00"

// 16. IsLeapYear
bool artikYil = DateTime.IsLeapYear(2024);
Console.WriteLine("IsLeapYear: " + artikYil); // true (2024 bir artık yıldır)

// 17. DaysInMonth
int gunSayisi = DateTime.DaysInMonth(2025, 2);
Console.WriteLine("DaysInMonth: " + gunSayisi); // 28 (2025 yılı normal bir yıldır)

// 18. IsToday
DateTime bugunTarih = DateTime.Today;
bool miBugun = bugunTarih.Date == DateTime.Now.Date;
Console.WriteLine("IsToday: " + miBugun); // true

// 19. Date
DateTime sadeceTarih = DateTime.Now.Date;
Console.WriteLine("Date: " + sadeceTarih); // "2025-02-21 00:00:00"


// değişkeneri sabit girdim

// öğrenciler
// 1. öğrenci
Person ogrenci_1 = new Person();
ogrenci_1.Ad = "Melih Can";
ogrenci_1.SoyAd = "Demir";
ogrenci_1.DoğumTarihi = "14.07.2001";
ogrenci_1.Gorevi = "öğrenci";

// 2. öğrenci : farklı yazma seçeneği
Person ogrenci_2 = new Person
{
    Ad = "Halil",
    SoyAd = "Can",
    DoğumTarihi = "18.03.2000",
    Gorevi = "öğrenci"
};

// 3. öğrenci
Person ogrenci_3 = new Person();
ogrenci_3.Ad = "Hilal";
ogrenci_3.SoyAd = "Demir";
ogrenci_3.DoğumTarihi = "15.08.1999";
ogrenci_3.Gorevi = "öğrenci";

// öğretmenler
Person ogretmen_1 = new Person();
// 1. öğretmen
ogretmen_1.Ad = "Sertan";
ogretmen_1.SoyAd = "Bozkuş";
ogretmen_1.DoğumTarihi = "19.10.1998";
ogretmen_1.Gorevi = "öğretmen";

// ekrana yazdırma
Console.WriteLine("Örenciler:");
ogrenci_1.Yazdir();
ogrenci_2.Yazdir();
ogrenci_3.Yazdir();

Console.WriteLine("////");

Console.WriteLine("Öğretmenler:");
ogretmen_1.Yazdir();

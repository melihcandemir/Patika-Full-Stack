// değişkeneri sabit girdim
// öğrenciler
Person ogrenci_1 = new Person();
// 1. öğrenci
ogrenci_1.Ad = "Melih Can";
ogrenci_1.SoyAd = "Demir";
ogrenci_1.DoğumTarihi = "14.07.2001";
ogrenci_1.Gorevi = "öğrenci";

Console.WriteLine($"{ogrenci_1.Ad} {ogrenci_1.SoyAd} isimli {ogrenci_1.Gorevi}. Doğum tarihi: {ogrenci_1.DoğumTarihi}");
Console.WriteLine("--------------------------------------");

Person ogrenci_2 = new Person();
// 2. öğrenci
ogrenci_2.Ad = "Halil";
ogrenci_2.SoyAd = "Can";
ogrenci_2.DoğumTarihi = "18.03.2000";
ogrenci_2.Gorevi = "öğrenci";

Console.WriteLine($"{ogrenci_2.Ad} {ogrenci_2.SoyAd} isimli {ogrenci_2.Gorevi}. Doğum tarihi: {ogrenci_2.DoğumTarihi}");
Console.WriteLine("--------------------------------------");

Person ogrenci_3 = new Person();
// 3. öğrenci
ogrenci_3.Ad = "Hilal";
ogrenci_3.SoyAd = "Demir";
ogrenci_3.DoğumTarihi = "15.08.1999";
ogrenci_3.Gorevi = "öğrenci";

Console.WriteLine($"{ogrenci_3.Ad} {ogrenci_3.SoyAd} isimli {ogrenci_3.Gorevi}. Doğum tarihi: {ogrenci_3.DoğumTarihi}");

Console.WriteLine("----------------------------------------------------------------------");
// öğretmenler
Person ogretmen_1 = new Person();
// 1. öğretmen
ogretmen_1.Ad = "Sertan";
ogretmen_1.SoyAd = "Bozkuş";
ogretmen_1.DoğumTarihi = "19.10.1998";
ogretmen_1.Gorevi = "öğretmen";

Console.WriteLine($"{ogretmen_1.Ad} {ogretmen_1.SoyAd} isimli {ogretmen_1.Gorevi}. Doğum tarihi: {ogretmen_1.DoğumTarihi}");
Console.WriteLine("--------------------------------------");

Person ogretmen_2 = new Person();
// 2. öğretmen
ogretmen_2.Ad = "Amet";
ogretmen_2.SoyAd = "Yıldız";
ogretmen_2.DoğumTarihi = "10.05.1998";
ogretmen_2.Gorevi = "öğrenci";

Console.WriteLine($"{ogretmen_2.Ad} {ogretmen_2.SoyAd} isimli {ogretmen_2.Gorevi}. Doğum tarihi: {ogretmen_2.DoğumTarihi}");
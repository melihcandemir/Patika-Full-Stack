# Pratik - İlk Sınıfımızı Oluşturuyoruz
- Week 4 ilk uygulama
## Person adında bir sınıf oluşturuyoruz ve bu özellikleri içeren public property'ler (get/set) tanımlıyoruz.
```C#
// sınıf oluşturuldu
public class Person
{
    // Ad, Soyad, Doğum Tarihi.
    public string? Ad {get; set;}
    public string? SoyAd {get; set;}
    public string? Gorevi {get; set;}
    public string? DoğumTarihi {get; set;}


    // ekrana yazdırma metodu 
    public void Yazdir()
    {
        Console.WriteLine($"{Ad} {SoyAd} isimli {Gorevi}. Doğum tarihi: {DoğumTarihi}");
    }
}
```
## Main metodu içinde, bu sınıftan birkaç öğrenci ve öğretmen nesnesi oluşturuyoruz ve bilgilerini konsola yazdırıyoruz.
```C#
// Örnek örenci ve öğretmenler oluşturuldu.
// öğrenciler
Person ogrenci_1 = new Person();
// 1. öğrenci
ogrenci_1.Ad = "Melih Can";
ogrenci_1.SoyAd = "Demir";
ogrenci_1.DoğumTarihi = "14.07.2001";
ogrenci_1.Gorevi = "öğrenci";


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

Console.WriteLine("Öğretmenler:");
ogretmen_1.Yazdir();
```
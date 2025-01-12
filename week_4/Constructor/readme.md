# Constructor
Bu dersde Bebek() sınıfı tanımlamammız isteniyor. Daha sonrq bu sınıf içerisinde 2 adet constructor oluştururlarak çağrılmamız isteniyor.


## Bebek() Class:
```C#
public class Bebek
{
    // property
    public string Ad { get; set; }
    public string SoyAd { get; set; }
    public DateTime DoğumTarihi { get; set; }

    // constructor
    public Bebek()
    {
        // propertylere default değer atanıyor
        Ad = "Belli değil";
        SoyAd = "Belli değil";
        DoğumTarihi = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }

    public Bebek(string ad, string soyad)
    {
        // girilen değerler propertylere eşitleniyor
        Ad = ad;
        SoyAd = soyad;
        DoğumTarihi = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }
}
```

## Bebek() Class 2 farklı şekide çağırılıyor:
```C#
// değer girilmeden bebek class çağırılıyor
Bebek bebek_1 = new Bebek();
Console.WriteLine($"Bebeğin adı {bebek_1.Ad}, bebeğin soyadı {bebek_1.SoyAd}, bebeğin doğum tarihi {bebek_1.DoğumTarihi}");


// değer girilerek bebek class çağırılıyor
Bebek bebek_2 = new Bebek("Ahmet", "Çelik");
Console.WriteLine($"Bebeğin adı {bebek_2.Ad}, bebeğin soyadı {bebek_2.SoyAd}, bebeğin doğum tarihi {bebek_2.DoğumTarihi}");
```

## Output:
```bash
// 1. constructor output
Ingaaaa
Bebeğin adı Belli değil, bebeğin soyadı Belli değil, bebeğin doğum tarihi 12.01.2025

// 2. constructor output
Ingaaaa
Bebeğin adı Ahmet, bebeğin soyadı Çelik, bebeğin doğum tarihi 12.01.2025
```
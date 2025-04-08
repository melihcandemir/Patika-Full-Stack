# Pratik - Abstraction
Bir şirketin çalışanlarını temsil eden bir program yazıyoruz. Abstraction Classları abstrack ve concrete klasörü içerisine düzenledim. Ve şu şekilde ilerliyorz:

## Her çalışan için ad, soyad, departman gibi ortak özellikler bulunmaktadır:
Bunu için absrack kalsörü altında abstract class BasePerson class'ı tanımladım. Aslında hespini interface class'ı içerisinde bulundura bilirdik.
```C#
abstract class BasePerson
{
    // Her çalışan için ad, soyad, departman gibi ortak özellikler bulunmaktadır.
    public string? Ad { get; set; }
    public string? SoyAd { get; set; }
    public string? Departman { get; set; }

}
```

## Görev metodunu çağırdığımızda her çalışan kendi yaptığı işi konsol ekranında söyleyecek.
Bu Görev metotdu için abstrack klasörü altında interface IBasePerson class'ı tanımladım:
```C#
interface IBasePerson
{
    // her çalışanın görevi (pozisyonu) farklı olabilir (Örneğin, Yazılım Geliştirici, Proje Yöneticisi, Satış Temsilcisi).
    void Gorev();
}
```

## Her çalışanın görevi (pozisyonu) farklı olabilir (Örneğin, Yazılım Geliştirici, Proje Yöneticisi, Satış Temsilcisi).
Örnek olarak Yazılım geliştiricisi:
```C#
// yazılım geliştiricisi class'ı
class Yazilim : BasePerson, IBasePerson
{
    public void Gorev()
    {
        Console.WriteLine($"Benim adım {Ad} {SoyAd}. Ben {Departman} departmanında yazılım geliştiricisi olarak çalışıyorum.");
    }
}
```

## Daha sonra oluşturulan classları çağırıyoruz:
```C#
// personel_1
Yazilim personel_1 = new Yazilim
{
    Ad = "Melih",
    SoyAd = "Can",
    Departman = "Yazılım"
};

personel_1.Gorev();

Console.WriteLine("------------------------------------");

// personel_2
Proje personel_2 = new Proje
{
    Ad = "Çelik",
    SoyAd = "Çakmak",
    Departman = "Yazılım"
};

personel_2.Gorev();

Console.WriteLine("------------------------------------");

// personel_3
Satis personel_3 = new Satis
{
    Ad = "Meftun",
    SoyAd = "Suiçmez",
    Departman = "Satış"
};

personel_3.Gorev();
```

## Output:
```bash
Benim adım Melih Can. Ben Yazılım departmanında yazılım geliştiricisi olarak çalışıyorum.
------------------------------------
Benim adım Çelik Çakmak. Ben Yazılım departmanında proje yöneticisi olarak çalışıyorum.
------------------------------------
Benim adım Meftun Suiçmez. Ben Satış departmanında satış temsilcisi olarak çalışıyorum.
```

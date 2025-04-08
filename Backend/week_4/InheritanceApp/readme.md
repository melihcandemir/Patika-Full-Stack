# Pratik - Inheritance
Bu pratikte bizden inheritance class ile çalışmamız isteniyor. Classları Class klasörü içerisine düzenledim.
Ve şu şekilde ilerliyorz:

## 1- Bizleden bir Base Sınıf oluşturmamız isteniyor. İsmi -> BaseKisi
- BaseKisi için propertyler -> Ad, Soyad
- BaseKisi için metotlar -> Konsol ekranına ad ve soyad yazdıran bir metot.
```C#
public class BaseKisi
{
    // BaseKisi için propertyler -> Ad, Soyad
    public string? Ad { get; set; }
    public string? SoyAd { get; set; }

    // BaseKisi için metotlar -> Konsol ekranına ad ve soyad yazdıran bir metot.
    // bu metot da virtual kullanarak diğer class larda düzenleme yapabilmesini sağlıyorum
    public virtual void Yazdir()
    {
        Console.Write($"Benim adım {Ad} soyadım {SoyAd}. ");
    }
}
```
## 2- Ardından BaseKisi'den miras alacak Ogrenci ve Ogretmen sınıfları oluşturmamız gerekiyor.
- Ogrenci için ilave propertyler -> Öğrenci Numarası
- Ogrenci için ilave metotlar -> Konsol ekranına öğrenci numarası, ad ve soyad yazdıran bir metot
```C#
public class Ogrenci : BaseKisi
{
    // Ogrenci için ilave propertyler -> Öğrenci Numarası
    public int OgrenciNo { get; set; }

    // Ogrenci için ilave metotlar -> Konsol ekranına öğrenci numarası, ad ve soyad yazdıran bir metot
    public override void Yazdir()
    {
        // Yazdir() methodunun hazır veren çıktısı
        base.Yazdir();

        // ek olarak öğrenci numarası ekliyorum
        Console.WriteLine($"Öğernci numaram {OgrenciNo}");
    }
}
```
- Ogretmen için ilave propertyler -> Maaş Bilgisi
- Ogretmen için ilave metotlar -> Konsol ekranına Maaş bilgisi, ad ve soyad yazdıran bir metot.
```C#
public class Ogretmen : BaseKisi
{
    // Ogretmen için ilave propertyler -> Maaş Bilgisi
    public decimal Maas { get; set; }

    // Ogretmen için ilave metotlar -> Konsol ekranına Maaş bilgisi, ad ve soyad yazdıran bir metot.
    public override void Yazdir()
    {
        base.Yazdir();
        // ek olarak maaş bilgisini giriyoruz.
        Console.WriteLine($"Maaşım {Maas}TL");
    }

}
```

## 3- Örnek birer öğretmen ve öğrenci nesneleri tanımlayarak bunlara değerler atadım. Ardından değerleri konsol ekranına yazdırdım.
```C#
// Örnek birer öğretmen ve öğrenci nesneleri tanımlayarak bunlara değerler atadım. Ardından değerleri konsol ekranına yazdırdım.
Ogrenci ogrenci_1 = new Ogrenci
{
    Ad = "Melih",
    SoyAd = "Can",
    OgrenciNo = 1423
};

Ogretmen ogretmen_1 = new Ogretmen
{
    Ad = "Serkan",
    SoyAd = "Bozkuş",
    Maas = 1000000
};


// konsola metot ile yazdırıyoruz
ogrenci_1.Yazdir();
ogretmen_1.Yazdir();
```

## 4- Output:
```bash
Benim adım Melih soyadım Can. Öğernci numaram 1423
Benim adım Serkan soyadım Bozkuş. Maaşım 1000000TL
```
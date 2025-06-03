# Pratik - Polymorphism
Bu pratikte bizden Polymorphism ile çalışmamız isteniyor.Classları Class klasörü içerisine düzenledim. Ve şu şekilde ilerliyorz:

## 1- Kare, Dikdörtgen, Dik Üçgen nesnelerinden oluşacak bir uygulamada alan hesaplaması yapmak istiyoruz.
Yukarıda bahsettiğimiz nesnelerin her birini üretebilmemiz için classlara ihtiyacımız var.

- Kare:
```C#
public class Kare : BaseGeometrikSekil
{
    public Kare()
    {
        Console.WriteLine("Kare oluşturuldu.");
    }

    // Kare ve Dikdortgen için Genişlik x Yükseklik şeklinde hesaplıyoruz.
    public override void AlanHesapla() // override ile motodu değiştiriyoruz
    {
        Console.WriteLine("Oluşturulan karenin alanı: " + Yukseklik * Genislik);
        Console.WriteLine("------------");
    }
}
```
- Dikdortgen:
```C#
public class Dikdortgen : BaseGeometrikSekil
{
    public Dikdortgen()
    {
        Console.WriteLine("Dikdörtgen oluşturuldu.");
    }

    // Kare ve Dikdortgen için Genişlik x Yükseklik şeklinde hesaplıyoruz.
    public override void AlanHesapla() // override ile motodu değiştiriyoruz
    {
        Console.WriteLine("Oluşturulan dikdörtgenin alanı: " + Yukseklik * Genislik);
        Console.WriteLine("------------");
    }
}
```
- DikUcgen:
```C#
public class DikUcgen : BaseGeometrikSekil
{
    public DikUcgen()
    {
        Console.WriteLine("Diküçgen oluşturuldu.");
    }

    // Dik Üçgen için (Genişlik x Yükseklik ) / 2 olarak alan hesaplanması.
    public override void AlanHesapla() // override ile motodu değiştiriyoruz
    {
        Console.WriteLine("Oluşturulan diküçgenin alanı: " + (Yukseklik * Genislik) / 2);
        Console.WriteLine("------------");
    }
}
```

## 2- Classlarımızı ortak bir çatı altında toplayarak BaseGeometrikSekil classından türetebiliriz:
```C#
public class BaseGeometrikSekil
{
    // BaseGeometrikSekil için Propertyler -> Genişlik ve Yükseklik
    public int Genislik { get; set; }
    public int Yukseklik { get; set; }

    // AlanHesapla() metodu tüm geometrik şekillerde bulanacağından Base Class içerisinde tanımlayabiliriz.
    public virtual void AlanHesapla() // virtual ile metot değiştirilebilir, ezilebilir
    {
        Console.WriteLine("Oluşturulan geometrik şeklin alanı : " + Genislik * Yukseklik);
    }
}
```
 
## 3- Polymorphism prensibini kullanarak ilgili uygulamayı kodlayınız. Her classtan bir örnek nesne oluşturarak Alan ölçülerini konsol ekranına yazdırınız:
```C#
DikUcgen ucgen = new DikUcgen
{
    Genislik = 5,
    Yukseklik = 10
};
// alan hesaplama
ucgen.AlanHesapla();


BaseGeometrikSekil kare = new Kare
{
    Genislik = 10,
    Yukseklik = 10
};
// alan hesaplama
kare.AlanHesapla();


Dikdortgen dikdortgen = new Dikdortgen
{
    Genislik = 10,
    Yukseklik = 5
};
// alan hesaplama
dikdortgen.AlanHesapla();
```

## 4- Output:
```bash
Diküçgen oluşturuldu.
Oluşturulan diküçgenin alanı: 25
------------
Kare oluşturuldu.
Oluşturulan karenin alanı: 100
------------
Dikdörtgen oluşturuldu.
Oluşturulan dikdörtgenin alanı: 50
------------
```
# PatikaLibrary
Patika Kütüphanesi için bir kitap kayıt uygulaması oluşturmak istiyoruz.


## Library() : 
- Ad, Yazar Adı, Yazar Soyadı, Sayfa Sayısı, Yayınevi, Kayit Tarihi bilgileri ile kitaplar kaydetmek istiyoruz.
- Bunun için Library() class oluşturuyoruz.
- Ekrana yazabilmek için de Yazdir() metodu oluşturdum.
- Constructor kullanarak default değerleri atadım ve class çağırma yöntemleri ekledim.
```C#
public class Library
{
    // Ad, Yazar Adı, Yazar Soyadı, Sayfa Sayısı, Yayınevi, Kayit Tarihi bilgileri
    public string KitapAdi { get; set; }
    public string YazarAdi { get; set; }
    public string YazarSoyAdi { get; set; }
    public int KitapSayfaSayisi { get; set; }
    public string YayinEvi { get; set; }
    public DateTime KayitTarihi { get; set; }

    // cosntructor metotlar
    public Library()
    {
        KitapAdi = "Bilinmeyen";
        YazarAdi = "Bilinmeyen";
        YazarSoyAdi = "Bilinmeyen";
        KitapSayfaSayisi = 0; // herhangi bir değer girilmez ise zaten 0 a eşit olur
        YayinEvi = "Bilinmeyen";
        KayitTarihi = DateTime.Now;
        Console.WriteLine("Default değerler atanarak kitap oluşturuldu.");
    }

    public Library(string kitapAdi, string yazarAdi, string yazarSoyAdi, int sayfaSayisi, string yayinEvi)
    {
        KitapAdi = kitapAdi;
        YazarAdi = yazarAdi;
        YazarSoyAdi = yazarSoyAdi;
        KitapSayfaSayisi = sayfaSayisi;
        YayinEvi = yayinEvi;
        KayitTarihi = DateTime.Now;
        Console.WriteLine("Kullanıcıdan değerler alınarak kitap oluşturuldu.");
    }

    // ekrana yazdırma metodu
    public void Yazdir()
    {
        Console.WriteLine($"{KitapAdi} kitabı {KitapSayfaSayisi} sayfa. {YazarAdi} {YazarSoyAdi} yazarı tarafından yazıldı. {YayinEvi} yayınevi tarafından {KayitTarihi.ToString("D")} tarihinde yayınlandı.");
    }

}
```

## Library() Class 2 farklı şekilde çağırılıyor:
```C#
// constructer 1
Library book1 = new Library();
book1.Yazdir();

Console.WriteLine("----------------------------------------");

// constructer 2
Library book2 = new Library("Aylin", "Ayşe", "Kuli", 398, "Remzi Kitabevi");
book2.Yazdir();
```

## Program.cs dosyasında: 
- Kodların altına birer yorum satırıyla örnek üzerinden Class , Property , New , Constructor kavramlarını kendi bildiğim kadarıyla açıkladım açıkladım.
```C#
// Class : Sınıflar, verileri ve bu veriler üzerinde işlem yapan metotlar bir araya getirir.

// Property : Bir sınıfın veya yapının verilerine erişimi kontrol etmek kullanılan bir yapıdır.

// New : Yeni bir nesne oluşturmak için kullanılır.

// Constructor : Oluşturulan Class'ı çağırdığımızda otomatik olarak çağrılan bir metot. Nesnenin başlangıç metodunu ayarlaya biliriz. Default değerleri atayabiliriz.
```
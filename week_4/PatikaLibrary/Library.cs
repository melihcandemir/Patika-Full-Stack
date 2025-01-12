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
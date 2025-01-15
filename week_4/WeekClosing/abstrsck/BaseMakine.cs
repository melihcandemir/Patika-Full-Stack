public abstract class BaseMakine
{
    // Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi,
    public string? Ad { get; set; }
    public int SeriNo { get; set; }
    public DateTime _uretimTarihi { get; set; }
    public string? Aciklama { set; get; }
    public string? Isletimsistemi { set; get; }

    // metot değiştirile bilir
    public virtual void UrunBilgileri()
    {
        Console.ResetColor(); // varsayılan console rengi geri yüklenir
        Console.WriteLine($"Ürün Adı: {Ad}\nÜrün Üretim Tarihi: {_uretimTarihi}\nSeri No: {SeriNo}\nİşletim Sistemi: {Isletimsistemi}\nAçıklam: {Aciklama}");
    }

    // metot değiştirile bilir
    public abstract void UrunAdiGetir();

    // kullanıcıdan ad, açıklama, işletim sistemini alıyorum
    public virtual void KullaniciGiris()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("Ürün adı giriniz: ");
        Ad = Console.ReadLine();

        Console.Write("Ürün işletim sistemi giriniz: ");
        Isletimsistemi = Console.ReadLine();

        Console.Write("Ürün açıklaması giriniz: ");
        Isletimsistemi = Console.ReadLine();
    }

}
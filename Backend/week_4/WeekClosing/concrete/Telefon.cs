class Telefon : BaseMakine
{
    bool TrLicanse { get; set; }

    public Telefon()
    {
        _uretimTarihi = DateTime.Now;
        // seri numarasını random olarak üretiyoruz
        Random sr = new Random();
        SeriNo = sr.Next(1000, 9999);
        // şimdilik true verildi
        TrLicanse = true;
    }

    // kullanıcı ister ise ürün adını getire biliyoruz
    public override void UrunAdiGetir()
    {
        Console.ResetColor(); // varsayılan console rengi geri yüklenir
        Console.WriteLine($"Telefonunuzun adı ----> {Ad}");
    }

    // kullanıcıdan ad, açıklama, işletim sistemini alıyorum
    public override void KullaniciGiris()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("Ürün adı giriniz: ");
        Ad = Console.ReadLine();

        Console.Write("Ürün işletim sistemi giriniz: ");
        Isletimsistemi = Console.ReadLine();

        Console.Write("Ürün açıklaması giriniz: ");
        Aciklama = Console.ReadLine();
    }

    // ürün bilgilerini yazdırıyoruz
    public override void UrunBilgileri()
    {
        base.UrunBilgileri();
        Console.WriteLine($"Türkiye Lisansı: {TrLicanse}");
    }

}
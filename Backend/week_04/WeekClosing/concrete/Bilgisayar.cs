class Bilgisayar : BaseMakine
{
    private int _usb;
    bool Bt { get; set; }
    int Usb
    {
        get { return _usb; }
        set
        {
            if (value == 2 || value == 4)
            {
                _usb = value;
            }
            else
            {
                Console.WriteLine("Port sayısını lütfen 2 veya 4 giriniz. Yanlış girildiği için -1 olarak atandı.");
                _usb = -1;
            }
        }
    }

    public Bilgisayar()
    {
        _uretimTarihi = DateTime.Now;
        // seri numarasını random olarak üretiyoruz
        Random sr = new Random();
        SeriNo = sr.Next(1000, 9999);
        // şimdilik true olarak ayarlandı
        Bt = true;
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

        Console.Write("Usb port giriş adedi giriniz: ");
        Usb = Convert.ToInt32(Console.ReadLine());
    }

    // ürün bilgilerini yazdırıyoruz
    public override void UrunBilgileri()
    {
        base.UrunBilgileri();
        Console.WriteLine($"Bluetooth özelliği: {Bt}");
        Console.WriteLine($"Usb port girişi adedi: {_usb}");
    }

}
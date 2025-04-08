# 💣Hafta 4 - Kapanış
Bir teknoloji mağazasında Telefon ve Bilgisayar kayıtları alıyoruz. Abstraction Classları abstrack ve concrete klasörü içerisine düzenledim. Ve şu şekilde ilerliyoruz:

## BaseMakine class'ında kayıt alınacak olan makinelerin ortak özelliklerini topluyoruz.
```C#
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
```

## Telefon ve Bilgisayar classları oluşturarak kayıt alınacak ürünlerin özelliklerini ayarlıyoruz.
Örnek olarak Bilgisayar class'ını veriyorum. Bu class da Usb port sayısı eğer 2 veya 4 girilmez ise -1 değeri atanır.
```C#
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
```

## Programda kayıt uygulaması oluşturuyoruz.
Console yazılarını renklendirerek uygulamaya devam ediyoruz.
```C#
Console.ForegroundColor = ConsoleColor.Red; // uygulama kırmızı renkte çalışacak
Console.WriteLine("-------------------------------- Telefon ve Bilgisayar kayıt programına hoşgeldiniz --------------------------------");
string? devam = "başladı";
int i = 1;
do
{
    Console.ForegroundColor = ConsoleColor.Green; // yeşil renkde devam ediyor
    Console.WriteLine($"---------------- KAYIT {i} ----------------");
    Console.Write("Hangi cihazın kaydını yapmak istiyorsunuz?\n[ Telefon için (1) - Bilgisayar için (2) seçiniz. ]\nSeçiminiz: ");
    string? secim = Console.ReadLine();

    // seçim sonrası yapılacakları metotlar ile yapıyoruz
    switch (secim)
    {
        case "1":
            Console.WriteLine("---------------- Telefon kaydı ----------------");
            Telefon tl = new Telefon();
            tl.KullaniciGiris();
            Console.WriteLine("----------------- Ürün Başarıyla Üretildi ------------------");
            Console.WriteLine("--------------------------------------------------");
            tl.UrunBilgileri();
            Console.WriteLine("--------------------------------------------------");
            tl.UrunAdiGetir();
            Console.WriteLine("--------------------------------------------------");
            i++;
            break;

        case "2":
            Console.WriteLine("---------------- Bilgisayar kaydı ----------------");
            Bilgisayar bl = new Bilgisayar();
            bl.KullaniciGiris();
            Console.WriteLine("----------------- Ürün Başarıyla Üretildi ------------------");
            Console.WriteLine("--------------------------------------------------");
            bl.UrunBilgileri();
            Console.WriteLine("--------------------------------------------------");
            bl.UrunAdiGetir();
            Console.WriteLine("--------------------------------------------------");
            i++;
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---!! 1 veya 2 seçiniz ---!!");
            break;
    }

    Console.ForegroundColor = ConsoleColor.Blue; // mavi
    Console.Write("Başka bir cihaz kaydı yapmak istiyor musunuz?\n[ Evet ise (1) - Hayır ise (2) seciniz. ]\nSeçiminiz: ");
    devam = Console.ReadLine();

} while (devam == "1");

Console.ForegroundColor = ConsoleColor.Red; // kırmızı
Console.WriteLine("---------------- İyi Günler Uygulama Sonlandırılıyor. ----------------");
Console.ResetColor(); // varsayılan console rengi geri yüklenir


```

## Örenk Output:
```bash
-------------------------------- Telefon ve Bilgisayar kayıt programına hoşgeldiniz --------------------------------
---------------- KAYIT 1 ----------------
Hangi cihazın kaydını yapmak istiyorsunuz?
[ Telefon için (1) - Bilgisayar için (2) seçiniz. ]
Seçiminiz: 2
---------------- Bilgisayar kaydı ----------------
Ürün adı giriniz: asus
Ürün işletim sistemi giriniz: windows
Ürün açıklaması giriniz: rtx 4050 olsun
Usb port giriş adedi giriniz: 4
----------------- Ürün Başarıyla Üretildi ------------------
--------------------------------------------------
Ürün Adı: asus
Ürün Üretim Tarihi: 15.01.2025 18:31:54
Seri No: 8055
İşletim Sistemi: windows
Açıklam: rtx 4050 olsun
Bluetooth özelliği: True
Usb port girişi adedi: 4
--------------------------------------------------
Telefonunuzun adı ----> asus
--------------------------------------------------
Başka bir cihaz kaydı yapmak istiyor musunuz?
[ Evet ise (1) - Hayır ise (2) seciniz. ]
Seçiminiz: 2
---------------- İyi Günler Uygulama Sonlandırılıyor. ----------------
```
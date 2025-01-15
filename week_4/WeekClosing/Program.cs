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


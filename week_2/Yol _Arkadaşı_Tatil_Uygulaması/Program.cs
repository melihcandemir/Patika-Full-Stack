
string tekrar; // uygulama terarı değişkeni
do
{
    // kullanıcı gideceği lokasyon döngüsü için değişkenler
    bool one = false;
    bool two = false;
    bool three = false;
    string gidecek;

    // do-while ile herhangi bir sorunda ve kullanıcının boş geçmesi durumundas uygulamayı tekrarlamasını sağlıyoruz
    do
    {
        // kullanıcıya gidebileceği lokasyonları veriyoruz..
        Console.WriteLine("Gidilebilecek yerler:");
        Console.WriteLine("1- Bodrum (4000 TL)\n2- Marmaris (3000 TL)\n3- Antalya(5000 TL)");
        Console.WriteLine("------------------------------------------------------");
        Console.Write("Nereye gitmek istiyorsanız giriniz: ");
        gidecek = Console.ReadLine()?.ToLower() ?? string.Empty; // gideceği yeri alıyoruz
        Console.WriteLine("------------------------------------------------------");

        // döngü hesaplatma
        one = (gidecek != "bodrum") && (gidecek != "1");
        two = (gidecek != "marmaris") && (gidecek != "2");
        three = (gidecek != "antalya") && (gidecek != "3");
        
        // lütfen gitmek istediğiniz yeri seçiniz yazdır..
        if((one == true) && (two == true) && (three == true))
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Lütfen yukarıdaki üç yerden birini seçiniz..");
            Console.WriteLine("------------------------------------------------------");
        }

    } while ((one == true) && (two == true) && (three == true));

    // kaç kişi gitmek istiyor bilgisi
    int kisi_sayisi;
    Console.Write("Kaç kişi tatil yapmak istiyorsunuz: ");
    kisi_sayisi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("------------------------------------------------------");

    // eğer kullanıcı kişi sayısını 0 girerse 1 e eşiter
    if(kisi_sayisi == 0)
    {
        kisi_sayisi = 1;
    }

    // gidilecek yer ve ne kadar harcanacak bilgisi
    int bod1 = 4000; // bodrum
    int mar2 = 3000; // marmaris
    int ant3 = 5000; // antalya
    int tatil_ücreti = 0;
    switch (gidecek)
    {
        case "1":
        case "bodrum":
            // kod düzenli olsun diye alt alta yazdım
            Console.WriteLine("Bodrum:\nBodrum hem tarihi ve kültürel zenginlikleriyle hem de doğal güzellikleriyle unutulmaz bir tatil deneyimi sunar.");
            Console.WriteLine("İster tarih meraklısı olun, ister doğa sever, isterse gece hayatının tutkunu; Bodrum'da herkes için bir şeyler bulunur.");
            Console.WriteLine($"Bodrum tatili paket başlangıç fiyatı: {bod1}TL");
            Console.WriteLine($"{kisi_sayisi} kişi gidileceği için: {bod1  * kisi_sayisi}TL"); // kaç kişi gidilecek ücret hesabı
            Console.WriteLine("------------------------------------------------------");
            tatil_ücreti = bod1  * kisi_sayisi;
            break;
        
        case "2":
        case "marmaris":
            // kod düzenli olsun diye alt alta yazdım
            Console.WriteLine("Marmaris:\nMarmaris, hem tarihi ve kültürel zenginlikleriyle hem de doğal güzellikleriyle unutulmaz bir tatil deneyimi sunar.");
            Console.WriteLine("İster tarih meraklısı olun, ister doğa sever, isterse gece hayatının tutkunu; Marmaris'de herkes için bir şeyler bulunur.");
            Console.WriteLine($"Marmaris tatili paket başlangıç fiyatı: {mar2}");
            Console.WriteLine($"{kisi_sayisi} kişi gidileceği için: {mar2  * kisi_sayisi}TL"); // kaç kişi gidilecek ücret hesabı
            Console.WriteLine("------------------------------------------------------");
            tatil_ücreti = mar2  * kisi_sayisi;
            break;

        case "3":
        case "antalya":
            // kod düzenli olsun diye alt alta yazdım
            Console.WriteLine("Antalya:\nAntalya, hem tarihi ve kültürel zenginlikleriyle hem de doğal güzellikleriyle unutulmaz bir tatil deneyimi sunar.");
            Console.WriteLine("İster tarih meraklısı olun, ister doğa sever, isterse gece hayatının tutkunu; Antalya'da herkes için bir şeyler bulunur.");
            Console.WriteLine($"Marmaris tatili paket başlangıç fiyatı: {ant3}");
            Console.WriteLine($"{kisi_sayisi} kişi gidileceği için: {ant3  * kisi_sayisi}TL"); // kaç kişi gidilecek ücret hesabı
            Console.WriteLine("------------------------------------------------------");
            tatil_ücreti = ant3  * kisi_sayisi;
            break;

        default:
            Console.WriteLine("Seçim yapılamadı..");
            break;
    }

    // gidiş yolu değişkenleri
    bool kara = false;
    bool hava = false;
    int kar1 = 1500;
    int hav2 = 4000;
    string hedef = ""; // yol seçimi
    int yol;
    int yol_ücreti = 0;

    do
    {
        // kullanıcıya gitmek istediği yolu soruyoruz
        Console.WriteLine("Tatile nasıl gitmek istersiniz?");
        Console.Write("1- Kara(1500 TL)\n2- Hava(4000 TL)\n1 veya 2 : ");
        yol = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("------------------------------------------------------");

        // döngü hesaplatma
        kara = yol != 1;
        hava = yol != 2;
        
        // yol tutarını hesapla

        if(yol == 1)
        {
            hedef = "Kara Yolu";
            yol_ücreti = kar1 * kisi_sayisi; // kaç kişi gidilecek ücret hesabı
        }
        else if(yol == 2)
        {
            hedef = "Hava Yolu";
            yol_ücreti = hav2 * kisi_sayisi; // kaç kişi gidilecek ücret hesabı
        }
        else
        {
            Console.WriteLine("Hesaplanamadı...");
        }


        // lütfen gitmek istediğiniz yolu seçiniz yazdır..
        if((kara == true) && (hava == true))
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Lütfen gitmek istediğiniz yolu 1 veya 2 olarak seçiniz..");
            Console.WriteLine("------------------------------------------------------");
        }


    } while ((kara == true) && (hava == true));

    // toplam tatil ücreti
    int toplam;
    toplam = yol_ücreti + tatil_ücreti;

    // Ardından gidilecek lokasyon, kişi sayısı ve ulaşım aracı seçenekleriyle bir toplam fiyat hesaplayıp bunu kullanıcıya sunalım
    switch (gidecek)
    {
        case "1":
        case "bodrum":
            Console.WriteLine($"Bodrum tatilini seçerek {kisi_sayisi} kişi planladınız.");
            Console.WriteLine($"Bodrum tatiline {hedef} ile gitmeyi seçtiniz.");
            Console.WriteLine($"Toplam tatil ücretiniz {toplam} olarak hesaplandı....\nİyi Tatiller dileriz...");
            break;
        
        case "2":
        case "marmaris":
            Console.WriteLine($"Marmaris tatilini seçerek {kisi_sayisi} kişi planladınız.");
            Console.WriteLine($"Marmaris tatiline {hedef} ile gitmeyi seçtiniz.");
            Console.WriteLine($"Toplam tatil ücretiniz {toplam} olarak hesaplandı....\nİyi Tatiller dileriz...");
            break;

        case "3":
        case "antalya":
            Console.WriteLine($"Antalya tatilini seçerek {kisi_sayisi} kişi planladınız.");
            Console.WriteLine($"Antalya tatiline {hedef} ile gitmeyi seçtiniz.");
            Console.WriteLine($"Toplam tatil ücretiniz {toplam} olarak hesaplandı....\nİyi Tatiller dileriz...");
            break;

        default:
            Console.WriteLine("Hata...sonn");
            break;
    }

    // kulanıcıdan tekrar tatil planı yapmasını isteyip istemediğini soruyoruz
    Console.WriteLine("------------------------------------------------------");
    Console.WriteLine("Tekrar tatil planı yapmak istiyor musun?\n(evet/hayır): ");
    
    tekrar = Console.ReadLine()?.ToLower() ?? string.Empty; // tekar bilgisini alıyoruz

    // döngü hesaplama
    if(tekrar == "evet")
    {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("------------------------------------------------------");
    }
    else
    {
        Console.WriteLine("İyi günler, iyi tatiller dilerim...");
        Console.WriteLine("------------------------------------------------------");
    }

} while (tekrar == "evet");

# Pratik - Yol Arkadaşı : Tatil uygulaması
Bu pratikte bir yardımcı seyehat uygulaması ile kullanıcılarımızın planlayacakları 3 günlük bir tatilde harcayacakları yaklaşık tutarı hesaplamalarına yardımcı oluyoruz.

## Uygulama özeti:
Yazdığım uygulama genel olarak do-while kullanılarak oluşturuldu. Kodların tamamı Program.cs dosyasında.

## 3 adet lokasyonumuz var:
- Bodrum (Paket başlangıç fiyatı 4000 TL)
- Marmaris (Paket başlangıç fiyatı 3000 TL)
- Antalya (Paket başlangıç fiyatı 5000 TL)

## Kullanıcıya gitmek istediği lokasyonu soruyoruz:
```C#
string gidecek;
Console.WriteLine("Gidilebilecek yerler:");
Console.WriteLine("1- Bodrum (4000 TL)\n2- Marmaris (3000 TL)\n3- Antalya(5000 TL)");
Console.WriteLine("------------------------------------------------------");
Console.Write("Nereye gitmek istiyorsanız giriniz: ");
gidecek = Console.ReadLine()?.ToLower() ?? string.Empty; // gideceği yeri alıyoruz
Console.WriteLine("------------------------------------------------------");
```

## Kullanıcıya kaç kişi tatil yapmak istediğini soruyoruz:
```C#
// kaç kişi gitmek istiyor bilgisi
int kisi_sayisi;
Console.Write("Kaç kişi tatil yapmak istiyorsunuz: ");
kisi_sayisi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------------------------------------------------");
```

Eğer kullanıcı 0değeri girer ise bunu 1 ile değiştiriyoruz:
```C#
// eğer kullanıcı kişi sayısını 0 girerse 1 e eşiter
if(kisi_sayisi == 0)
{
    kisi_sayisi = 1;
}
```
## Gitmek istenilen lokasyon ve o lokasyonda tatili sırasında yapabilecekleri ile ilgili bir özet bilgiyi ekrana yazdırıyoruz:
```C#
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
```
## Kullanıcıya tatile nasıl gitmek istediğini soruyoruz:
```C#
// kullanıcıya gitmek istediği yolu soruyoruz
Console.WriteLine("Tatile nasıl gitmek istersiniz?");
Console.Write("1- Kara(1500 TL)\n2- Hava(4000 TL)\n1 veya 2 : ");
yol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------------------------------------------------");
```
2 Seçenek var:

- Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )
- Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)

## Ardından gidilecek lokasyon, kişi sayısı ve ulaşım aracı seçenekleriyle bir toplam fiyat hesaplayıp bunu kullanıcıya sunuyoruz:
```C#
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
```

## Kullanıcıya başka bir tatil planlamak isteyip istemediğini soruyoruz, istiyorsa uygulama ilk aşamadan çalışmaya başlatıyoruz, kullanıcı istemiyorsa iyi günler, iyi tatiller... dileyerek uygulamayı sonlandırıyoruz:
```C#
do
{
    // uygulama bu do-while içinde


    
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
```
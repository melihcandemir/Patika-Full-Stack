# Pratik - Patikaflix Diziler Platformu

- Bu pratikte sizlerden bir Diziler listesi oluşturmanız ve içerisindeki nesneleri tanımlamanız bekleniyor. Elemanların oluşturuluşu Console ekranı üzerinden olacak.
```bash
----- 1. diziyi giriniz -----
Dizinin adı: Avrupa Yakası
Dizinin yapım yılı: 2004
Dizinin türü: Komedi
Dizinin yayınlanma tarihi: 2004
Dizinin yönetmeni: Yüksel Aksu
Dizinin yayınlandığı ilk platform: Kanal D
```


- Yani kullanıcıya her diziyi oluşturup listeye ekledikten sonra yeni bir dizi ekleyip eklemediğini sormamız gerekiyor.
```bash
Başka dizi kaydı yapmak istiyor musunuz ? [ e / h ] : e
```

## Console üzerinden bilgileri alıyoruz
```C#
do
{
    Series serie = new Series();
    Console.WriteLine($"----- {i}. diziyi giriniz -----");
    //
    Console.Write("Dizinin adı: ");
    serie.Name = Console.ReadLine()?.Trim(); // .Trim() ile eğer kullanıcı ismin başında veya sonunda boşluk bırakırsa siler.
    //
    Console.Write("Dizinin yapım yılı: ");
    serie.ProductionYear = Convert.ToInt32(Console.ReadLine());
    //
    Console.Write("Dizinin türü: ");
    serie.Genre = Console.ReadLine()?.Trim();
    //
    Console.Write("Dizinin yayınlanma tarihi: ");
    serie.PublicationDate = Convert.ToInt32(Console.ReadLine());
    //
    Console.Write("Dizinin yönetmeni: ");
    serie.Directors = Console.ReadLine()?.Trim();
    //
    Console.Write("Dizinin yayınlandığı ilk platform: ");
    serie.ReleasePlatform = Console.ReadLine()?.Trim();

    // dizi eklendi
    series.Add(serie);

    Console.Write("Başka dizi kaydı yapmak istiyor musunuz ? [ e / h ] : ");
    reply = Console.ReadLine()?.Trim().ToLower();
    i++;

} while (reply == "e");
```

## Ardından aşağıda istenilen işlemleri gerçekleştiriniz.

- İlk listenizde bulunan komedi dizilerinden yeni bir liste oluşturunuz. Bu listede yalnızca Dizi Adı / Dizi Türü / Yönetmen bilgileri yer alsın (Yani başka bir class ihtiyacınız doğuyor.)
```C#
// kullanıcıdan alınan dizilerden komedi türündekileri aldık
var comediSeries = series.Where(x => x.Genre == "Komedi");

// yeni bir liste oluşturarak içerisine sırardık
List<DisplaySerie> displaySeries = comediSeries.Select(x => new DisplaySerie { NameDisplay = x.Name, GenreDisplay = x.Genre, DirectorsDisplay = x.Directors }).ToList();

// ekrana düzenli yazdırmak için yeni liste oluşturuk
var display = displaySeries.OrderBy(x => x.NameDisplay).ThenBy(x => x.DirectorsDisplay).ToList();

Console.WriteLine("------ Komedi dizileri listesi ------");
int t = 1;
foreach (var comedy in display)
{
    Console.WriteLine($"{t}- Dizi adı: {comedy.NameDisplay} - Yönetmen adı: {comedy.DirectorsDisplay} - Türü: {comedy.GenreDisplay}");
    t++;
}
```

- Bu yeni listenin bütün elemanlarını bütün özellikleriyle ekrana yazdırınız. Yazımın öncelikle dizi isimleri sonra da yönetmen isimleri baz alınarak sıralanmasına özen gösteriniz.

```bash
------ Komedi dizileri listesi ------
1- Dizi adı: Avrupa Yakası - Yönetmen adı: Yüksel Aksu - Türü: Komedi
2- Dizi adı: Jet Sosyete - Yönetmen adı: Gülseren Buda Başkaya - Türü: Komedi
3- Dizi adı: Yalan Dünya - Yönetmen adı: Gülseren Buda Başkaya - Türü: Komedi
```
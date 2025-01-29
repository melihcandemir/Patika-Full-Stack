# Pratik - Patikafy Müzik Platformu
Oluşturulan liste üzerinden sorguları çevaplıyoruz
```C#
// Liste
List<Artist> artists = new List<Artist>
{
    new Artist { NameSurname = "Ajda Pekkan", Genre = "Pop", ReleaseYear = 1968, Sales = 20000000},
    new Artist { NameSurname = "Sezen Aksu", Genre = "Türk Halk Müzüği / Pop", ReleaseYear = 1971, Sales = 10000000},
    new Artist { NameSurname = "Funda Arar", Genre = "Pop", ReleaseYear = 1999, Sales = 3000000},
    new Artist { NameSurname = "Sertab Erener", Genre = "Pop", ReleaseYear = 1994, Sales = 5000000},
    new Artist { NameSurname = "Sıla", Genre = "Pop", ReleaseYear = 2009, Sales = 3000000},
    new Artist { NameSurname = "Serdar Ortaç", Genre = "Pop", ReleaseYear = 1994, Sales = 10000000},
    new Artist { NameSurname = "Tarkan", Genre = "Pop", ReleaseYear = 1992, Sales = 40000000},
    new Artist { NameSurname = "Hande Yener", Genre = "Pop", ReleaseYear = 1999, Sales = 7000000},
    new Artist { NameSurname = "Hadise", Genre = "Pop", ReleaseYear = 2005, Sales = 5000000},
    new Artist { NameSurname = "Gülben Ergen", Genre = "Türk Halk Müziği / Pop", ReleaseYear = 1997, Sales = 10000000},
    new Artist { NameSurname = "Neşet Ertaş", Genre = "Türk Halk Müziği / Türk Sanat Müziği", ReleaseYear = 1960, Sales = 2000000},
};
```

## 1- Adı 'S' ile başlayan şarkıcılar
```C#
// Adı 'S' ile başlayan şarkıcılar
var start_S = artists.Where(x => x?.NameSurname?.StartsWith("S") == true);

Console.WriteLine("Adı -S- ile başlayan şarkıcılar: ");
foreach (var s in start_S)
{
    Console.WriteLine($"Sanatçı: {s.NameSurname}");
}
```
### Output:
```bash
Adı -S- ile başlayan şarkıcılar: 
Şarkıcı: Sezen Aksu
Şarkıcı: Sertab Erener
Şarkıcı: Sıla
Şarkıcı: Serdar Ortaç
```

## 2- Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
```C#
// Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
var salesplus = artists.Where(x => x.Sales > 10000000);

Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar: ");
foreach (var s in salesplus)
{
    Console.WriteLine($"şarkıcılar: {s.NameSurname}");
}
```

### Output:
```bash
Albüm satışları 10 milyon'un üzerinde olan şarkıcılar: 
Şarkıcı: Ajda Pekkan
Şarkıcı: Tarkan
```

## 3- 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.)
```C#
var release_year_group = artists.Where(x => x.ReleaseYear < 2000 && x?.Genre?.Contains("Pop") == true).GroupBy(x => x.ReleaseYear).OrderBy(x => x.Key);

Console.WriteLine($"2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
foreach (var group in release_year_group)
{
    Console.WriteLine($"Çıkış yılı: {group.Key}");
    Console.WriteLine($"-------");
    foreach (var item in group)
    {
        var name_order = group.OrderBy(x => x.NameSurname);
        Console.WriteLine($"Şarkıcı: {item.NameSurname}");
        Console.WriteLine($"***");
    }
}
```
### Output:
```bash
2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:
Çıkış yılı: 1968
-------
Şarkıcı: Ajda Pekkan
***
Çıkış yılı: 1971
-------
Şarkıcı: Sezen Aksu
***
Çıkış yılı: 1992
-------
Şarkıcı: Tarkan
***
Çıkış yılı: 1994
-------
Şarkıcı: Sertab Erener
***
Şarkıcı: Serdar Ortaç
***
Çıkış yılı: 1997
-------
Şarkıcı: Gülben Ergen
***
Çıkış yılı: 1999
-------
Şarkıcı: Funda Arar
***
Şarkıcı: Hande Yener
***
```

## 4- En çok albüm satan şarkıcı
```C#
var maxSales = artists.Max(x => x.Sales); // il önce en yüksek sales belirlendi
var maxSalesArtist = artists.Where(x => x.Sales == maxSales).First(); // daha sonra bu salese karşılık gelen isim belirlerndi

Console.WriteLine($"En çok albüm satan şarkıcı: {maxSalesArtist.NameSurname}");
```
### Output:
```bash
En çok albüm satan şarkıcı: Tarkan
```

## 5- En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
```C#
// en yeni
var newReleaseYear = artists.Max(x => x.ReleaseYear);
var newArtist = artists.Where(x => x.ReleaseYear == newReleaseYear).First();
// en eski
var oldReleaseYear = artists.Min(x => x.ReleaseYear);
var oldArtist = artists.Where(x => x.ReleaseYear == oldReleaseYear).First();

Console.WriteLine($"En yeni çıkış yapan şarkıcı: {newArtist.NameSurname}\nEn eski çıkış yapan şarkıcı: {oldArtist.NameSurname}");



// ikinci şekilde yapımı
var oldArtist1 = artists.OrderBy(x => x.ReleaseYear).First();
var newArtist1 = artists.OrderBy(x => x.ReleaseYear).Last();

Console.WriteLine($"En yeni çıkış yapan şarkıcı: {newArtist1.NameSurname}\nEn eski çıkış yapan şarkıcı: {oldArtist1.NameSurname}");
```

### Output:
```bash
En yeni çıkış yapan şarkıcı: Sıla
En eski çıkış yapan şarkıcı: Neşet Ertaş
```
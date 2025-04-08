// veri ekliyoruz
//
// yazarlar
List<Yazar> yazarlar = new List<Yazar>
{
    new Yazar { AuthorId = 1, Name = "Melih" },
    new Yazar { AuthorId = 2, Name = "Halil" },
    new Yazar { AuthorId = 3, Name = "Ahmet" }
};
//
// kitaplar
List<Kitap> kitaplar = new List<Kitap>
{
    new Kitap { BookId = 1, Title = "C#", AuthorId = 1 },
    new Kitap { BookId = 2, Title = "Java", AuthorId = 1 },
    new Kitap { BookId = 3, Title = "Python", AuthorId = 2 },
    new Kitap { BookId = 4, Title = "C++", AuthorId = 3 }
};

// Kitapları ve yazarları birleştiren bir LINQ sorgusu
var birlesim = yazarlar.Join(kitaplar, y => y.AuthorId, k => k.AuthorId, (y, k) => new
{
    YazarAdi = y.Name,
    KitapBasligi = k.Title
});

// ekrana kitap ve yazar bilgilerini yazdırma
foreach (var item in birlesim)
{
    Console.WriteLine($"{item.YazarAdi} yazarının yazdığı {item.KitapBasligi}");
}
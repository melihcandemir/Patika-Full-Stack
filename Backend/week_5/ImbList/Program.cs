using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
Console.OutputEncoding = Encoding.GetEncoding(1254); // veya Encoding.GetEncoding(1254) veya Encoding.UTF8;
Console.InputEncoding = Encoding.GetEncoding(1254);
// buraya kadar olan kodlar kullanıcı herhangi bir değer girişinde türkçe karakter kaybolmasını önlüyor
// yapay zekadan yardım aldım


List<Movies> movie = new List<Movies>();

Console.ForegroundColor = ConsoleColor.Red; // renklendirme
Console.WriteLine("------------ ** Hoşgeldiniz ** ------------");


while (true)
{
    Movies cinema = new Movies();

    Console.ResetColor(); // renklendirme
    Console.Write("Eklemek istediğiniz film ismi : ");
    Console.ForegroundColor = ConsoleColor.Green; // renklendirme
    cinema.Name = Console.ReadLine()?.Trim(); // .Trim() ile eğer kullanıcı ismin başında veya sonunda boşluk bırakırsa siler.


tekrar: // kullanıcı yanlış değer girer ise geri döner
    try
    {

        Console.ResetColor(); // renklendirme
        Console.Write($"{cinema.Name} Imdb Puanını giriniz [ 0.0 - 10.0 ] : ");
        Console.ForegroundColor = ConsoleColor.Green; // renklendirme
        cinema.ImbPuan = Convert.ToDouble(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.Cyan; // renklendirme
        Console.WriteLine("!! Lütfen Puan Olarak Sayı Giriniz !!");
        goto tekrar;
    }

    movie.Add(cinema);

tekrar2: // yanlış cevap verilirse tekrar istenir
    Console.ResetColor(); // renklendirme
    Console.Write("Baska film kaydi yapmak istiyor musunuz ? [ e / h ] : ");
    Console.ForegroundColor = ConsoleColor.Green; // renklendirme
    string? cevap = Console.ReadLine()?.ToLower();

    if (cevap != "e" && cevap != "h")
    {
        Console.ForegroundColor = ConsoleColor.Cyan; // renklendirme
        Console.WriteLine("Tanimlanmayan bir giris yaptiniz. Lütfen [ e / h ] giriniz");
        goto tekrar2;
    }

    if (cevap == "h")
    {
        Console.ForegroundColor = ConsoleColor.Red; // renklendirme
        Console.WriteLine("---------------------------------------");
        Console.ResetColor(); // renklendirme
        break;
    }
    Console.ForegroundColor = ConsoleColor.Cyan; // renklendirme
    Console.WriteLine("---------------------------------------");
    Console.ResetColor(); // renklendirme
}


// Bütün filmler listelensin.
Console.ForegroundColor = ConsoleColor.Blue; // renklendirme
Console.WriteLine("------------ ** Filmler Listesi ** ------------");
Console.ResetColor();
foreach (var i in movie)
{
    Console.WriteLine(i.Name);
}

// Imdb puanı 4 ile 9 arasında olan bütün filmler listelensin.
Console.ForegroundColor = ConsoleColor.Blue; // renklendirme
Console.WriteLine("------------ ** Imdb puanı 4 ile 9 arasında olan filmler ** ------------");
Console.ResetColor();

foreach (var m in movie)
{
    if (m.ImbPuan > 4 && m.ImbPuan < 9)
    {
        Console.WriteLine($"{m.Name} filminin Imdb puanı : {m.ImbPuan}");
    }
}



// İsmi 'A' ile başlayan filmler ve imdb puanları listelensin.

Console.ForegroundColor = ConsoleColor.Blue; // renklendirme
Console.WriteLine("------------ ** Film adı -A- İle başlayanlar ** ------------");
Console.ResetColor();
foreach (var t in movie)
{
    if (t.Name?[0] == 'A' || t.Name?[0] == 'a')
    {
        Console.WriteLine($"{t.Name} filminin Imdb puanı : {t.ImbPuan}");
    }
}





Console.ForegroundColor = ConsoleColor.Red; // renklendirme
Console.WriteLine("---------------------------------------");
Console.ResetColor(); // renklendirme
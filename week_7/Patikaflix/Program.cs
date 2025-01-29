using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
Console.OutputEncoding = Encoding.GetEncoding(1254); // veya Encoding.GetEncoding(1254) veya Encoding.UTF8;
Console.InputEncoding = Encoding.GetEncoding(1254);
// buraya kadar olan kodlar kullanıcı herhangi bir değer girişinde türkçe karakter kaybolmasını önlüyor
// yapay zekadan yardım aldım



// patikaflix

List<Series> series = new List<Series>();
//
Console.WriteLine("************** Patikaflix'e Hoşgeldiniz **************");

int i = 1;
string? reply = "e";
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

Console.WriteLine("---- Dizi ekleme sonlandı ----");

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


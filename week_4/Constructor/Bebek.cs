public class Bebek
{
    // property
    public string Ad { get; set; }
    public string SoyAd { get; set; }
    public DateTime DoğumTarihi { get; set; }

    // constructor
    public Bebek()
    {
        // propertylere default değer atanıyor
        Ad = "Belli değil";
        SoyAd = "Belli değil";
        DoğumTarihi = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }

    public Bebek(string ad, string soyad)
    {
        // girilen değerler propertylere eşitleniyor
        Ad = ad;
        SoyAd = soyad;
        DoğumTarihi = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }
}
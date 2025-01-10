public class Person
{
    // Ad, Soyad, Doğum Tarihi.
    public string? Ad { get; set; }
    public string? SoyAd { get; set; }
    public string? Gorevi { get; set; } // görevi ile örenci veya öğretmen olmaını belirliyoruz
    public string? DoğumTarihi { get; set; }

    // konsola yazdırma metodu
    public void Yazdir()
    {
        Console.WriteLine($"{Ad} {SoyAd} isimli {Gorevi}. Doğum tarihi: {DoğumTarihi}");
    }
}
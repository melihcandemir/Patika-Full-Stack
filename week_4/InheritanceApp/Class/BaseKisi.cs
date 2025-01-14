public class BaseKisi
{
    // BaseKisi için propertyler -> Ad, Soyad
    public string? Ad { get; set; }
    public string? SoyAd { get; set; }

    // BaseKisi için metotlar -> Konsol ekranına ad ve soyad yazdıran bir metot.
    // bu metot da virtual kullanarak diğer class larda düzenleme yapabilmesini sağlıyorum
    public virtual void Yazdir()
    {
        Console.Write($"Benim adım {Ad} soyadım {SoyAd}. ");
    }
}
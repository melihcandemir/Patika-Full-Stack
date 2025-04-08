public class Ogretmen : BaseKisi
{
    // Ogretmen için ilave propertyler -> Maaş Bilgisi
    public decimal Maas { get; set; }

    // Ogretmen için ilave metotlar -> Konsol ekranına Maaş bilgisi, ad ve soyad yazdıran bir metot.
    public override void Yazdir()
    {
        base.Yazdir();
        // ek olarak maaş bilgisini giriyoruz.
        Console.WriteLine($"Maaşım {Maas}TL");
    }

}
public class DikUcgen : BaseGeometrikSekil
{
    public DikUcgen()
    {
        Console.WriteLine("Diküçgen oluşturuldu.");
    }

    // Dik Üçgen için (Genişlik x Yükseklik ) / 2 olarak alan hesaplanması.
    public override void AlanHesapla() // override ile motodu değiştiriyoruz
    {
        Console.WriteLine("Oluşturulan diküçgenin alanı: " + (Yukseklik * Genislik) / 2);
        Console.WriteLine("------------");
    }
}
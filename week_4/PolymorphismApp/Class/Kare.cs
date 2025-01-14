public class Kare : BaseGeometrikSekil
{
    public Kare()
    {
        Console.WriteLine("Kare oluşturuldu.");
    }

    // Kare ve Dikdortgen için Genişlik x Yükseklik şeklinde hesaplıyoruz.
    public override void AlanHesapla() // override ile motodu değiştiriyoruz
    {
        Console.WriteLine("Oluşturulan karenin alanı: " + Yukseklik * Genislik);
        Console.WriteLine("------------");
    }
}
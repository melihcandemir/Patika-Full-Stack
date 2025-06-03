public class Dikdortgen : BaseGeometrikSekil
{
    public Dikdortgen()
    {
        Console.WriteLine("Dikdörtgen oluşturuldu.");
    }

    // Kare ve Dikdortgen için Genişlik x Yükseklik şeklinde hesaplıyoruz.
    public override void AlanHesapla() // override ile motodu değiştiriyoruz
    {
        Console.WriteLine("Oluşturulan dikdörtgenin alanı: " + Yukseklik * Genislik);
        Console.WriteLine("------------");
    }
}
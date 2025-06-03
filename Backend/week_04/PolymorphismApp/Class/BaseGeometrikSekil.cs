public class BaseGeometrikSekil
{
    // BaseGeometrikSekil için Propertyler -> Genişlik ve Yükseklik
    public int Genislik { get; set; }
    public int Yukseklik { get; set; }

    // AlanHesapla() metodu tüm geometrik şekillerde bulanacağından Base Class içerisinde tanımlayabiliriz.
    public virtual void AlanHesapla() // virtual ile metot değiştirilebilir, ezilebilir
    {
        Console.WriteLine("Oluşturulan geometrik şeklin alanı : " + Genislik * Yukseklik);
    }
}
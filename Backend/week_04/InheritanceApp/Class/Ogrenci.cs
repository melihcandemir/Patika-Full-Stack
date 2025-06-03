public class Ogrenci : BaseKisi
{
    // Ogrenci için ilave propertyler -> Öğrenci Numarası
    public int OgrenciNo { get; set; }

    // Ogrenci için ilave metotlar -> Konsol ekranına öğrenci numarası, ad ve soyad yazdıran bir metot
    public override void Yazdir()
    {
        // Yazdir() methodunun hazır veren çıktısı
        base.Yazdir();

        // ek olarak öğrenci numarası ekliyorum
        Console.WriteLine($"Öğernci numaram {OgrenciNo}");
    }
}
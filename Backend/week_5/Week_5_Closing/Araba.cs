// Araba -> Üretim Tarihi, Seri Numarası, Marka, Model, Renk, Kapı Sayısı
class Araba
{
    public DateTime UretimTarihi;
    public int SeriNo;
    public string? Marka;
    public string? Model;
    public string? Renk;
    public int KapiSayisi;

    // 3- Üretim Tarihi değeri araba üretilirken otomatik olarak o an olarak atanacak.
    public Araba()
    {
        // üretim tarihi otamatik atandı
        UretimTarihi = DateTime.Now;
        // seri no belirlendi
        Random sr = new Random();
        SeriNo = sr.Next(1000, 10000);
    }


}
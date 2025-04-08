// Örnek birer öğretmen ve öğrenci nesneleri tanımlayarak bunlara değerler atayınız. Ardından değerleri konsol ekranına yazdırınız.
Ogrenci ogrenci_1 = new Ogrenci
{
    Ad = "Melih",
    SoyAd = "Can",
    OgrenciNo = 1423
};

Ogretmen ogretmen_1 = new Ogretmen
{
    Ad = "Serkan",
    SoyAd = "Bozkuş",
    Maas = 1000000
};


// konsola metot ile yazdırıyoruz
ogrenci_1.Yazdir();
ogretmen_1.Yazdir();
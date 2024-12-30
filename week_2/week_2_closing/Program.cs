// 1 - Aşağıdaki çıktıyı yazan bir program.
// Merhaba
// Nasılsın ?
// İyiyim
// Sen nasılsın ?

// \n kullanarak alt satıra geçiliyor
Console.WriteLine("Merhaba\nNasılsın?\nİyiyim\nSen nasılsın?");
Console.WriteLine("----------------------------------------------------------------------");

// 2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
// metinsel veri
string metin = "Melih Can DEMİR";
// tam sayı veri
int sayi = 3;
Console.WriteLine($"Metinsel veri: {metin}\nTam sayı veri: {sayi}");
Console.WriteLine("----------------------------------------------------------------------");

// 3 - Rastgele bir sayı üretip , ekrana yazdırınız.
Random x = new Random();
int rastgele_sayi = x.Next(); // .next() ile int sınırları içerisinde rastgele sayı üretir
Console.WriteLine($"Rastgele sayı: {rastgele_sayi}");
Console.WriteLine("----------------------------------------------------------------------");

// 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
Random y = new Random();
int rastgele_sayi2 = y.Next(); // .next() ile int sınırları içerisinde rastgele sayı üretir
int sonuc = rastgele_sayi2 % 3; // 3'e bölümünden kalan
Console.WriteLine($"{rastgele_sayi2} sayısının 3'e bölümünden kalan: {sonuc}");
Console.WriteLine("----------------------------------------------------------------------");

// 5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
Console.Write("Yaşınızı giriniz: "); // .write kullanarak altsatıra geçmeden yaşını alıyoruz.
string? giris = Console.ReadLine(); // null yani boş olabilir
int yas = string.IsNullOrWhiteSpace(giris) ? 0 : int.Parse(giris); // kullanıcı boş değer girer ise 0'a eşitlenir yapay zekadan yardım alındı

// 18'den büyüklük kontrolü yapıyoruz
if(yas > 18)
{
    Console.WriteLine($"{yas} yaşındasınız. 18'den büyük: +"); // 18'den büyük ise + işareti yazdırır
}
else if (yas < 18)
{
    Console.WriteLine($"{yas} yaşındasınız. 18'den küçük: -"); // 18'den küçük ise - işareti yazdırır
}
else
{
    Console.WriteLine($"{yas} yaşındasınız. 18'e eşit: ="); // 18'e eşit ise = işareti yazdırır
}
Console.WriteLine("----------------------------------------------------------------------");

// 6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
for (int i = 1; i < 11; i++) // 1 ve 11 seçmemin sebebi madde sayılarının 1 den 10'a kadar olamsı için
{
    Console.WriteLine($"{i}- Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}
Console.WriteLine("----------------------------------------------------------------------");

// 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
Console.Write("İlk metini girin: ");
string? metin1 = Console.ReadLine();

Console.Write("İkinci metini giriniz: ");
string? metin2 = Console.ReadLine();

// değiştirilmeden önce ekrana yazdırıyoruz
Console.WriteLine($"Değiştirilmeden önce girilen ilk metin: {metin1} ve ikinci metin: {metin2}");

// Yerlerini değiştiriyoruz
string? gecici = metin1;
metin1 = metin2;
metin2 = gecici;

// değiştirildikten sonra kontrol yapıyoruz
Console.WriteLine($"Değiştirildikten sonra ilk metin: {metin1} ve ikinci metin: {metin2}");
Console.WriteLine("----------------------------------------------------------------------");

// 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
// metot çağırıyoruz
BenDegerDondurmem();
Console.WriteLine("----------------------------------------------------------------------");

// 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
int Toplam()
{
    Console.Write("İlk sayıyı giriniz: ");
    string? giris1 = Console.ReadLine();
    int sayi_1 = string.IsNullOrWhiteSpace(giris1) ? 0 : int.Parse(giris1); // kullanıcı boş değer girer ise 0'a eşitlenir

    Console.Write("İlk sayıyı giriniz: ");
    string? giris2 = Console.ReadLine();
    int sayi_2 = string.IsNullOrWhiteSpace(giris2) ? 0 : int.Parse(giris2); // kullanıcı boş değer girer ise 0'a eşitlenir

    int toplam = sayi_1 + sayi_2;
    return toplam;
}

// metot çağırıyoruz
int j = Toplam();
Console.WriteLine($"Girdiğiniz sayıların toplamı: {j}");
Console.WriteLine("----------------------------------------------------------------------");

// 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
string Sonuc()
{
    Console.Write("True ya da False değerini giriniz: ");
    string? giris = Console.ReadLine()?.ToLower();
    // kullanıcının gidiği değerin true ya da false olduğunu kontrol ediyoruz.
    bool deger = giris == "true" || giris == "false";
    // kullanıcının girdiği değeri string olarak geri döndürüyoruz
    if (deger)
        return $"Değer olarak {giris} girdiniz.";
    else
        return $"Değer olarak yanlış girdiniz: {giris}";
}
// metot çağırıyoruz metodu ekrana yazdırabilmek için değişkene atıyoruz
string m = Sonuc();
Console.WriteLine(m);
Console.WriteLine("----------------------------------------------------------------------");

// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
int Yas()
{
    Console.Write("Birinci yaşı giriniz: ");
    int yas_1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("İkinci yaşı giriniz: ");
    int yas_2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Üçüncü yaşı giriniz: ");
    int yas_3 = Convert.ToInt32(Console.ReadLine());

    if (yas_1 > yas_2 && yas_1 > yas_3)
        return yas_1;
    else if (yas_2 > yas_1 && yas_2 > yas_3)
        return yas_2;
    else
        return yas_3;

}

int q = Yas(); // metodu değişkene atıyoruz
Console.WriteLine($"Girilen en büyük yaş: {q}");
Console.WriteLine("----------------------------------------------------------------------");

// 12 - Kullanıcıdan sınırsız sayıda sayı alıp, bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
int EnBuyuk()
{
    int[] sayilar = new int[0]; // alınan bütün değerler bu diziye kaydedilir
    while (true) // kullnıcıdan sonsuz değer alan döngü
    {
        Console.Write("Eklemek istediğiniz sayıyı giriniz: ");
        int sayi_x = Convert.ToInt32(Console.ReadLine());

        Array.Resize(ref sayilar, sayilar.Length + 1);
        sayilar[sayilar.Length - 1] = sayi_x;

        // kullanıcıdan değer alımını devam ettiriyoruz
        Console.Write("Sayı ekelemek için (E) / Sonlandırmak için herhangi bir karakter giriniz: ");
        char u = Convert.ToChar(Console.ReadLine()?.ToLower() ?? " ");

        if (u != 'e') // değer alımını sonlandırır
            break;
    }

    Array.Sort(sayilar); // diziyi küçükten büyüğe sıraladık
    Array.Reverse(sayilar); // diziyi ters çevirdik

    // en büyük girilen sayıyı konsola yazdırıyoruz
    Console.WriteLine($"Girdiğiniz en büyük sayı: {sayilar[0]}");
    return sayilar[0];
}

// metot çağrılıyor
int u = EnBuyuk();
Console.WriteLine($"Metotdan geriye dönen değer {u}");
Console.WriteLine("----------------------------------------------------------------------");

// 13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
void Degistir()
{
    Console.Write("İlk ismi giriniz: ");
    string? isim1 = Console.ReadLine();

    Console.Write("İkinci ismi giriniz: ");
    string? isim2 = Console.ReadLine();
    Console.WriteLine("--------------");

    Console.WriteLine($"İlk girilen isim: {isim1}\nİkinci girilen isim: {isim2}");
    Console.WriteLine("--------------");

    Console.WriteLine("Değerler değiştirildi");

    // girilen değerleri değiştiriyoruz
    string? degisken = isim1;
    isim1 = isim2;
    isim2 = degisken;
    // değişimden sonra
    Console.WriteLine($"isim1 = {isim1}");
    Console.WriteLine($"isim2 = {isim2}");

}

Degistir();

// 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
bool CiftMi()
{
    Console.Write("Tek mi çift mi öğrenmek için sayı giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());

    int sonuc = sayi % 2; // kalan hesaplanıyor

    if (sonuc == 0)
        return true; // çift ise true
    else
        return false; // tek ise false
}

bool e = CiftMi();
if (e)
    Console.WriteLine($"Girdiginiz değer çift --> {e} ");
else
    Console.WriteLine($"Girdiginiz değer tek  --> {e} ");

// 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
void Hiz()
{
    Console.Write("Kaç saniye yol gittiniz: ");
    int sn = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ortalam kaç m/s hızla gittiniz: ");
    int ms = Convert.ToInt32(Console.ReadLine());

    int hiz = ms * sn; // kam metre yol gitiğini hesaplıyoruz.

    Console.WriteLine($"Ortalama {ms}m/s hızla {sn} yol gittiğiniz için\nOrtalam gittiğiniz yol: {hiz}metre");

}

Hiz();

// 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
void Alan()
{
    // A = π * r² dairenin alanı
    // alt + 0178 2 üs yazmak için
    // cm² cinsinden hesaplanıyor

    double alan;
    double r;
    double pi = 3.14; // π sayısını 3,14 olarak kabul ediyoruz

    Console.Write("Alanının hesaplamak istediğiniz dairenin yarıçap cm bilgisi: ");
    r = Convert.ToDouble(Console.ReadLine());

    alan = pi * (r * r); // alan hesaplama formülü

    // sonucu yazdırıyoruz
    Console.WriteLine($"Yarıçapı {r}cm girilen dairenin alanı: {alan}cm²");

}

Alan();

// 17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
string cmm = "Zaman bir GeRi SayIm";
// büyük harf yazdır
Console.WriteLine(cmm.ToUpper());
// küçük harf yazdır
Console.WriteLine(cmm.ToLower());

// 18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
void Kalici(ref string x)
{
    x = x.Trim(); // trim ile boşluklar silinir
}

string bos = "    Selamlar   ";
Console.WriteLine(bos); // silinmeden once

Kalici(ref bos);
Console.WriteLine(bos); // silindikten sonra
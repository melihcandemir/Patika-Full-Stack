// Geriye Değer Döndürmeyen Bir void metot. 
static void Sarkisozu()
{
    Console.WriteLine("Unutulur gidersin..");
}
// metot çağırıyoruz
Sarkisozu();
Console.WriteLine("---------------------------------");


// Geriye Tamsayı Döndüren Bir metot
static void Rastgele()
{
    // Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
    Random rd = new Random();
    int sayi = rd.Next(500); // maximum 500 olan random bir sayı oluşturuldu.
    int kalan = sayi % 2; // sayının modunu alıyoruz
    Console.WriteLine($"Rastgele oluşturulan {sayi} sayısının 2'ye bölümünden kalan: {kalan}");
}
// metot çağırıyoruz
Rastgele();
Console.WriteLine("---------------------------------");


// Parametre Alan ve Geriye Değer Döndüren Bir Metot
int Carpım(int a, int b)
{
    // Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
    int sonuc = a * b;
    return sonuc;
}
// Carpım(); metoduna parametre gönderiyoruz
Console.WriteLine("Çarpma işelemine başlıyoruz..");
Console.Write("İlk sayıyı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("İkinci sayıyı giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine()); 
// metotu çağırıyoruz
int cevap = Carpım(sayi1, sayi2); // ancak ekrana yazdırmak için console.writeline içerisine koymamız gerekiyor
// metotu cevap değişkenine atayarak ekrana yazdırıyoruz
Console.WriteLine($"{sayi1} ve {sayi2} çarpımının sonucu: {cevap}");
Console.WriteLine("---------------------------------");


// Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
static void HosGeldiniz(string isim, string soyisim)
{
    // Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
    Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
}
// HosGeldiniz(); metotuna parametreleri gönderiyoruz
Console.WriteLine("Mesajı alabilmek için isim ve soyisim giriniz..");
Console.Write("İsim: ");
string isim = Console.ReadLine() ?? " ";
Console.Write("Soyisim: ");
string soyisim = Console.ReadLine() ?? " ";
// metot çağırıyoruz
HosGeldiniz(isim, soyisim);
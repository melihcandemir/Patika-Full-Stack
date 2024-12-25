# Pratik - İlk Metot Uygulamamız
Yapmış olduğum metotlarda kullanıcı boş değer girer ise hata oluşur. İlerleyen derslerde bunu düzelterek devam edeceğim.

## Geriye Değer Döndürmeyen Bir void metot:
Ekrana sevdiğiniz bir şarkı sözünü yazdırsın.
```C#
static void Sarkisozu()
{
    Console.WriteLine("Unutulur gidersin..");
}
// metot çağırıyoruz
Sarkisozu();
```

## Geriye Tamsayı Döndüren Bir metot:
Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün. 
```C#
static void Rastgele()
{.
    Random rd = new Random();
    int sayi = rd.Next(500); // maximum 500 olan random bir sayı oluşturuldu.
    int kalan = sayi % 2; // sayının modunu alıyoruz
    Console.WriteLine($"Rastgele oluşturulan {sayi} sayısının 2'ye bölümünden kalan: {kalan}");
}
// metot çağırıyoruz
Rastgele();
```

## Parametre Alan ve Geriye Değer Döndüren Bir Metot:
Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
```C#
int Carpım(int a, int b)
{
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
```

## Parametre Alan ve Geriye Değer Döndürmeyen bir Metot:
Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
```C#
static void HosGeldiniz(string isim, string soyisim)
{
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
```
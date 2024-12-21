
// kullanıcıdan sayı alıyoruz
Console.Write("Sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

// sayının 10 ile olan durumunu belirliyoruz
if (sayi > 10) 
{
    // tek veya çift olmasını kontrol ediyoruz
    if (sayi % 2 == 0)
    {
        Console.WriteLine($"{sayi} sayısı 10'dan büyük ve çift sayıdır");
    }
    else
    {
        Console.WriteLine($"{sayi} sayısı 10'dan büyük ve tek sayıdır");
    }
}
else if (sayi < 10)
{
    // tek veya çift olmasını kontrol ediyoruz
    if (sayi % 2 == 0)
    {
        Console.WriteLine($"{sayi} sayısı 10'dan küçük ve çift sayıdır");
    }
    else
    {
        Console.WriteLine($"{sayi} sayısı 10'dan küçük ve tek sayıdır");
    }
}
else // bu koşullar olmaması durumda sayı 10 ve çift sayıdır
{
    Console.WriteLine("Sayı 10'a eşit ve çift sayıdır");
}
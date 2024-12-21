
// bilgilendirme
Console.WriteLine("Kim Milyoner Olmak İster yarışmasına hoşgeldiniz..");
Console.WriteLine("- Yarışma 3 sorudan oluşmaktadır.\n- Sorularda 2 cevap şıkkı bulunmaktadır\n- 2 soruyu doğru bilen milyoner olacak..");

// doğru cevap sayısını tutmak için oluşturulan değer
byte cevap = 0;

Console.WriteLine("--------------------------------------------------------");
// 1. soru ve cavap alımı
string soru1;
Console.WriteLine("1-> Kızınca tüküren hayvan hangisidir ?");
Console.Write("A: Lama\nB: Deve\nCevabınız: ");
soru1 = Console.ReadLine()?.ToLower() ?? string.Empty; // boş cevap girildiğinde null değer yerine boş string atanır
if (soru1 == "lama" || soru1 == "a")
{
    Console.WriteLine($"{soru1.ToUpper()} cevabını vererek doğru bildiniz..");
    cevap += 1; // doğru cevap sayısını 1 arttırmak için kullanılıyor
}
else 
{
    Console.WriteLine($"{soru1.ToUpper()} cevabını vererek yanlış bildiniz. Doğru cevap A: Lama");
}

Console.WriteLine("--------------------------------------------------------");
// 2. soru ve cavap alımı
string soru2;
Console.WriteLine("2-> Dünya'ya en yakın gezegen hangisidir ?");
Console.Write("A: Venüs\nB: Mars\nCevabınız: ");
soru2 = Console.ReadLine()?.ToLower() ?? string.Empty; // boş cevap girildiğinde null değer yerine boş string atanır
if (soru2 == "venüs" || soru2 == "a")
{
    Console.WriteLine($"{soru2.ToUpper()} cevabını vererek doğru bildiniz..");
    cevap += 1; // doğru cevap sayısını 1 arttırmak için kullanılıyor
}
else 
{
    Console.WriteLine($"{soru2.ToUpper()} cevabını vererek yanlış bildiniz. Doğru cevap A: Venüs");
}

Console.WriteLine("--------------------------------------------------------");
// 3. soru ve cavap alımı
string soru3;
Console.WriteLine("3-> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
Console.Write("A: 7\nB: 12\nCevabınız: ");
soru3 = Console.ReadLine()?.ToLower() ?? string.Empty; // boş cevap girildiğinde null değer yerine boş string atanır
if (soru3 == "12" || soru3 == "b")
{
    Console.WriteLine($"{soru3.ToUpper()} cevabını vererek doğru bildiniz..");
    cevap += 1; // doğru cevap sayısını 1 arttırmak için kullanılıyor
}
else 
{
    Console.WriteLine($"{soru3.ToUpper()} cevabını vererek yanlış bildiniz. Doğru cevap B: 12");
}

Console.WriteLine("--------------------------------------------------------");
// yarışma sonucu verecek bir sorgu
if (cevap >=2)
{
    Console.WriteLine($"3 sorudan {cevap} doğru cevap vererek milyoner oldunuz..");
}
else
{
    Console.WriteLine($"3 sorudan {cevap} doğru cevap vererek.\nYarışmayı Kaybettiniz..");
}


// 1-> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
for(byte i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i}- Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

// 2-> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
for(byte i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}


// 3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
for(byte i = 1; i <= 20; i++)
{
    int x = i % 2; // mod alarak çift sayıları buluyoruz

    if(x == 0)
        Console.WriteLine(i);
}

// 4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int toplam = 0;
for(int i = 50; i <= 150; i++)
{
    toplam = toplam + i; // toplam += i
}
Console.WriteLine(toplam);

// 5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int toplam_1 = 0; 
int toplam_2 = 0;

for (int i = 1; i <= 120; i++)
{
    int x = i % 2; // mod alarak tek veya çift olduğunu buluyoruz
    if (x == 0)
    {
        toplam_1 += i; // sayı çift ise toplam_1 içerisine topluyoruz
    }
    else
    {
        toplam_2 += i; // sayı tek ise toplam_2 içerisine topluyoruz
    }
}

Console.WriteLine($"1 ile 120 arasındaki tek sayıların tolamı: {toplam_2}");
Console.WriteLine($"1 ile 120 arasındaki çift sayıların tolamı: {toplam_1}");

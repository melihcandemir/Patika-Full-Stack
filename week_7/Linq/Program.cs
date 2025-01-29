// Rastgele 10 adet sayıdan oluşan bir liste
List<int> numbers_list = new List<int>() { 10, -11, 66, 2, -9, 100, 80, 3, -40, -3 };

// Çift olan sayıları ekrana yazdır
// Çift olan sayılar
var even_number = numbers_list.Where(num => num % 2 == 0);

Console.WriteLine($"Çift sayılar: ");
int e = 1;
foreach (var x in even_number)
{
    Console.WriteLine($"{e}. sayı --> {x}");
    e++;
}

// Tek olan sayıları ekrana yazdır
// Tek olan sayılar
var odd_number = numbers_list.Where(num => num % 2 != 0);

Console.WriteLine($"Tek sayılar: ");
int o = 1;
foreach (var x in odd_number)
{
    Console.WriteLine($"{o}. sayı --> {x}");
    o++;
}

// Negatif olan sayıları ekrana yazdır
// Negatif sayılar
var negative = numbers_list.Where(num => num < 0);

Console.WriteLine($"Negatif sayılar: ");
int n = 1;
foreach (var x in negative)
{
    Console.WriteLine($"{n}. sayı --> {x}");
    n++;
}

// Pozitif sayıları ekrana yazdır
// Pozitif Sayılar
var positive = numbers_list.Where(num => num > 0);

Console.WriteLine($"Pozitif sayılar: ");
int p = 1;
foreach (var x in positive)
{
    Console.WriteLine($"{p}. sayı --> {x}");
    p++;
}

// 15'ten büyük ve 22'den küçük sayıları ekrana yazdır
// Oluşturduğum listede 15 ve 22 arasında sayı olmadığı için 1 ve 15 arasındaki sayıları alıyorum
// 1'den büyük ve 15'den küçük sayılar
var range_numbers = numbers_list.Where(num => 1 < num && num < 15);

Console.WriteLine($"1'den büyük ve 15'den küçük sayılar: ");
int r = 1;
foreach (var x in range_numbers)
{
    Console.WriteLine($"{r}. sayı --> {x}");
    r++;
}

// Listedeki her bir sayının karesini ekrana yazdır
// Listedeki her bir sayının karesi
var squared = numbers_list.Select(num => num * num).ToList();

Console.WriteLine($"Listedeki her bir sayının karesi: ");
int s = 1;
foreach (var x in squared)
{
    Console.WriteLine($"{s}. sayı --> {x}");
    s++;
}
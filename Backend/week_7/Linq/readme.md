# Pratik - Linq
Rastgele 10 adet sayıdan oluşan bir liste oluşturuyoruz. Bu liste üzerinden aşağıdaki linq sorgularını çalıştırarak konsol ekranına istenilenleri yazdırıyoruz.

```C#
// Rastgele 10 adet sayıdan oluşan bir liste
// Random ile de oluşturulabilir ancak outputlar birbiri ile ilişkili olsun diye sabit değerler girdim
List<int> numbers_list = new List<int>() { 10, -11, 66, 2, -9, 100, 80, 3, -40, -3 };
```

## 1- Çift olan sayıları ekrana yazdır
```C#
// Çift olan sayılar
var even_number = numnumbers_listbers.Where(num => num % 2 == 0);

Console.WriteLine($"Çift sayılar: ");
int i = 1;
foreach (var x in even_number)
{
    Console.WriteLine($"{i}. sayı --> {x}");
    i++;
}
```
### Output:
```bash
Çift sayılar: 
1. sayı --> 10
2. sayı --> 66
3. sayı --> 2
4. sayı --> 100
5. sayı --> 80
6. sayı --> -40
```


## 2- Tek olan sayıları ekrana yazdır
```C#
// Tek olan sayılar
var odd_number = numbers_list.Where(num => num % 2 != 0);

Console.WriteLine($"Çift sayılar: ");
int o = 1;
foreach (var x in odd_number)
{
    Console.WriteLine($"{o}. sayı --> {x}");
    o++;
}
```
### Output:
```bash
Tek sayılar: 
1. sayı --> -11
2. sayı --> -9
3. sayı --> 3
4. sayı --> -3
```


## 3- Negatif olan sayıları ekrana yazdır
```C#
// Negatif sayılar
var negative = numbers_list.Where(num => num < 0);

Console.WriteLine($"Negatif sayılar: ");
int n = 1;
foreach (var x in negative)
{
    Console.WriteLine($"{n}. sayı --> {x}");
    n++;
}
```
### Output:
```bash
Negatif sayılar: 
1. sayı --> -11
2. sayı --> -9
3. sayı --> -40
4. sayı --> -3
```

## 4- Pozitif sayıları ekrana yazdır
```C#
// Pozitif Sayılar
var positive = numbers_list.Where(num => num > 0);

Console.WriteLine($"Pozitif sayılar: ");
int p = 1;
foreach (var x in positive)
{
    Console.WriteLine($"{p}. sayı --> {x}");
    p++;
}
```
### Output:
```bash
Pozitif sayılar: 
1. sayı --> 10
2. sayı --> 66
3. sayı --> 2
4. sayı --> 100
5. sayı --> 80
6. sayı --> 3
```

## 5- 15'ten büyük ve 22'den küçük sayıları ekrana yazdır
Oluşturduğum listede 15 ve 22 arasında sayı olmadığı için 1 ve 15 arasındaki sayıları alıyorum.
```C#
// 1'den büyük ve 15'den küçük sayılar
var range_numbers = numbers_list.Where(num => 1 < num && num < 15);

Console.WriteLine($"1'den büyük ve 15'den küçük sayılar: ");
int r = 1;
foreach (var x in range_numbers)
{
    Console.WriteLine($"{r}. sayı --> {x}");
    r++;
}
```
### Output:
```bash
1'den büyük ve 15'den küçük sayılar: 
1. sayı --> 10
2. sayı --> 2
3. sayı --> 3
```

## 6- Listedeki her bir sayının karesini ekrana yazdır
```C#
// Listedeki her bir sayının karesi
var squared = numbers_list.Select(num => num * num).ToList();

Console.WriteLine($"Listedeki her bir sayının karesi: ");
int s = 1;
foreach (var x in squared)
{
    Console.WriteLine($"{s}. sayı --> {x}");
    s++;
}
```
### Output:
```bash
Listedeki her bir sayının karesi: 
1. sayı --> 100
2. sayı --> 121
3. sayı --> 4356
4. sayı --> 4
5. sayı --> 81
6. sayı --> 10000
7. sayı --> 6400
8. sayı --> 9
9. sayı --> 1600
10. sayı --> 9
```
# Pratik - Array
Bu pratikte aşağıdaki 4 aşamayı kodlamamız isteniyor.

## 1- 10 adet tam sayı verisi alacak bir dizi tanımlıyoruz.
```C#
int[] numbers = new int[10];
```

## 2- Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazdırıyoruz.
```C#
// tam sayıları girme
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"number[{i}] int değerini giriniz: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

// ekrana yazdırma
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

## 3- Bu diziye kullanıcıdan alınan yeni bir değeri ekliyoruz. (11. eleman olarak)
```C#
// kullanıcıdan yeni bir değer alma
Console.Write("Diziye yeni bir değer ekleyiniz: ");
int newNumber = Convert.ToInt32(Console.ReadLine());

int[] newNumbers = new int[numbers.Length + 1];
// numbers dizisini newNumbers dizisinin içerisine kaydediyor. yapay zekadan yardım aldım
Array.Copy(numbers, newNumbers, numbers.Length); 
newNumbers[newNumbers.Length - 1] = newNumber; // değer eklendi
```
## 4- Bu diziyi büyükten küçüğe ekrana yazdırınız.
```C#
// Diziyi alfabetik veya sayısal olarak küçükten büyüğe sıralar. yapay zekadan yardım aldım
Array.Sort(newNumbers);
// sıralamayı tam tersi çevirir
Array.Reverse(newNumbers);

foreach (int item in newNumbers)
{
    Console.WriteLine(item);
}
```

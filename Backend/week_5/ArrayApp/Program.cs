

int[] numbers = new int[10];
// tam sayıları girme
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"number[{i}] int değerini giriniz: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("----------------------------------------------");
// ekrana yazdırma
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("----------------------------------------------");
// kullanıcıdan yeni bir değer alma
Console.Write("Diziye yeni bir değer ekleyiniz: ");
int newNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("----------------------------------------------");

int[] newNumbers = new int[numbers.Length + 1];
// numbers dizisini newNumbers dizisinin içerisine kaydediyor. yapay zekadan yardım aldım
Array.Copy(numbers, newNumbers, numbers.Length);
newNumbers[newNumbers.Length - 1] = newNumber; // değer eklendi

// Diziyi alfabetik veya sayısal olarak küçükten büyüğe sıralar. yapay zekadan yardım aldım
Array.Sort(newNumbers);
// sıralamayı tam tersi çevirir
Array.Reverse(newNumbers);

foreach (int item in newNumbers)
{
    Console.WriteLine(item);
}
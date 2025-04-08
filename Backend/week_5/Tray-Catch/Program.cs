// bunu doğru yapana kadar tekrarlıyacağız
bool devammi = true;
while (devammi)
{
    // tray-catch
    try
    {

        Console.Write("Lütfen karesini almak isteiğiniz sayı giriniz: ");
        Console.ForegroundColor = ConsoleColor.Green; // renklendirme
        int sayi = Convert.ToInt32(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Blue; // renklendirme
        Console.WriteLine($"Girilen sayının karesi: {sayi * sayi}");
        // kod hatasız devam ederse sonlanır
        devammi = false;
        Console.ResetColor(); // renklendirme

    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.Red; // renklendirme
        Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        Console.ResetColor(); // renklendirme
    }
}
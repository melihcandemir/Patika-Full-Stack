// davetliler listesi
List<string> guests = new List<string>()
{
"Bülent Ersoy",
"Ajda Pekkan",
"Ebru Gündeş",
"Hadise",
"Hande Yener",
"Tarkan",
"Funda Arar",
"Demet Akalın"
};

Console.ForegroundColor = ConsoleColor.Green; // renklendirme
Console.WriteLine("----------------- ** GUESTS ** -----------------");
// ekrana yazdırma
for (int i = 0; i < guests.Count(); i++)
{
    Console.ForegroundColor = ConsoleColor.Red; // liste sayıları kırmızı renk yazılacak
    Console.Write($"{i + 1}");
    Console.ResetColor(); // isimler normal renkde devam edecek
    Console.WriteLine($" - {guests[i]}");
}
Console.ForegroundColor = ConsoleColor.Green; // renklendirme
Console.WriteLine("------------------------------------------------");
Console.ResetColor(); // renklendirme
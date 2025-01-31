// yazarlar ve kitaplar classları oluştur
internal class Yazar
{
    public int AuthorId { get; set; }
    public string? Name { get; set; }
}

internal class Kitap
{
    public int BookId { get; set; }
    public string? Title { get; set; }
    public int AuthorId { get; set; } // Yazarı belirtmek için kullanılır.
}
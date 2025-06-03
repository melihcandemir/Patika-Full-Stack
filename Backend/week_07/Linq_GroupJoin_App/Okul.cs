// Student ve Class classları oluşturuyoruz
// öğrenci
internal class Student
{
    public int StudentId { get; set; }
    public string? StudentName { get; set; }
    public int ClassId { get; set; } // öğrencinin ait olduğu sınıf kimliği
}

// sınıf
internal class Class
{
    public int ClassId { get; set; }
    public string? ClassName { get; set; }
}
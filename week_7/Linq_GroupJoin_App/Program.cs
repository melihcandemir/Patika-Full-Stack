// veri girişi
//
// öğrenciler
List<Student> students = new List<Student>
{
    new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
    new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
    new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
    new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 },
    new Student { StudentId = 4, StudentName = "Ahmet", ClassId = 2 }
};

// sınıflar
List<Class> classes = new List<Class>
{
    new Class { ClassId = 1, ClassName = "Matematik" },
    new Class  { ClassId = 2, ClassName = "Türkçe" },
    new Class  { ClassId = 3, ClassName = "Kimya"}
};

// ekrana sınıfları gruplayarak öğreciler ile beraber yazdırma

var birlesim = classes.GroupJoin(students, c => c.ClassId, s => s.ClassId, (c, sIds) => new
{
    Classes = c,
    Student = sIds.ToList()
});

// sınıfları ve öğrecileri ekrana yazdırma
foreach (var item in birlesim)
{
    Console.WriteLine($"{item.Classes.ClassName} sınıfı öğrencileri:");
    foreach (var it in item.Student)
    {
        Console.WriteLine($"- {it.StudentName}");
    }
    Console.WriteLine($"-----------------------------");
}


# Okul Bilgisi Sistemi

Bu proje, öğrenciler ve sınıfları temsil eden `Student` ve `Class` sınıflarını içeren bir C# uygulamasıdır. Bu sınıflar kullanılarak öğrencilerin hangi sınıfta olduğunu göstermek amacıyla LINQ (Language Integrated Query) ile birleştirilmiş bir çıktı oluşturulmuştur.

## Proje Yapı

1. **Okul.cs**: 
    - `Student` ve `Class` sınıflarını tanımlayan dosya.
2. **Program.cs**:
    - Öğrenciler ve sınıfları içeren listeler oluşturur.
    - LINQ ile sınıfları ve öğrencileri birleştirir ve sonuçları ekrana yazdırır.

## Sınıflar

### Student
- `StudentId`: Öğrencinin benzersiz kimliği.
- `StudentName`: Öğrencinin adı.
- `ClassId`: Öğrencinin ait olduğu sınıfın kimliği.

### Class
- `ClassId`: Sınıfın benzersiz kimliği.
- `ClassName`: Sınıfın adı.

## LINQ İşlemi

Proje, öğrenciler ve sınıfları birleştirmek için LINQ'un `GroupJoin` metodu kullanılmıştır. Bu metot, her sınıfın kendine ait öğrencilerini gruplandırır ve sonuçları yeni bir nesne içinde temsil eder.

```csharp
var birlesim = classes.GroupJoin(students, c => c.ClassId, s => s.ClassId, (c, sIds) => new
{
    Classes = c,
    Student = sIds.ToList()
});
```

Bu kod parçası, her sınıfın kendine ait öğrencilerini içeren bir liste oluşturur ve bu listeyi `Classes` adlı bir nesne içinde saklar.

## Sonuç

Sonuç olarak, program çalıştırıldığında ekrana aşağıdaki gibi bir çıktı verir:

```bash
Matematik sınıfı öğrencileri:
- Ali
- Mehmet
-----------------------------
Türkçe sınıfı öğrencileri:
- Ayşe
- Ahmet
-----------------------------
Kimya sınıfı öğrencileri:
- Fatma
-----------------------------
```

Bu proje, LINQ ile karmaşık verileri kolayca gruplayıp birleştirme yeteneğini göstermektedir.
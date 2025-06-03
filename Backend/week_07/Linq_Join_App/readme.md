# LINQ Join Örneği ve Veri İşleme

Bu proje, LINQ (Language Integrated Query) kullanarak yazarlar ve kitapları birleştirme işlemi göstermektedir. Projenin yapısı ve işlevleri aşağıda açıklanmıştır.

## Proje Yapıları

### Kutuphane.cs
Bu dosya, `Yazar` ve `Kitap` sınıflarını tanımlar. Her iki sınıf da aşağıdaki özelliklere sahiptir:

- `AuthorId` (yazarın kimliği)
- `Name` (yazarın adı)
- `BookId` (kitabın kimliği)
- `Title` (kitabın başlığı)

### Program.cs
Bu dosya, LINQ sorgularını kullanarak yazarlar ve kitapları birleştirir ve ekrana yazdırır. İşte ana işlemleri adım adım açıklamaları:

1. **Veri Ekleme**:
   - `yazarlar` listesi, üç yazarın bilgilerini içerir.
   - `kitaplar` listesi, dört kitabın bilgilerini ve her birinin yazarının kimliğini içerir.

2. **LINQ Sorgusu**:
   - `Join` metodu kullanılarak `yazarlar` ve `kitaplar` listeleri birleştirilir.
   - `y => y.AuthorId` ve `k => k.AuthorId` ifadeleri, her iki listeyi birleştirmek için kullanılan anahtar (author ID) değerlerini belirtir.
   - `(y, k) => new { YazarAdi = y.Name, KitapBasligi = k.Title }` ifadesi, yeni bir anonim nesne oluşturur ve her kitabın yazarının adını ve kitabın başlığını içeren bilgileri içerir.

3. **Sonuç Yazdırma**:
   - `foreach` döngüsü kullanılarak, birleştirilmiş sonuçların her elemanı ekrana yazdırılır.

## Kullanım
Bu projeyi çalıştırmak için aşağıdaki adımları takip edin:

1. Visual Studio veya başka bir IDE'de projeyi açın.
2. `Program.cs` dosyasını açın ve yukarıdaki kodu inceleyin.
3. Projenizi derleyin ve çalıştırın.

Çalıştırıldığında, ekranda her yazarın yazdığı kitap başlıkları görüntülenir.
```bash
Melih yazarının yazdığı C#
Melih yazarının yazdığı Java
Halil yazarının yazdığı Python
Ahmet yazarının yazdığı C++
```

## Sonuç
Bu projede LINQ kullanarak veri birleştirme işlemi gösterilmiştir. Bu, büyük ölçekli verilerle çalışırken veriyi daha etkili bir şekilde yönetmenin yanı sıra, kodun okunabilirliğini ve bakımını kolaylaştıracaktır.
# Encapsulation CarsApp
Bu örnekte bizlerden bir Araba sınıfı oluşturmamız isteniyor.
- Araba sınıfının özellikleri -> Marka, Model, Renk, Kapı Sayısı
- Özelliklerimizden (Property) Kapı sayısı için kapsülleme işlemi yapmak istiyoruz.
    - Eğer bir Araba nesnesi oluşturulduğunda Kapı Sayısı için 2 veya 4 dışında bir değer atanmak isterse konsol ekranında bir uyarı mesajı yayınlayalım ve Kapı Sayısı değerini -1 olarak atayalım.

## Cars() :
```C#
public class Cars
{
    // propertyler
    private string? _marka;
    private string? _model;
    private string? _renk;
    private int _kapi_sayisi;

    public string? Marka { get { return _marka; } set { _marka = value; } } // değerleri class içerisine alıyoruz
    public string? Model { get { return _model; } set { _model = value; } }
    public string? Renk { get { return _renk; } set { _renk = value; } }

    // kapı sayısı eğer 2 veya 4 değil ise yanlış olduğunu belirtiyoruz ve -1 atdıyoruz.
    public int KapiSayiyi
    {
        get { return _kapi_sayisi; }
        set
        {
            if (value == 2 || value == 4)
            {
                _kapi_sayisi = value;
            }
            else
            {
                Console.WriteLine("Kapı sayısını lütfen 2 veya 4 giriniz.");
                _kapi_sayisi = -1;
            }
        }
    }

    // araç özelliklerini ekrana yazdırma metodu.
    public void Yazdir()
    {
        if (_kapi_sayisi == 2 || _kapi_sayisi == 4)
            Console.WriteLine($"{_marka} - {_model} aracın rengi {_renk}, kapı sayısı {_kapi_sayisi}");
        else
            Console.WriteLine($"Aracın kapı sayısını yanlış girdiniz. Hata: {_kapi_sayisi}");
    }

}
```

## Cars() sınıfına kapı sayısı değeri eğer 2 veya 4 gönderilmez ise hata döner:
```C#
Cars aracim = new Cars // yeni bir cars sınıfı oluşturuyoruz
{
    Renk = "mavi",
    Model = "corolla",
    Marka = "TOYOTA",
    KapiSayiyi = 1
};

// araç özelliklerini ekrana yazdırıyoruz
aracim.Yazdir();
```
#### Hata Output:
```bash
Kapı sayısını lütfen 2 veya 4 giriniz.
Aracın kapı sayısını yanlış girdiniz. Hata: -1
```
#### Hata olmadan Output:
```bash
TOYOTA - corolla aracın rengi mavi, kapı sayısı 2
```
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
// proje yöneticisi class'ı
class Proje : BasePerson, IBasePerson
{
    public void Gorev()
    {
        Console.WriteLine($"Benim adım {Ad} {SoyAd}. Ben {Departman} departmanında proje yöneticisi olarak çalışıyorum.");
    }
}
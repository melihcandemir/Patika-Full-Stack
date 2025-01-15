// satış temsilcisi class'ı
class Satis : BasePerson, IBasePerson
{
    public void Gorev()
    {
        Console.WriteLine($"Benim adım {Ad} {SoyAd}. Ben {Departman} departmanında satış temsilcisi olarak çalışıyorum.");
    }
}
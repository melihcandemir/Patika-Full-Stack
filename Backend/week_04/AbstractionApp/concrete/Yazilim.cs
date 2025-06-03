// yazılım geliştiricisi class'ı
class Yazilim : BasePerson, IBasePerson
{
    public void Gorev()
    {
        Console.WriteLine($"Benim adım {Ad} {SoyAd}. Ben {Departman} departmanında yazılım geliştiricisi olarak çalışıyorum.");
    }
}
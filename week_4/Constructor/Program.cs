// değer girilmeden bebek class çağırılıyor
Bebek bebek_1 = new Bebek();
Console.WriteLine($"Bebeğin adı {bebek_1.Ad}, bebeğin soyadı {bebek_1.SoyAd}, bebeğin doğum tarihi {bebek_1.DoğumTarihi}");


// değer girilerek bebek class çağırılıyor
Bebek bebek_2 = new Bebek("Ahmet", "Çelik");
Console.WriteLine($"Bebeğin adı {bebek_2.Ad}, bebeğin soyadı {bebek_2.SoyAd}, bebeğin doğum tarihi {bebek_2.DoğumTarihi}");
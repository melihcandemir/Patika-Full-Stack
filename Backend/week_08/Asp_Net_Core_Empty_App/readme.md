## Pratik - Asp.Net Core Empty
Bu pratikte, bir ASP.NET Core Empty projesi oluşturup, projedeki yapıları MVC tasarım desenine uygun olarak yapılandırmamız beklenmektedir.

###  Controller - Action - Model -  View - Razor - RazorView - wwwroot kavramlarının ve builder.Build() - app.Run() metotlarının ne işe yaradıklarını,  hangi amaçla kullanıldıklarını Program.cs'in en alt kısmında yorum satırı olarak açıkladım.

```C#
// Controller: Mvc mimarisinde bulunan bir parça. Genellikle HTTP isteklerini yönetir ve View'lara veri gönderir.
// Action: Bir controller içerisindeki metotlar. Bu metotlar genellikle belirli bir URL'ye yanıt olarak çağrılırlar ve bu sayede istekleri gösterebilirler.
// Model: Veritabanındaki verileri temsil eden nesnelerdir.
// View: Kullanıcı arayüzünü oluşturmak için kullanılır ve genellikle bir .cshtml dosyasıdır. Controller'dan gelen veriyi gösterir.
// Razor: ASP.NET Core MVC'de HTML sayfaları oluşturmak için kullanılan bir templating dilidir.
// RazorView: View'lar, genellikle .cshtml uzantılı dosyalarla temsil edilir ve bu dosyalarda Razor syntax'i kullanılarak HTML ve C# gibi dillerin birleşimi yapılır.
// wwwroot kavramları: Genellikle statik dosyaları (CSS, JS, imajlar vb.) içeren klasördür. Bu dosyalara web sayfalarından erişmek mümkündür ve bu sayede dinamik olmayan içerikler sunulur.
// builde.Build(); : Uygulama yapılandırmasını tamamlamak ve uygulamayı başlatmak için kullanılır. Bu sayede, ASP.NET Core MVC uygulaması oluşturulur ve çalıştırılabilir hale getirilir.
// app.Run(); : Uygulamanın başlangıç noktasıdır ve belirli bir URL'ye yanıt olarak çağrılır. Bu sayede, uygulama belirtilen URL'yi dinlemeye başlar ve istekleri karşılar.
```

### Programı başlatmak için yapman gereken
Proje Vs Code kullanılarak oluşturuldu. 
- Dosyaları indirni.
- Başlatmak için terminale `dotnet watch` yazın.
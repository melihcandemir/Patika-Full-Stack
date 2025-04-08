var builder = WebApplication.CreateBuilder(args);

//
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
);

// app.MapGet("/", () => "Hello World!");

app.Run();


// Controller: Mvc mimarisinde bulunan bir parça. Genellikle HTTP isteklerini yönetir ve View'lara veri gönderir.
// Action: Bir controller içerisindeki metotlar. Bu metotlar genellikle belirli bir URL'ye yanıt olarak çağrılırlar ve bu sayede istekleri gösterebilirler.
// Model: Veritabanındaki verileri temsil eden nesnelerdir.
// View: Kullanıcı arayüzünü oluşturmak için kullanılır ve genellikle bir .cshtml dosyasıdır. Controller'dan gelen veriyi gösterir.
// Razor: ASP.NET Core MVC'de HTML sayfaları oluşturmak için kullanılan bir templating dilidir.
// RazorView: View'lar, genellikle .cshtml uzantılı dosyalarla temsil edilir ve bu dosyalarda Razor syntax'i kullanılarak HTML ve C# gibi dillerin birleşimi yapılır.
// wwwroot kavramları: Genellikle statik dosyaları (CSS, JS, imajlar vb.) içeren klasördür. Bu dosyalara web sayfalarından erişmek mümkündür ve bu sayede dinamik olmayan içerikler sunulur.
// builde.Build(); : Uygulama yapılandırmasını tamamlamak ve uygulamayı başlatmak için kullanılır. Bu sayede, ASP.NET Core MVC uygulaması oluşturulur ve çalıştırılabilir hale getirilir.
// app.Run(); : Uygulamanın başlangıç noktasıdır ve belirli bir URL'ye yanıt olarak çağrılır. Bu sayede, uygulama belirtilen URL'yi dinlemeye başlar ve istekleri karşılar.
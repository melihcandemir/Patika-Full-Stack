# DependencyInjection Projesi 🚀

Bu proje, ASP.NET Core Web API uygulamasında **Bağımlılık Enjeksiyonu** (Dependency Injection) kullanımını göstermektedir. `ITeacher` servisini `ClassRoom` kontrolcüsüne enjekte ederek öğretmenle ilgili işlemleri gerçekleştiren basit bir örnek içerir.

## Özellikler ✨
- **Bağımlılık Enjeksiyonu**: `AddScoped` kullanılarak DI uygulanmıştır.
- **Swagger Entegrasyonu**: API dokümantasyonu otomatik olarak oluşturulur.
- **.NET 8.0**: En son .NET framework ile geliştirilmiştir.
- **RESTful API**: Öğretmen bilgileri için uç noktalar sağlar.

## Proje Yapısı 📂
- **Controllers**: API isteklerini işlemek için `ClassRoom` kontrolcüsünü içerir.
- **Services**: `ITeacher` arayüzünü ve `Teacher` sınıfındaki uygulamasını tanımlar.
- **Konfigürasyon**: Günlük kaydı ve ortam ayarları için `appsettings.json` dosyasını içerir.

## Nasıl Çalıştırılır? 🏃‍♂️
1. **Depoyu Klonlayın**:
   ```bash
   git clone https://github.com/melihcandemir/Patika-Full-Stack.git
   cd DependencyInjection
   ```

2. **Bağımlılıkları Yükleyin**:
   ```bash
   dotnet restore
   ```

3. **Projeyi Derleyin**:
   ```bash
   dotnet build
   ```

4. **Uygulamayı Çalıştırın**:
   ```bash
   dotnet run
   ```

5. **Swagger Arayüzüne Erişin**:
   Tarayıcınızı açın ve şu adrese gidin:
   ```
   http://localhost:5046/swagger
   ```

## API Uç Noktaları 📡
- **GET** `/api/ClassRoom`: Öğretmen bilgilerini getirir.
  - **Sorgu Parametreleri**:
    - `firstName` (string): Öğretmenin adı.
    - `lastName` (string): Öğretmenin soyadı.

## Örnek İstek 🛠️
API'yi test etmek için aşağıdaki HTTP isteğini kullanabilirsiniz:
```http
GET http://localhost:5046/api/ClassRoom?firstName=John&lastName=Doe
Accept: application/json
```

## Bağımlılıklar 📦
- **Microsoft.AspNetCore.OpenApi**: OpenAPI/Swagger desteği için.
- **Swashbuckle.AspNetCore**: Swagger UI entegrasyonu için.

---
İyi Kodlamalar! 😊

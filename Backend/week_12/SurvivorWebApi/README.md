# 🌟 Survivor Web API

## 📝 Proje Hakkında
Survivor Web API, Survivor yarışmasının kategorilerini ve yarışmacılarını yönetmek için geliştirilmiş bir backend uygulamasıdır. Bu proje, Entity Framework Core ve PostgreSQL kullanılarak geliştirilmiştir.

## 🚀 Özellikler
- 🏷️ **Kategori Yönetimi**: Kategorileri listeleme, ekleme, güncelleme ve silme.
- 🏃‍♂️ **Yarışmacı Yönetimi**: Yarışmacıları listeleme, ekleme, güncelleme ve silme.
- 🔗 **Kategoriye Göre Yarışmacılar**: Belirli bir kategoriye ait yarışmacıları listeleme.

## 🛠️ Kurulum
1. Projeyi klonlayın:
   ```bash
   git clone https://github.com/melihcandemir/Patika-Full-Stack.git
   ```

2. Proje dizinine gidin:
   ```bash
   cd SurvivorWebApi
   ```

3. Bağımlılıkları yükleyin:
   ```bash
   dotnet restore
   ```

4. Veritabanını güncelleyin:
   ```bash
   dotnet ef database update
   ```

5. Uygulamayı çalıştırın:
   ```bash
   dotnet run
   ```

## 📡 API Endpoint'leri
### Kategoriler
- 🔍 **GET /api/categories**: Tüm kategorileri listeler.
- 🔍 **GET /api/categories/{id}**: Belirli bir kategoriyi getirir.
- ➕ **POST /api/categories**: Yeni bir kategori ekler.
- ✏️ **PUT /api/categories/{id}**: Mevcut bir kategoriyi günceller.
- ❌ **DELETE /api/categories/{id}**: Bir kategoriyi siler.

### Yarışmacılar
- 🔍 **GET /api/competitors**: Tüm yarışmacıları listeler.
- 🔍 **GET /api/competitors/{id}**: Belirli bir yarışmacıyı getirir.
- 🔍 **GET /api/competitors/categories/{categoryId}**: Belirli bir kategoriye ait yarışmacıları listeler.
- ➕ **POST /api/competitors**: Yeni bir yarışmacı ekler.
- ✏️ **PUT /api/competitors/{id}**: Mevcut bir yarışmacıyı günceller.
- ❌ **DELETE /api/competitors/{id}**: Bir yarışmacıyı siler.

## 🔧 Kullanılan Teknolojiler
- 💻 **.NET 8**
- 🗄️ **Entity Framework Core**
- 🐘 **PostgreSQL**
- 📚 **Swagger** (API dokümantasyonu için)

## 📂 Proje Yapısı
- **Controllers**: API endpoint'lerini barındırır.
- **Entity**: Veritabanı modellerini içerir.
- **Migrations**: Veritabanı migration dosyalarını içerir.
- **Models**: Request ve response modellerini içerir.
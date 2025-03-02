# 🎸 Crazy Musicians API

## 📌 Proje Açıklaması
Crazy Musicians API, müzisyenler üzerinde temel CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştiren bir RESTful web servisidir. API, belirlenen routing standartlarına uygun şekilde geliştirilmiştir ve validasyon işlemleri sağlanmıştır. Ayrıca, `[FromQuery]` kullanılarak bir arama fonksiyonu da eklenmiştir. 🔍

---

## 🚀 API Endpoint'leri

### 🎼 Tüm Müzisyenleri Getir
**🔗 Endpoint:** `GET /api/musicians`

**📌 Açıklama:** Tüm müzisyenlerin listesini getirir.

**📥 Örnek Yanıt:**
```json
[
  {
    "id": 1,
    "name": "Ahmet Çalgı",
    "job": "Ünlü Çalgı Çalar",
    "funFeature": "Her zaman yanlış nota çalar, ama çok eğlenceli"
  },
  ...
]
```

---

### 🎤 Belirli Bir Müzisyeni Getir
**🔗 Endpoint:** `GET /api/musicians/{id}`

**📌 Açıklama:** Belirtilen ID'ye sahip müzisyeni getirir.

**📥 Örnek Yanıt:**
```json
{
  "id": 1,
  "name": "Ahmet Çalgı",
  "job": "Ünlü Çalgı Çalar",
  "funFeature": "Her zaman yanlış nota çalar, ama çok eğlenceli"
}
```

---

### 🔍 Müzisyen Arama
**🔗 Endpoint:** `GET /api/musicians/search?name={name}`

**📌 Açıklama:** İsme göre müzisyen araması yapar.

**📥 Örnek Yanıt:**
```json
[
  {
    "id": 2,
    "name": "Zeynep Melodi",
    "job": "Popüler Melodi Yazan",
    "funFeature": "Şarkıları yanlış anlaşılır ama çok popüler"
  }
]
```

---

### ✨ Yeni Müzisyen Ekle
**🔗 Endpoint:** `POST /api/musicians`

**📌 Açıklama:** Yeni bir müzisyen ekler.

**📤 Örnek Gönderim:**
```json
{
  "name": "David Bowie",
  "job": "Vokalist",
  "funFeature": "Kostümleri ile dikkat çeker"
}
```

**📥 Örnek Yanıt:**
```json
{
  "id": 11,
  "name": "David Bowie",
  "job": "Vokalist",
  "funFeature": "Kostümleri ile dikkat çeker"
}
```

---

### 📝 Müzisyen Adını Güncelle (Kısmi Güncelleme)
**🔗 Endpoint:** `PATCH /api/musicians/{id}`

**📌 Açıklama:** Belirtilen müzisyenin sadece adını günceller.

**📤 Örnek Gönderim:**
```json
{
  "name": "Yeni İsim"
}
```

**📥 Örnek Yanıt:**
```json
{
  "message": "Müzisyen adı başarıyla güncellendi."
}
```

---

### 🔄 Müzisyeni Tamamen Güncelle
**🔗 Endpoint:** `PUT /api/musicians/{id}`

**📌 Açıklama:** Belirtilen müzisyenin tüm bilgilerini günceller.

**📤 Örnek Gönderim:**
```json
{
  "name": "Cemil Akor",
  "job": "Besteci",
  "funFeature": "Çok hızlı beste yapar"
}
```

**📥 Örnek Yanıt:**
```json
{
  "id": 3,
  "name": "Cemil Akor",
  "job": "Besteci",
  "funFeature": "Çok hızlı beste yapar"
}
```

---

### ❌ Müzisyeni Sil
**🔗 Endpoint:** `DELETE /api/musicians/{id}`

**📌 Açıklama:** Belirtilen ID'ye sahip müzisyeni siler.

**📥 Örnek Yanıt:**
```json
{
  "message": "Müzisyen başarıyla silindi."
}
```

## 🛠 Gereksinimler & Kurulum
1. **.NET SDK 7.0 veya daha yeni bir sürümünü yükleyin.**
2. **Projeyi klonlayın:**
   ```sh
   git clone https://github.com/melihcandemir/Patika-Full-Stack.git
   ```
3. **Proje klasörüne gidin:**
   ```sh
   cd CrazyApp
   ```
4. **Uygulamayı çalıştırın:**
   ```sh
   dotnet watch
   ```

---

## 🎯 Kullanım
API'yi test etmek için Postman, cURL veya herhangi bir API test aracını kullanabilirsiniz.

🎵 **Müzik dolu keyifli kodlamalar dileriz!** 🎶


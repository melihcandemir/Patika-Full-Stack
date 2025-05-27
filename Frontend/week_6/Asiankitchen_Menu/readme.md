# 🍜 Asian Kitchen Menü Projesi 🍣

Bu proje, farklı kategorilerdeki yiyecekleri listeleyen ve filtreleme özelliği sunan basit bir menü uygulamasıdır. HTML, CSS ve JavaScript kullanılarak geliştirilmiştir.

## ✨ Özellikler

* **Dinamik Menü Listeleme**: `app.js` dosyasında tanımlanan menü öğeleri otomatik olarak listelenir.
* **Kategoriye Göre Filtreleme**: "All" (Tümü), "Korea" (Kore), "Japan" (Japonya) ve "China" (Çin) gibi kategorilere göre menü öğeleri filtrelenebilir.
* **Duyarlı Tasarım**: Bootstrap kullanılarak farklı ekran boyutlarına uyum sağlar.
* **Modern Arayüz**: Temiz ve kullanımı kolay bir arayüze sahiptir.

## 🚀 Nasıl Çalışır?

1.  `index.html` dosyası uygulamanın ana yapısını oluşturur.
2.  `style.css` dosyası uygulamanın görsel stilini sağlar.
3.  `app.js` dosyası ise menü verilerini yönetir, kategori butonlarını oluşturur ve menü öğelerini dinamik olarak sayfaya ekler.

### `app.js` Detayları:

* `menu` dizisi, her bir menü öğesinin `id`, `title`, `category`, `price`, `img` ve `desc` gibi özelliklerini içerir.
* `categories` dizisi, menü öğelerinden benzersiz kategorileri (ve "All" kategorisini) toplar.
* `categoryList()` fonksiyonu, kategori butonlarını dinamik olarak oluşturur ve sayfaya ekler. Bu butonlara tıklandığında ilgili kategoriye ait menü öğeleri filtrelenir.
* `menuList()` fonksiyonu, verilen menü öğeleri dizisini alarak HTML yapısını oluşturur ve `section-center` div'ine yerleştirir.

## 🛠️ Kurulum

1.  Projeyi klonlayın veya indirin.
2.  `index.html` dosyasını bir web tarayıcısında açın.

Bu kadar! 🎉

## 📂 Proje Yapısı
```
.
├── app.js
├── index.html
└── style.css
```
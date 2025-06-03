-- country tablosunda bulunan country sütunundaki ülke isimlerinden 'A' karakteri ile başlayıp 'a' karakteri ile sonlananları sıralıyoruz.
SELECT country FROM country
WHERE country LIKE 'A%a';
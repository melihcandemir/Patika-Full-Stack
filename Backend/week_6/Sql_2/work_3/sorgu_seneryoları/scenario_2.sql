-- country tablosunda bulunan country sütunundaki ülke isimlerinden en az 6 karakterden oluşan ve sonu 'n' karakteri ile sonlananları sıralıyoruz.
SELECT country FROM country
WHERE country LIKE '_____%n';
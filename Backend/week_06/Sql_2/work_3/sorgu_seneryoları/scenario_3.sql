-- film tablosunda bulunan title sütunundaki film isimlerinden en az 4 adet büyük ya da küçük harf farketmeksizin 'T' karakteri içeren film isimlerini sıralıyoruz.
SELECT title FROM film
WHERE title ILIKE '%T%T%T%T%';
-- ILIKE ile büyük küçük harf duyarlılığı kalkıyor
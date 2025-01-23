-- city tablosunda bulunan şehir verilerini country_id sütununa göre gruplandırdıktan sonra en fazla şehir sayısı barındıran country_id bilgisini ve şehir sayısını paylaşıyoruz.
SELECT country_id, COUNT(*) FROM city
GROUP BY country_id
ORDER BY COUNT(*) DESC  -- country_id'ye göre büyükten küçüğe sıralandı
LIMIT 1; -- sadece en büyük yazıldı
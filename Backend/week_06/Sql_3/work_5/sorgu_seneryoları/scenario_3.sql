-- customer tablosunda bulunan last_name sütununa göre azalan yapılan sıralamada store_id 1 olmak koşuluyla ilk 4 veriyi sıralıyoruz.
SELECT * FROM customer
WHERE store_id = 1
ORDER BY last_name
LIMIT 4;
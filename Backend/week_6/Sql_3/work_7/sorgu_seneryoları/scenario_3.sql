-- customer tablosunda bulunan store_id değerlerine karşılık gelen müşteri sayıları nelerdir?
SELECT store_id, COUNT(*) FROM customer
GROUP BY store_id;
# Aşağıdaki sorgu senaryolarını dvdrental veri tabanı üzerinden gerçekleştiriyoruz.
Bu pratiğin tamamını readme.md dosyasından kontrol edebilirsiniz. 



## 1- film tablosunda film uzunluğu length sütununda gösterilmektedir. Uzunluğu ortalama film uzunluğundan fazla kaç tane film vardır?
SONUC : 489
```sql
SELECT COUNT(*) AS ortalamdan_uzun FROM film
WHERE length > 
(	
	SELECT AVG(length) FROM film
)
```
Bu linke tıklayarak dvdrental örnek veri tabanının 1. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_1.csv)



## 2- film tablosunda en yüksek rental_rate değerine sahip kaç tane film vardır?
SONUC : 336
```sql
SELECT COUNT(rental_rate) FROM film
WHERE rental_rate = 
( 
SELECT MAX(rental_rate) FROM film
)
```
Bu linke tıklayarak dvdrental örnek veri tabanının 2. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_2.csv)



## 3- film tablosunda en düşük rental_rate ve en düşün replacement_cost değerlerine sahip filmleri sıralayınız.
```sql
SELECT rental_rate FROM film
WHERE rental_rate = (SELECT MIN(rental_rate) FROM film) AND replacement_cost = (SELECT MIN(replacement_cost) FROM film)
```
Bu linke tıklayarak dvdrental örnek veri tabanının 3. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_3.csv)




## 4- payment tablosunda en fazla sayıda alışveriş yapan müşterileri(customer) sıralayınız.
```sql
SELECT customer_id, COUNT(*) AS payment_count
FROM payment
GROUP BY customer_id
ORDER BY payment_count DESC;
```
Bu linke tıklayarak dvdrental örnek veri tabanının 4. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_4.csv)
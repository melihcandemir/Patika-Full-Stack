# Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriyoruz.
Bu pratiğin tamamını readme.md dosyasından kontrol edebilirsiniz. 


## 1- film tablosunda bulunan filmleri rating değerlerine göre grupluyoruz.
```sql
SELECT rating, COUNT(*) FROM film
GROUP BY rating;
```
Bu linke tıklayarak dvdrental örnek veri tabanının 1. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_1.csv)




## 2- film tablosunda bulunan filmleri replacement_cost sütununa göre grupladığımızda film sayısı 50 den fazla olan replacement_cost değerini ve karşılık gelen film sayısını sıralıyoruz.
```sql
SELECT replacement_cost, COUNT(*) FROM film
GROUP BY replacement_cost
HAVING COUNT(*) > 50;
```
Bu linke tıklayarak dvdrental örnek veri tabanının 2. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_2.csv)



## 3- customer tablosunda bulunan store_id değerlerine karşılık gelen müşteri sayıları nelerdir?
Cevap: 1 --> 326
       2 --> 273 

```sql
SELECT store_id, COUNT(*) FROM customer
GROUP BY store_id;
```
Bu linke tıklayarak dvdrental örnek veri tabanının 3. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_3.csv)



## 4- city tablosunda bulunan şehir verilerini country_id sütununa göre gruplandırdıktan sonra en fazla şehir sayısı barındıran country_id bilgisini ve şehir sayısını paylaşıyoruz.
```sql
SELECT country_id, COUNT(*) FROM city
GROUP BY country_id
ORDER BY COUNT(*) DESC  -- country_id'ye göre büyükten küçüğe sıralandı
LIMIT 1; -- sadece en büyük yazıldı
```
Bu linke tıklayarak dvdrental örnek veri tabanının 4. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_4.csv)
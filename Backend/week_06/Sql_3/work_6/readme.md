# Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriyoruz.
Bu pratiğin tamamını readme.md dosyasından kontrol edebilirsiniz. 


## 1- film tablosunda bulunan rental_rate sütunundaki değerlerin ortalaması nedir?
Cevap: 2.980
```sql
SELECT ROUND(AVG(rental_rate), 3) FROM film;
```
Bu linke tıklayarak dvdrental örnek veri tabanının 1. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_1.csv)



## 2- film tablosunda bulunan filmlerden kaç tanesi 'C' karakteri ile başlar?
Cevap: 92
```sql
SELECT COUNT(*) FROM film
WHERE title LIKE 'C%';
```
Bu linke tıklayarak dvdrental örnek veri tabanının 2. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_2.csv)



## 3- film tablosunda bulunan filmlerden rental_rate değeri 0.99 a eşit olan en uzun (length) film kaç dakikadır?
Cevap: 184
```sql
SELECT MAX(length) FROM film
WHERE rental_rate = 0.99;
```
Bu linke tıklayarak dvdrental örnek veri tabanının 3. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_3.csv)




## 4- film tablosunda bulunan filmlerin uzunluğu 150 dakikadan büyük olanlarına ait kaç farklı replacement_cost değeri vardır?
Cevap: 21
```sql
SELECT COUNT(DISTINCT(replacement_cost)) FROM film
WHERE length > 150;
```
Bu linke tıklayarak dvdrental örnek veri tabanının 4. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_4.csv)
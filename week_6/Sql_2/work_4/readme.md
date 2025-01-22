# Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriyoruz.
Bu pratiğin tamamını readme.md dosyasından kontrol edebilirsiniz. 


## 1- film tablosunda bulunan replacement_cost sütununda bulunan birbirinden farklı değerleri sıralıyoruz.
```sql
SELECT DISTINCT replacement_cost FROM film;
```
Bu linke tıklayarak dvdrental örnek veri tabanının 1. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_1.csv)



## 2- film tablosunda bulunan replacement_cost sütununda birbirinden farklı kaç tane veri vardır?
Cevap: 21
```sql
SELECT COUNT(DISTINCT replacement_cost) FROM film;
```
Bu linke tıklayarak dvdrental örnek veri tabanının 2. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_2.csv)



## 3- film tablosunda bulunan film isimlerinde (title) kaç tanesini T karakteri ile başlar ve aynı zamanda rating 'G' ye eşittir?
Cevap: 9
```sql
SELECT COUNT(DISTINCT (title, rating)) FROM film
WHERE title LIKE 'T%' AND rating = 'G';
```
Bu linke tıklayarak dvdrental örnek veri tabanının 3. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_3.csv)



## 4- country tablosunda bulunan ülke isimlerinden (country) kaç tanesi 5 karakterden oluşmaktadır?
Cevap: 13
```sql
SELECT COUNT(*) FROM country
WHERE country LIKE '_____';
```
Bu linke tıklayarak dvdrental örnek veri tabanının 4. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_4.csv)



## 5- city tablosundaki şehir isimlerinin kaç tanesi 'R' veya r karakteri ile biter?
Cevap: 33
```sql
SELECT COUNT(*) FROM city
WHERE city ILIKE '%r';
```
Bu linke tıklayarak dvdrental örnek veri tabanının 5. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_5.csv)
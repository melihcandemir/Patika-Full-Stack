# Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriyoruz.
Bu pratiğin tamamını readme.md dosyasından kontrol edebilirsiniz. 


## 1- film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en uzun (length) 5 filmi sıralıyoruz.
```sql
SELECT * FROM film
WHERE title LIKE '%n'
ORDER BY length DESC
LIMIT 5;
```
Bu linke tıklayarak dvdrental örnek veri tabanının 1. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_1.csv)


## 2- film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en kısa (length) ikinci(6,7,8,9,10) 5 filmi(6,7,8,9,10) sıralıyoruz.
```sql
SELECT * FROM film
WHERE title LIKE '%n'
ORDER BY length
OFFSET 5
LIMIT 5;
```
Bu linke tıklayarak dvdrental örnek veri tabanının 2. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_2.csv)


## 3- customer tablosunda bulunan last_name sütununa göre azalan yapılan sıralamada store_id 1 olmak koşuluyla ilk 4 veriyi sıralıyoruz.
```sql
SELECT * FROM customer
WHERE store_id = 1
ORDER BY last_name
LIMIT 4;
```
Bu linke tıklayarak dvdrental örnek veri tabanının 3. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_3.csv)
# Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriyoruz.
Bu pratiğin tamamını readme.md dosyasından kontrol edebilirsiniz. 



## 1- film tablosunda bulunan tüm sütunlardaki verileri replacement cost değeri 12.99 dan büyük eşit ve 16.99 küçük olma koşuluyla sıralıyoruz. ( BETWEEN - AND yapısını kullanarak.)
```sql
SELECT * FROM film
WHERE replacement_cost BETWEEN 12.99 AND 16.99;
```
Bu linke tıklayarak dvdrental örnek veri tabanının 1. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_1.csv)



## 2- .actor tablosunda bulunan first_name ve last_name sütunlardaki verileri first_name 'Penelope' veya 'Nick' veya 'Ed' değerleri olması koşuluyla sıralıyouz. ( IN operatörünü kullanarak.)
```sql
SELECT first_name, last_name FROM actor
WHERE first_name IN ('Penelope', 'Nick', 'Ed');
```
Bu linke tıklayarak dvdrental örnek veri tabanının 2. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_2.csv)



## 3- film tablosunda bulunan tüm sütunlardaki verileri rental_rate 0.99, 2.99, 4.99 VE replacement_cost 12.99, 15.99, 28.99 olma koşullarıyla sıralıyoruz. ( IN operatörünü kullanarak.)
```sql
SELECT * FROM film
WHERE rental_rate IN (0.99, 2.99, 4.99) AND replacement_cost IN (12.99, 15.99, 28.99);
```
Bu linke tıklayarak dvdrental örnek veri tabanının 3. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_3.csv)
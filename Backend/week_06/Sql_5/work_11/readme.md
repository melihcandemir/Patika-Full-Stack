# Aşağıdaki sorgu senaryolarını dvdrental veri tabanı üzerinden gerçekleştiriyoruz.
Bu pratiğin tamamını readme.md dosyasından kontrol edebilirsiniz. 




## 1- actor ve customer tablolarında bulunan first_name sütunları için tüm verileri sıralayalım.
```sql
(SELECT first_name FROM actor)
UNION ALL
(SELECT first_name FROM customer)
```
Bu linke tıklayarak dvdrental örnek veri tabanının 1. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_1.csv)




## 2- actor ve customer tablolarında bulunan first_name sütunları için kesişen verileri sıralayalım.
```sql
(SELECT first_name FROM actor)
INTERSECT
(SELECT first_name FROM customer)
```
Bu linke tıklayarak dvdrental örnek veri tabanının 2. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_2.csv)



## 3- actor ve customer tablolarında bulunan first_name sütunları için ilk tabloda bulunan ancak ikinci tabloda bulunmayan verileri sıralayalım.
```sql
(SELECT first_name FROM actor)
EXCEPT
(SELECT first_name FROM customer)
```
Bu linke tıklayarak dvdrental örnek veri tabanının 3. seneryoya karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_3.csv)



## 4- İlk 3 sorguyu tekrar eden veriler için de yapalım.
```sql
--1
SELECT first_name FROM actor
UNION ALL
SELECT first_name FROM customer;

--2
SELECT first_name FROM actor
INTERSECT ALL
SELECT first_name FROM customer;

--3
SELECT first_name FROM actor
EXCEPT ALL
SELECT first_name FROM customer;
```
Bu linke tıklayarak dvdrental örnek veri tabanının 4. seneryoda bulunan 1. seryo karşılığını alabilirsiniz : 
[Output dosyasını görüntüle](output_veri/data_4.csv)

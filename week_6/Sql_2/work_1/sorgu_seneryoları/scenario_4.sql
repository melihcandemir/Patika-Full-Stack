-- customer tablosunda bulunan first_name sütunundaki değeri 'Mary' olan müşterinin last_name sütunundaki değeri nedir?
SELECT first_name, last_name FROM customer
WHERE first_name = 'Mary';
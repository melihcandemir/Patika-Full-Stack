-- city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.
SELECT country.country, city.city FROM city
LEFT JOIN country ON country.country_id = city.country_id;
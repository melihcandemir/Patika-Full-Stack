-- film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en uzun (length) 5 filmi sıralıyoruz.
SELECT * FROM film
WHERE title LIKE '%n'
ORDER BY length DESC
LIMIT 5;
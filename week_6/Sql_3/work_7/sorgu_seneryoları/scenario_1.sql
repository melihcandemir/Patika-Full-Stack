-- film tablosunda bulunan filmleri rating değerlerine göre grupluyoruz.
SELECT rating, COUNT(*) FROM film
GROUP BY rating;
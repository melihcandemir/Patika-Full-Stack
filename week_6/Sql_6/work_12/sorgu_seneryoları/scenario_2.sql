-- film tablosunda en yüksek rental_rate değerine sahip kaç tane film vardır?
SELECT COUNT(rental_rate) FROM film
WHERE rental_rate = 
( 
SELECT MAX(rental_rate) FROM film
)
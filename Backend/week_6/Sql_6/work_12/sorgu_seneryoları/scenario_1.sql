-- film tablosunda film uzunluğu length sütununda gösterilmektedir. Uzunluğu ortalama film uzunluğundan fazla kaç tane film vardır?
SELECT COUNT(*) AS ortalamdan_uzun FROM film
WHERE length > 
(	
	SELECT AVG(length) FROM film
)
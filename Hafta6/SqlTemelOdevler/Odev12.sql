
SELECT COUNT(*) AS fazla_uzun_film_sayisi
FROM film
WHERE length > (SELECT AVG(length) FROM film);

SELECT COUNT(*) AS en_yuksek_rental_rate_film_sayisi
FROM film
WHERE rental_rate = (SELECT MAX(rental_rate) FROM film);

SELECT * 
FROM film
WHERE rental_rate = (SELECT MIN(rental_rate) FROM film)
AND replacement_cost = (SELECT MIN(replacement_cost) FROM film);


SELECT customer_id, COUNT(*) AS toplam_odeme_sayisi
FROM payment
GROUP BY customer_id
ORDER BY toplam_odeme_sayisi DESC
LIMIT 5;

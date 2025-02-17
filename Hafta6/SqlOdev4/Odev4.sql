SELECT DISTINCT replacement_cost FROM film;
SELECT COUNT(DISTINCT replacement_cost) FROM film;
SELECT COUNT(DISTINCT title~~('T%')) FROM film;
SELECT  title,rating FROM film
WHERE title~~'T%' AND rating='G';
SELECT * FROM country 
WHERE LENGTH(country)=5;
SELECT * FROM city 
WHERE city~~*('%r')
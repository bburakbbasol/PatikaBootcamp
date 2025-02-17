SELECT country From country
WHERE country ~~('A%a');
SELECT country FROM country
WHERE LENGTH(country)>=6 AND country ~~('%n');
SELECT title
FROM film
WHERE title ~~* '%t%t%t%t%';
SELECT title,length,rental_rate FROM film
WHERE title ~~('C%')
AND length>90
AND rental_rate=2.99;



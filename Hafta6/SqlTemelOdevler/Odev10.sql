--SELECT city,country FROM city
--LEFT JOIN country ON country.country_id=city.country_id;
--SELECT payment_id,first_name,last_name FROM payment
--RIGHT JOIN customer ON  customer.customer_id=payment.customer_id;
SELECT rental_id,first_name,last_name FROM rental
FULL JOIN customer ON rental.customer_id=customer.customer_id;
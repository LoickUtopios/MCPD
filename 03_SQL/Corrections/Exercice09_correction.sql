SELECT *
FROM users
WHERE location = 'New York' AND (salary >= 3000 AND salary <= 3500) AND NOT (job = 'Doctor' OR job = 'Lawyer') 
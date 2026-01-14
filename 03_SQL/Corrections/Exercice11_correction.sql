-- 1) Sélectionnez les utilisateurs ayant un prénom qui commence par "D".

SELECT first_name
FROM users
WHERE first_name LIKE 'D%'; 

-- 2) Trouvez les utilisateurs dont le nom de famille se termine par "son".

SELECT last_name
FROM users
WHERE last_name LIKE '%son'; 

-- 3) Identifiez les utilisateurs dont le prénom contient exactement 5 caractères.

SELECT first_name
FROM users
WHERE first_name LIKE '_____'; 

-- 4) Sélectionnez les utilisateurs ayant "Doctor" dans leur métier. (caractère générique obligatoire )

SELECT job
FROM users
WHERE job LIKE '%Doctor%'; 
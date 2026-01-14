-- 1) Dans une première requête, récupérez tous les utilisateurs dont le métier n'est pas développeur

SELECT * 
FROM users
WHERE job != 'Developer'; 
-- WHERE NOT job = 'Developer';

-- 2) Dans une seconde requête, récupérez tous les utilisateurs dont le prénom est John.

SELECT * 
FROM users
WHERE first_name = 'John'; 

-- 3) Dans une dernière requête, récupérez tous les utilisateurs dont le salaire est supérieur ou égal à 3000.

SELECT * 
FROM users
WHERE salary >= 3000; 
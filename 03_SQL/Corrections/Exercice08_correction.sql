-- 1) Dans un première requête, récupérez tous les utilisateurs dont l'âge est inférieur à 30ans ou supérieur et égal à 35ans.

SELECT *
FROM users
WHERE age < 30 OR age >= 35; 

-- 2) Récupérez ensuite tous les utilisateurs dont le métier est professeur et le salaire est supérieur à 2600.

SELECT *
FROM users
WHERE job = 'Teacher' AND salary > 2600; 
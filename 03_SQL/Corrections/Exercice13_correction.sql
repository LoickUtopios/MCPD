-- 1) Quel est le salaire minimum parmi tous les utilisateurs ?

SELECT MIN(salary) AS salaire_minimum, job
FROM users;

-- 2) Quel est l'âge maximum parmi les utilisateurs ayant le métier "Engineer" ?

SELECT MAX(age) AS age_maximum
FROM users
WHERE job = 'Engineer';

-- 3) Trouvez le salaire moyen des utilisateurs dont le métier est "Teacher".

SELECT AVG(salary) AS salaire_moyen
FROM users
WHERE job = 'Teacher';

-- 4) Trouvez le montant total des salaires de tous les utilisateurs.

SELECT SUM(salary) AS montant_total
FROM users;
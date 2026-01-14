-- 1. Affichez le nombre d'utilisateurs par lieu de naissance, mais ne montrez que les lieux avec plus d'un utilisateur.

SELECT COUNT(*) AS nb_utilisateur, location
FROM users
GROUP BY location
HAVING COUNT(*) > 1; 

-- 2. Sélectionnez la profession et la moyenne des salaires pour chaque profession, mais ne montrez que celles avec une moyenne de salaire supérieure à 2500.

SELECT job, AVG(salary) AS moyenne_salaire
FROM users
GROUP BY job
HAVING AVG(salary) > 2500;

-- 3. Affichez la somme des salaires pour chaque lieu de naissance, mais ne montrez que les lieux dont la somme des salaires est supérieure à 5000.

SELECT SUM(salary) AS somme_des_salaires, location
FROM users
GROUP BY location
HAVING SUM(salary) > 5000; 

-- 4. Sélectionnez la date de naissance et le nombre d'utilisateurs nés à chaque date, mais ne montrez que les dates où il y a plus d'un utilisateur né.

SELECT  birth_date, COUNT(*) AS nb_utilisateur
FROM users
GROUP BY birth_date
HAVING COUNT(*) > 1; 

-- 5. Affichez la profession, le lieu de naissance, et le salaire maximum pour chaque profession et lieu, mais ne montrez que les résultats où le salaire maximum est supérieur à 3000.

SELECT job, location, MAX(salary) AS salaire_maximum
FROM users
GROUP BY job, location
HAVING MAX(salary) > 3000; 
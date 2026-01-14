INSERT INTO salarie (nom, prenom, age, salaire, service_id)
VALUES
	("Dupont", "Jean", 30, 1400, 1),
    ("Dufour", "Michelle", 29, 2900,2),
    ("De rives", "Geralt", 24, 1500, 1),
    ("Dandelion", "Jasquier", 41, 2100, 2),
    ("Jager", "Eren", 20, 3500, 1),
    ("Ackerman", "Mikasa", 25, 2200, 1),
    ("Pinkman", "Jessie", 30, 3000, 2),
    ("White", "Walter", 27, 600, 2);
    
-- Sélectionner toutes les colonnes d'une tables
SELECT * 
FROM salarie; 

-- Sélectionner des colonnes spécifiques
SELECT nom, prenom
FROM salarie; 

-- Alias pour les colonnes
SELECT libelle AS nom_service, date_creation AS creation 
FROM services;

-- La clause WHERE permet de filter les résultats de la requete.
SELECT *
FROM salarie
WHERE salarie_id = 1; 

SELECT *
FROM salarie
WHERE salaire > 2000 AND age > 20;

SELECT *
FROM salarie
WHERE salaire > 3000 OR (age < 30 AND NOT service_id = 1); 

-- DISTINCT permet de ne récupérer que les valeurs uniques d'une table (pas de doublon).
SELECT DISTINCT service_id 
FROM salarie; 

-- Nous pouvons fournir une plage de valeur dans notre filtre WHERE
-- Pour rechercher des termes spécifiques, nous utilisons le mot-clé IN
SELECT * 
FROM salarie
WHERE prenom IN ('Eren', 'Walter', 'Jasquier');  

SELECT * 
FROM salarie
WHERE age NOT IN (20, 25, 30); 

-- Pour rechercher un élément qui fait partie d'une plage de valeur, nous utilisons BETWEEN..AND...
SELECT *
FROM salarie
WHERE salaire BETWEEN 1500 AND 2500; -- Les valeurs données sont incluses.

SELECT *
FROM salarie
WHERE age NOT BETWEEN 20 AND 30;

-- Le LIKE permet d'effectuer une recherche sur une partie d'une chaine de caractere
SELECT *
FROM salarie
WHERE prenom LIKE 'J%';

SELECT *
FROM salarie
WHERE prenom LIKE 'J___';

SELECT *
FROM salarie
WHERE prenom LIKE '%g%';

-- ORDER BY
-- Permet d'ordonner le jeu de résultat par rapport à une ou plusieurs colonnes
-- de manière croissante (ASC) ou décroissante (DESC)
-- Par défaut: ASC, pas besoin de le préciser
SELECT * 
FROM salarie
ORDER BY prenom; 

SELECT * 
FROM salarie
ORDER BY age DESC; 

SELECT * 
FROM salarie
ORDER BY service_id, prenom; 

-- LIMIT 
-- Permet de limiter le nombre de résultat obtenue
SELECT prenom, salaire
FROM salarie
ORDER BY salaire DESC
LIMIT 3;

-- OFFSET permet de décaler le jeu de résultat que l'on récupère
SELECT prenom, salaire
FROM salarie
ORDER BY salaire DESC
LIMIT 3 OFFSET 3;


-- Fonction d'aggrégation et GROUP BY
-- Les fonctions d'aggrégation sont des fonctions pour effectuer des calculs sur nos enregistrements.
-- Attention, elle ne retourne qu'une seule valeur
-- MAX permet de récupérer la valeur maximum d'une colonne. 
-- MIN permet de récupérer la valeur minimum. 
SELECT MAX(salaire) AS salaire_maximum
FROM salarie; 

-- AVG() renvoie la moyenne des valeurs d'une colonne
-- SUM() renvoie la somme des valeurs d'une colonne
-- ROUND() permet d'arondir une valeur à l'entier le plus proche
SELECT ROUND(AVG(salaire)) AS salaire_moyen
FROM salarie;

-- Le GROUP BY va permettre de regrouper nos enregistrements selon une valeur identique d'une colonne.
SELECT AVG(salaire) AS salaire_moyen, service_id
FROM salarie
GROUP BY service_id;

-- COUNT permet de compter le nombre d'enregistrement basé sur la colonne précisé. 
-- Attention, il ne compte pas les valeurs a NULL
SELECT COUNT(*) AS nb_salarie, service_id
FROM salarie
GROUP BY service_id;

-- Le HAVING permet d'ajouter une condition à chaque groupe réalisé par le GROUP BY
SELECT AVG(age) AS age_moyen, service_id
FROM salarie
GROUP BY service_id
HAVING AVG(age) >= 30; 

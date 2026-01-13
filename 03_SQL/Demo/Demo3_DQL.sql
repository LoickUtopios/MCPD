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


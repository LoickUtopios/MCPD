-- 1) Sélectionnez tous les enregistrements où le métier est "Engineer"

SELECT *
FROM users
WHERE job IN ('Engineer'); 

-- 2) Sélectionnez les prénoms et les noms de famille des utilisateurs nés à Londres, Paris ou Berlin

SELECT last_name, first_name, location
FROM users
WHERE location IN ('London', 'Paris', 'Berlin'); 


-- 3) Sélectionnez les utilisateurs dont l'âge est compris entre 25 et 35 ans

SELECT *
FROM users
WHERE age BETWEEN 25 AND 35;

-- 4) Sélectionnez les utilisateurs qui sont à la fois des développeurs et dont le salaire est supérieur à 2500€

SELECT * 
FROM users
WHERE job IN ('Developer') AND salary > 2500; 


#### Bonus

-- 5) Sélectionner tous les enregistrements dont le métier ne soit ni 'Lawyer' ni 'Designer'.

SELECT * 
FROM users
WHERE job NOT IN ('Lawyer', 'Designer');

-- 6) Sélectionner les utilisateurs dont l'age ne soit pas compris entre 30 et 40 ans et dont le lieu de naissance est soit 'Tokyo' soit 'Los Angeles'

SELECT *
FROM users
WHERE (age NOT BETWEEN 30 AND 40) AND location IN ('Tokyo', 'Los Angeles'); 
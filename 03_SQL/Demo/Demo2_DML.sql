CREATE TABLE IF NOT EXISTS Services (
	service_id INT AUTO_INCREMENT PRIMARY KEY,
    libelle VARCHAR(255),
    date_creation DATETIME DEFAULT NOW()
);

CREATE TABLE IF NOT EXISTS Salarie (
  salarie_id INT AUTO_INCREMENT PRIMARY KEY,
  prenom VARCHAR(255) NOT NULL,
  nom VARCHAR(255) NOT NULL,
  age INT NOT NULL CHECK (age >= 18),
  salaire DECIMAL DEFAULT 1500.0,
  service_id INT NOT NULL,
  CONSTRAINT fk_service_id FOREIGN KEY (service_id) REFERENCES Services(service_id) 
); 

ALTER TABLE Salarie
DROP CONSTRAINT fk_service_id;

-- ------- INSERTION ------------

-- Pour insérer une valeur dans une table, nous utilisons la commande INSERT INTO
-- Si aucune parathèse n'a été mise, nous devons renseigner la totalité des champs.
INSERT INTO Services (libelle)
-- Le mot-clé VALUES, nous permet d'insérer les valeurs précisé dans le INSERT INTO
-- Attention l'ordre donnée doit être respecté
VALUES ('Informatique'); 

-- Nous pouvons insérer plusieurs valeurs d'un coup en les séparant par des ','
INSERT INTO Services (libelle, date_creation)
VALUES ('RH', '2025-01-01'), ('Comptabilite','2026-01-01'); 

-- Format TIMESTAMP (date-heure) : AAAA-MM-DD HH:mm:SS

-- ---------- MISE A JOUR --------------------

-- Cette commande permet ed retirer le safe mode pour les mises à jours et permettre
-- les modifications sans filtres (WHERE)
SET SQL_SAFE_UPDATES = 0;

-- Pour mettre à jour plusieurs enregistrement, nous utilisons le mot-clé UPDATE suivie de SET
UPDATE Services
-- Si aucun (WHERE) n'a été donnée, tout les enregistrements de la table seront modifié.
SET date_creation = '2026-01-10';

-- Pour mettre à jour plusieurs attibuts, il suffit de les préciser dans SET en les séparant par des ','
UPDATE Services
SET libelle = "Ressources Humaines", date_creation = '2026-01-01'
-- Avec le WHERE, nous pouvons 'filtrer' les enregistrements qui seront modifiés.
WHERE service_id = 2;

-- --------- SUPPRESSION ------------------

-- Pour supprimer un élément, nous utilisons le mot-clé DELETE FROM
DELETE FROM services
WHERE service_id = 3;

-- Attention en l'absence de WHERE, le DELETE va supprimer l'ensemble des enregistrements de la table.
DELETE FROM services; 

-- Le TRUNCATE effectue également une supression intégrale mais de façon performante MAIS irréversible
-- (il réinitialise tout les id)
TRUNCATE services; 



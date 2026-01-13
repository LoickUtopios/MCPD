CREATE TABLE Services (
	service_id INT AUTO_INCREMENT PRIMARY KEY,
    libelle VARCHAR(255) NOT NULL,
    date_creation DATE DEFAULT (CURRENT_DATE())
);

CREATE TABLE Employes (
	employe_id INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(255) NOT NULL,
    prenom VARCHAR(255) NOT NULL,
    service_id INT, 
    CONSTRAINT fk_service FOREIGN KEY (service_id) REFERENCES Services(service_id)
);

INSERT INTO Services (libelle)
VALUES ('Informatique');

INSERT INTO Services (libelle, date_creation)
VALUES ('Ressources Humaines', '2024-01-01');

INSERT INTO Services (libelle)
VALUES ('Marketing');

SET SQL_SAFE_UPDATES = 0;

UPDATE Services
SET libelle = "IT"
WHERE libelle = "Informatique";

UPDATE Services
SET date_creation = current_date()
WHERE libelle = 'Ressources Humaines';

DELETE FROM Services
WHERE service_id = 3;
-- WHERE libelle = 'Marketing'

DELETE FROM Services
WHERE date_creation < '2024-01-01'; 

INSERT INTO Employes (nom, prenom, service_id)
VALUES ("Martin", "Paul", 1), ("Dupont", "Claire", 1), ("Bernard", "Sophie", 2);

UPDATE Employes
SET nom = 'Martinez'
WHERE nom = 'Martin'; 

DELETE FROM Employes
WHERE prenom = 'Claire'; 
-- WHERE employe_id = 2; 
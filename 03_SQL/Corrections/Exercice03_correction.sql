CREATE TABLE clients (
	id_client INT PRIMARY KEY AUTO_INCREMENT,
    nom VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE Commandes (
	id_commande INT PRIMARY KEY AUTO_INCREMENT,
    date_commande DATE NOT NULL,
    montant DECIMAL (10,2) NOT NULL CHECK (montant >= 0),
    id_client INT NOT NULL,
    CONSTRAINT fk_client FOREIGN KEY (id_client) REFERENCES clients (id_client)
);
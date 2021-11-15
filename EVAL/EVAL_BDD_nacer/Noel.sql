DROP DATABASE IF EXISTS noel;
CREATE DATABASE noel DEFAULT CHARACTER SET utf8;
Use noel;



CREATE TABLE Enfants(
   IdEnfant INT AUTO_INCREMENT PRIMARY KEY,
   nom VARCHAR(50),
   prenom VARCHAR(50),
   adresseEnfant VARCHAR(200),
   sexe VARCHAR(10),
   voeu VARCHAR(100),
   sagesse DECIMAL(15,2),
   IdCadeau INT
   
) ENGINE=InnoDB;

CREATE TABLE Cadeaux(
   IdCadeau INT AUTO_INCREMENT PRIMARY KEY,
   designation VARCHAR(150)
   
) ENGINE=InnoDB;

CREATE TABLE Rennes(
   IdRenne INT AUTO_INCREMENT PRIMARY KEY,
   nom VARCHAR(50),
   sexe VARCHAR(10),
   dateDeNaissance VARCHAR(50)
   
) ENGINE=InnoDB;

CREATE TABLE Lutins(
   IdLutin INT AUTO_INCREMENT PRIMARY KEY,
   nom VARCHAR(50),
   prenom VARCHAR(50)
   
) ENGINE=InnoDB;;

CREATE TABLE Traineaux(
   IdTraineau INT AUTO_INCREMENT PRIMARY KEY,
   taille VARCHAR(5),
   dateMiseEnService DATE,
   dateDerniereRevision DATE,
   responsable VARCHAR(50)
  
)ENGINE=InnoDB;

CREATE TABLE Tournees(
   IdTournee INT AUTO_INCREMENT PRIMARY KEY,
   heureDepart DATETIME
   
) ENGINE=InnoDB;

CREATE TABLE Utilise(
   IdUtilise INT AUTO_INCREMENT PRIMARY KEY,
   IdLutin INT,
   IdTraineau INT,
   DateUtilisation DATE
   
) ENGINE=InnoDB;

CREATE TABLE Participe(
   IdParticipe INT AUTO_INCREMENT PRIMARY KEY,
   IdRenne INT,
   IdLutin INT,
   IdTraineau INT,
   IdTournee INT
    
) ENGINE=InnoDB;


CREATE TABLE Transporte(
   IdTransporte INT AUTO_INCREMENT PRIMARY KEY,
   IdCadeau INT,
   IdTraineau INT
   
) ENGINE=InnoDB;

ALTER TABLE Utilise 
ADD CONSTRAINT FK_Utilise_Lutin FOREIGN KEY(IdLutin) REFERENCES Lutins(IdLutin),
ADD CONSTRAINT FK_Utilise_Traineau FOREIGN KEY(IdTraineau) REFERENCES Traineaux(IdTraineau);

ALTER TABLE Participe
ADD CONSTRAINT FK_Participe_Renne  FOREIGN KEY(IdRenne) REFERENCES Rennes(IdRenne),
ADD CONSTRAINT FK_Participe_Lutin  FOREIGN KEY(IdLutin) REFERENCES Lutins(IdLutin),
ADD CONSTRAINT FK_Participe_Traineau FOREIGN KEY(IdTraineau) REFERENCES Traineaux(IdTraineau),
ADD CONSTRAINT FK_Participe_Tournee FOREIGN KEY(IdTournee) REFERENCES Tournees(IdTournee);

ALTER TABLE Transporte 
ADD CONSTRAINT FK_Transporte_Cadeau FOREIGN KEY(IdCadeau) REFERENCES Cadeaux(IdCadeau),
ADD CONSTRAINT FK_Transporte_Traineau FOREIGN KEY(IdTraineau) REFERENCES Traineaux(IdTraineau);

ALTER TABLE Enfants
ADD CONSTRAINT FK_Enfants_Cadeaux FOREIGN KEY(IdCadeau) REFERENCES Cadeaux(IdCadeau);
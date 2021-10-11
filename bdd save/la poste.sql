DROP DATABASE IF EXISTS Poste;
CREATE DATABASE Poste DEFAULT CHARACTER SET utf8;
USE Poste;

CREATE TABLE Bureaux(
   idBureau INT AUTO_INCREMENT PRIMARY KEY,
   codePostal VARCHAR(6) 
   
) ENGINE=InnoDB;

CREATE TABLE Types(
   idType INT AUTO_INCREMENT PRIMARY KEY,
   libelleType VARCHAR(50) 
   
) ENGINE=InnoDB;

CREATE TABLE Courriers(
   idCourrier INT AUTO_INCREMENT PRIMARY KEY,
   rueDestinataire VARCHAR(150)  NOT NULL,
   numDestintaire VARCHAR(5)  NOT NULL,
   rueEmetteur VARCHAR(150) ,
   numEmetteur VARCHAR(50) ,
   idType INT NOT NULL
   
   
) ENGINE=InnoDB;

CREATE TABLE Transports(
   idTransport INT AUTO_INCREMENT PRIMARY KEY,
   libelleTransport VARCHAR(50) ,
   taxeCarbonne INT
   
) ENGINE=InnoDB;

CREATE TABLE Centres_de_tri(
   idCentresDeTri INT AUTO_INCREMENT PRIMARY KEY,
   nomCentreDeTri VARCHAR(50) 
  
) ENGINE=InnoDB;

CREATE TABLE Achemine(
   idAchemine INT AUTO_INCREMENT PRIMARY KEY,
   idBureau INT,
   idTransport INT,
   idCentresDeTri INT
  
   
) ENGINE=InnoDB;

CREATE TABLE Gere(
   idGere INT AUTO_INCREMENT PRIMARY KEY,
   idBureau INT,
   idCourrier INT,
   dateEnvoi DATE,
   dateReception DATE
   
  
) ENGINE=InnoDB;

ALTER TABLE Achemine
ADD CONSTRAINT FK_Achemine_Bureaux
FOREIGN KEY (idBureau) REFERENCES Bureaux(idBureau),

ADD CONSTRAINT FK_Achemine_Transports
FOREIGN KEY (idTransport) REFERENCES Transports(idTransport),

ADD CONSTRAINT FK_Achemine_CentreTri
FOREIGN KEY (idCentresDeTri) REFERENCES Centres_de_tri(idCentresDeTri)

ALTER TABLE Gere 
ADD CONSTRAINT FK_Gere_Courriers
FOREIGN KEY (idCourrier) REFERENCES Courriers(idCourrier),

ADD CONSTRAINT FK_Gere_Bureaux
FOREIGN KEY (idBureau) REFERENCES Bureaux(idBureau)








DROP DATABASE IF EXISTS requetebase;
CREATE DATEBASE requetebase DEFAULT CHARACTER SET utf8;
USE requetebase;


CREATE TABLE DEPARTEMENT(
   nodep INT AUTO_INCREMENT PRIMARY KEY,
   nomdep VARCHAR(50),
   ville VARCHAR(50)
   
)ENGINE=InnoDB;

CREATE TABLE EMPLOYE(
   noemp INT AUTO_INCREMENT PRIMARY KEY,
   nomemp VARCHAR(50),
   fonction VARCHAR(50),
   noresp INT,
   datemb DATE,
   sala CURRENCY,
   comm CURRENCY,
   nodep INT NOT NULL
   
)ENGINE=InnoDB;

CREATE TABLE GRADE(
   nograde INT AUTO_INCREMENT PRIMARY KEY,
   salmin CURRENCY,
   salmax CURRENCY
  
)ENGINE=InnoDB;

CREATE TABLE HISTOFONCTION(
   noemp INT,
   date_nom DATE,
   Fonction VARCHAR(50)
   PRIMARY KEY (nomep,date_nom)
   
)ENGINE=InnoDB;

ALTER TABLE EMPLOYE 
ADD CONSTRAINT FK_EMPLOYE_DEPARTMENT FOREIGN KEY (nodep) REFERENCES DEPARTEMENT(nodep);
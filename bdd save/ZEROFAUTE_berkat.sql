DROP DATABASE IF EXISTS ZEROFAUTE;
CREATE DATABASE ZEROFAUTE DEFAULT CHARACTER utf8;
Use ZEROFAUTE;

CREATE TABLE modeles(
   idModele     INT AUTO INCREMENT PRIMARY KEY,
   codeAlphanumerique INT,
   nomModele VARCHAR(50),
   dateMiseEnMarché DATE
   
);

CREATE TABLE produits(
   Id_produit INT AUTO INCREMENT PRIMARY KEY,
   numSerie INT,
   numProduit VARCHAR(4),
   annéeProduction DATE,
   idModele INT NOT NULL

);

CREATE TABLE fautes(
   code int AUTO INCREMENT PRIMARY KEY,
   titre VARCHAR(50),
   dateDetection DATE,
   dateReparation DATE,
   commentaire VARCHAR(150),
   Id_produit INT NOT NULL
  
);

CREATE TABLE categories(
   Idcategorie INT AUTO INCREMENT PRIMARY KEY,
   nomCategorie VARCHAR(50),
   description VARCHAR(150)
  
);

CREATE TABLE sousCategories(
   IdsousCategorie INT AUTO INCREMENT PRIMARY KEY,
   nomSousCategorie VARCHAR(50),
   description VARCHAR(150),
   Idcategorie INT NOT NULL
  
);

CREATE TABLE classifié(
   code INT AUTO INCREMENT PRIMARY KEY,
   IdsousCategorie INT
   
);


ALTER TABLE classifié
ADD CONSTRAINT FK_classifié_sousCategorie
FOREIGN KEY (IdsousCategorie) REFERENCES sousCategories(IdsousCategorie),

ADD CONSTRAINT FK_classifié_fautes 
FOREIGN KEY (code) REFERENCES fautes(code)

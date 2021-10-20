-- a. Affichez la totalité de la table « client ».

SELECT * FROM client 

-- b. Affichez les noms de tous les clients.

SELECT nomClient FROM client 

-- c. Affichez les différentes dates de commandes sans répétition.

SELECT DISTINCT(dateCommande) FROM commandes

-- d. Affichez les clients qui se prénomment « sophie ».

SELECT prenomClient FROM clients 
WHERE prenomClient = "sophie"

-- e. Affichez les numéros des articles et leur quantité commandés par le client1.

SELECT A.descriptionArticle, C.quantiteCommande FROM articles as A
INNER JOIN commandes as C on C.idArticle= A.idArticle 
WHERE idClient = 1

-- f. Affichez les noms des clients en majuscules-.

SELECT UPPER(nomClient) FROM clients

-- g. Affichez les noms des clients avec la première lettre en majuscule.

SELECT CONCAT(UPPER(substring(nomClient,1,1)),(LOWER(substring(nomCLient,2,LENGTH(nomCLient)-1)))) as MAJ FROM clients 

-- h. Affichez les noms des clients qui ont 5caractères.

SELECT nomClient FROM clients
WHERE LENGTH(nomClient) = 5

-- i. Affichez les noms des clients qui commencent par « t » ou qui ont un « l » en troisième position.

SELECT nomClient FROM clients
WHERE nomClient like "t%" AND "__l%"
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
WHERE nomClient like "t%" AND nomCLient like "___l%"

-- j. Affichez le numéro de client, le numéro de commande, la date de commande et la date de paiement attendue des commandes (=date_cde+15jours).

SELECT C.idClient, idCommande, dateCommande, (dateCommande + INTERVAL 15 DAY) as datePaiement FROM clients as C
INNER JOIN commandes as Co on Co.idClient = C.idClient 

-- k. Affichez la date et l'heure actuelles.

SELECT NOW()

-- l. Affichez l'ancienneté des clients.

SELECT DATEDIFF( NOW(), dateEntreeClient) as anciennete FROM clients
GROUP BY anciennete DESC

-- m. Affichez la quantité maximale achetée par un client.

SELECT idClient, SUM(quantiteCommande) as totale FROM commandes
GROUP BY idClient

-- n. Affichez la quantité totale achetée par le client1.

SELECT C.idClient, SUM(quantiteCommande) FROM clients as C
INNER JOIN commandes as Co on Co.idCLient= C.idClient 
WHERE C.idClient = 2
GROUP BY idClient

-- o. Affichez la quantité moyenne achetée par le client 2.

SELECT C.idClient, AVG(quantiteCommande) FROM clients as C
INNER JOIN commandes as Co on Co.idCLient= C.idClient 
WHERE C.idClient = 2
GROUP BY idClient

-- p. Affichez les clients classés par ordre alphabétique de leur nom.

SELECT nomClient FROM clients
ORDER BY nomClient

-- q. Affichez les articles classés selon leur prix décroissant. 
SELECT idArticle, descriptionArticle, prixArticle FROM articles
ORDER BY prixArticle DESC
-- Il y a une nouvelle collone dans la table commandes
-- cde_total = quantitecommande-prixArticle

-- A)Afficher le montant le plus élevé de commande.

SELECT MAX(cde_total) FROM commandes 

-- B) Afficher le montant moyen des commandes.

SELECT AVG(cde_total) FROM commandes

-- C) Afficher le montant le plus bas de commande.

SELECT MIN(cde_total) FROM commandes

-- D) Afficher le nombre de commandes qui ont été passées.

SELECT SUM(quantitecommande) FROM commandes

-- E) Afficher le montant moyen de commande par client

SELECT AVG(cde_total), idClient FROM commandes
GROUP BY idClient

-- F) Afficher le montant le plus élevé de commande par client.

SELECT MAX(cde_total), idClient FROM commandes
GROUP BY idClient

-- G) Afficher le nombre de commandes par client.

SELECT SUM(quantitecommande), idClient FROM commandes
GROUP BY idClient

-- H) Afficher le nombre d 'articles commandés en moyenne par client

SELECT AVG(quantitecommande), idClient FROM commandes
GROUP BY idClient

-- I) Afficher le nombre d'articles commandés en moyenne par article.

SELECT AVG(quantitecommande), idArticle FROM commandes
GROUP BY idArticle

-- J) Afficher le nombre total d'articles commandés par article.

SELECT SUM(quantitecommande), idArticle FROM commandes
GROUP BY idArticle

-- K) Afficher le nombre moyen d'articles par client et par date.

SELECT AVG(quantitecommande), idClient, dateCommande FROM commandes
GROUP BY idClient, dateCommande

-- L) Afficher le nombre de commandes par jour.

SELECT datecommande, SUM(quantitecommande) FROM commandes
GROUP BY dateCommande

-- M) Afficher le nombre de clients dans la table.

SELECT COUNT(idClient) FROM commandes

-- N) Afficher le nombre de clients différents qui ont passé commande.

SELECT COUNT(DISTINCT(idClient)) FROM commandes

-- O) Afficher le nombre d' articles différents qui ont été commandés.

SELECT COUNT(DISTINCT(idArticle)) FROM commandes

-- P) Afficher le nombre de jours différents de commandes

SELECT COUNT(DISTINCT(dateCommande)) FROM commandes
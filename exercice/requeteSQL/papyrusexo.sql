-- 1. Quelles sont les commandes du fournisseur 09120 ?

SELECT * FROM entcom
WHERE numfou= 9120

-- 2. Afficher le code des fournisseurs pour lesquels des commandes ont été passées

SELECT DISTINCT numfou FROM entcom

-- 3. Afficher le nombre de commandes fournisseurs passées, et le nombre defournisseur concernés.

SELECT COUNT(DISTINCT numfou) as nbreFou, COUNT(*) as "numfou" FROM entcom

-- 4. Editer les produits ayant un stock inférieur ou égal au stock d'alerte et dont laquantité annuelle est inférieur est inférieure à 1000(informations à fournir : n° produit, libellé produit, stock, stock actuel d'alerte,quantité annuelle)

SELECT codart, libart, stkale, stkphy, qteann FROM produit 
WHERE stkphy < stkale

-- 5. Quels sont les fournisseurs situés dans les départements 75 78 92 77 ?L’affichage (département, nom fournisseur) sera effectué par départementdécroissant, puis par ordre alphabétique

SELECT nomfou, posfou FROM fournis 
WHERE substring(posfou,1,2)= "75" OR substring(posfou,1,2)= "78" OR substring(posfou,1,2)= "92" OR substring(posfou,1,2)= "77"
ORDER BY posfou, nomfou 

-- 6. Quelles sont les commandes passées au mois de mars et avril ?

SELECT numcom FROM ligcom
WHERE (MONTH(derliv)) in (3,4)

-- 7. Quelles sont les commandes du jour qui ont des observations particulières ? (Affichage numéro de commande, date de commande)

SELECT obscom, numcom FROM entcom 
WHERE DATE(datcom) = DATE( NOW()) AND obscom != ""
SELECT obscom, numcom FROM entcom 
WHERE obscom != "" AND datcom = CURDATE()

-- 8. Lister le total de chaque commande par total décroissant(Affichage numéro de commande et total)

SELECT SUM(qtecde*priuni) AS "somme", numcom FROM ligcom
GROUP BY numcom
ORDER BY somme DESC

-- 9. Lister les commandes dont le total est supérieur à 10 000€ ; on exclura dans lecalcul du total les articles commandés en quantité supérieure ou égale à 1000.(Affichage numéro de commande et total)

SELECT SUM(qtecde*priuni) AS "somme", numcom FROM ligcom
WHERE priuni < 1000 
HAVING SUM(qtecde*priuni) > 10000

-- 10. Lister les commandes par nom fournisseur(Afficher le nom du fournisseur, le numéro de commande et la date)

SELECT numfou, numcom, datcom FROM entcom
GROUP BY numfou

-- 11. Sortir les produits des commandes ayant le mot "urgent' en observation?(Afficher le numéro de commande, le nom du fournisseur, le libellé du produit et le sous total = quantité commandée * Prix unitaire)

SELECT E.numcom, numfou, libart, (qtecde*priuni) AS "sousTotal", obscom FROM entcom as E
INNER JOIN ligcom as L on E.numcom = L.numcom
INNER JOIN produit as P on P.codart = L.codart
WHERE obscom = "Commande urgente"

-- 12. Coder de 2 manières différentes la requête suivante : Lister le nom des fournisseurs susceptibles de livrer au moins un article




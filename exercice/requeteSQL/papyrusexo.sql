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
GROUP BY numcom
HAVING somme > 10000


-- 10. Lister les commandes par nom fournisseur(Afficher le nom du fournisseur, le numéro de commande et la date)

SELECT numfou, numcom, datcom FROM entcom
GROUP BY numfou

-- 11. Sortir les produits des commandes ayant le mot "urgent' en observation?(Afficher le numéro de commande, le nom du fournisseur, le libellé du produit et le sous total = quantité commandée * Prix unitaire)

SELECT E.numcom, numfou, libart, (qtecde*priuni) AS "sousTotal", obscom FROM entcom as E
INNER JOIN ligcom as L on E.numcom = L.numcom
INNER JOIN produit as P on P.codart = L.codart
WHERE obscom = "Commande urgente"

-- 12. Coder de 2 manières différentes la requête suivante : Lister le nom des fournisseurs susceptibles de livrer au moins un article

SELECT numfou, nomfou FROM ligcom as L
INNER JOIN entcom as E on E.numcom=L.numcom
INNER JOIN produit as P on P.nomfou=L.nomfou
WHERE (qtecde-qteliv) != 0 AND (qtecde-qteliv) > 0
GROUP BY numfou

-- 13

SELECT numcom, datcom, numfou FROM entcom as E
WHERE  numfou = ( SELECT numfou FROM entcom WHERE numcom = 70210)

-- 14 

SELECT V.prix1, P.libart FROM vente as V
INNER JOIN produit as P on P.codart=V.codart
WHERE stkphy>0 AND prix1 < (SELECT MIN(prix1) FROM vente as V INNER JOIN produit as P on P.codart=V.codart WHERE libart like "r%" )



--15

SELECT L.codart, E.numfou FROM ligcom as L
INNER JOIN entcom as E on E.numcom=L.numcom
INNER JOIN produit as P on P.codart=L.codart
WHERE (qtecde-qteliv) != 0 AND (qtecde-qteliv) > 0 AND stkphy <= ((150/100)*stkale)
ORDER BY codart,numfou

-- 16 

SELECT L.codart, E.numfou FROM ligcom as L
INNER JOIN entcom as E on E.numcom=L.numcom
INNER JOIN produit as P on P.codart=L.codart
INNER JOIN vente as V on V.codart=L.codart
WHERE (qtecde-qteliv) != 0 AND (qtecde-qteliv) > 0 AND stkphy <= ((150/100)*stkale) AND delliv > 30
ORDER BY codart,numfou

-- 17

SELECT E.numfou, SUM(P.stkphy) FROM ligcom as L
INNER JOIN entcom as E on E.numcom=L.numcom
INNER JOIN produit as P on P.codart=L.codart
INNER JOIN vente as V on V.codart=L.codart
GROUP BY numfou

-- 18 

SELECT L.codart FROM ligcom as L
INNER JOIN entcom as E on E.numcom=L.numcom
INNER JOIN produit as P on P.codart=L.codart
WHERE qtecde > ((90/100)*qteann) 

-- 19 

SELECT






-- 1. 

UPDATE vente
SET prix1= prix1 * (4/100), prix2= prix2 * (2/100)
WHERE numfou= 9180


-- 2.

UPDATE vente
SET prix2= 120
WHERE prix2= 0

-- 3. 

UPDATE entcom
INNER JOIN fournis on entcom.numfou=fournis.numfou
SET obscom= concat("****** ",obscom)
WHERE satisf < 5 

-- 4.

DELETE FROM produit 
WHERE codart = "I110"

-- 5.

DELETE FROM entcom
WHERE obscom= ""






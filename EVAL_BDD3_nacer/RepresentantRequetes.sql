--1.

SELECT * FROM clients

--2.

SELECT IdProduit, NomProduit, CouleurProduit, PoidsProduit FROM produits
WHERE CouleurProduit="Rouge" AND PoidsProduit>2000

--3.

SELECT R.NomRepres, SUM(Quantite) FROM ventes as V 
INNER JOIN representants as R on R.IdRepres=V.IdRepres
GROUP BY R.NomRepres
HAVING SUM(Quantite)>=1
ORDER BY R.NomRepres

--4.

SELECT C.IdClient, NomClient, VilleClient, SUM(Quantite) FROM clients as C
INNER JOIN ventes as V on V.Idclient=C.IdClient
WHERE VilleClient="Paris"
GROUP BY C.IdClient
HAVING SUM(Quantite)>180

--5.

SELECT NomRepres, NomClient, CouleurProduit, Quantite FROM ventes as V
INNER JOIN clients as C on V.IdClient=C.IdClient
INNER JOIN produits as P on P.IdProduit=V.IdProduit
INNER JOIN representant as R on R.IdRepres=V.IdRepres
WHERE CouleurProduit="Rouge"
GROUP BY Nomrepres
HAVING Quantite>100

--6.

SELECT V.IdProduit, SUM(Quantite), NomProduit FROM ventes as V
INNER JOIN Produits as P on V.IdProduit=P.IdProduit
GROUP BY NomProduit

--7.

SELECT v.IdClient, NomClient , SUM(Quantite) as "sommeParClient" FROM ventes as v
INNER JOIN clients as c on c.IdClient=v.IdClient
GROUP BY v.IdClient
HAVING SUM(Quantite) > (SELECT AVG(Quantite) FROM ventes)

--8.

CREATE VIEW vue AS 
SELECT     V.IdVente,
           V.IdRepres,
           V.IdProduit,
           V.IdClient,
           V.Quantite,               	  
    	   C.NomClient,
    	   C.VilleClient
FROM ventes as V 
INNER JOIN clients as C on C.IdClient=V.IdClient
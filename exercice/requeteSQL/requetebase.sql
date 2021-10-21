--1.

SELECT nomdep FROM DEPARTEMENT 

--2.

SELECT nodep, nomdep FROM DEPARTEMENT 

--3.
SELECT * FROM EMPLOYE

--4.

SELECT fonction FROM EMPLOYE 

--5.

SELECT DISTINCT fonction FROM EMPLOYE 

--6.

SELECT nomemp, datemb, (datemb + INTERVAL 1 DAY) as "datemb+1" FROM EMPLOYE 

--7.

SELECT CONCAT(nomemp," ",fonction) FROM EMPLOYE 

-- B

--1.

SELECT nodep, nomemp FROM EMPLOYE 
WHERE nodep= 30

--2.

SELECT noemp, nomemp FROM EMPLOYE 
WHERE fonction = "ouvrier"

--3.

SELECT nomemp, noemp FROM EMPLOYE 
WHERE noemp >= 30

--4.

SELECT nomemp, sala, comm FROM EMPLOYE 
WHERE comm > sala

--5.

SELECT nomemp, sala FROM EMPLOYE 
WHERE sala > 1500 AND nodep= 30 AND fonction = "vendeur"
GROUP BY nomemp

--6.

SELECT nomemp, sala, fonction FROM EMPLOYE
WHERE fonction= "directeur" OR fonction="president"

--7.

SELECT nomemp, fonction, sala FROM EMPLOYE
WHERE fonction= "directeur" OR sala > 2500

--8.

SELECT nomemp, noemp FROM EMPLOYE
WHERE (fonction= "directeur" OR fonction="presidents") AND nodep= 10
GROUP BY nomemp

--9.

SELECT nomemp, fonction, nodep FROM EMPLOYE
WHERE (fonction != "ouvriers" OR fonction != "directeurs") AND nodep=10 

--10.

SELECT nomemp, fonction, noemp FROM EMPLOYE
WHERE fonction= "directeurs" AND fonction not in (SELECT fonction FROM EMPLOYE WHERE nodep=30)

--11.

SELECT nomemp, fonction, sala FROM EMPLOYE
WHERE sala BETWEEN 1200 AND 1300

--12.

SELECT nomemp, nodep, fonction FROM EMPLOYE
WHERE fonction != "directeur"

--13.

SELECT nomemp FROM EMPLOYE
WHERE fonction != "vendeur"

--14.

SELECT nomemp FROM EMPLOYE
WHERE nomemp like "C%"

--15.

SELECT nomemp FROM EMPLOYE
WHERE comm = ""
GROUP BY nomemp

--16.

SELECT nomemp FROM EMPLOYE
WHERE nodep=30 OR nodep=20 AND comm != ""
GROUP BY nomemp

--C.

--1.

SELECT sala, fonction, nomemp FROM EMPLOYE
WHERE nodep = 30 
GROUP BY nomemp
ORDER BY sala ASC 

--2.

SELECT sala, fonction, nomemp FROM EMPLOYE
WHERE nodep = 30 
GROUP BY nomemp
ORDER BY sala DESC 

--3.

SELECT nomemp, fonction, sala FROM EMPLOYE
ORDER BY fonction, sala DESC 

--4.

SELECT comm, sala, nomemp FROM test
ORDER BY comm

--5.

SELECT comm, sala ,nomemp FROM test
ORDER BY comm DESC 

--D

--1.

SELECT nomemp, ville FROM test
WHERE nomemp= "Costanza"

--2.

SELECT nomemp, fonction, nomdep, nodep FROM test
WHERE nodep = 30 OR nodep= 40

--3.

SELECT 

--4.

SELECT nomemp, sala, noresp FROM test
WHERE sala > (SELECT sala FROM test as t WHERE test.noresp = t.noemp)

--5.

SELECT nomemp, sala, fonction FROM test
WHERE sala > (SELECT sala FROM test WHERE nomemp= "Perou")

--E

--1.

SELECT nomemp, sala, comm, (sala+comm) as "revenu" FROM test

--2.

SELECT nomemp, sala, comm FROM test
WHERE comm > 0.25*sala

--3.

SELECT nomemp, fonction FROM test 
WHERE fonction = "Vendeur"
ORDER BY (comm/sala) DESC

--4.

SELECT (sala*12+comm) as revenuAnnuel, fonction, nomemp FROM test
WHERE fonction= "Vendeur" 

--5.

SELECT ROUND(sala/30) revenuQuotidien,fonction, nomemp FROM test
WHERE fonction= "Vendeur"

--6.

SELECT AVG(sala), fonction FROM test
WHERE fonction= "Ouvrier"

--7.

SELECT SUM(sala) SommeSalaire, SUM(comm) SommeCommission, fonction FROM test
WHERE fonction= "Vendeur"

--8.

SELECT AVG(sala*12+comm) as revenuAnnuel, fonction, nomemp FROM test
WHERE fonction= "Vendeur" 

--9.

SELECT MIN(sala) SalaireMIN, MAX(sala) SalireMAX, (MAX(sala)-MIN(sala)) Ecart FROM test

--10.

SELECT COUNT(noemp), nodep FROM test 
WHERE nodep= 30

--F

--1.

SELECT AVG(sala) SalaireMoyen, nodep FROM test
GROUP BY nodep

--2

SELECT AVG(sala*12) as SalaireAnnuelMoyen, fonction, nodep FROM test
WHERE fonction != "Directeur" AND fonction != "President" 
GROUP BY nodep

--3.

SELECT COUNT(noemp) NombreEmploye, AVG(sala*12) as SalaireAnnuelMoyen, fonction, nodep FROM test
GROUP BY fonction, nodep

--4.

SELECT AVG(sala*12) as SalaireAnnuelMoyen, fonction, 





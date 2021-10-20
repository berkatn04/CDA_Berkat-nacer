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

SELECT nomemp, datemb, (datemb + INTERVAL 1 DAY) as datemb+1 FROM EMPLOYE 

--7.

SELECT CONCAT(nomemp,"",fonction) FROM EMPLOYE 

-- B

--1.

SELECT nodep, nomemp FROM EMPLOYE 
WHERE nodep= 30

--2.

SELECT noemp, nomemp FROM EMPLOYE 
WHERE fonction = "ouvriers"

--3.

SELECT nomemp, noemp FROM EMPLOYE 
WHERE noemp >= 30

--4.

SELECT nomemp, sala, comm FROM EMPLOYE 
WHERE comm > sala

--5.

SELECT nomemp, sala FROM EMPLOYE 
WHERE sala > 1500 AND nodep= 30 AND fonction = "vendeurs"

--6.

SELECT nomemp, sala, fonctions FROM EMPLOYE
WHERE fonction= "directeurs" OR fonction="presidents"

--7.

SELECT nomemp, fonction, sala FROM EMPLOYE
WHERE fonction= "directeurs" OR salaire > 2500

--8.

SELECT nomemp, noemp FROM EMPLOYE
WHERE (fonction= "directeur" OR fonction="presidents") AND nodep= 10

--9.

SELECT nomemp, fonction, nodep FROM EMPLOYE
WHERE fonction != "ouvriers" OR fonction != "directeurs" AND nodep=10 

--10.

SELECT nomemp, fonction, noemp FROM EMPLOYE
WHERE fonction= "directeurs" AND fonction not in (SELECT fonction FROM EMPLOYE WHERE nodep=30)

--11.

SELECT nomemp, fonction, sala FROM EMPLOYE
WHERE sala BETWEEN 1200 AND 1300

--12.

SELECT nomemp, nodep, fonction FROM EMPLOYE
WHERE fonctions != "directeur"*

--13.

SELECT nomemp FROM EMPLOYE
WHERE fonction != "vendeur"

--14.

SELECT nomemp FROM EMPLOYE
WHERE nomemp like "C%"

--15.

SELECT nomemp FROM EMPLOYE
WHERE comm = ""

--16.

SELECT nomemp FROM EMPLOYE
WHERE nodep=30 OR nodep=20 AND comm != ""

--C.

--1.

SELECT sala, fonction, nomemp FROM EMPLOYE
WHERE fonction = 30 
ORDER BY sala ASC 

--2.

SELECT sala, fonction, nomemp FROM EMPLOYE
WHERE fonction = 30 
ORDER BY sala DESC 

--3.


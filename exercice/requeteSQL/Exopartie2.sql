-- 1/Rechercher le prénom des employés et le numéro de la région de leur département. 

SELECT prenom, noregion, nodep FROM employe
INNER JOIN dept ON employe.nodep = dept.nodept

-- 2/Rechercher le numéro du département, le nom du département, le nom des employés classés par numéro de département (renommer les tables utilisées). 

SELECT nodept, dept.nom as nomDept, employe.nom as nomEmp FROM dept 
INNER JOIN employe ON dept.nodept = employe.nodep
ORDER BY nodept

-- 3/Rechercher le nom des employés du département Distribution. 

SELECT nodept, employe.nom as nomEmp, dept.nom as nomDept FROM dept 
INNER JOIN employe ON dept.nodept = employe.nodep
WHERE dept.nom= "distribution"

-- 4/Rechercher le nom et le salaire des employés qui gagnent plus que leur patron, et le nom et le salaire de leur patron. 

Select employe.nom, employe.salaire, boss.nom, boss.salaire
from employe inner join employe as boss on employe.nosup = boss.noemp
where employe.salaire>boss.salaire

-- 5/Rechercher le nom et le titre des employés qui ont le même titre que Amartakaldire. 

SELECT nom, titre FROM employe
WHERE titre in (SELECT titre FROM employe WHERE nom="Amartakaldire" )

-- 6/Rechercher le nom, le salaire et le numéro de département des employés qui gagnent plus qu'un seul employé du département 31, classés par numéro de département et salaire. 

SELECT nom, salaire, nodep FROM employe
WHERE salaire > (SELECT MIN(salaire) FROM employe WHERE nodep = 31)
ORDER BY nodep, salaire

-- 7/Rechercher le nom, le salaire et le numéro de département des employés qui gagnent plus que tous les employés du département 31, classés par numéro de département et salaire. 

SELECT nom, salaire, nodep FROM employe
WHERE salaire > (SELECT MAX(salaire) FROM employe WHERE nodep = 31) 
ORDER BY nodep, salaire
-- 8/Rechercher le nom et le titre des employés du service 31 qui ont un titre que l'on trouve dans le département 32.

SELECT nom, titre, nodep FROM employe 
WHERE nodep = 31 AND titre in (SELECT titre FROM employe WHERE nodep=32)

-- 9/Rechercher le nom et le titre des employés du service 31 qui ont un titre l'on ne trouve pas dans le département 32.

SELECT nom, titre, nodep FROM employe 
WHERE nodep = 31 AND titre NOT in (SELECT titre FROM employe WHERE nodep=32)

-- 10/Rechercher le nom, le titre et le salaire des employés qui ont le même titre et le même salaire que Fairant. 

SELECT nom, titre, salaire FROM employe
WHERE NOT nom = 'Fairent'AND titre,salaire = (SELECT titre, salaire FROM employe WHERE nom = 'Fairent')

-- 11/ Calculer le nombre d'employés de chaque titre. 

SELECT titre, COUNT(*)
 FROM emp
 GROUP BY titre
 

--  12/ Calculer la moyenne des salaires et leur somme, par région.

SELECT employe.nodep, AVG(salaire), salaire, noregion FROM employe
INNER JOIN dept ON employe.nodep = dept.nodep
GROUP BY noregion

-- 13/ Afficher les numéros des départements ayant au moins 3 employés. 

SELECT nodep, COUNT(noemp) as "nomEmploye", noregion FROM employe
INNER JOIN dept ON employe.nodep = dept.nodept
GROUP BY noregion
HAVING COUNT(noemp)> 3

-- 14/ Afficher les lettres qui sont l'initiale d'au moins trois employés. 

SELECT nomemp, COUNT(substring(nom,1,1)) FROM employe
GROUP BY nomemp
HAVING COUNT(substring(nom,1,1)) > 3

-- 15/ Rechercher le salaire maximum et le salaire minimum parmi tous les salariés et l'écart entre les deux.

SELECT MAX(salaire) as "salaireMAX", MIN(salaire) as "salaireMIN", (MAX(salaire)-MIN(salaire)) as "salaireDIFF" FROM employe

-- 16/ Rechercher le nombre de titres différents. 

SELECT COUNT(DISTINCT(titre)) as "nbreTitre" FROM employe

-- 17 Pour chaque titre, compter le nombre d'employés possédant ce titre

SELECT DISTINCT titre, nom, COUNT(nom) FROM employe
GROUP BY titre

-- 18/ Pour chaque nom de département, afficher le nom du département et le nombre d'employés.

SELECT dept.nom, COUNT(nom) FROM employe
INNER JOIN dept ON employe.nodep = dept.nodept











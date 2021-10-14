-- Rechercher le prénom des employés et le numéro de la région de leur département. 

SELECT prenom, noregion, nodep FROM employe
INNER JOIN dept ON employe.nodep = dept.nodept

-- Rechercher le numéro du département, le nom du département, le nom des employés classés par numéro de département (renommer les tables utilisées). 

SELECT nodept, dept.nom as nomDept, employe.nom as nomEmp FROM dept 
INNER JOIN employe ON dept.nodept = employe.nodep
ORDER BY nodept

-- Rechercher le nom des employés du département Distribution. 

SELECT nodept, employe.nom as nomEmp, dept.nom as nomDept FROM dept 
INNER JOIN employe ON dept.nodept = employe.nodep
WHERE dept.nom= "distribution"

-- Rechercher le nom et le salaire des employés qui gagnent plus que leur patron, et le nom et le salaire de leur patron. 

SELECT nom, salaire FROM employee 
WHERE 

-- Rechercher le nom et le titre des employés qui ont le même titre que Amartakaldire. 

SELECT nom, titre FROM employe
WHERE titre in (SELECT titre FROM employe WHERE nom="Amartakaldire" )

-- Rechercher le nom, le salaire et le numéro de département des employés qui gagnent plus qu'un seul employé du département 31, classés par numéro de département et salaire. 

SELECT nom, salaire, nodep FROM employe
WHERE salaire > (SELECT MIN(salaire) FROM employe WHERE nodep = 31)

-- Rechercher le nom, le salaire et le numéro de département des employés qui gagnent plus que tous les employés du département 31, classés par numéro de département et salaire. 

SELECT nom, salaire, nodep FROM employe
WHERE salaire > (SELECT MAX(salaire) FROM employe WHERE nodep = 31) 

--Rechercher le nom et le titre des employés du service 31 qui ont un titre que l'on trouve dans le département 32.

SELECT nom, titre, nodep FROM employe 
WHERE nodep = 31 AND titre in (SELECT titre FROM employe WHERE nodep=32)

-- Rechercher le nom et le titre des employés du service 31 qui ont un titre l'on ne trouve pas dans le département 32.

SELECT nom, titre, nodep FROM employe 
WHERE nodep = 31 AND titre NOT in (SELECT titre FROM employe WHERE nodep=32)

-- Rechercher le nom, le titre et le salaire des employés qui ont le même titre et le même salaire que Fairant. 
SELECT nom, titre, salaire FROM employe 
WHERE titre = (SELECT titre FROM employe WHERE nom= "fairent") AND salaire = ( SELECT salaire)




























-- 1. Calculer le nombre d'employés de chaque titre. 

SELECT titre, COUNT(*)
 FROM emp
 GROUP BY titre
 

--  2. Calculer la moyenne des salaires et leur somme, par région.

SELECT employe.nodep, AVG(salaire), salaire, noregion FROM employe
INNER JOIN dept ON employee.nodep = dept.nodep
GROUP BY noregion

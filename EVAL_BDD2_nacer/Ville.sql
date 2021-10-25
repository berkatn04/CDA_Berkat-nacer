--1.

SELECT ville_nom FROM villes_france
WHERE LENGTH(ville_nom) > 40

--2.

SELECT departement_code, departement_nom FROM departements
WHERE substring(departement_code,1,2) IN ("97")

--3.

SELECT departement_nom, departement_regionId FROM departements
WHERE departement_regionId = 7
ORDER BY departement_nom

--4.

SELECT ville_departement, departement_nom, ville_population_2012 FROM villes_france AS V
INNER JOIN departements as D on D.departement_code=V.ville_departement
GROUP BY ville_departement
ORDER BY ville_population_2012 DESC

--5.

SELECT departement_nom, departement_code, COUNT(ville_id) as nombreCommunes FROM villes_france as V
INNER JOIN departements as D on D.departement_code= V.ville_departement
GROUP BY departement_code  
ORDER BY nombreCommunes DESC

--6.

SELECT departement_nom, ROUND(SUM(ville_surface)) as superficie FROM villes_france as V
INNER JOIN departements as D on D.departement_code= V.ville_departement
GROUP BY departement_nom

--7.

SELECT COUNT(ville_id) as nombreVille FROM villes_france
WHERE substring(ville_nom_simple,1,5) in ("Saint")


--8.

SELECT ville_nom, COUNT(ville_nom) as nbreRecurence FROM villes_france
GROUP BY ville_nom
HAVING nbreRecurence > 2
ORDER BY nbreRecurence DESC

--9.

SELECT ville_nom, ville_surface FROM villes_france
GROUP BY ville_nom
HAVING ville_surface > AVG(ville_surface)

--10.

SELECT departement_nom, ville_population_2012 FROM villes_france AS V
INNER JOIN departements as D on D.departement_code=V.ville_departement
WHERE ville_population_2012 > 1500000

--11.

UPDATE villes_france 
SET ville_nom = REPLACE(ville_nom, "-", " ")

--12.

SELECT ville_nom, ville_surface FROM villes_france
ORDER BY ville_surface 
LIMIT 50

--13.

ALTER TABLE regions
ADD region_nbDepartement INT

--14.

DELIMITER $$
CREATE PROCEDURE MajRegion()
UPDATE regions
SET region_nbDepartement= 0 $$
DELIMITER ;

--15.

CREATE VIEW vue AS
SELECT
    D.departement_id, 
    D.departement_code, 
    D.departement_nom, 
    D.departement_nom_uppercase, 
    D.departement_slug, 
    D.departement_nom_soundex, 
    D.departement_regionId,
    R.region_nom,
    R.region_nbDepartement,
    V.ville_id,
    V.ville_slug,
    V.ville_nom,
    V.ville_nom_simple,
    V.ville_nom_reel,
    V.ville_nom_soundex,
    V.ville_nom_metaphone,
    V.ville_code_postal,
    V.ville_commune,
    V.ville_code_commune,
    V.ville_arrondissement,
    V.ville_canton,
    V.ville_amdi,
    V.ville_population_2010,
    V.ville_population_1999,
    V.ville_population_2012,
    V.ville_densite_2010,
    V.ville_surface,
    V.ville_longitude_deg,
    V.ville_latitude_deg,
    V.ville_longitude_grd,
    V.ville_latitude_grd,
    V.ville_longitude_dms,
    V.ville_latitude_dms,
    V.ville_zmin,
    V.ville_zmax

FROM departements as D 
INNER JOIN villes_france as V on D.departement_code= V.ville_departement
INNER JOIN regions as R on R.region_id=D.departement_regionId


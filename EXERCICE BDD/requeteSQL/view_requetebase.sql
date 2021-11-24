
CREATE VIEW test as
SELECT
    e.noemp,
    e.nomemp,
    e.fonction,
    e.noresp,
    e.datemb,
    e.sala,
    e.comm,
    e.nodep,
    d.nomdep,
    d.ville
FROM
    employe as e
INNER JOIN departement as d on d.nodep=e.nodep
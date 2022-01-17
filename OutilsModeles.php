<?php

/**
 * Undocumented function
 *
 * @param string $table
 * @param [type] $nomId
 * @param [type] $colonne  peut etre plusieurs colonne à concatener separé par une virgule
 * @param [type] $filtres sous forme de tableau
 * @param [type] $api  recoit true ou false
 * @return 
 */
function creerRequete($table, $nomId, $colonne, $filtres, $api)
{
    $table=ucfirst($table);
    $db = DbConnect::getDb();
    $flag = false;
    $liste = [];
    $requete = 'SELECT DISTINCT ' . $nomId . ',' . $colonne . ' FROM amb_' . $table;
    foreach ($filtres as $filtre => $elt) {
        if ($elt != "" && $elt != "null")
        //Le flag sert à ne pas mettre le "And" la première fois et à mettre WHERE la première fois
        {
            if ($flag) {
                $requete .= " AND ";
            } else {
                $requete .= " WHERE ";
            }
            $flag = true;
            if (is_array($elt)) {
                $requete .= $filtre . ' IN("' . (implode('","', $elt)) . '")';
            } else {
                $requete .= $filtre . " = " . '"' . $elt . '"';
            }
        }
    }
    $requete .= " order by " . $colonne;
    //var_dump($requete);
    $q = $db->query($requete);
    while ($donnees = $q->fetch(PDO::FETCH_ASSOC)) {
        if ($donnees != false) {
            if ($api) {
                $liste[] = $donnees;
            } else {

                $liste[] = new $table($donnees);
            }
        }
    }
    return $liste;
}


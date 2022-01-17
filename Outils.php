<?php

/*fonctions du projet*/

/**
 * Fonction qui renvoi la liste necessaire a la creation du select
 * @array : contient la la liste des colonnes
 */
function appelGetList($nomTable)
{
    $methode = ucfirst($nomTable) . "Manager::getList";
    return call_user_func($methode);
}

/**
 * Fonction qui renvoi l'objet renvoyé par l'appel de la methode formé de Get et de la chaine de caractere
 * @obj : contient l'objet sur lequel porte l'appel
 * @chaine : contient la partie de la methode apres le get
 * ex: chaine="libelle" on appele la méthode $obj->getLibelle()
 *
 * @chaine peut être un tableau qui contient 2 informations à concatener
 */
function appelGet($obj, $chaine)
{
    if (is_string($chaine)) {
        $methode = 'get' . ucfirst($chaine);
        return call_user_func(array($obj, $methode));
    } else {
        $methode1 = 'get' . ucfirst($chaine[0]);
        $methode2 = 'get' . ucfirst($chaine[1]);
        return call_user_func(array($obj, $methode1)) . "." . call_user_func(array($obj, $methode2));
    }
}

/**
 * Crée un select à partir des informations 
 *
 * @param int $valeur
 * @param string $table
 * @param string $nomId
 * @param string $colonne string contenant les différentes colonnes séparés par des ,
 * @param string $mode
 * @param string $attribut
 * @param array $filtres  sous forme de tableau
 * @param boolean $api   recoit true or false
 * @return string
 */
function optionSelectAvecFiltres($valeur, $table, $nomId, $colonne, $mode, $attribut, $filtres, $api)
{
    $select = '<select id="' . $nomId . '" name="' . $nomId . '"';
    if ($mode == "details" || $mode == "supprimer") {
        $select .= " disabled ";
    }
    $select .= $attribut . '>';
    $liste = creerRequete($table, $nomId, $colonne, $filtres, $api);
    if ($valeur == null) { // si le code est null, on ne mets pas de choix par défaut avec valeur
        $select .= '<option value="" SELECTED>Choisir une valeur</option>';
    }
    else{
        $select .= '<option value="">Choisir une valeur</option>';
    }
    foreach ($liste as $elt) {
        $colonnes = explode(",", $colonne);
        $content = "";
        foreach ($colonnes as $value) {
            $content .= appelGet($elt, $value) . " ";
        }
        if ($valeur == appelGet($elt, $nomId)) //appel de la methode stockée dans $method
        { // si le code entré en paramètre est égale à l'élément alors c'est celui qui est selectionné
            $select .= '<option value="' . appelGet($elt, $nomId) . '" SELECTED>' . $content . '</option>';
        } else {
            $select .= '<option value="' . appelGet($elt, $nomId) . '">' . $content . '</option>';
        }
    }
    $select .= "</select>";
    return $select;
}

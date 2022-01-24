<?php
var_dump($_POST);
$p = new TypeProduits($_POST);
var_dump($p);
switch ($_GET['mode']) {
    case "Ajouter": {
            TypeProduitsManager::add($p);
            break;
        }
    case "Modifier": {

            TypeProduitsManager::update($p);
            break;
        }
    case "Supprimer": {

            TypeProduitsManager::delete($p);
            break;
        }
}

header("location:index.php?page=listeTypePrduits");
<?php
var_dump($_POST);
$p = new Articles($_POST);
var_dump($p);
switch ($_GET['mode']) {
    case "Ajouter": {
            ArticlesManager::add($p);
            break;
        }
    case "Modifier": {

            ArticlesManager::update($p);
            break;
        }
    case "Supprimer": {

            ArticlesManager::delete($p);
            break;
        }
}

header("location:index.php?page=listeArticle");

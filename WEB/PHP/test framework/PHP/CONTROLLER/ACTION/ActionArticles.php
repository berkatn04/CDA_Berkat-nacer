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

if (!$erreur) {  // si pas d'erreur
    header("location:index.php?page=listeCategorie");   //redirection directe
} else {
    header("refresh:3;url=index.php?page=listeArticles");    // on attend 3 secondes avant la redirection
}
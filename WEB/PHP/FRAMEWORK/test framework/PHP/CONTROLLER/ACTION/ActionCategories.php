<?php
$erreur = false;
 //var_dump($_POST);
$p = new Categories($_POST);
 // var_dump($p);
switch ($_GET['mode']) {
    case "Ajouter": {
            CategoriesManager::add($p);
            break;
        }
    case "Modifier": {
            CategoriesManager::update($p);
            break;
        }
    case "Supprimer": {
            $listeArticle = ArticlesManager::getListByCategorie($p->getIdCategories());
            /**** Technique informative */
            //    if (count($listeArticle)>0)
            //    {
            //        echo 'Il reste des Articles';
            //        $erreur=true;

            //    }
            //    else{
            //     CategoriesManager::delete($p);
            //    }

            /**** Technique de suppression en cascade */
            foreach ($listeArticle as $unArticle) {
                ArticlesManager::delete($unArticle);
            }
            CategoriesManager::delete($p);
            break;
        }
}

if (!$erreur) {  // si pas d'erreur
    header("location:index.php?page=listeCategorie");   //redirection directe
} else {
    header("refresh:3;url=index.php?page=listeCategorie");    // on attend 3 secondes avant la redirection
}

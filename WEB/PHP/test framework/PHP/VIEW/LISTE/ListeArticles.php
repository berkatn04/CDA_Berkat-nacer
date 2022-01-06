<?php
$liste = ArticlessManager::getList();
?>
<div class="demiPage colonne">
    <div id="crudBarreOutil">
        <a class=" crudBtn crudBtnOutil" href='index.php?page=formArticles&mode=Ajouter'>Ajouter </a>
    </div>
    <div id="crudTableau">

        <div class="crudColonne">Libellé</div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <?php foreach ($liste as $elt) {
            echo '<div class="crudColonne">' . $elt->getLibelleArticles() . '</div>
            <div></div>    
            <a class=" crudBtn crudBtnEditer" href="index.php?page=formArticles&mode=Editer&id='. $elt->getIdArticles().'">Afficher </a>
                <a class=" crudBtn crudBtnModifier" href="index.php?page=formArticles&mode=Modifier&id='.$elt->getIdArticles().'">Modifier</a>
                <a class=" crudBtn crudBtnSupprimer" href="index.php?page=formArticles&mode=Supprimer&id='. $elt->getIdArticles().'">Supprimer</a>
            ';
        } ?>

    </div>
</div>
<?php
$liste = TypeProduitsManager::getList();
?>
<div class="demiPage colonne">
    <div id="crudBarreOutil">
        <a class=" crudBtn crudBtnOutil" href='index.php?page=formTypeProduits&mode=Ajouter'>Ajouter </a>
    </div>
    <div id="crudTableau">

        <div class="crudColonne">Libellé</div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>

        <?php foreach ($liste as $elt) {

            echo '<div class="crudColonne">' . $elt->getLibelleTypeProduits() . '</div>
                <div></div>
                <a class=" crudBtn crudBtnEditer" href="index.php?page=formTypeProduits&mode=Editer&id=' . $elt->getIdTypeProduits() . '">Afficher </a>
                <a class=" crudBtn crudBtnModifier" href="index.php?page=formTypeProduits&mode=Modifier&id=' . $elt->getIdTypeProduits() . '">Modifier</a>
                <a class=" crudBtn crudBtnSupprimer" href="index.php?page=formTypeProduits&mode=Supprimer&id=' . $elt->getIdTypeProduits() . '">Supprimer</a>
             ';
        } ?>

    </div>

</div>
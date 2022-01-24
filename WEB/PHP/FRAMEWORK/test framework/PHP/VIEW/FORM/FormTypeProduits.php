<?php
$mode = $_GET['mode'];
echo '<div class="demiPage colonne">';
echo '<div id="DivSousTitre">';


$disabled = " ";
switch ($mode) {
    case "Editer":
    case "Supprimer":
        $disabled = " disabled ";
        break;
}
echo '  <h5>'.$mode.' un Type de Produit</h5></div>
        <form id="formulaire" method="post" action="index.php?page=actionTypeProduit&mode='.$mode.'">';

if (isset($_GET['id'])) {
    $categ = TypeProduitsManager::findById($_GET['id']);
}
else{
    $categ = new TypeProduits();
}

echo '  <input type="hidden" name="idTypeProduit" value="' . $categ->getIdTypeProduits() . '">';
echo '  <label> Libelle :</label>
        <input type="text" name="libelleTypeProduit" value="' . $categ->getLibelleTypeProduits() . '"' .$disabled.'>';
echo '<input type="submit" value="'.$mode.'" class=" crudBtn crudBtn'.$mode.'"/>';

echo '<a href="index.php?page=listeTypeProduit" class=" crudBtn crudBtnRetour">Annuler</a>
</form>';
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
echo '  <h5>'.$mode.' une catégorie</h5></div>
        <form id="formulaire" method="post" action="index.php?page=actionCategorie&mode='.$mode.'">';

if (isset($_GET['id'])) {
    $categ = CategoriesManager::findById($_GET['id']);
    $idType = $categ->getIdTypeProduits();
}
else{
    $categ = new Categories();
    $idType = null;
}

$listeType = TypeProduitsManager::getList();

echo '  <input type="hidden" name="idCategorie" value="' . $categ->getIdCategories() . '">';
echo '  <label> Libelle :</label>
        <input type="text" name="libelleCategorie" value="' . $categ->getLibelleCategorie() . '"' .$disabled.'>';
echo '  <label> TypeProduits :</label>
        <select name="idCategorie" '.$disabled.'>';

        foreach ($listeType as $unType) {
    $sel = "";
    if ($uneCategorie->getIdTypeProduits() == $idCateg) {
        $sel = "selected";
    }

    echo '<option value="' . $unType->getIdTypeProduits() . '" ' . $sel . ' >' . $unType->getLibelleTypeProduits() . '</option>';
}

echo '
    </select>
    </div>';

    echo '<div class="ligneDetail"><input type="submit" value="' . $mode . '" class=" crudBtn crudBtn' . $mode . '"/>';

echo '<a href="index.php?page=listeCategorie" class=" crudBtn crudBtnRetour">Annuler</a>
</form>';
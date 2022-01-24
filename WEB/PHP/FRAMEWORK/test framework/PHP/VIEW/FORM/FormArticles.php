<?php
$mode = $_GET['mode'];
echo '<div class="demiPage colonne">';
echo '<div id="DivSousTitre" >';

$disabled = " ";
switch ($mode) {
    case "Editer":
    case "Supprimer":
        $disabled = " disabled ";
        break;
}

echo '<h5>' . $mode . ' un nouveau Article</h5></div>
<form id="formulaire" method="post" action="index.php?page=actionArticle&mode=' . $mode . '">';
if (isset($_GET['id'])) {
    $prod = ArticlesManager::findById($_GET['id']);
    $idCateg = $prod->getIdCategories();
} else {
    $prod = new Articles();
    $idCateg = null;
}

$listeCateg = CategoriesManager::getList();

// on crée les inputs du formulaire
// il faut que les name des input correspondent aux attributs de la class
// si on a les informations (cas Editer, Modifier, supp) on les mets à jour
echo '  <input type="hidden" name="idArticles" value="' . $prod->getIdArticle() . '">';
echo '  <label> Libelle :</label>
        <input type="text" name="libelleArticles" value="' . $prod->getLibelleArticle() . '"' . $disabled . '>';
echo '  <label>QuantiteStockee :</label>
        <input type="date" name="QuantiteStockee" value="' . $prod->getQuantiteStockee() . '"' . $disabled . '>';
echo '  <label>Categories :</label>
        <select name="idCategories" '.$disabled.'>';
foreach ($listeCateg as $uneCategories) {
    $sel = "";
    if ($uneCategories->getIdCategories() == $idCateg) {
        $sel = "selected";
    }

    echo '<option value="' . $uneCategories->getIdCategories() . '" ' . $sel . ' >' . $uneCategories->getLibelleCategorie() . '</option>';
}

echo '
    </select>
    </div>';

echo '<div class="ligneDetail"><input type="submit" value="' . $mode . '" class=" crudBtn crudBtn' . $mode . '"/>';
echo '<a href="index.php?page=listeArticles" class=" crudBtn crudBtnRetour">Annuler</a>

</form>';
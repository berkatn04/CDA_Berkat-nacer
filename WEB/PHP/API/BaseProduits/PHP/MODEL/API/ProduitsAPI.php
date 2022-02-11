<?php
$categ=$_POST['categ'];
echo json_encode(creerSelect(null,"Produits",["LibelleProduit"],"",["idCategorie"=>$categ]));
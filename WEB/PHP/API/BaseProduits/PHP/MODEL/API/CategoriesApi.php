<?php
//$categ=$_POST['categ'];
// $test=json_decode($_POST['toto']);
// //var_dump($test);
// echo $test->un;
//echo json_encode(MavueManager::getList(null,["idCategorie"=>$categ],null,null,true,false));
//echo JSON_encode(creerSelect(1,"Produits",["LibelleProduit"]));
//echo json_encode(MavueManager::getList(["libelleProduit"],["idCategorie"=>$categ],null,null,true,false));
echo json_encode(creerSelect(null,"Categories",["libelleCategorie"]));
//echo json_encode(MavueManager::getList());

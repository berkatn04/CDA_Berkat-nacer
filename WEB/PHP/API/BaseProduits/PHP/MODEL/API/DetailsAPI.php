<?php
$details=$_POST['details'];
$elm = (ProduitsManager::findById($details));
var_dump($elm);


echo '<div>'.$elm->getLibelleProduit().'</div>';
echo '<div>'.$elm->getPrix().'</div>';
echo '<div>'.$elm->getDateDePeremption().'</div>';
echo '<div>'.$elm->getIdCategorie().'</div>';
echo '<div>'.$elm->getImage().'</div>';
<?php
//  $r = new Regions(["libelleRegion"=>"test","numeroRegion"=>3]);
//  var_dump(RegionsManager::add($r));
//   $r = RegionsManager::findById(15);
//  $r2 = RegionsManager::findById(16);
 //$r->setLibelleRegion("toto");
// var_dump($r);
 //var_dump(RegionsManager::update($r));
// var_dump( RegionsManager::delete($r));
//$d = DepartementsManager::getList(null,["idRegion"=>7,"LibelleDepartement"=>"%i%"],"libelleDepartement DESC",null,true,true);
//$d = DepartementsManager::getList(["numeroDepartement"],["idRegion" =>1],"libelleDepartement",null,true,true);
$s = optionSelectAvecFiltres(20,'departements', ['libelleDepartement'], 'class="jsp');
echo $s;

<?php
include "Employé.class.php";
include "Agence.class.php";

$a1 = new Agence(["Nom" => "pole emploi", "Adresse" => "145 rue jspfrr", "codePostale" => 62300, "Ville" => "Lens", false]);
$a2 = new Agence(["Nom" => "Aarouss", "Adresse" => "145 rue jspfrr", "codePostale" => 62300, "Ville" => "Lens"], true);

$e1[] = new Employes(["Nom" => "Aarouss", "Prenom" => "Sofiane", "dateEmbauche" => new DateTime("01-12-2000"), "fonction" => "Eleveur de punaise", "salaireAnnuel" => "14", "Service" => "Nettoyage"]);
$e[] = new Employes(["Nom" => "Courquin", "Prenom" => "Pierre", "dateEmbauche" => new DateTime("12-03-2006"), "fonction" => "Gynecologue", "salaireAnnuel" => "40", "Service" => "Medecine"]); 
$e[] = new Employes(["Nom" => "Rjeb", "Prenom" => "Zied", "dateEmbauche" => new DateTime("15-09-2015"), "fonction" => "Kebabiste", "salaireAnnuel" => "30", "Service" => "Restauration"]);
$e[] = new Employes(["Nom" => "Balair", "Prenom" => "Quentin", "dateEmbauche" => new DateTime("03-03-2003"), "fonction" => "Plaquiste", "salaireAnnuel" => "20", "Service" => "batiment"]);
$e[] = new Employes(["Nom" => "Cugny", "Prenom" => "Maxime", "dateEmbauche" => new DateTime("27-08-2007"), "fonction" => "Homme de menage", "salaireAnnuel" => "50", "Service" => "Nettoyage"]);

echo 'Il y a '.count($e).' employés dans l\'entreprise';

//echo '<div>Avant Tri</div>';
foreach ($e1 as $key => $value) {
    echo '<div>'.$value->toString();
    echo 'prime : '.$value->primeAnnuelle().'</div>';
}
// usort($e,array("Employes","compareToNomPrenom"));

// echo '<div>Apres Tri</div>';
// foreach ($e as $key => $value) {
//     echo '<div>'.$value->toString();
//     echo 'prime : '.$value->primeAnnuelle().'</div>';
// }

//echo $a1->ToString();
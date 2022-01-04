<?php

class Employes
{

    /*****************Attributs***************** */
    private $_nom;
    private $_prenom;
    private $_dateEmbauche;
    private $_fonction;
    private $_salaireAnnuel;
    private $_service;
    private $_agence;

    /*****************Accesseurs***************** */

    public function getNom()
    {
        return $this->_nom;
    }

    public function setNom($nom)
    {
        $this->_nom = $nom;
    }

    public function getPrenom()
    {
        return $this->_prenom;
    }

    public function setPrenom($prenom)
    {
        $this->_prenom = $prenom;
    }

    public function getDateEmbauche()
    {
        return $this->_dateEmbauche;
    }

    public function setDateEmbauche(DateTime $dateEmbauche)
    {
        $this->_dateEmbauche = $dateEmbauche;
    }

    public function getFonction()
    {
        return $this->_fonction;
    }

    public function setFonction($fonction)
    {
        $this->_fonction = $fonction;
    }

    public function getSalaireAnnuel()
    {
        return $this->_salaireAnnuel;
    }

    public function setSalaireAnnuel($salaireAnnuel)
    {
        $this->_salaireAnnuel = $salaireAnnuel;
    }

    public function getService()
    {
        return $this->_service;
    }

    public function setService($service)
    {
        $this->_service = $service;
    }

    public function getAgence()
    {
        return $this->_agence;
    }

    public function setAgence($agence)
    {
        $this->_agence = $agence;
    }

    /*****************Constructeur***************** */

    public function __construct(array $options = [])
    {
        if (!empty($options)) // empty : renvoi vrai si le tableau est vide
        {
            $this->hydrate($options);
        }
    }
    public function hydrate($data)
    {
        foreach ($data as $key => $value) {
            $methode = "set" . ucfirst($key); //ucfirst met la 1ere lettre en majuscule
            if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
            {
                $this->$methode($value);
            }
        }
    }

    /*****************Autres Méthodes***************** */
    public function toString()
    {
        $aff = "";
        $aff .= "Nom :" . $this->getNom() . "\nPrenom :" . $this->getPrenom() . "\nDateEmbauche :" . $this->getDateEmbauche()->format('Y-m-d') . "\nPosteEntreprise :" . $this->getFonction() . "\nSalaire annuel :" . $this->getSalaireAnnuel() . "K€\nService :" . $this->getService() 
        . '\nChequeVacance :' . $this->ChequeVac();
        return $aff;
    }
    /**
     * Compare 2 objets sur le nom et le prénom
     * Renvoi 1 si le 1er est >
     *        0 si ils sont égaux
     *        -1 si le 1er est <
     *
     * @param [type] $obj1
     * @param [type] $obj2
     * @return int
     */
    public static function compareToNomPrenom($obj1, $obj2)
    {
        if ($obj1->getNom() < $obj2->getNom()) {
            return -1;
        } else if ($obj1->getNom() > $obj2->getNom()) {
            return 1;
        } else if ($obj1->getPrenom() < $obj2->getPrenom()) {
            return -1;
        } else if ($obj1->getPrenom() > $obj2->getPrenom()) {
            return 1;
        }

        return 0;
    }

    function anciennete()
    {
        $dateJour = new DateTime("now");
        $interval = $dateJour->diff($this->getDateEmbauche(), true);
        $annee = $interval->format("%y") * 1;  // on multiplie par 1 pour obtenir un int
        return $annee;
    }

    private function primeSalaire()
    {
        return $this->getSalaireAnnuel() * 0.05;
    }

    private function primeAnciennete()
    {
        return $this->getSalaireAnnuel() * 0.02 * $this->anciennete();
    }

    function primeAnnuelle()
    {
        return $this->primeAnciennete() + $this->primeSalaire();
    }

    function ChequeVac()
        {
            if ($this->anciennete() >= 1)
            {
                return "L'employe bénéficie de chèques vacances";
            }
            return "L'employe ne bénéficie pas de chèques vacances";

        }




}

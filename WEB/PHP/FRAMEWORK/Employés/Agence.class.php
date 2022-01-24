<?php 
class Agence
{

private $_nom;
private $_adresse;
private $_codePostale;
private $_ville;
private $_restaurant;
 

public function getNom()
{
return $this->_nom;
}

public function setNom($nom)
{
$this->_nom = $nom;
}

public function getAdresse()
{
return $this->_adresse;
}

public function setAdresse($adresse)
{
$this->_adresse = $adresse;
}

public function getCodePostale()
{
return $this->_codePostale;
}

public function setCodePostale($codePostale)
{
$this->_codePostale = $codePostale;
}

public function getVille()
{
return $this->_ville;
}

public function setVille($ville)
{
$this->_ville = $ville;
}





public function __construct(array $options = [])
    {
        if (!empty($options))
        {
            $this->hydrate($options);
        }
    }

    
   
    public function hydrate($data)
    {
        foreach ($data as $key => $value) {
            $methode = "set" . ucfirst($key); 
            if (is_callable(([$this, $methode]))) 
            {
                $this->$methode($value);
            }
        }
    }

    public function toString()
    {
        $aff = "";
        $aff .= "Nom :" . $this->getNom() . "\nAdresse :" . $this->getAdresse() . "\nCodePostale :" . $this->getCodePostale() . "\nVille :" . $this->getVille() . "\nRestauration  :" . $this->ModeRestauration() ;
        return $aff;
    }

    public function ModeRestauration()
        {
            return $this->_restaurant ? "Restaurant disponible" : "Tickets restaurant";
        }





}
?>
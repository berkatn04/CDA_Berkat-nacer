<?php

class TypeProduits
{

	/*****************Attributs***************** */

	private $_idTypeProduits;
	private $_LibelleTypeProduit;

	public function getIdTypeProduits()
	{
		return $this->_idTypeProduits;
	}

	public function setIdTypeProduits($idTypeProduits)
	{
		$this->_idTypeProduits = $idTypeProduits;
	}

	public function getLibelleTypeProduit()
	{
		return $this->_LibelleTypeProduit;
	}

	public function setLibelleTypeProduit($LibelleTypeProduit)
	{
		$this->_LibelleTypeProduit = $LibelleTypeProduit;
	}

    public function __construct(array $options = [])
	{
 		if (!empty($options)) // empty : renvoi vrai si le tableau est vide
		{
			$this->hydrate($options);
		}
	}
	public function hydrate($data)
	{
 		foreach ($data as $key => $value)
		{
 			$methode = "set".ucfirst($key); //ucfirst met la 1ere lettre en majuscule
			if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
			{
				$this->$methode($value);
			}
		}
	}


}
    
<?php

class Categories 
{

	/*****************Attributs***************** */

	private $_idCategories;
	private $_libelleCategorie;
    private $_idTypesProduits;

	/***************** Accesseurs ***************** */


	public function getIdCategories()
	{
		return $this->_idCategories;
	}

	public function setIdCategories($idCategories)
	{
		$this->_idCategories=$idCategories;
	}

	public function getlibelleCategorie()
	{
		return $this->_libelleCategorie;
	}

	public function setlibelleCategorie($libelleCategorie)
	{
		$this->_libelleCategorie=$libelleCategorie;
	}

    public function getIdTypesProduits()
    {
        return $this->_idTypesProduits;
    }

    public function setIdTypesProduits($idTypesProduits)
    {
        $this->_idTypesProduits = $idTypesProduits;
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
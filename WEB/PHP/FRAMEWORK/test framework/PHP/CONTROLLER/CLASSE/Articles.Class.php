<?php

class Articles
{

	/*****************Attributs***************** */

	private $_idArticle;
	private $_LibelleArticle;
    private $_quantiteStockee;
    private $_idCategories;

	/***************** Accesseurs ***************** */
    public function getIdArticle()
	{
		return $this->_idArticle;
	}

	public function setIdArticle($idArticle)
	{
		$this->_idArticle = $idArticle;
	}

    
	public function getLibelleArticle()
	{
		return $this->_LibelleArticle;
	}

	public function setLibelleArticle($LibelleArticle)
	{
		$this->_LibelleArticle = $LibelleArticle;
	}

    public function getQuantiteStockee()
    {
        return $this->_quantiteStockee;
    }

    public function setQuantiteStockee($quantiteStockee)
    {
        $this->_quantiteStockee = $quantiteStockee;
    }

    public function getIdCategories()
    {
        return $this->_idCategories;
    }

    public function setIdCategories($idCategories)
    {
        $this->_idCategories = $idCategories;
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
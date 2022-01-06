<?php

class CategoriesManager 
{
	public static function add(Categories $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("INSERT INTO Categories (LibelleCategorie) VALUES (:LibelleCategorie,:idTypesProduits)");
		// vérifier qu'il ne contient pas de ;
		$q->bindValue(":LibelleCategorie", $obj->getLibelleCategorie(), PDO::PARAM_STR);
        $q->bindValue(":idTypesProduits", $obj->getidTypesProduits(), PDO::PARAM_INT);

		$q->execute();
	}

	public static function update(Categories $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("UPDATE Categories SET LibelleCategorie=:LibelleCategorie, idTypesProduits=:idTypesProduits WHERE idCategorie=:idCategories");
		$q->bindValue(":idCategories", $obj->getIdCategories(), PDO::PARAM_INT);
		$q->bindValue(":LibelleCategorie", $obj->getLibelleCategorie(),PDO::PARAM_STR);
        $q->bindValue(":idTypesProduits", $obj->getidTypesProduits(), PDO::PARAM_INT);
		$q->execute();
	}
	public static function delete(Categories $obj)
	{
 		$db=DbConnect::getDb();
		$id = (int) $obj->getIdCategorie(); // permet de bloquer les injections SQL
		$db->exec("DELETE FROM Categories WHERE idCategories=" .$id);
	}
	public static function findById($id)
	{
 		$db=DbConnect::getDb();
		$id = (int) $id;
		$q=$db->query("SELECT * FROM Categories WHERE idCategories =".$id);
		$results = $q->fetch(PDO::FETCH_ASSOC);
		if($results != false)
		{
			return new Categories($results);
		}
		else
		{
			return false;
		}
	}
	public static function getList()
	{
 		$db=DbConnect::getDb();
		$liste = [];
		$q = $db->query("SELECT * FROM Categories");
		while($donnees = $q->fetch(PDO::FETCH_ASSOC))
		{
			if($donnees != false)
			{
				$liste[] = new Categories($donnees);
			}
		}
		return $liste;
	}
}
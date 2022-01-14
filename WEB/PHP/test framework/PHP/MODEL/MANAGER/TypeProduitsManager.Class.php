<?php

class TypeProduitsManager 
{
	public static function add(TypeProduits $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("INSERT INTO TypeProduits (LibelleTypeProduits) VALUES (:LibelleTypeProduits)");
		// vérifier qu'il ne contient pas de ;
		$q->bindValue(":LibelleTypeProduits", $obj->getLibelleTypeProduits(), PDO::PARAM_STR);
		$q->execute();
	}

	public static function update(TypeProduits $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("UPDATE TypeProduits SET LibelleTypeProduits=:LibelleTypeProduits WHERE idTypeProduits=:idTypeProduits");
		$q->bindValue(":idTypeProduits", $obj->getIdTypeProduits(), PDO::PARAM_INT);
		$q->bindValue(":LibelleTypeProduits", $obj->getLibelleTypeProduits(),PDO::PARAM_STR);
		$q->execute();
	}
	public static function delete(TypeProduits $obj)
	{
 		$db=DbConnect::getDb();
		$id = (int) $obj->getIdTypeProduits(); // permet de bloquer les injections SQL
		$db->exec("DELETE FROM TypeProduits WHERE IdTypeProduits=" .$id);
	}
	public static function findById($id)
	{
 		$db=DbConnect::getDb();
		$id = (int) $id;
		$q=$db->query("SELECT * FROM TypeProduits WHERE IdTypeProduits =".$id);
		$results = $q->fetch(PDO::FETCH_ASSOC);
		if($results != false)
		{
			return new TypeProduits($results);
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
		$q = $db->query("SELECT * FROM TypeProduits");
		while($donnees = $q->fetch(PDO::FETCH_ASSOC))
		{
			if($donnees != false)
			{
				$liste[] = new TypeProduits($donnees);
			}
		}
		return $liste;
	}
}
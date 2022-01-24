<?php
class ArticlesManager
{
    public static function add(Articles $obj)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("INSERT INTO Articles (LibelleArticle,QuantiteStockee,idCategories) VALUES (:LibelleArticle,:QuantiteStockee,:idCategories)");
        $q->bindValue(":LibelleArticle", $obj->getLibelleArticle());
        $q->bindValue(":QuantiteStockee", $obj->getQuantiteStockee());
        $q->bindValue(":idCategories", $obj->getIdCategories());
        $q->execute();
    }

    public static function update(Articles $obj)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("UPDATE Articles SET LibelleArticle=:LibelleArticle, QuantiteStockee=:QuantiteStockee, idCategorie=:idCategorie WHERE idArticles=:idArticles");
        $q->bindValue(":LibelleArticle", $obj->getLibelleArticle());
        $q->bindValue(":QuantiteStockee", $obj->getQuantiteStockee());
        $q->bindValue(":idCategories", $obj->getIdCategories());
        $q->bindValue(":idArticle", $obj->getIdArticle());
        $q->execute();
    }

    public static function delete(Articles $obj)
    {
        $db = DbConnect::getDb();
        $db->exec("DELETE FROM Articles WHERE idArticle=" . $obj->getIdArticle());
    }

    public static function findById($id)
    {
        $db = DbConnect::getDb();
        $id = (int) $id;  // on verifie que id est numerique, evite l'injection SQL
        $q = $db->query("SELECT * FROM Articles WHERE idArticle=" . $id);
        $results = $q->fetch(PDO::FETCH_ASSOC);
        if ($results != false)
        {
            return new Articles($results);
        }
        else
        {
            return false;
        }
    }

    public static function getList()
    {
        $db = DbConnect::getDb();
        $liste = [];
        $q = $db->query("SELECT * FROM Articles");
        while ($donnees = $q->fetch(PDO::FETCH_ASSOC))
        {
            if ($donnees != false)
            {
                $liste[] = new Articles($donnees);
            }
        }
        return $liste;  // tableau contenant les objets Articles
    }

    public static function getListByCategorie($idCategorie)
    {
        $idCategorie=(int) $idCategorie;
        $db = DbConnect::getDb();
        $liste = [];
        $q = $db->query("SELECT * FROM Articles where idCategories=$idCategorie");
        while ($donnees = $q->fetch(PDO::FETCH_ASSOC))
        {
            if ($donnees != false)
            {
                $liste[] = new Articles($donnees);
            }
        }
        return $liste;  // tableau contenant les objets Articles
    }
}
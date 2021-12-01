-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: stock
-- ------------------------------------------------------
-- Server version	5.7.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `stock`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `stock` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `stock`;

--
-- Table structure for table `articles`
--

DROP TABLE IF EXISTS `articles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `articles` (
  `IdArticle` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleArticle` varchar(100) DEFAULT NULL,
  `QuantiteStockee` int(11) DEFAULT NULL,
  `IdCategories` int(11) NOT NULL,
  PRIMARY KEY (`IdArticle`),
  KEY `FK_Article_Categories` (`IdCategories`),
  CONSTRAINT `FK_Article_Categories` FOREIGN KEY (`IdCategories`) REFERENCES `categories` (`IdCategories`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `articles`
--

LOCK TABLES `articles` WRITE;
/*!40000 ALTER TABLE `articles` DISABLE KEYS */;
INSERT INTO `articles` VALUES (1,'Pates',30,6),(2,'Jeu enfant +2 ans',5,3),(3,'Cassoulet',46,4),(4,'Antibact\'',94,2),(5,'Frites surgelées',24,5),(6,'Mustela',64,1);
/*!40000 ALTER TABLE `articles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categories` (
  `IdCategories` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleCategorie` varchar(100) DEFAULT NULL,
  `IdTypeProduits` int(11) NOT NULL,
  PRIMARY KEY (`IdCategories`),
  KEY `FK_Categories_TypeProduits` (`IdTypeProduits`),
  CONSTRAINT `FK_Categories_TypeProduits` FOREIGN KEY (`IdTypeProduits`) REFERENCES `typeproduits` (`IdTypeProduits`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'bébé',3),(2,'détergents',3),(3,'Jouet',2),(4,'Conserve',1),(5,'surgelés',1),(6,'non perissable',1),(7,'bébé',3),(8,'détergents',3),(9,'Jouet',2),(10,'Conserve',1),(11,'surgelés',1),(12,'non perissable',1);
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `typeproduits`
--

DROP TABLE IF EXISTS `typeproduits`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `typeproduits` (
  `IdTypeProduits` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleTypeProduit` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdTypeProduits`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `typeproduits`
--

LOCK TABLES `typeproduits` WRITE;
/*!40000 ALTER TABLE `typeproduits` DISABLE KEYS */;
INSERT INTO `typeproduits` VALUES (1,'Alimentaire'),(2,'non Alimentaire'),(3,'Hygiène'),(4,'Alimentaire'),(5,'non Alimentaire'),(6,'Hygiène'),(7,'Alimentaire'),(8,'non Alimentaire'),(9,'Hygiène');
/*!40000 ALTER TABLE `typeproduits` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-01 17:20:03

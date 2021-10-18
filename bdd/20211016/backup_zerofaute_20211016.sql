-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: zerofaute
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
-- Current Database: `zerofaute`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `zerofaute` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `zerofaute`;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categories` (
  `Idcategorie` int(11) NOT NULL AUTO_INCREMENT,
  `nomCategorie` varchar(50) DEFAULT NULL,
  `description` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`Idcategorie`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classifié`
--

DROP TABLE IF EXISTS `classifié`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `classifié` (
  `code` int(11) NOT NULL AUTO_INCREMENT,
  `IdsousCategorie` int(11) DEFAULT NULL,
  PRIMARY KEY (`code`),
  KEY `FK_classifié_sousCategorie` (`IdsousCategorie`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classifié`
--

LOCK TABLES `classifié` WRITE;
/*!40000 ALTER TABLE `classifié` DISABLE KEYS */;
/*!40000 ALTER TABLE `classifié` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fautes`
--

DROP TABLE IF EXISTS `fautes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fautes` (
  `CODE` int(11) NOT NULL AUTO_INCREMENT,
  `titre` varchar(50) DEFAULT NULL,
  `dateDetection` date DEFAULT NULL,
  `dateReparation` date DEFAULT NULL,
  `commentaire` varchar(150) DEFAULT NULL,
  `Id_produit` int(11) NOT NULL,
  PRIMARY KEY (`CODE`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fautes`
--

LOCK TABLES `fautes` WRITE;
/*!40000 ALTER TABLE `fautes` DISABLE KEYS */;
/*!40000 ALTER TABLE `fautes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modeles`
--

DROP TABLE IF EXISTS `modeles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `modeles` (
  `idModele` int(11) NOT NULL AUTO_INCREMENT,
  `codeAlphanumerique` int(11) DEFAULT NULL,
  `nomModele` varchar(50) DEFAULT NULL,
  `dateMiseEnMarché` date DEFAULT NULL,
  PRIMARY KEY (`idModele`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modeles`
--

LOCK TABLES `modeles` WRITE;
/*!40000 ALTER TABLE `modeles` DISABLE KEYS */;
/*!40000 ALTER TABLE `modeles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produits`
--

DROP TABLE IF EXISTS `produits`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produits` (
  `Id_produit` int(11) NOT NULL AUTO_INCREMENT,
  `numSerie` int(11) DEFAULT NULL,
  `numProduit` varchar(4) DEFAULT NULL,
  `annéeProduction` date DEFAULT NULL,
  `idModele` int(11) NOT NULL,
  PRIMARY KEY (`Id_produit`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produits`
--

LOCK TABLES `produits` WRITE;
/*!40000 ALTER TABLE `produits` DISABLE KEYS */;
/*!40000 ALTER TABLE `produits` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `souscategories`
--

DROP TABLE IF EXISTS `souscategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `souscategories` (
  `IdsousCategorie` int(11) NOT NULL AUTO_INCREMENT,
  `nomSousCategorie` varchar(50) DEFAULT NULL,
  `description` varchar(150) DEFAULT NULL,
  `Idcategorie` int(11) NOT NULL,
  PRIMARY KEY (`IdsousCategorie`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `souscategories`
--

LOCK TABLES `souscategories` WRITE;
/*!40000 ALTER TABLE `souscategories` DISABLE KEYS */;
/*!40000 ALTER TABLE `souscategories` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-16 17:20:01

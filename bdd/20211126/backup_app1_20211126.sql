-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: app1
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
-- Current Database: `app1`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `app1` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `app1`;

--
-- Table structure for table `entite1`
--

DROP TABLE IF EXISTS `entite1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `entite1` (
  `IdEntite1` int(32) NOT NULL AUTO_INCREMENT,
  `NomEntite1` varchar(250) NOT NULL,
  `IdEntite2` int(32) NOT NULL,
  PRIMARY KEY (`IdEntite1`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entite1`
--

LOCK TABLES `entite1` WRITE;
/*!40000 ALTER TABLE `entite1` DISABLE KEYS */;
INSERT INTO `entite1` VALUES (1,'a',1),(2,'az',1);
/*!40000 ALTER TABLE `entite1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entite2`
--

DROP TABLE IF EXISTS `entite2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `entite2` (
  `IdEntite2` int(32) NOT NULL AUTO_INCREMENT,
  `NomEntite2` varchar(250) NOT NULL,
  PRIMARY KEY (`IdEntite2`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entite2`
--

LOCK TABLES `entite2` WRITE;
/*!40000 ALTER TABLE `entite2` DISABLE KEYS */;
INSERT INTO `entite2` VALUES (1,'azerty'),(2,'azertyuiop');
/*!40000 ALTER TABLE `entite2` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-11-26 10:45:02

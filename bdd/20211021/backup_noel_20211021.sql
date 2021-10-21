-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: noel
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
-- Current Database: `noel`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `noel` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `noel`;

--
-- Table structure for table `cadeaux`
--

DROP TABLE IF EXISTS `cadeaux`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cadeaux` (
  `IdCadeau` int(11) NOT NULL AUTO_INCREMENT,
  `designation` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`IdCadeau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cadeaux`
--

LOCK TABLES `cadeaux` WRITE;
/*!40000 ALTER TABLE `cadeaux` DISABLE KEYS */;
/*!40000 ALTER TABLE `cadeaux` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enfants`
--

DROP TABLE IF EXISTS `enfants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enfants` (
  `IdEnfant` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `adresseEnfant` varchar(200) DEFAULT NULL,
  `sexe` varchar(10) DEFAULT NULL,
  `voeu` varchar(100) DEFAULT NULL,
  `sagesse` decimal(15,2) DEFAULT NULL,
  `IdCadeau` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdEnfant`),
  KEY `FK_Enfants_Cadeaux` (`IdCadeau`),
  CONSTRAINT `FK_Enfants_Cadeaux` FOREIGN KEY (`IdCadeau`) REFERENCES `cadeaux` (`IdCadeau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enfants`
--

LOCK TABLES `enfants` WRITE;
/*!40000 ALTER TABLE `enfants` DISABLE KEYS */;
/*!40000 ALTER TABLE `enfants` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lutins`
--

DROP TABLE IF EXISTS `lutins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lutins` (
  `IdLutin` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdLutin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lutins`
--

LOCK TABLES `lutins` WRITE;
/*!40000 ALTER TABLE `lutins` DISABLE KEYS */;
/*!40000 ALTER TABLE `lutins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `participe`
--

DROP TABLE IF EXISTS `participe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `participe` (
  `IdParticipe` int(11) NOT NULL AUTO_INCREMENT,
  `IdRenne` int(11) DEFAULT NULL,
  `IdLutin` int(11) DEFAULT NULL,
  `IdTraineau` int(11) DEFAULT NULL,
  `IdTournee` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdParticipe`),
  KEY `FK_Participe_Renne` (`IdRenne`),
  KEY `FK_Participe_Lutin` (`IdLutin`),
  KEY `FK_Participe_Traineau` (`IdTraineau`),
  KEY `FK_Participe_Tournee` (`IdTournee`),
  CONSTRAINT `FK_Participe_Lutin` FOREIGN KEY (`IdLutin`) REFERENCES `lutins` (`IdLutin`),
  CONSTRAINT `FK_Participe_Renne` FOREIGN KEY (`IdRenne`) REFERENCES `rennes` (`IdRenne`),
  CONSTRAINT `FK_Participe_Tournee` FOREIGN KEY (`IdTournee`) REFERENCES `tournees` (`IdTournee`),
  CONSTRAINT `FK_Participe_Traineau` FOREIGN KEY (`IdTraineau`) REFERENCES `traineaux` (`IdTraineau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `participe`
--

LOCK TABLES `participe` WRITE;
/*!40000 ALTER TABLE `participe` DISABLE KEYS */;
/*!40000 ALTER TABLE `participe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rennes`
--

DROP TABLE IF EXISTS `rennes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rennes` (
  `IdRenne` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `sexe` varchar(10) DEFAULT NULL,
  `dateDeNaissance` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdRenne`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rennes`
--

LOCK TABLES `rennes` WRITE;
/*!40000 ALTER TABLE `rennes` DISABLE KEYS */;
/*!40000 ALTER TABLE `rennes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tournees`
--

DROP TABLE IF EXISTS `tournees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tournees` (
  `IdTournee` int(11) NOT NULL AUTO_INCREMENT,
  `heureDepart` datetime DEFAULT NULL,
  PRIMARY KEY (`IdTournee`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tournees`
--

LOCK TABLES `tournees` WRITE;
/*!40000 ALTER TABLE `tournees` DISABLE KEYS */;
/*!40000 ALTER TABLE `tournees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `traineaux`
--

DROP TABLE IF EXISTS `traineaux`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `traineaux` (
  `IdTraineau` int(11) NOT NULL AUTO_INCREMENT,
  `taille` varchar(5) DEFAULT NULL,
  `dateMiseEnService` date DEFAULT NULL,
  `dateDerniereRevision` date DEFAULT NULL,
  `responsable` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdTraineau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `traineaux`
--

LOCK TABLES `traineaux` WRITE;
/*!40000 ALTER TABLE `traineaux` DISABLE KEYS */;
/*!40000 ALTER TABLE `traineaux` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transporte`
--

DROP TABLE IF EXISTS `transporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transporte` (
  `IdTransporte` int(11) NOT NULL AUTO_INCREMENT,
  `IdCadeau` int(11) DEFAULT NULL,
  `IdTraineau` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdTransporte`),
  KEY `FK_Transporte_Cadeau` (`IdCadeau`),
  KEY `FK_Transporte_Traineau` (`IdTraineau`),
  CONSTRAINT `FK_Transporte_Cadeau` FOREIGN KEY (`IdCadeau`) REFERENCES `cadeaux` (`IdCadeau`),
  CONSTRAINT `FK_Transporte_Traineau` FOREIGN KEY (`IdTraineau`) REFERENCES `traineaux` (`IdTraineau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transporte`
--

LOCK TABLES `transporte` WRITE;
/*!40000 ALTER TABLE `transporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `transporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `utilise`
--

DROP TABLE IF EXISTS `utilise`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `utilise` (
  `IdUtilise` int(11) NOT NULL AUTO_INCREMENT,
  `IdLutin` int(11) DEFAULT NULL,
  `IdTraineau` int(11) DEFAULT NULL,
  `DateUtilisation` date DEFAULT NULL,
  PRIMARY KEY (`IdUtilise`),
  KEY `FK_Utilise_Lutin` (`IdLutin`),
  KEY `FK_Utilise_Traineau` (`IdTraineau`),
  CONSTRAINT `FK_Utilise_Lutin` FOREIGN KEY (`IdLutin`) REFERENCES `lutins` (`IdLutin`),
  CONSTRAINT `FK_Utilise_Traineau` FOREIGN KEY (`IdTraineau`) REFERENCES `traineaux` (`IdTraineau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `utilise`
--

LOCK TABLES `utilise` WRITE;
/*!40000 ALTER TABLE `utilise` DISABLE KEYS */;
/*!40000 ALTER TABLE `utilise` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-21 17:20:01

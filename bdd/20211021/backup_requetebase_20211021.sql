-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: requetebase
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
-- Current Database: `requetebase`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `requetebase` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `requetebase`;

--
-- Table structure for table `departement`
--

DROP TABLE IF EXISTS `departement`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departement` (
  `nodep` int(11) NOT NULL AUTO_INCREMENT,
  `nomdep` varchar(50) DEFAULT NULL,
  `ville` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`nodep`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departement`
--

LOCK TABLES `departement` WRITE;
/*!40000 ALTER TABLE `departement` DISABLE KEYS */;
INSERT INTO `departement` VALUES (10,'Formation','Aix'),(20,'Ingénierie','Paris'),(30,'Industrie','Bordeaux'),(40,'Direction générale','Paris');
/*!40000 ALTER TABLE `departement` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employe`
--

DROP TABLE IF EXISTS `employe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employe` (
  `noemp` int(11) NOT NULL AUTO_INCREMENT,
  `nomemp` varchar(50) DEFAULT NULL,
  `fonction` varchar(50) DEFAULT NULL,
  `noresp` int(11) DEFAULT NULL,
  `datemb` date DEFAULT NULL,
  `sala` int(11) DEFAULT NULL,
  `comm` int(11) DEFAULT NULL,
  `nodep` int(11) NOT NULL,
  PRIMARY KEY (`noemp`),
  KEY `FK_EMPLOYE_DEPARTMENT` (`nodep`),
  CONSTRAINT `FK_EMPLOYE_DEPARTMENT` FOREIGN KEY (`nodep`) REFERENCES `departement` (`nodep`)
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employe`
--

LOCK TABLES `employe` WRITE;
/*!40000 ALTER TABLE `employe` DISABLE KEYS */;
INSERT INTO `employe` VALUES (1,'Costanza','psychologue',8,'1994-10-19',1715,200,30),(2,'Mioche','Directeur',6,'1990-03-15',2200,1000,20),(3,'Durand','Responsable',2,'1996-04-18',3250,0,10),(4,'Xiong','vendeur',5,'1994-12-15',1150,200,30),(5,'Manoukian','vendeur',11,'1993-08-15',2530,500,30),(6,'Bourdais','directeur',15,'2002-07-12',3550,850,40),(7,'Moreno','ouvrier',3,'1999-05-05',1075,50,10),(8,'Perou','directeur',2,'1995-07-05',2450,800,10),(9,'Costanza','psychologue',8,'1994-10-19',1715,200,30),(10,'Mioche','Directeur',6,'1990-03-15',2200,1000,20),(11,'Costanza','psychologue',8,'1994-10-19',1715,200,30),(12,'Mioche','Directeur',6,'1990-03-15',2200,1000,20),(13,'Durand','Responsable',2,'1996-04-18',3250,0,10),(14,'Xiong','vendeur',5,'1994-12-15',1150,200,30),(15,'Manoukian','vendeur',11,'1993-08-15',2530,500,30),(16,'Bourdais','directeur',15,'2002-07-12',3550,850,40),(17,'Moreno','ouvrier',3,'1999-05-05',1075,50,10),(18,'Perou','directeur',2,'1995-07-05',2450,800,10),(19,'Costanza','psychologue',8,'1994-10-19',1715,200,30),(20,'Mioche','Directeur',6,'1990-03-15',2200,1000,20),(21,'Durand','Responsable',2,'1996-04-18',3250,0,10),(22,'Xiong','vendeur',5,'1994-12-15',1150,200,30),(23,'Manoukian','vendeur',11,'1993-08-15',2530,500,30),(24,'Bourdais','directeur',15,'2002-07-12',3550,850,40),(25,'Moreno','ouvrier',3,'1999-05-05',1075,50,10),(26,'Perou','directeur',2,'1995-07-05',2450,800,10),(27,'Costanza','psychologue',8,'1994-10-19',1715,200,30),(28,'Mioche','Directeur',6,'1990-03-15',2200,1000,20),(29,'Durand','Responsable',2,'1996-04-18',3250,0,10),(30,'Xiong','vendeur',5,'1994-12-15',1150,200,30),(31,'Manoukian','vendeur',11,'1993-08-15',2530,500,30),(32,'Bourdais','directeur',15,'2002-07-12',3550,850,40),(33,'Moreno','ouvrier',3,'1999-05-05',1075,50,10),(34,'Perou','directeur',2,'1995-07-05',2450,800,10),(35,'Costanza','psychologue',8,'1994-10-19',1715,200,30),(36,'Mioche','Directeur',6,'1990-03-15',2200,1000,20),(37,'Durand','Responsable',2,'1996-04-18',3250,0,10),(38,'Xiong','vendeur',5,'1994-12-15',1150,200,30),(39,'Manoukian','vendeur',11,'1993-08-15',2530,500,30),(40,'Bourdais','directeur',15,'2002-07-12',3550,850,40),(41,'Moreno','ouvrier',3,'1999-05-05',1075,50,10),(42,'Perou','directeur',2,'1995-07-05',2450,800,10),(43,'Costanza','psychologue',8,'1994-10-19',1715,200,30),(44,'Mioche','Directeur',6,'1990-03-15',2200,1000,20),(45,'Durand','Responsable',2,'1996-04-18',3250,0,10),(46,'Xiong','vendeur',5,'1994-12-15',1150,200,30),(47,'Manoukian','vendeur',11,'1993-08-15',2530,500,30),(48,'Bourdais','directeur',15,'2002-07-12',3550,850,40),(49,'Moreno','ouvrier',3,'1999-05-05',1075,50,10),(50,'Perou','directeur',2,'1995-07-05',2450,800,10),(51,'Costanza','psychologue',8,'1994-10-19',1715,200,30),(52,'Mioche','Directeur',6,'1990-03-15',2200,1000,20),(53,'Durand','Responsable',2,'1996-04-18',3250,0,10),(54,'Xiong','vendeur',5,'1994-12-15',1150,200,30),(55,'Manoukian','vendeur',11,'1993-08-15',2530,500,30),(56,'Bourdais','directeur',15,'2002-07-12',3550,850,40),(57,'Moreno','ouvrier',3,'1999-05-05',1075,50,10),(58,'Perou','directeur',2,'1995-07-05',2450,800,10),(59,'Bibaut','chef de service',8,'1993-06-07',2200,0,20),(60,'Manian','assistant',9,'1996-10-18',1000,250,10),(61,'Costanza','psychologue',8,'1994-10-19',1715,200,30),(62,'Mioche','Directeur',6,'1990-03-15',2200,1000,20),(63,'Durand','Responsable',2,'1996-04-18',3250,0,10),(64,'Xiong','vendeur',5,'1994-12-15',1150,200,30),(65,'Manoukian','vendeur',11,'1993-08-15',2530,500,30),(66,'Bourdais','directeur',15,'2002-07-12',3550,850,40),(67,'Moreno','ouvrier',3,'1999-05-05',1075,50,10),(68,'Perou','directeur',2,'1995-07-05',2450,800,10),(69,'Bibaut','chef de service',8,'1993-06-07',2200,0,20),(70,'Manian','assistant',9,'1996-10-18',1000,250,10),(71,'Colin','analyste',2,'1992-07-05',2703,625,30),(72,'Coulon','ouvrier',8,'2002-09-18',858,125,20),(73,'Roméo','assistant',8,'2001-08-16',1025,1150,10),(74,'Costanza','psychologue',8,'1994-10-19',1715,200,30),(75,'Mioche','Directeur',6,'1990-03-15',2200,1000,20),(76,'Durand','Responsable',2,'1996-04-18',3250,0,10),(77,'Xiong','vendeur',5,'1994-12-15',1150,200,30),(78,'Manoukian','vendeur',11,'1993-08-15',2530,500,30),(79,'Bourdais','directeur',15,'2002-07-12',3550,850,40),(80,'Moreno','ouvrier',3,'1999-05-05',1075,50,10),(81,'Perou','directeur',2,'1995-07-05',2450,800,10),(82,'Bibaut','chef de service',8,'1993-06-07',2200,0,20),(83,'Manian','assistant',9,'1996-10-18',1000,250,10),(84,'Colin','analyste',2,'1992-07-05',2703,625,30),(85,'Coulon','ouvrier',8,'2002-09-18',858,125,20),(86,'Roméo','assistant',8,'2001-08-16',1025,1150,10),(87,'Solal','secrétaire',3,'1992-02-15',1225,0,20),(88,'Costanza','psychologue',8,'1994-10-19',1715,200,30),(89,'Mioche','Directeur',6,'1990-03-15',2200,1000,20),(90,'Durand','Responsable',2,'1996-04-18',3250,0,10),(91,'Xiong','vendeur',5,'1994-12-15',1150,200,30),(92,'Manoukian','vendeur',11,'1993-08-15',2530,500,30),(93,'Bourdais','directeur',15,'2002-07-12',3550,850,40),(94,'Moreno','ouvrier',3,'1999-05-05',1075,50,10),(95,'Perou','directeur',2,'1995-07-05',2450,800,10),(96,'Bibaut','chef de service',8,'1993-06-07',2200,0,20),(97,'Manian','assistant',9,'1996-10-18',1000,250,10),(98,'Colin','analyste',2,'1992-07-05',2703,625,30),(99,'Coulon','ouvrier',8,'2002-09-18',858,125,20),(100,'Roméo','assistant',8,'2001-08-16',1025,1150,10),(101,'Solal','secrétaire',3,'1992-02-15',1225,0,20),(102,'Bailly','Président',0,'1985-01-05',4275,2000,40),(103,'Jazarin','Ouvrier',2,'2001-07-05',875,0,10),(104,'Font','Ouvrier',2,'1990-08-04',1200,250,10),(105,'Servel','ouvrier',3,'1998-12-02',1025,55,30);
/*!40000 ALTER TABLE `employe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grade`
--

DROP TABLE IF EXISTS `grade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grade` (
  `nograde` int(11) NOT NULL AUTO_INCREMENT,
  `salmin` int(11) DEFAULT NULL,
  `salmax` int(11) DEFAULT NULL,
  PRIMARY KEY (`nograde`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grade`
--

LOCK TABLES `grade` WRITE;
/*!40000 ALTER TABLE `grade` DISABLE KEYS */;
INSERT INTO `grade` VALUES (1,0,1000),(2,0,1000),(3,1000,2000),(4,2000,3000),(5,3000,4000),(6,4000,5000),(7,5000,6000);
/*!40000 ALTER TABLE `grade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `histofonction`
--

DROP TABLE IF EXISTS `histofonction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `histofonction` (
  `noemp` int(11) NOT NULL,
  `date_nom` date NOT NULL,
  `Fonction` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`noemp`,`date_nom`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `histofonction`
--

LOCK TABLES `histofonction` WRITE;
/*!40000 ALTER TABLE `histofonction` DISABLE KEYS */;
INSERT INTO `histofonction` VALUES (1,'1994-10-19','vendeur'),(1,'1996-12-18','psychologue'),(2,'1990-03-15','responsable'),(2,'1994-10-18','directeur'),(3,'1996-04-18','vendeur'),(3,'1998-06-18','responsable'),(4,'1994-12-15','vendeur'),(5,'1993-08-15','vendeur'),(6,'2002-07-12','directeur'),(7,'1999-05-05','ouvrier'),(8,'1995-07-05','vendeur'),(8,'1997-04-15','responsable'),(8,'1999-10-18','directeur'),(10,'1996-10-18','assistant'),(11,'1992-07-05','vendeur'),(11,'1995-07-15','responsable'),(11,'1999-05-19','analyste'),(12,'2002-09-18','ouvrier'),(13,'2001-08-16','ouvrier'),(13,'2003-07-17','assistant'),(14,'1992-01-02','secrétaire'),(15,'1985-01-05','directeur'),(15,'1995-10-05','président'),(16,'2001-07-05','ouvrier'),(17,'1990-08-04','ouvrier'),(18,'1998-12-02','ouvrier');
/*!40000 ALTER TABLE `histofonction` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-21 12:20:02

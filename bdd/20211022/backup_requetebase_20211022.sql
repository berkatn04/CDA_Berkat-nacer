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

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `requetebase` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_bin */;

USE `requetebase`;

--
-- Table structure for table `departement`
--

DROP TABLE IF EXISTS `departement`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departement` (
  `nodep` int(11) NOT NULL,
  `nomdep` varchar(150) DEFAULT NULL,
  `ville` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`nodep`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
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
  `nomemp` varchar(100) DEFAULT NULL,
  `fonction` varchar(50) DEFAULT NULL,
  `noresp` int(11) DEFAULT NULL,
  `datemb` date DEFAULT NULL,
  `sala` float DEFAULT NULL,
  `comm` float DEFAULT NULL,
  `nodep` int(11) NOT NULL,
  PRIMARY KEY (`noemp`),
  KEY `FK_Employe_Departement` (`nodep`),
  KEY `FK_Employe_Employe` (`noresp`),
  CONSTRAINT `FK_Employe_Departement` FOREIGN KEY (`nodep`) REFERENCES `departement` (`nodep`),
  CONSTRAINT `FK_Employe_Employe` FOREIGN KEY (`noresp`) REFERENCES `employe` (`noemp`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employe`
--

LOCK TABLES `employe` WRITE;
/*!40000 ALTER TABLE `employe` DISABLE KEYS */;
INSERT INTO `employe` VALUES (1,'Costanza','psychologue',8,'1994-10-19',1715,200,30),(2,'Mioche','Directeur',6,'1990-03-15',2200,1000,20),(3,'Durand','Responsable',2,'1996-04-18',3250,0,10),(4,'Xiong','vendeur',5,'1994-12-15',1150,200,30),(5,'Manoukian','vendeur',11,'1993-08-15',2530,500,30),(6,'Bourdais','directeur',15,'2002-07-12',3550,850,40),(7,'Moreno','ouvrier',3,'1999-05-05',1075,50,10),(8,'Perou','directeur',2,'1995-07-05',2450,800,10),(9,'Bibaut','chef de service',8,'1993-06-07',2200,NULL,20),(10,'Manian','assistant',9,'1996-10-18',1000,250,10),(11,'Colin','analyste',2,'1992-07-05',2702,625,30),(12,'Coulon','ouvrier',8,'2002-09-18',858,125,20),(13,'Roméo','assistant',8,'2001-08-16',1025,1150,10),(14,'Solal','secrétaire',3,'1992-02-15',1225,NULL,20),(15,'Bailly','Président',NULL,'1985-01-05',4275,2000,40);
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
  `salmin` float DEFAULT NULL,
  `salmax` float DEFAULT NULL,
  PRIMARY KEY (`nograde`)
) ENGINE=InnoDB AUTO_INCREMENT=5001 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grade`
--

LOCK TABLES `grade` WRITE;
/*!40000 ALTER TABLE `grade` DISABLE KEYS */;
INSERT INTO `grade` VALUES (1,0,1000),(1000,1,2000),(2000,1,3000),(3000,1,4000),(4000,1,5000),(5000,1,6000);
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
  `date_nom` date DEFAULT NULL,
  `fonction` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`noemp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `histofonction`
--

LOCK TABLES `histofonction` WRITE;
/*!40000 ALTER TABLE `histofonction` DISABLE KEYS */;
INSERT INTO `histofonction` VALUES (1,'1994-10-19','vendeur'),(2,'1990-03-15','responsable'),(3,'1996-04-18','vendeur'),(4,'1994-12-15','vendeur'),(5,'1993-08-15','vendeur'),(6,'2002-07-12','directeur'),(7,'1999-05-05','ouvrier'),(8,'1995-07-05','vendeur'),(10,'1996-10-18','assistant'),(11,'1992-07-05','vendeur'),(12,'2002-09-18','ouvrier'),(13,'2001-08-16','ouvrier'),(14,'1992-01-02','secrétaire'),(15,'1985-01-05','directeur');
/*!40000 ALTER TABLE `histofonction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `test`
--

DROP TABLE IF EXISTS `test`;
/*!50001 DROP VIEW IF EXISTS `test`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `test` AS SELECT 
 1 AS `noemp`,
 1 AS `nomemp`,
 1 AS `fonction`,
 1 AS `noresp`,
 1 AS `datemb`,
 1 AS `sala`,
 1 AS `comm`,
 1 AS `nodep`,
 1 AS `nomdep`,
 1 AS `ville`*/;
SET character_set_client = @saved_cs_client;

--
-- Current Database: `requetebase`
--

USE `requetebase`;

--
-- Final view structure for view `test`
--

/*!50001 DROP VIEW IF EXISTS `test`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_unicode_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `test` AS select `e`.`noemp` AS `noemp`,`e`.`nomemp` AS `nomemp`,`e`.`fonction` AS `fonction`,`e`.`noresp` AS `noresp`,`e`.`datemb` AS `datemb`,`e`.`sala` AS `sala`,`e`.`comm` AS `comm`,`e`.`nodep` AS `nodep`,`d`.`nomdep` AS `nomdep`,`d`.`ville` AS `ville` from (`employe` `e` join `departement` `d` on((`d`.`nodep` = `e`.`nodep`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-22 12:20:01

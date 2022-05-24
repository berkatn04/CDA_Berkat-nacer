-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 11 fév. 2022 à 07:33
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bibliotheque`
--

-- --------------------------------------------------------

--
-- Structure de la table `abonnes`
--

DROP TABLE IF EXISTS `abonnes`;
CREATE TABLE IF NOT EXISTS `abonnes` (
  `IdAbonne` int(11) NOT NULL AUTO_INCREMENT,
  `MatriculeAbonne` varchar(50) DEFAULT NULL,
  `NomAbonne` varchar(50) DEFAULT NULL,
  `AdresseAbonne` varchar(50) DEFAULT NULL,
  `TelephoneAbonne` varchar(50) DEFAULT NULL,
  `DateAdhesion` date DEFAULT NULL,
  `DateNaissance` date DEFAULT NULL,
  `IdCategorieProfessionnelle` int(11) NOT NULL,
  PRIMARY KEY (`IdAbonne`),
  KEY `FK_Abonnes_CategoriesProfessionnelles` (`IdCategorieProfessionnelle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `auteurs`
--

DROP TABLE IF EXISTS `auteurs`;
CREATE TABLE IF NOT EXISTS `auteurs` (
  `IdAuteur` int(11) NOT NULL AUTO_INCREMENT,
  `NomAutheur` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdAuteur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `categoriesprofessionnelles`
--

DROP TABLE IF EXISTS `categoriesprofessionnelles`;
CREATE TABLE IF NOT EXISTS `categoriesprofessionnelles` (
  `IdCategorieProfessionnelle` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleCategPro` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdCategorieProfessionnelle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `compositions`
--

DROP TABLE IF EXISTS `compositions`;
CREATE TABLE IF NOT EXISTS `compositions` (
  `IdCompositions` int(11) NOT NULL AUTO_INCREMENT,
  `IdAuteur` int(11) DEFAULT NULL,
  `IdLivre` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdCompositions`),
  KEY `FK_Compositions_Auteurs` (`IdAuteur`),
  KEY `FK_Compositions_Livres` (`IdLivre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `definitions`
--

DROP TABLE IF EXISTS `definitions`;
CREATE TABLE IF NOT EXISTS `definitions` (
  `IdDefinitions` int(11) NOT NULL AUTO_INCREMENT,
  `IdGenre` int(11) DEFAULT NULL,
  `IdLivre` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdDefinitions`),
  KEY `FK_Definitions_Genres` (`IdGenre`),
  KEY `FK_Definitions_Livres` (`IdLivre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `editeurs`
--

DROP TABLE IF EXISTS `editeurs`;
CREATE TABLE IF NOT EXISTS `editeurs` (
  `IdEditeur` int(11) NOT NULL AUTO_INCREMENT,
  `NomEditeur` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdEditeur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `empruntexemplaires`
--

DROP TABLE IF EXISTS `empruntexemplaires`;
CREATE TABLE IF NOT EXISTS `empruntexemplaires` (
  `IdEmpruntExemplaires` int(11) NOT NULL AUTO_INCREMENT,
  `IdExemplaire` int(11) DEFAULT NULL,
  `IdAbonne` int(11) DEFAULT NULL,
  `DateEmprunt` datetime DEFAULT NULL,
  `DateRetourEffective` datetime DEFAULT NULL,
  PRIMARY KEY (`IdEmpruntExemplaires`),
  KEY `FK_EmpruntExemplaires_Exemplaires` (`IdExemplaire`),
  KEY `FK_EmpruntExemplaires_Abonnes` (`IdAbonne`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `etatsreserves`
--

DROP TABLE IF EXISTS `etatsreserves`;
CREATE TABLE IF NOT EXISTS `etatsreserves` (
  `IdEtatReserve` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleEtatReserve` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdEtatReserve`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `exemplaires`
--

DROP TABLE IF EXISTS `exemplaires`;
CREATE TABLE IF NOT EXISTS `exemplaires` (
  `IdExemplaire` int(11) NOT NULL AUTO_INCREMENT,
  `DateAcquisition` date DEFAULT NULL,
  `Disponibilite` tinyint(1) DEFAULT NULL,
  `CodeRayon` varchar(50) DEFAULT NULL,
  `IdUsure` int(11) NOT NULL,
  `IdLivre` int(11) NOT NULL,
  PRIMARY KEY (`IdExemplaire`),
  KEY `FK_Exemplaires_Usures` (`IdUsure`),
  KEY `FK_Exemplaires_Livres` (`IdLivre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `genres`
--

DROP TABLE IF EXISTS `genres`;
CREATE TABLE IF NOT EXISTS `genres` (
  `IdGenre` int(11) NOT NULL AUTO_INCREMENT,
  `NomGenre` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdGenre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `identifications`
--

DROP TABLE IF EXISTS `identifications`;
CREATE TABLE IF NOT EXISTS `identifications` (
  `IdIdentification` int(11) NOT NULL AUTO_INCREMENT,
  `IdLivre` int(11) DEFAULT NULL,
  `IdMotCle` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdIdentification`),
  KEY `FK_Identifications_Livres` (`IdLivre`),
  KEY `FK_Identifications_MotsCles` (`IdMotCle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `livres`
--

DROP TABLE IF EXISTS `livres`;
CREATE TABLE IF NOT EXISTS `livres` (
  `IdLivre` int(11) NOT NULL AUTO_INCREMENT,
  `TitreLivre` varchar(50) DEFAULT NULL,
  `CodeCatalogue` varchar(50) DEFAULT NULL,
  `IdEditeur` int(11) NOT NULL,
  `IdTheme` int(11) NOT NULL,
  PRIMARY KEY (`IdLivre`),
  KEY `FK_Livres_Editeurs` (`IdEditeur`),
  KEY `FK_Livres_Themes` (`IdTheme`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `motscles`
--

DROP TABLE IF EXISTS `motscles`;
CREATE TABLE IF NOT EXISTS `motscles` (
  `IdMotCle` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleMotCle` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdMotCle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `reservations`
--

DROP TABLE IF EXISTS `reservations`;
CREATE TABLE IF NOT EXISTS `reservations` (
  `IdReservations` int(11) NOT NULL AUTO_INCREMENT,
  `IdEtatReserve` int(11) DEFAULT NULL,
  `IdLivre` int(11) DEFAULT NULL,
  `IdAbonne` int(11) DEFAULT NULL,
  `DateDebutReservation` datetime DEFAULT NULL,
  `DateDemandeReservation` datetime DEFAULT NULL,
  PRIMARY KEY (`IdReservations`),
  KEY `FK_Reservations_EtatsReserves` (`IdEtatReserve`),
  KEY `FK_Reservations_Livres` (`IdLivre`),
  KEY `FK_Reservations_Abonnes` (`IdAbonne`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `themes`
--

DROP TABLE IF EXISTS `themes`;
CREATE TABLE IF NOT EXISTS `themes` (
  `IdTheme` int(11) NOT NULL AUTO_INCREMENT,
  `NomTheme` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdTheme`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `usures`
--

DROP TABLE IF EXISTS `usures`;
CREATE TABLE IF NOT EXISTS `usures` (
  `IdUsure` int(11) NOT NULL AUTO_INCREMENT,
  `CodeUsure` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdUsure`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `abonnes`
--
ALTER TABLE `abonnes`
  ADD CONSTRAINT `FK_Abonnes_CategoriesProfessionnelles` FOREIGN KEY (`IdCategorieProfessionnelle`) REFERENCES `categoriesprofessionnelles` (`IdCategorieProfessionnelle`);

--
-- Contraintes pour la table `compositions`
--
ALTER TABLE `compositions`
  ADD CONSTRAINT `FK_Compositions_Auteurs` FOREIGN KEY (`IdAuteur`) REFERENCES `auteurs` (`IdAuteur`),
  ADD CONSTRAINT `FK_Compositions_Livres` FOREIGN KEY (`IdLivre`) REFERENCES `livres` (`IdLivre`);

--
-- Contraintes pour la table `definitions`
--
ALTER TABLE `definitions`
  ADD CONSTRAINT `FK_Definitions_Genres` FOREIGN KEY (`IdGenre`) REFERENCES `genres` (`IdGenre`),
  ADD CONSTRAINT `FK_Definitions_Livres` FOREIGN KEY (`IdLivre`) REFERENCES `livres` (`IdLivre`);

--
-- Contraintes pour la table `empruntexemplaires`
--
ALTER TABLE `empruntexemplaires`
  ADD CONSTRAINT `FK_EmpruntExemplaires_Abonnes` FOREIGN KEY (`IdAbonne`) REFERENCES `abonnes` (`IdAbonne`),
  ADD CONSTRAINT `FK_EmpruntExemplaires_Exemplaires` FOREIGN KEY (`IdExemplaire`) REFERENCES `exemplaires` (`IdExemplaire`);

--
-- Contraintes pour la table `exemplaires`
--
ALTER TABLE `exemplaires`
  ADD CONSTRAINT `FK_Exemplaires_Livres` FOREIGN KEY (`IdLivre`) REFERENCES `livres` (`IdLivre`),
  ADD CONSTRAINT `FK_Exemplaires_Usures` FOREIGN KEY (`IdUsure`) REFERENCES `usures` (`IdUsure`);

--
-- Contraintes pour la table `identifications`
--
ALTER TABLE `identifications`
  ADD CONSTRAINT `FK_Identifications_Livres` FOREIGN KEY (`IdLivre`) REFERENCES `livres` (`IdLivre`),
  ADD CONSTRAINT `FK_Identifications_MotsCles` FOREIGN KEY (`IdMotCle`) REFERENCES `motscles` (`IdMotCle`);

--
-- Contraintes pour la table `livres`
--
ALTER TABLE `livres`
  ADD CONSTRAINT `FK_Livres_Editeurs` FOREIGN KEY (`IdEditeur`) REFERENCES `editeurs` (`IdEditeur`),
  ADD CONSTRAINT `FK_Livres_Themes` FOREIGN KEY (`IdTheme`) REFERENCES `themes` (`IdTheme`);

--
-- Contraintes pour la table `reservations`
--
ALTER TABLE `reservations`
  ADD CONSTRAINT `FK_Reservations_Abonnes` FOREIGN KEY (`IdAbonne`) REFERENCES `abonnes` (`IdAbonne`),
  ADD CONSTRAINT `FK_Reservations_EtatsReserves` FOREIGN KEY (`IdEtatReserve`) REFERENCES `etatsreserves` (`IdEtatReserve`),
  ADD CONSTRAINT `FK_Reservations_Livres` FOREIGN KEY (`IdLivre`) REFERENCES `livres` (`IdLivre`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

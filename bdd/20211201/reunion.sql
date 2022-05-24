-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 11 fév. 2022 à 07:35
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
-- Base de données : `reunion`
--

-- --------------------------------------------------------

--
-- Structure de la table `convies`
--

DROP TABLE IF EXISTS `convies`;
CREATE TABLE IF NOT EXISTS `convies` (
  `idConvie` int(11) NOT NULL AUTO_INCREMENT,
  `idUser` int(11) DEFAULT NULL,
  `idReunion` int(11) DEFAULT NULL,
  `importance` tinyint(1) NOT NULL,
  PRIMARY KEY (`idConvie`),
  KEY `FK_Convies_idUser` (`idUser`),
  KEY `FK_Convies_idReunion` (`idReunion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `horaires`
--

DROP TABLE IF EXISTS `horaires`;
CREATE TABLE IF NOT EXISTS `horaires` (
  `idHoraire` int(11) NOT NULL AUTO_INCREMENT,
  `libelleHoraire` varchar(5) NOT NULL,
  PRIMARY KEY (`idHoraire`),
  UNIQUE KEY `libelleHoraire` (`libelleHoraire`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `ordresdujour`
--

DROP TABLE IF EXISTS `ordresdujour`;
CREATE TABLE IF NOT EXISTS `ordresdujour` (
  `idOrdreDuJour` int(11) NOT NULL AUTO_INCREMENT,
  `idReunion` int(11) DEFAULT NULL,
  `idSujet` int(11) DEFAULT NULL,
  PRIMARY KEY (`idOrdreDuJour`),
  KEY `FK_OrdresDuJour_idReunion` (`idReunion`),
  KEY `FK_OrdresDuJour_idSujet` (`idSujet`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `reunions`
--

DROP TABLE IF EXISTS `reunions`;
CREATE TABLE IF NOT EXISTS `reunions` (
  `idReunion` int(11) NOT NULL AUTO_INCREMENT,
  `dateDeReunion` date NOT NULL,
  `objectif` text NOT NULL,
  `idCreateur` int(11) NOT NULL,
  `idStatut` int(11) NOT NULL,
  `idRedacteur` int(11) NOT NULL,
  `idHoraireDebut` int(11) NOT NULL,
  `idHoraireFin` int(11) NOT NULL,
  PRIMARY KEY (`idReunion`),
  KEY `FK_Reunions_idCreateur` (`idCreateur`),
  KEY `FK_Reunions_idStatut` (`idStatut`),
  KEY `FK_Reunions_idRedacteur` (`idRedacteur`),
  KEY `FK_Reunions_idHoraireDebut` (`idHoraireDebut`),
  KEY `FK_Reunions_idHoraireFin` (`idHoraireFin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `roles`
--

DROP TABLE IF EXISTS `roles`;
CREATE TABLE IF NOT EXISTS `roles` (
  `idRole` int(11) NOT NULL AUTO_INCREMENT,
  `libelleRole` varchar(50) NOT NULL,
  PRIMARY KEY (`idRole`),
  UNIQUE KEY `libelleRole` (`libelleRole`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `roles`
--

INSERT INTO `roles` (`idRole`, `libelleRole`) VALUES
(1, 'admin'),
(2, 'Utilisateurs');

-- --------------------------------------------------------

--
-- Structure de la table `statuts`
--

DROP TABLE IF EXISTS `statuts`;
CREATE TABLE IF NOT EXISTS `statuts` (
  `idStatut` int(11) NOT NULL AUTO_INCREMENT,
  `libelleStatut` varchar(50) NOT NULL,
  PRIMARY KEY (`idStatut`),
  UNIQUE KEY `libelleStatut` (`libelleStatut`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `sujets`
--

DROP TABLE IF EXISTS `sujets`;
CREATE TABLE IF NOT EXISTS `sujets` (
  `idSujet` int(11) NOT NULL AUTO_INCREMENT,
  `libelleSujet` varchar(50) DEFAULT NULL,
  `duree` int(11) DEFAULT NULL,
  `idUser` int(11) NOT NULL,
  PRIMARY KEY (`idSujet`),
  KEY `FK_Sujets_idUser` (`idUser`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `taches`
--

DROP TABLE IF EXISTS `taches`;
CREATE TABLE IF NOT EXISTS `taches` (
  `idTache` int(11) NOT NULL AUTO_INCREMENT,
  `libelleTache` varchar(100) NOT NULL,
  `dateButoir` date NOT NULL,
  `idStatut` int(11) NOT NULL,
  `idUser` int(11) NOT NULL,
  PRIMARY KEY (`idTache`),
  KEY `FK_Taches_idStatut` (`idStatut`),
  KEY `FK_Taches_idTypeDocument` (`idUser`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `tachesreunion`
--

DROP TABLE IF EXISTS `tachesreunion`;
CREATE TABLE IF NOT EXISTS `tachesreunion` (
  `idTacheReunion` int(11) NOT NULL AUTO_INCREMENT,
  `idReunion` int(11) DEFAULT NULL,
  `idTache` int(11) DEFAULT NULL,
  PRIMARY KEY (`idTacheReunion`),
  KEY `FK_TachesReunion_idReunion` (`idReunion`),
  KEY `FK_TachesReunion_idTache` (`idTache`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `idUser` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `mdp` varchar(50) NOT NULL,
  `idRole` int(11) NOT NULL,
  PRIMARY KEY (`idUser`),
  UNIQUE KEY `email` (`email`),
  KEY `FK_Users_idRoles` (`idRole`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`idUser`, `nom`, `prenom`, `email`, `mdp`, `idRole`) VALUES
(8, 'berkat', 'az', 'berkat.n@hotmail.com', '88403fa773748f5d0177c20092e64085', 1);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `convies`
--
ALTER TABLE `convies`
  ADD CONSTRAINT `FK_Convies_idReunion` FOREIGN KEY (`idReunion`) REFERENCES `reunions` (`idReunion`),
  ADD CONSTRAINT `FK_Convies_idUser` FOREIGN KEY (`idUser`) REFERENCES `users` (`idUser`);

--
-- Contraintes pour la table `ordresdujour`
--
ALTER TABLE `ordresdujour`
  ADD CONSTRAINT `FK_OrdresDuJour_idReunion` FOREIGN KEY (`idReunion`) REFERENCES `reunions` (`idReunion`),
  ADD CONSTRAINT `FK_OrdresDuJour_idSujet` FOREIGN KEY (`idSujet`) REFERENCES `sujets` (`idSujet`);

--
-- Contraintes pour la table `reunions`
--
ALTER TABLE `reunions`
  ADD CONSTRAINT `FK_Reunions_idCreateur` FOREIGN KEY (`idCreateur`) REFERENCES `users` (`idUser`),
  ADD CONSTRAINT `FK_Reunions_idHoraireDebut` FOREIGN KEY (`idHoraireDebut`) REFERENCES `horaires` (`idHoraire`),
  ADD CONSTRAINT `FK_Reunions_idHoraireFin` FOREIGN KEY (`idHoraireFin`) REFERENCES `horaires` (`idHoraire`),
  ADD CONSTRAINT `FK_Reunions_idRedacteur` FOREIGN KEY (`idRedacteur`) REFERENCES `users` (`idUser`),
  ADD CONSTRAINT `FK_Reunions_idStatut` FOREIGN KEY (`idStatut`) REFERENCES `statuts` (`idStatut`);

--
-- Contraintes pour la table `sujets`
--
ALTER TABLE `sujets`
  ADD CONSTRAINT `FK_Sujets_idUser` FOREIGN KEY (`idUser`) REFERENCES `users` (`idUser`);

--
-- Contraintes pour la table `taches`
--
ALTER TABLE `taches`
  ADD CONSTRAINT `FK_Taches_idStatut` FOREIGN KEY (`idStatut`) REFERENCES `statuts` (`idStatut`),
  ADD CONSTRAINT `FK_Taches_idTypeDocument` FOREIGN KEY (`idUser`) REFERENCES `users` (`idUser`);

--
-- Contraintes pour la table `tachesreunion`
--
ALTER TABLE `tachesreunion`
  ADD CONSTRAINT `FK_TachesReunion_idReunion` FOREIGN KEY (`idReunion`) REFERENCES `reunions` (`idReunion`),
  ADD CONSTRAINT `FK_TachesReunion_idTache` FOREIGN KEY (`idTache`) REFERENCES `taches` (`idTache`);

--
-- Contraintes pour la table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `FK_Users_idRoles` FOREIGN KEY (`idRole`) REFERENCES `roles` (`idRole`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

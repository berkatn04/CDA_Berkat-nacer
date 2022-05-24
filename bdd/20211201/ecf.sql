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
-- Base de données : `ecf`
--

-- --------------------------------------------------------

--
-- Structure de la table `groupes`
--

DROP TABLE IF EXISTS `groupes`;
CREATE TABLE IF NOT EXISTS `groupes` (
  `IdGroupe` int(11) NOT NULL AUTO_INCREMENT,
  `NomDuGroupe` varchar(50) NOT NULL,
  `NombreDeFollowers` int(11) NOT NULL,
  `Logo` varchar(250) NOT NULL,
  PRIMARY KEY (`IdGroupe`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `groupes`
--

INSERT INTO `groupes` (`IdGroupe`, `NomDuGroupe`, `NombreDeFollowers`, `Logo`) VALUES
(1, 'TheGroup', 4, 'logo1.jpg'),
(2, 'Meilleur Groupe', 30, 'logo2.png'),
(5, 'LE Groupe', 45456, 'gfd'),
(6, 'g', 5, 'jhg');

-- --------------------------------------------------------

--
-- Structure de la table `musiciens`
--

DROP TABLE IF EXISTS `musiciens`;
CREATE TABLE IF NOT EXISTS `musiciens` (
  `idMusicien` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) NOT NULL,
  `Prenom` varchar(50) NOT NULL,
  `Instrument` varchar(50) NOT NULL,
  `IdGroupe` int(11) NOT NULL,
  PRIMARY KEY (`idMusicien`),
  KEY `FK_Membres_Groupes` (`IdGroupe`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `musiciens`
--

INSERT INTO `musiciens` (`idMusicien`, `Nom`, `Prenom`, `Instrument`, `IdGroupe`) VALUES
(4, 'Durand', 'Toto', 'batterie', 1),
(5, 'COURQUIN', 'Pierre', 'flute', 5),
(6, 'rgdfgfdg', 'dfgdfg', 'dfg', 1),
(7, 'dfgdfg', 'dfgdfg', 'dfgdfg', 5),
(8, 'FFF', 'FFF', 'FFF', 2),
(9, 'hj', 'hgj', 'hgj', 2);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `musiciens`
--
ALTER TABLE `musiciens`
  ADD CONSTRAINT `FK_Membres_Groupes` FOREIGN KEY (`IdGroupe`) REFERENCES `groupes` (`IdGroupe`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

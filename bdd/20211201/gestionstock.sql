-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 11 fév. 2022 à 07:34
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
-- Base de données : `gestionstock`
--

-- --------------------------------------------------------

--
-- Structure de la table `articles`
--

DROP TABLE IF EXISTS `articles`;
CREATE TABLE IF NOT EXISTS `articles` (
  `IdArticle` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleArticle` varchar(50) NOT NULL,
  `QuantiteStockee` int(11) NOT NULL,
  `IdCategories` int(11) NOT NULL,
  PRIMARY KEY (`IdArticle`),
  KEY `FK_Articles_Categorie` (`IdCategories`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `articles`
--

INSERT INTO `articles` (`IdArticle`, `LibelleArticle`, `QuantiteStockee`, `IdCategories`) VALUES
(1, 'PS5', 45, 1),
(2, 'Pate', 21, 2),
(3, 'dfdg', 45, 2);

-- --------------------------------------------------------

--
-- Structure de la table `categories`
--

DROP TABLE IF EXISTS `categories`;
CREATE TABLE IF NOT EXISTS `categories` (
  `IdCategories` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleCategorie` varchar(255) NOT NULL,
  `IdTypesProduits` int(11) NOT NULL,
  PRIMARY KEY (`IdCategories`),
  KEY `FK_Categories_TypessProduits` (`IdTypesProduits`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `categories`
--

INSERT INTO `categories` (`IdCategories`, `LibelleCategorie`, `IdTypesProduits`) VALUES
(1, 'Console', 2),
(2, 'Produit Sec', 1),
(3, 'Animaux', 1),
(4, 'Alcool', 1),
(5, 'Maison', 2);

-- --------------------------------------------------------

--
-- Structure de la table `typesproduits`
--

DROP TABLE IF EXISTS `typesproduits`;
CREATE TABLE IF NOT EXISTS `typesproduits` (
  `IdTypesProduits` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleTypesProduit` varchar(255) NOT NULL,
  PRIMARY KEY (`IdTypesProduits`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `typesproduits`
--

INSERT INTO `typesproduits` (`IdTypesProduits`, `LibelleTypesProduit`) VALUES
(1, 'Alimentaire'),
(2, 'Non Alimentaire');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `articles`
--
ALTER TABLE `articles`
  ADD CONSTRAINT `FK_Articles_Categorie` FOREIGN KEY (`IdCategories`) REFERENCES `categories` (`IdCategories`);

--
-- Contraintes pour la table `categories`
--
ALTER TABLE `categories`
  ADD CONSTRAINT `FK_Categories_TypessProduits` FOREIGN KEY (`IdTypesProduits`) REFERENCES `typesproduits` (`IdTypesProduits`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

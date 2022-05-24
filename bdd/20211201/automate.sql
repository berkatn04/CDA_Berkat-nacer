-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 11 fév. 2022 à 07:32
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
-- Base de données : `automate`
--

-- --------------------------------------------------------

--
-- Structure de la table `afpa_anomalies`
--

DROP TABLE IF EXISTS `afpa_anomalies`;
CREATE TABLE IF NOT EXISTS `afpa_anomalies` (
  `IdAnomalie` int(11) NOT NULL AUTO_INCREMENT,
  `DateAnomalie` datetime DEFAULT NULL,
  `TypeAnomalie` varchar(50) DEFAULT NULL,
  `NbDeclasses` int(11) DEFAULT NULL,
  `IdErreur` int(11) NOT NULL,
  PRIMARY KEY (`IdAnomalie`),
  KEY `Afpa_Anomalies_Afpa_Erreurs` (`IdErreur`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `afpa_anomalies`
--

INSERT INTO `afpa_anomalies` (`IdAnomalie`, `DateAnomalie`, `TypeAnomalie`, `NbDeclasses`, `IdErreur`) VALUES
(1, '2022-02-01 14:20:30', 'Lumière ', 10, 3),
(2, '2022-02-01 14:21:52', 'Son', 10, 2);

-- --------------------------------------------------------

--
-- Structure de la table `afpa_cadences`
--

DROP TABLE IF EXISTS `afpa_cadences`;
CREATE TABLE IF NOT EXISTS `afpa_cadences` (
  `IdCadence` int(11) NOT NULL AUTO_INCREMENT,
  `NbProduit` int(11) DEFAULT NULL,
  `DateCadence` datetime DEFAULT NULL,
  PRIMARY KEY (`IdCadence`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `afpa_cadences`
--

INSERT INTO `afpa_cadences` (`IdCadence`, `NbProduit`, `DateCadence`) VALUES
(1, 100, '2022-02-01 14:20:30'),
(2, 150, '2022-02-01 14:22:30');

-- --------------------------------------------------------

--
-- Structure de la table `afpa_couleurs`
--

DROP TABLE IF EXISTS `afpa_couleurs`;
CREATE TABLE IF NOT EXISTS `afpa_couleurs` (
  `IdCouleur` int(11) NOT NULL AUTO_INCREMENT,
  `Red` int(11) DEFAULT NULL,
  `Green` int(11) DEFAULT NULL,
  `Blue` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdCouleur`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `afpa_couleurs`
--

INSERT INTO `afpa_couleurs` (`IdCouleur`, `Red`, `Green`, `Blue`) VALUES
(1, 198, 8, 0),
(2, 158, 253, 56),
(3, 254, 27, 0);

-- --------------------------------------------------------

--
-- Structure de la table `afpa_erreurs`
--

DROP TABLE IF EXISTS `afpa_erreurs`;
CREATE TABLE IF NOT EXISTS `afpa_erreurs` (
  `IdErreur` int(11) NOT NULL AUTO_INCREMENT,
  `MessageErreur` text,
  PRIMARY KEY (`IdErreur`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `afpa_erreurs`
--

INSERT INTO `afpa_erreurs` (`IdErreur`, `MessageErreur`) VALUES
(1, 'Luminosité trop basse '),
(2, 'Son trop haut '),
(3, 'Luminosité trop faible'),
(4, 'Son trop bas'),
(5, 'Température trop élevé. '),
(6, 'Température trop basse. '),
(7, 'Son ne fonctionne pas '),
(8, 'Lumière ne fonctionne pas '),
(9, 'Température ne fonctionne pas '),
(10, 'Lumière saccadée '),
(11, 'Son grésillement '),
(12, 'Température Instable');

-- --------------------------------------------------------

--
-- Structure de la table `afpa_lumieres`
--

DROP TABLE IF EXISTS `afpa_lumieres`;
CREATE TABLE IF NOT EXISTS `afpa_lumieres` (
  `IdLumiere` int(11) NOT NULL AUTO_INCREMENT,
  `ValeurLumiere` float DEFAULT NULL,
  `DateLumiere` datetime DEFAULT NULL,
  PRIMARY KEY (`IdLumiere`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `afpa_lumieres`
--

INSERT INTO `afpa_lumieres` (`IdLumiere`, `ValeurLumiere`, `DateLumiere`) VALUES
(1, 350, '2022-02-02 14:08:16'),
(2, 120, '2022-02-01 14:08:16');

-- --------------------------------------------------------

--
-- Structure de la table `afpa_objectifs`
--

DROP TABLE IF EXISTS `afpa_objectifs`;
CREATE TABLE IF NOT EXISTS `afpa_objectifs` (
  `IdObjectif` int(11) NOT NULL AUTO_INCREMENT,
  `Rendement` int(11) DEFAULT NULL,
  `MaxNombreArretTemperature` int(11) DEFAULT NULL,
  `MaxNombreArretDecibel` int(11) DEFAULT NULL,
  `MaxPourcentDeclasses` int(11) DEFAULT NULL,
  `Date` datetime DEFAULT NULL,
  PRIMARY KEY (`IdObjectif`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `afpa_objectifs`
--

INSERT INTO `afpa_objectifs` (`IdObjectif`, `Rendement`, `MaxNombreArretTemperature`, `MaxNombreArretDecibel`, `MaxPourcentDeclasses`, `Date`) VALUES
(1, 100, 4, 5, 60, NULL),
(2, 200, 5, 4, 70, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `afpa_seuils`
--

DROP TABLE IF EXISTS `afpa_seuils`;
CREATE TABLE IF NOT EXISTS `afpa_seuils` (
  `IdSeuil` int(11) NOT NULL AUTO_INCREMENT,
  `SeuilBas` float DEFAULT NULL,
  `SeuilHaut` float DEFAULT NULL,
  `DateSeuil` date DEFAULT NULL,
  `Temps` int(11) DEFAULT NULL,
  `Nature` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdSeuil`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `afpa_seuils`
--

INSERT INTO `afpa_seuils` (`IdSeuil`, `SeuilBas`, `SeuilHaut`, `DateSeuil`, `Temps`, `Nature`) VALUES
(1, 10, 30, '2022-02-01', 1, 3),
(2, 40, 150, '2022-02-02', 2, 2),
(3, 100, 1000, '2022-02-25', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `afpa_sons`
--

DROP TABLE IF EXISTS `afpa_sons`;
CREATE TABLE IF NOT EXISTS `afpa_sons` (
  `IdSon` int(11) NOT NULL AUTO_INCREMENT,
  `ValeurSon` float DEFAULT NULL,
  `DateSon` datetime DEFAULT NULL,
  PRIMARY KEY (`IdSon`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `afpa_sons`
--

INSERT INTO `afpa_sons` (`IdSon`, `ValeurSon`, `DateSon`) VALUES
(1, 120, '2022-02-01 13:58:44'),
(2, 100, '2022-02-02 13:58:44');

-- --------------------------------------------------------

--
-- Structure de la table `afpa_temperatures`
--

DROP TABLE IF EXISTS `afpa_temperatures`;
CREATE TABLE IF NOT EXISTS `afpa_temperatures` (
  `IdTemperature` int(11) NOT NULL AUTO_INCREMENT,
  `ValeurTemperature` float DEFAULT NULL,
  `DateTemperature` datetime DEFAULT NULL,
  PRIMARY KEY (`IdTemperature`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `afpa_temperatures`
--

INSERT INTO `afpa_temperatures` (`IdTemperature`, `ValeurTemperature`, `DateTemperature`) VALUES
(1, 21, '2022-02-01 13:57:57'),
(2, -3, '2022-02-01 14:57:57');

-- --------------------------------------------------------

--
-- Structure de la table `afpa_textes`
--

DROP TABLE IF EXISTS `afpa_textes`;
CREATE TABLE IF NOT EXISTS `afpa_textes` (
  `idTexte` int(11) NOT NULL AUTO_INCREMENT,
  `codeTexte` varchar(50) NOT NULL,
  `fr` longtext NOT NULL,
  `en` longtext NOT NULL,
  PRIMARY KEY (`idTexte`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `afpa_textes`
--

INSERT INTO `afpa_textes` (`idTexte`, `codeTexte`, `fr`, `en`) VALUES
(1, 'Bonjour', 'Bonjour', 'Hello'),
(2, 'Connexion', 'Connexion', 'Log in'),
(3, 'Deconnexion', 'Deconnexion', 'Log out'),
(4, 'Accueil', 'Accueil', 'Home'),
(5, 'AdresseEmail', 'Adresse email', 'Email address'),
(6, 'Mdp', 'Mot de passe', 'Password'),
(7, 'Inscription', 'Inscription', 'Registration'),
(8, 'Nom', 'Nom', 'Surname'),
(9, 'Prenom', 'Prenom', 'Name'),
(10, 'InfoMdpLegend', 'Veuillez saisir au moins', 'Please enter at least'),
(11, 'UneMajuscule', '1 majuscule', '1 uppercase'),
(12, 'UneMinuscule', '1 minuscule', '1 lowercase'),
(13, 'UnChiffre', '1 chiffre', '1 number'),
(14, 'UnCaractereSpecial', '1 caractère spécial ( ! @ & # * ^ $ % +)', '1 special character ( ! @ & # * ^ $ % +)'),
(15, 'MinimumCaractere', '8 caractères', '8 character'),
(16, 'Confirmation', 'Confirmation', 'Confirmation'),
(17, 'Reset', 'Réinitialisation', 'Reset'),
(18, 'Envoyer', 'Envoyer', 'Send');

-- --------------------------------------------------------

--
-- Structure de la table `afpa_utilisateurs`
--

DROP TABLE IF EXISTS `afpa_utilisateurs`;
CREATE TABLE IF NOT EXISTS `afpa_utilisateurs` (
  `idUtilisateur` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `adresseMail` varchar(50) NOT NULL,
  `motDePasse` varchar(50) NOT NULL,
  `role` int(11) NOT NULL COMMENT '2 Admin 1 User',
  PRIMARY KEY (`idUtilisateur`),
  UNIQUE KEY `adresseMail` (`adresseMail`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `afpa_utilisateurs`
--

INSERT INTO `afpa_utilisateurs` (`idUtilisateur`, `nom`, `prenom`, `adresseMail`, `motDePasse`, `role`) VALUES
(1, 'ad', 'ad', 'ad@ad.ad', 'ad', 1);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `afpa_anomalies`
--
ALTER TABLE `afpa_anomalies`
  ADD CONSTRAINT `Afpa_Anomalies_Afpa_Erreurs` FOREIGN KEY (`IdErreur`) REFERENCES `afpa_erreurs` (`IdErreur`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

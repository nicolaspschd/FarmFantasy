-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Jeu 03 Novembre 2016 à 09:22
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.5.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `farmfantasy`
--
CREATE DATABASE IF NOT EXISTS `farmfantasy` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `farmfantasy`;

-- --------------------------------------------------------

--
-- Structure de la table `animaux`
--

CREATE TABLE IF NOT EXISTS `animaux` (
  `idNomAnimal` varchar(50) NOT NULL,
  `nbrAnimaux` int(11) NOT NULL,
  `tempProdActu` int(11) NOT NULL,
  `idNomProduit` varchar(50) NOT NULL,
  PRIMARY KEY (`idNomAnimal`),
  KEY `idNomProduit` (`idNomProduit`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `animaux`
--

INSERT INTO `animaux` (`idNomAnimal`, `nbrAnimaux`, `tempProdActu`, `idNomProduit`) VALUES
('cochon', 0, 0, 'bacon'),
('mouton', 0, 0, 'laine'),
('poule', 0, 0, 'oeufs'),
('vache', 0, 0, 'lait');

-- --------------------------------------------------------

--
-- Structure de la table `champs`
--

CREATE TABLE IF NOT EXISTS `champs` (
  `idChamps` varchar(40) NOT NULL,
  `tempsRestant` int(11) NOT NULL,
  `idNomSemence` varchar(50) NOT NULL,
  PRIMARY KEY (`idChamps`),
  KEY `idNomSemence` (`idNomSemence`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `champs`
--

INSERT INTO `champs` (`idChamps`, `tempsRestant`, `idNomSemence`) VALUES
('pbxChamps1', 0, 'rien'),
('pbxChamps10', 0, 'rien'),
('pbxChamps2', 3, 'colza'),
('pbxChamps3', 22, 'ble'),
('pbxChamps4', 3, 'colza'),
('pbxChamps5', 0, 'rien'),
('pbxChamps6', 0, 'rien'),
('pbxChamps7', 0, 'rien'),
('pbxChamps8', 22, 'ble'),
('pbxChamps9', 22, 'ble');

-- --------------------------------------------------------

--
-- Structure de la table `entrepots`
--

CREATE TABLE IF NOT EXISTS `entrepots` (
  `idNomItem` varchar(50) NOT NULL,
  `qteItem` int(11) NOT NULL,
  PRIMARY KEY (`idNomItem`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `entrepots`
--

INSERT INTO `entrepots` (`idNomItem`, `qteItem`) VALUES
('bacon', 0),
('ble', 12),
('carotte', 0),
('colza', 0),
('laine', 0),
('lait', 0),
('mais', 0),
('oeufs', 0),
('patate', 0),
('rien', 0);

-- --------------------------------------------------------

--
-- Structure de la table `joueurs`
--

CREATE TABLE IF NOT EXISTS `joueurs` (
  `idJoueur` int(11) NOT NULL AUTO_INCREMENT,
  `argent` int(11) NOT NULL,
  PRIMARY KEY (`idJoueur`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Contenu de la table `joueurs`
--

INSERT INTO `joueurs` (`idJoueur`, `argent`) VALUES
(1, 60);

-- --------------------------------------------------------

--
-- Structure de la table `produits`
--

CREATE TABLE IF NOT EXISTS `produits` (
  `idNomProduit` varchar(50) NOT NULL,
  `tempsProduction` int(11) NOT NULL,
  `idNomItem` varchar(50) NOT NULL,
  PRIMARY KEY (`idNomProduit`),
  KEY `idNomItem` (`idNomItem`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `produits`
--

INSERT INTO `produits` (`idNomProduit`, `tempsProduction`, `idNomItem`) VALUES
('bacon', 1200, 'bacon'),
('laine', 7200, 'laine'),
('lait', 600, 'lait'),
('oeufs', 100, 'oeufs');

-- --------------------------------------------------------

--
-- Structure de la table `semences`
--

CREATE TABLE IF NOT EXISTS `semences` (
  `idNomSemence` varchar(50) NOT NULL,
  `tempsPousse` int(11) NOT NULL,
  `idNomItem` varchar(50) NOT NULL,
  PRIMARY KEY (`idNomSemence`),
  KEY `idNomItem` (`idNomItem`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `semences`
--

INSERT INTO `semences` (`idNomSemence`, `tempsPousse`, `idNomItem`) VALUES
('ble', 60, 'ble'),
('carotte', 300, 'carotte'),
('colza', 120, 'colza'),
('mais', 900, 'mais'),
('patate', 500, 'patate'),
('rien', 0, 'rien');

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `animaux`
--
ALTER TABLE `animaux`
  ADD CONSTRAINT `animaux_ibfk_1` FOREIGN KEY (`idNomProduit`) REFERENCES `produits` (`idNomProduit`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `champs`
--
ALTER TABLE `champs`
  ADD CONSTRAINT `champs_ibfk_1` FOREIGN KEY (`idNomSemence`) REFERENCES `semences` (`idNomSemence`);

--
-- Contraintes pour la table `produits`
--
ALTER TABLE `produits`
  ADD CONSTRAINT `produits_ibfk_1` FOREIGN KEY (`idNomItem`) REFERENCES `entrepots` (`idNomItem`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `semences`
--
ALTER TABLE `semences`
  ADD CONSTRAINT `semences_ibfk_1` FOREIGN KEY (`idNomItem`) REFERENCES `entrepots` (`idNomItem`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

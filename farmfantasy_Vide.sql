-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Jeu 29 Septembre 2016 à 08:26
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

-- --------------------------------------------------------

--
-- Structure de la table `champs`
--

CREATE TABLE IF NOT EXISTS `champs` (
  `idChamps` int(11) NOT NULL AUTO_INCREMENT,
  `semence` varchar(50) NOT NULL,
  `tempsRestant` int(11) NOT NULL,
  `idNomSemence` varchar(50) NOT NULL,
  PRIMARY KEY (`idChamps`),
  KEY `idNomSemence` (`idNomSemence`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `entrepots`
--

CREATE TABLE IF NOT EXISTS `entrepots` (
  `idNomItem` varchar(50) NOT NULL,
  `qteItem` int(11) NOT NULL,
  PRIMARY KEY (`idNomItem`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `joueurs`
--

CREATE TABLE IF NOT EXISTS `joueurs` (
  `idJoueur` int(11) NOT NULL AUTO_INCREMENT,
  `argent` int(11) NOT NULL,
  PRIMARY KEY (`idJoueur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `prduits`
--

CREATE TABLE IF NOT EXISTS `prduits` (
  `idNomProduit` varchar(50) NOT NULL,
  `tempsProduction` int(11) NOT NULL,
  `idNomItem` varchar(50) NOT NULL,
  PRIMARY KEY (`idNomProduit`),
  KEY `idNomItem` (`idNomItem`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `animaux`
--
ALTER TABLE `animaux`
  ADD CONSTRAINT `animaux_ibfk_1` FOREIGN KEY (`idNomProduit`) REFERENCES `prduits` (`idNomProduit`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `champs`
--
ALTER TABLE `champs`
  ADD CONSTRAINT `champs_ibfk_1` FOREIGN KEY (`idNomSemence`) REFERENCES `semences` (`idNomSemence`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `prduits`
--
ALTER TABLE `prduits`
  ADD CONSTRAINT `prduits_ibfk_1` FOREIGN KEY (`idNomItem`) REFERENCES `entrepots` (`idNomItem`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `semences`
--
ALTER TABLE `semences`
  ADD CONSTRAINT `semences_ibfk_1` FOREIGN KEY (`idNomItem`) REFERENCES `entrepots` (`idNomItem`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

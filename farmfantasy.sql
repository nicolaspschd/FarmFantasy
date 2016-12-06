-- phpMyAdmin SQL Dump
-- version 4.2.12deb2+deb8u2
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Jeu 01 Décembre 2016 à 19:34
-- Version du serveur :  5.5.52-0+deb8u1
-- Version de PHP :  5.6.27-0+deb8u1

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
`idAnimal` int(11) NOT NULL,
  `nomAnimal` varchar(50) NOT NULL,
  `nbrAnimaux` int(11) NOT NULL,
  `tempProdActu` int(11) NOT NULL,
  `qteProd` int(11) NOT NULL,
  `idNomProduit` varchar(50) NOT NULL,
  `idJoueur` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

--
-- Contenu de la table `animaux`
--

INSERT INTO `animaux` (`idAnimal`, `nomAnimal`, `nbrAnimaux`, `tempProdActu`, `qteProd`, `idNomProduit`, `idJoueur`) VALUES
(5, 'poule', 0, 0, 1, 'oeufs', 2),
(6, 'mouton', 0, 0, 25, 'laine', 2),
(7, 'cochon', 636, 179, 4, 'bacon', 2),
(8, 'vache', 0, 0, 1, 'lait', 2);

-- --------------------------------------------------------

--
-- Structure de la table `champs`
--

CREATE TABLE IF NOT EXISTS `champs` (
`idChamps` int(11) NOT NULL,
  `nomChamps` varchar(40) NOT NULL,
  `tempsRestant` int(11) NOT NULL,
  `idNomSemence` varchar(50) NOT NULL,
  `idJoueur` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8;

--
-- Contenu de la table `champs`
--

INSERT INTO `champs` (`idChamps`, `nomChamps`, `tempsRestant`, `idNomSemence`, `idJoueur`) VALUES
(11, 'pbxChamps1', 10, 'ble', 2),
(12, 'pbxChamps2', 10, 'ble', 2),
(13, 'pbxChamps3', 10, 'ble', 2),
(14, 'pbxChamps4', 9, 'ble', 2),
(15, 'pbxChamps5', 9, 'ble', 2),
(16, 'pbxChamps6', 8, 'ble', 2),
(17, 'pbxChamps7', 9, 'ble', 2),
(18, 'pbxChamps8', 11, 'ble', 2),
(19, 'pbxChamps9', 11, 'ble', 2),
(20, 'pbxChamps10', 8, 'ble', 2);

-- --------------------------------------------------------

--
-- Structure de la table `entrepots`
--

CREATE TABLE IF NOT EXISTS `entrepots` (
`idEntrepot` int(11) NOT NULL,
  `idNomItem` varchar(40) NOT NULL,
  `qteItem` int(11) NOT NULL,
  `idJoueur` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;

--
-- Contenu de la table `entrepots`
--

INSERT INTO `entrepots` (`idEntrepot`, `idNomItem`, `qteItem`, `idJoueur`) VALUES
(1, 'ble', 20, 2),
(2, 'colza', 0, 2),
(3, 'carotte', 0, 2),
(4, 'patate', 0, 2),
(5, 'mais', 0, 2),
(6, 'oeufs', 0, 2),
(7, 'laine', 0, 2),
(8, 'lait', 0, 2),
(9, 'bacon', 0, 2);

-- --------------------------------------------------------

--
-- Structure de la table `joueurs`
--

CREATE TABLE IF NOT EXISTS `joueurs` (
`idJoueur` int(11) NOT NULL,
  `Pseudo` varchar(50) NOT NULL,
  `mdp` varchar(50) NOT NULL,
  `argent` int(11) NOT NULL DEFAULT '100'
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Contenu de la table `joueurs`
--

INSERT INTO `joueurs` (`idJoueur`, `Pseudo`, `mdp`, `argent`) VALUES
(2, 'Robert', '035d22fc1be7512050cf2be88e65cb04b4d844da', 100);

-- --------------------------------------------------------

--
-- Structure de la table `produits`
--

CREATE TABLE IF NOT EXISTS `produits` (
  `idNomProduit` varchar(50) NOT NULL,
  `tempsProduction` int(11) NOT NULL,
  `prixVenteUnite` int(11) NOT NULL,
  `idNomItem` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `produits`
--

INSERT INTO `produits` (`idNomProduit`, `tempsProduction`, `prixVenteUnite`, `idNomItem`) VALUES
('bacon', 500, 75, 'bacon'),
('laine', 7200, 150, 'laine'),
('lait', 600, 2, 'lait'),
('oeufs', 100, 1, 'oeufs');

-- --------------------------------------------------------

--
-- Structure de la table `semences`
--

CREATE TABLE IF NOT EXISTS `semences` (
  `idNomSemence` varchar(50) NOT NULL,
  `tempsPousse` int(11) NOT NULL,
  `idNomItem` varchar(50) NOT NULL
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
-- Index pour les tables exportées
--

--
-- Index pour la table `animaux`
--
ALTER TABLE `animaux`
 ADD PRIMARY KEY (`idAnimal`), ADD KEY `idNomProduit` (`idNomProduit`), ADD KEY `idJoueur` (`idJoueur`), ADD KEY `idJoueur_2` (`idJoueur`);

--
-- Index pour la table `champs`
--
ALTER TABLE `champs`
 ADD PRIMARY KEY (`idChamps`), ADD KEY `idNomSemence` (`idNomSemence`), ADD KEY `idJoueur` (`idJoueur`), ADD KEY `idJoueur_2` (`idJoueur`);

--
-- Index pour la table `entrepots`
--
ALTER TABLE `entrepots`
 ADD PRIMARY KEY (`idEntrepot`), ADD KEY `idJoueur` (`idJoueur`), ADD KEY `idJoueur_2` (`idJoueur`), ADD KEY `idJoueur_3` (`idJoueur`), ADD KEY `idJoueur_4` (`idJoueur`), ADD KEY `idNomItem` (`idNomItem`);

--
-- Index pour la table `joueurs`
--
ALTER TABLE `joueurs`
 ADD PRIMARY KEY (`idJoueur`), ADD UNIQUE KEY `Pseudo` (`Pseudo`), ADD KEY `idJoueur` (`idJoueur`);

--
-- Index pour la table `produits`
--
ALTER TABLE `produits`
 ADD PRIMARY KEY (`idNomProduit`), ADD KEY `idNomItem` (`idNomItem`), ADD KEY `idNomItem_2` (`idNomItem`);

--
-- Index pour la table `semences`
--
ALTER TABLE `semences`
 ADD PRIMARY KEY (`idNomSemence`), ADD KEY `idNomItem` (`idNomItem`), ADD KEY `idNomItem_2` (`idNomItem`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `animaux`
--
ALTER TABLE `animaux`
MODIFY `idAnimal` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT pour la table `champs`
--
ALTER TABLE `champs`
MODIFY `idChamps` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=41;
--
-- AUTO_INCREMENT pour la table `entrepots`
--
ALTER TABLE `entrepots`
MODIFY `idEntrepot` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=28;
--
-- AUTO_INCREMENT pour la table `joueurs`
--
ALTER TABLE `joueurs`
MODIFY `idJoueur` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `animaux`
--
ALTER TABLE `animaux`
ADD CONSTRAINT `animaux_ibfk_1` FOREIGN KEY (`idNomProduit`) REFERENCES `produits` (`idNomProduit`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `animaux_ibfk_2` FOREIGN KEY (`idJoueur`) REFERENCES `joueurs` (`idJoueur`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `champs`
--
ALTER TABLE `champs`
ADD CONSTRAINT `champs_ibfk_1` FOREIGN KEY (`idNomSemence`) REFERENCES `semences` (`idNomSemence`),
ADD CONSTRAINT `champs_ibfk_2` FOREIGN KEY (`idJoueur`) REFERENCES `joueurs` (`idJoueur`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `entrepots`
--
ALTER TABLE `entrepots`
ADD CONSTRAINT `entrepots_ibfk_1` FOREIGN KEY (`idJoueur`) REFERENCES `joueurs` (`idJoueur`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

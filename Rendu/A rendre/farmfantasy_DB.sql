-- phpMyAdmin SQL Dump
-- version 4.6.5
-- https://www.phpmyadmin.net/
--
-- Client :  localhost
-- Généré le :  Jeu 22 Décembre 2016 à 11:24
-- Version du serveur :  5.5.52-MariaDB
-- Version de PHP :  5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `farmfantasy`
--
CREATE DATABASE IF NOT EXISTS `farmfantasy` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `farmfantasy`;

-- --------------------------------------------------------

--
-- Structure de la table `animaux`
--

CREATE TABLE `animaux` (
  `idAnimal` int(11) NOT NULL,
  `nomAnimal` varchar(50) NOT NULL,
  `nbrAnimaux` int(11) NOT NULL,
  `tempProdActu` int(11) NOT NULL,
  `qteProd` int(11) NOT NULL,
  `idNomProduit` varchar(50) NOT NULL,
  `idJoueur` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `animaux`
--

INSERT INTO `animaux` (`idAnimal`, `nomAnimal`, `nbrAnimaux`, `tempProdActu`, `qteProd`, `idNomProduit`, `idJoueur`) VALUES
(5, 'poule', 100, 29, 1, 'oeufs', 2),
(6, 'mouton', 100, 35, 25, 'laine', 2),
(7, 'cochon', 636, 28, 4, 'bacon', 2),
(8, 'vache', 100, 45, 1, 'lait', 2),
(13, 'poule', 12, 21, 5, 'oeufs', 4),
(14, 'mouton', 0, 0, 25, 'laine', 4),
(15, 'cochon', 1, 21, 4, 'bacon', 4),
(16, 'vache', 0, 0, 1, 'lait', 4),
(17, 'poule', 3, 27, 5, 'oeufs', 5),
(18, 'mouton', 0, 0, 25, 'laine', 5),
(19, 'cochon', 0, 0, 4, 'bacon', 5),
(20, 'vache', 0, 0, 1, 'lait', 5),
(21, 'poule', 0, 0, 5, 'oeufs', 6),
(22, 'mouton', 0, 0, 25, 'laine', 6),
(23, 'cochon', 0, 0, 4, 'bacon', 6),
(24, 'vache', 0, 0, 1, 'lait', 6);

-- --------------------------------------------------------

--
-- Structure de la table `champs`
--

CREATE TABLE `champs` (
  `idChamps` int(11) NOT NULL,
  `nomChamps` varchar(40) NOT NULL,
  `tempsRestant` int(11) NOT NULL,
  `idNomSemence` varchar(50) NOT NULL,
  `idJoueur` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `champs`
--

INSERT INTO `champs` (`idChamps`, `nomChamps`, `tempsRestant`, `idNomSemence`, `idJoueur`) VALUES
(11, 'pbxChamps1', 483, 'mais', 2),
(12, 'pbxChamps2', 483, 'mais', 2),
(13, 'pbxChamps3', 484, 'mais', 2),
(14, 'pbxChamps4', 483, 'mais', 2),
(15, 'pbxChamps5', 482, 'mais', 2),
(16, 'pbxChamps6', 482, 'mais', 2),
(17, 'pbxChamps7', 484, 'mais', 2),
(18, 'pbxChamps8', 485, 'mais', 2),
(19, 'pbxChamps9', 485, 'mais', 2),
(20, 'pbxChamps10', 485, 'mais', 2),
(31, 'pbxChamps1', 65, 'patate', 4),
(32, 'pbxChamps2', 63, 'carotte', 4),
(33, 'pbxChamps3', 62, 'carotte', 4),
(34, 'pbxChamps4', 62, 'carotte', 4),
(35, 'pbxChamps5', 61, 'carotte', 4),
(36, 'pbxChamps6', 64, 'patate', 4),
(37, 'pbxChamps7', 59, 'ble', 4),
(38, 'pbxChamps8', 768, 'mais', 4),
(39, 'pbxChamps9', 769, 'mais', 4),
(40, 'pbxChamps10', 58, 'ble', 4),
(41, 'pbxChamps1', 50, 'ble', 5),
(42, 'pbxChamps2', 48, 'ble', 5),
(43, 'pbxChamps3', 49, 'ble', 5),
(44, 'pbxChamps4', 50, 'ble', 5),
(45, 'pbxChamps5', 51, 'ble', 5),
(46, 'pbxChamps6', 50, 'ble', 5),
(47, 'pbxChamps7', 51, 'ble', 5),
(48, 'pbxChamps8', 49, 'ble', 5),
(49, 'pbxChamps9', 49, 'ble', 5),
(50, 'pbxChamps10', 51, 'ble', 5),
(51, 'pbxChamps1', 0, 'rien', 6),
(52, 'pbxChamps2', 0, 'rien', 6),
(53, 'pbxChamps3', 0, 'rien', 6),
(54, 'pbxChamps4', 0, 'rien', 6),
(55, 'pbxChamps5', 0, 'rien', 6),
(56, 'pbxChamps6', 0, 'rien', 6),
(57, 'pbxChamps7', 0, 'rien', 6),
(58, 'pbxChamps8', 0, 'rien', 6),
(59, 'pbxChamps9', 0, 'rien', 6),
(60, 'pbxChamps10', 0, 'rien', 6);

-- --------------------------------------------------------

--
-- Structure de la table `entrepots`
--

CREATE TABLE `entrepots` (
  `idEntrepot` int(11) NOT NULL,
  `idNomItem` varchar(40) NOT NULL,
  `qteItem` int(11) NOT NULL,
  `idJoueur` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `entrepots`
--

INSERT INTO `entrepots` (`idEntrepot`, `idNomItem`, `qteItem`, `idJoueur`) VALUES
(1, 'ble', 46, 2),
(2, 'colza', 8, 2),
(3, 'carotte', 0, 2),
(4, 'patate', 0, 2),
(5, 'mais', 0, 2),
(6, 'oeufs', 0, 2),
(7, 'laine', 0, 2),
(8, 'lait', 0, 2),
(9, 'bacon', 2544, 2),
(19, 'ble', 0, 4),
(20, 'colza', 0, 4),
(21, 'carotte', 0, 4),
(22, 'patate', 0, 4),
(23, 'mais', 0, 4),
(24, 'oeufs', 0, 4),
(25, 'laine', 0, 4),
(26, 'lait', 0, 4),
(27, 'bacon', 0, 4),
(28, 'ble', 0, 5),
(29, 'colza', 0, 5),
(30, 'carotte', 0, 5),
(31, 'patate', 0, 5),
(32, 'mais', 0, 5),
(33, 'oeufs', 15, 5),
(34, 'laine', 0, 5),
(35, 'lait', 0, 5),
(36, 'bacon', 0, 5),
(37, 'ble', 10, 6),
(38, 'colza', 0, 6),
(39, 'carotte', 0, 6),
(40, 'patate', 0, 6),
(41, 'mais', 0, 6),
(42, 'oeufs', 0, 6),
(43, 'laine', 0, 6),
(44, 'lait', 0, 6),
(45, 'bacon', 0, 6);

-- --------------------------------------------------------

--
-- Structure de la table `joueurs`
--

CREATE TABLE `joueurs` (
  `idJoueur` int(11) NOT NULL,
  `Pseudo` varchar(50) NOT NULL,
  `mdp` varchar(50) NOT NULL,
  `argent` int(11) NOT NULL DEFAULT '100'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `joueurs`
--

INSERT INTO `joueurs` (`idJoueur`, `Pseudo`, `mdp`, `argent`) VALUES
(2, 'Robert', '035d22fc1be7512050cf2be88e65cb04b4d844da', 53745),
(4, 'Marcupo', 'f6889fc97e14b42dec11a8c183ea791c5465b658', 1),
(5, 'Knowpe', 'f6889fc97e14b42dec11a8c183ea791c5465b658', 95),
(6, 'PsYkOz', 'f6889fc97e14b42dec11a8c183ea791c5465b658', 100);

-- --------------------------------------------------------

--
-- Structure de la table `produits`
--

CREATE TABLE `produits` (
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

CREATE TABLE `semences` (
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
  ADD PRIMARY KEY (`idAnimal`),
  ADD KEY `idNomProduit` (`idNomProduit`),
  ADD KEY `idJoueur` (`idJoueur`),
  ADD KEY `idJoueur_2` (`idJoueur`);

--
-- Index pour la table `champs`
--
ALTER TABLE `champs`
  ADD PRIMARY KEY (`idChamps`),
  ADD KEY `idNomSemence` (`idNomSemence`),
  ADD KEY `idJoueur` (`idJoueur`),
  ADD KEY `idJoueur_2` (`idJoueur`);

--
-- Index pour la table `entrepots`
--
ALTER TABLE `entrepots`
  ADD PRIMARY KEY (`idEntrepot`),
  ADD KEY `idJoueur` (`idJoueur`),
  ADD KEY `idJoueur_2` (`idJoueur`),
  ADD KEY `idJoueur_3` (`idJoueur`),
  ADD KEY `idJoueur_4` (`idJoueur`),
  ADD KEY `idNomItem` (`idNomItem`);

--
-- Index pour la table `joueurs`
--
ALTER TABLE `joueurs`
  ADD PRIMARY KEY (`idJoueur`),
  ADD UNIQUE KEY `Pseudo` (`Pseudo`),
  ADD KEY `idJoueur` (`idJoueur`);

--
-- Index pour la table `produits`
--
ALTER TABLE `produits`
  ADD PRIMARY KEY (`idNomProduit`),
  ADD KEY `idNomItem` (`idNomItem`),
  ADD KEY `idNomItem_2` (`idNomItem`);

--
-- Index pour la table `semences`
--
ALTER TABLE `semences`
  ADD PRIMARY KEY (`idNomSemence`),
  ADD KEY `idNomItem` (`idNomItem`),
  ADD KEY `idNomItem_2` (`idNomItem`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `animaux`
--
ALTER TABLE `animaux`
  MODIFY `idAnimal` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
--
-- AUTO_INCREMENT pour la table `champs`
--
ALTER TABLE `champs`
  MODIFY `idChamps` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;
--
-- AUTO_INCREMENT pour la table `entrepots`
--
ALTER TABLE `entrepots`
  MODIFY `idEntrepot` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;
--
-- AUTO_INCREMENT pour la table `joueurs`
--
ALTER TABLE `joueurs`
  MODIFY `idJoueur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
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


GRANT USAGE ON *.* TO 'Thierry'@'%' IDENTIFIED BY PASSWORD '*05955BF0265C38132022EC96F63CC730807ACB06';
GRANT ALL PRIVILEGES ON `farmfantasy`.* TO 'Thierry'@'%';

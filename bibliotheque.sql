-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : dim. 04 mai 2025 à 13:01
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.2.12

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
-- Structure de la table `bibliothecaire`
--

CREATE TABLE `bibliothecaire` (
  `id_biblio` int(11) NOT NULL,
  `nom_biblio` varchar(100) DEFAULT NULL,
  `passwords` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `bibliothecaire`
--

INSERT INTO `bibliothecaire` (`id_biblio`, `nom_biblio`, `passwords`) VALUES
(1, 'Roberto', 'Roberto1cr');

-- --------------------------------------------------------

--
-- Structure de la table `emprunt`
--

CREATE TABLE `emprunt` (
  `id_emprunt` int(11) NOT NULL,
  `id_livre` int(11) NOT NULL,
  `id_emprunteur` int(11) NOT NULL,
  `date_emprunt` date DEFAULT NULL,
  `date_retour` date DEFAULT NULL,
  `etat` varchar(255) NOT NULL,
  `nombre_emprunt` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `emprunt`
--

INSERT INTO `emprunt` (`id_emprunt`, `id_livre`, `id_emprunteur`, `date_emprunt`, `date_retour`, `etat`, `nombre_emprunt`) VALUES
(1, 1, 1, '2025-04-08', '2025-04-09', 'emprunter', 1),
(2, 2, 2, '2025-04-08', '2025-04-11', 'emprunter', 1),
(3, 1, 2, '2025-04-08', '2025-04-17', 'rendu', 2),
(4, 1, 4, '2025-04-08', '2025-04-15', 'emprunter', 1),
(5, 2, 4, '2025-04-08', '2025-04-10', 'rendu', 2),
(6, 1, 2, '2025-04-08', '2025-04-10', 'emprunter', 2),
(7, 3, 2, '2025-04-08', '2025-04-04', 'emprunter', 3);

-- --------------------------------------------------------

--
-- Structure de la table `emprunteurs`
--

CREATE TABLE `emprunteurs` (
  `id_emprunteur` int(11) NOT NULL,
  `id_biblio` int(11) NOT NULL,
  `nom_emprunteur` varchar(100) DEFAULT NULL,
  `prenom_emprunteur` varchar(100) DEFAULT NULL,
  `adresse_residence` varchar(100) DEFAULT NULL,
  `telephone` varchar(100) DEFAULT NULL,
  `adresse_mail` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `emprunteurs`
--

INSERT INTO `emprunteurs` (`id_emprunteur`, `id_biblio`, `nom_emprunteur`, `prenom_emprunteur`, `adresse_residence`, `telephone`, `adresse_mail`) VALUES
(1, 1, 'Jesus', 'Credo', 'Douala', '637383743', 'Credo@gmail.com'),
(2, 1, 'Landry', 'Bakogo', 'Douala', '637353745', 'Landry@gmail.com'),
(3, 1, 'Ryan', 'gims', 'Douala', '637383934', 'Ryan@gmail.com'),
(4, 1, 'lorelle', 'Gogan', 'Douala', '638383738', 'lorelle@gmail.com');

-- --------------------------------------------------------

--
-- Structure de la table `livres`
--

CREATE TABLE `livres` (
  `id_livre` int(11) NOT NULL,
  `id_biblio` int(11) NOT NULL,
  `titre_livre` varchar(100) DEFAULT NULL,
  `auteur_livre` varchar(100) DEFAULT NULL,
  `editeur_livre` varchar(100) DEFAULT NULL,
  `annee_pub` int(11) DEFAULT NULL,
  `nbre_exemplaire_dispo` int(11) DEFAULT NULL,
  `etat` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `livres`
--

INSERT INTO `livres` (`id_livre`, `id_biblio`, `titre_livre`, `auteur_livre`, `editeur_livre`, `annee_pub`, `nbre_exemplaire_dispo`, `etat`) VALUES
(1, 1, 'Java', 'Marie', 'Lore', 2002, 1, 'encours'),
(2, 1, 'NodeJs', 'Franck', 'Loic', 2022, 1, 'encours'),
(3, 1, 'Reactjs', 'Jordan', 'Mario', 2022, 3, 'encours');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `bibliothecaire`
--
ALTER TABLE `bibliothecaire`
  ADD PRIMARY KEY (`id_biblio`);

--
-- Index pour la table `emprunt`
--
ALTER TABLE `emprunt`
  ADD PRIMARY KEY (`id_emprunt`),
  ADD KEY `id_livre` (`id_livre`),
  ADD KEY `id_emprunteur` (`id_emprunteur`);

--
-- Index pour la table `emprunteurs`
--
ALTER TABLE `emprunteurs`
  ADD PRIMARY KEY (`id_emprunteur`),
  ADD KEY `id_biblio` (`id_biblio`);

--
-- Index pour la table `livres`
--
ALTER TABLE `livres`
  ADD PRIMARY KEY (`id_livre`),
  ADD KEY `id_biblio` (`id_biblio`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `bibliothecaire`
--
ALTER TABLE `bibliothecaire`
  MODIFY `id_biblio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `emprunt`
--
ALTER TABLE `emprunt`
  MODIFY `id_emprunt` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `emprunteurs`
--
ALTER TABLE `emprunteurs`
  MODIFY `id_emprunteur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `livres`
--
ALTER TABLE `livres`
  MODIFY `id_livre` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `emprunt`
--
ALTER TABLE `emprunt`
  ADD CONSTRAINT `Emprunt_ibfk_1` FOREIGN KEY (`id_livre`) REFERENCES `livres` (`id_livre`),
  ADD CONSTRAINT `Emprunt_ibfk_2` FOREIGN KEY (`id_emprunteur`) REFERENCES `emprunteurs` (`id_emprunteur`);

--
-- Contraintes pour la table `emprunteurs`
--
ALTER TABLE `emprunteurs`
  ADD CONSTRAINT `Emprunteurs_ibfk_1` FOREIGN KEY (`id_biblio`) REFERENCES `bibliothecaire` (`id_biblio`);

--
-- Contraintes pour la table `livres`
--
ALTER TABLE `livres`
  ADD CONSTRAINT `Livres_ibfk_1` FOREIGN KEY (`id_biblio`) REFERENCES `bibliothecaire` (`id_biblio`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

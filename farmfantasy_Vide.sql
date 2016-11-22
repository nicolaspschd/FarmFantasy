#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: champs
#------------------------------------------------------------

CREATE TABLE champs(
        idChamps     int (11) Auto_increment  NOT NULL ,
        nomChamps    Varchar (40) ,
        tempsRestant Int ,
        idNomSemence Varchar (40) ,
        idJoueur     Int ,
        PRIMARY KEY (idChamps )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: semences
#------------------------------------------------------------

CREATE TABLE semences(
        idNomSemence Varchar (40) NOT NULL ,
        tempsPousse  Int ,
        idItem       Int ,
        PRIMARY KEY (idNomSemence )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: animaux
#------------------------------------------------------------

CREATE TABLE animaux(
        idAnimal      int (11) Auto_increment  NOT NULL ,
        nomAnimal     Varchar (40) ,
        nbrAnimal     Int ,
        tempsProdActu Int ,
        idNomProduit  Varchar (25) ,
        idJoueur      Int ,
        PRIMARY KEY (idAnimal )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: produits
#------------------------------------------------------------

CREATE TABLE produits(
        idNomProduit    Varchar (25) NOT NULL ,
        tempsProduction Int ,
        prixVenteUnite  Int ,
        idItem          Int ,
        PRIMARY KEY (idNomProduit )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: entrepots
#------------------------------------------------------------

CREATE TABLE entrepots(
        idItem   int (11) Auto_increment  NOT NULL ,
        nomItem  Varchar (40) ,
        qteItem  Int ,
        idJoueur Int ,
        PRIMARY KEY (idItem )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: joueurs
#------------------------------------------------------------

CREATE TABLE joueurs(
        idJoueur int (11) Auto_increment  NOT NULL ,
        argent   Int ,
        pseudo   Varchar (50) ,
        mdp      Varchar (50) ,
        PRIMARY KEY (idJoueur ) ,
        UNIQUE (pseudo )
)ENGINE=InnoDB;

ALTER TABLE champs ADD CONSTRAINT FK_champs_idNomSemence FOREIGN KEY (idNomSemence) REFERENCES semences(idNomSemence);
ALTER TABLE champs ADD CONSTRAINT FK_champs_idJoueur FOREIGN KEY (idJoueur) REFERENCES joueurs(idJoueur);
ALTER TABLE semences ADD CONSTRAINT FK_semences_idItem FOREIGN KEY (idItem) REFERENCES entrepots(idItem);
ALTER TABLE animaux ADD CONSTRAINT FK_animaux_idNomProduit FOREIGN KEY (idNomProduit) REFERENCES produits(idNomProduit);
ALTER TABLE animaux ADD CONSTRAINT FK_animaux_idJoueur FOREIGN KEY (idJoueur) REFERENCES joueurs(idJoueur);
ALTER TABLE produits ADD CONSTRAINT FK_produits_idItem FOREIGN KEY (idItem) REFERENCES entrepots(idItem);
ALTER TABLE entrepots ADD CONSTRAINT FK_entrepots_idJoueur FOREIGN KEY (idJoueur) REFERENCES joueurs(idJoueur);

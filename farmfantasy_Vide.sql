#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: Champs
#------------------------------------------------------------

CREATE TABLE Champs(
        idChamps     int (11) Auto_increment  NOT NULL ,
        nomChamps    Varchar (40) ,
        semence      Varchar (40) ,
        tempsR       Int ,
        idnomSemence Varchar (40) ,
        idJoueur     Int ,
        PRIMARY KEY (idChamps )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Semences
#------------------------------------------------------------

CREATE TABLE Semences(
        idnomSemence Varchar (40) NOT NULL ,
        tempsPousse  Int ,
        idItem       Int ,
        PRIMARY KEY (idnomSemence )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Animaux
#------------------------------------------------------------

CREATE TABLE Animaux(
        idAnimal     int (11) Auto_increment  NOT NULL ,
        nomAnimal    Varchar (40) ,
        nbrAnimal    Int ,
        tempsPactu   Int ,
        idnomProduit Varchar (25) ,
        idJoueur     Int ,
        PRIMARY KEY (idAnimal )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Produits
#------------------------------------------------------------

CREATE TABLE Produits(
        idnomProduit    Varchar (25) NOT NULL ,
        tempsProduction Int ,
        prixVenteUnite  Int ,
        idItem          Int ,
        PRIMARY KEY (idnomProduit )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Entrepots
#------------------------------------------------------------

CREATE TABLE Entrepots(
        idItem   int (11) Auto_increment  NOT NULL ,
        nomItem  Varchar (40) ,
        qteItem  Int ,
        idJoueur Int ,
        PRIMARY KEY (idItem )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Joueurs
#------------------------------------------------------------

CREATE TABLE Joueurs(
        idJoueur int (11) Auto_increment  NOT NULL ,
        argent   Int ,
        Pseudo   Varchar (50) ,
        mdp      Varchar (50) ,
        PRIMARY KEY (idJoueur ) ,
        UNIQUE (Pseudo )
)ENGINE=InnoDB;

ALTER TABLE Champs ADD CONSTRAINT FK_Champs_idnomSemence FOREIGN KEY (idnomSemence) REFERENCES Semences(idnomSemence);
ALTER TABLE Champs ADD CONSTRAINT FK_Champs_idJoueur FOREIGN KEY (idJoueur) REFERENCES Joueurs(idJoueur);
ALTER TABLE Semences ADD CONSTRAINT FK_Semences_idItem FOREIGN KEY (idItem) REFERENCES Entrepots(idItem);
ALTER TABLE Animaux ADD CONSTRAINT FK_Animaux_idnomProduit FOREIGN KEY (idnomProduit) REFERENCES Produits(idnomProduit);
ALTER TABLE Animaux ADD CONSTRAINT FK_Animaux_idJoueur FOREIGN KEY (idJoueur) REFERENCES Joueurs(idJoueur);
ALTER TABLE Produits ADD CONSTRAINT FK_Produits_idItem FOREIGN KEY (idItem) REFERENCES Entrepots(idItem);
ALTER TABLE Entrepots ADD CONSTRAINT FK_Entrepots_idJoueur FOREIGN KEY (idJoueur) REFERENCES Joueurs(idJoueur);

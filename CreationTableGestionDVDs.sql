USE BDW56_424r

DROP TABLE FilmsSupplements
DROP TABLE FilmsSousTitres
DROP TABLE FilmsLangues
DROP TABLE FilmsActeurs
DROP TABLE Films
DROP TABLE Exemplaires
DROP TABLE EmpruntsFilms
DROP TABLE UtilisateursPreferences
DROP TABLE Utilisateurs
DROP TABLE TypesUtilisateur
DROP TABLE Supplements
DROP TABLE SousTitres
DROP TABLE Realisateurs
DROP TABLE Producteurs
DROP TABLE Preferences
DROP TABLE Langues
DROP TABLE Formats
DROP TABLE Categories
DROP TABLE Acteurs


CREATE TABLE Acteurs (
    NoActeur INT NOT NULL PRIMARY KEY,
    Nom NVARCHAR(50) NOT NULL,
    Sexe NCHAR(1) NOT NULL
)
INSERT INTO Acteurs VALUES
    (1,'Marlon Brando','H'),
    (2,'Robert Duvall','H'),
    (3,'Martin Sheen','H'),
    (4,'Guy Jodoin','H'),
    (5,'Sylvie Moreau','F'),
    (6,'St�phane Cr�te','H'),
    (7,'Georges Clooney','H'),
    (8,'Brad Pitt','H'),
    (9,'Matt Damon','H'),
    (10,'Steven Strait','H'),
    (11,'Nathanael Baring','H'),
    (12,'Tim Barlow','H'),
    (13,'Michel C�t�','H'),
    (14,'Marc-Andr� Grodin','H'),
    (15,'Danielle Proulx','F'),
    (16,'Glenn Close','F'),
    (17,'G�rard Depardieu','H'),
    (18,'Alice Evans','F'),
    (19,'Isabelle Blais','F'),
    (20,'Ricardo Trogi','H'),
    (21,'Louis-Jos� Houde','H'),
    (22,'Patrick Huard','H'),
    (23,'Christopher Heyerdahl','H'),
    (24,'Julie Lebreton','F'),
    (25,'Anne Dorval','F'),
    (26,'Xavier Dolan','H'),
    (27,'Al Pacino','H'),
    (28,'Diane Keaton','F'),
    (29,'Henry Fonda','H'),
    (30,'Adrien Brody','H'),
    (31,'Keira Knightley','F'),
    (32,'Kris Kristofferson','H'),
    (33,'Tim Robbins','H'),
    (34,'Morgan Freeman','H'),
    (35,'Bob Gunton','H'),
    (36,'Drew Barrymore','F'),
    (37,'Anjelica Huston','F'),
    (38,'Drougray Scott','H'),
    (39,'Liam Neeson','H'),
    (40,'Bradley Cooper','H');

------------------------------------------------------------------------------

CREATE TABLE Categories (
    NoCategorie INT NOT NULL PRIMARY KEY,
    Description NVARCHAR(50) NOT NULL
)
INSERT INTO Categories VALUES
    (1,'Action'),
    (2,'Adolescent'),
    (3,'Biographie'),
    (4,'Cape et d''�p�e'),
    (5,'Catastrophe'),
    (6,'Chronique'),
    (7,'Com�die de moeurs'),
    (8,'Com�die d''horreur'),
    (9,'Com�die dramatique'),
    (10,'Com�die fantaisiste'),
    (11,'Com�die musicale'),
    (12,'Com�die polici�re'),
    (13,'Com�die satirique'),
    (14,'Com�die sentimentale'),
    (15,'Com�die'),
    (16,'Criminel'),
    (17,'Danse'),
    (18,'Dessins anim�s'),
    (19,'Documentaire'),
    (20,'Drame de guerre'),
    (21,'Drame de moeurs'),
    (22,'Drame d''horreur'),
    (23,'Drame judiciaire'),
    (24,'Drame musical'),
    (25,'Drame po�tique'),
    (26,'Drame policier'),
    (27,'Drame psychologique'),
    (28,'Drame sentimental'),
    (29,'Drame social'),
    (30,'Drame'),
    (31,'Espionnage'),
    (32,'Exp�rimental'),
    (33,'Fantastique'),
    (34,'Film � sketches'),
    (35,'Film d''animation'),
    (36,'Film d''art martial'),
    (37,'Historique'),
    (38,'Horreur'),
    (39,'Humoristique'),
    (40,'Marionnettes'),
    (41,'M�lodrame'),
    (42,'Musical'),
    (43,'Road movie'),
    (44,'Romantique'),
    (45,'Science-fiction'),
    (46,'S�rie polici�re'),
    (47,'S�rie TV'),
    (48,'Spectacle d''humour'),
    (49,'Spectacle musical'),
    (50,'Suspense'),
    (51,'Western');

------------------------------------------------------------------------------
CREATE TABLE Formats (
    NoFormat INT NOT NULL PRIMARY KEY,
    Description NVARCHAR(50) NOT NULL
);
INSERT INTO Formats VALUES
    (1,'Blu-Ray'),
    (2,'Normal'),
    (3,'Panoramique');
------------------------------------------------------------------------------
CREATE TABLE Langues (
    NoLangue INT NOT NULL PRIMARY KEY,
    Langue NVARCHAR(10) NOT NULL
);
INSERT INTO Langues VALUES
    (1,'Fran�ais'),
    (2,'Anglais'),
    (3,'Espagnol');
------------------------------------------------------------------------------
CREATE TABLE Preferences (
    NoPreference INT NOT NULL PRIMARY KEY,
    Description NVARCHAR(50) NOT NULL
);
INSERT INTO Preferences VALUES
    (1,'Couleur de fond'),
    (2,'Couleur du texte'),
    (3,'Envoi courriel si ajout'),
    (4,'Envoi courriel si appropriation'),
    (5,'Envoi courriel si suppression'),
    (6,'Image de fond'),
    (7,'Nombre de films par page');
------------------------------------------------------------------------------
CREATE TABLE Producteurs (
    NoProducteur INT NOT NULL PRIMARY KEY,
    Nom NVARCHAR(50) NOT NULL
);
INSERT INTO Producteurs VALUES
    (1,'Francis Ford Coppola'),
    (2,'Jerry Weintraub'),
    (3,'Jim Czarnecki'),
    (4,'Michael Wimer'),
    (5,'Pierre Even'),
    (6,'Edward S. Feldman'),
    (7,'Nicole Robert'),
    (8,'Pierre Gendron'),
    (9,'Xavier Dolan'),
    (10,'Albert S. Ruddy'),
    (11,'Henry Fonda'),
    (12,'George Clooney'),
    (13,'Niki Marvin'),
    (14,'Peter Jackson'),
    (15,'Stephen J. Cannell'),
    (16,'Oren Peli'),
    (17,'Matthew Gross');
------------------------------------------------------------------------------
CREATE TABLE Realisateurs (
    NoRealisateur INT NOT NULL PRIMARY KEY,
    Nom NVARCHAR(50) NOT NULL
);
INSERT INTO Realisateurs VALUES
    (1,'Francis Ford Coppola'),
    (2,'Claude Desrosiers'),
    (3,'Steven Soderbergh'),
    (4,'Michael Moore'),
    (5,'Roland Emmerich'),
    (6,'Jean-Marc Vall�e'),
    (7,'Kevin Lima'),
    (8,'Yves Pelletier'),
    (9,'�ric Canuel'),
    (10,'Xavier Dolan'),
    (11,'Sidney Lumet'),
    (12,'John Maybury'),
    (13,'Frank Darabont'),
    (14,'Andy Tennant'),
    (15,'Joe Carnahan'),
    (16,'Oren Peli'),
    (17,'Philippe Gagnon'),
    (18,'Julie Taymor');
------------------------------------------------------------------------------
CREATE TABLE SousTitres (
    NoSousTitre INT NOT NULL PRIMARY KEY,
    LangueSousTitre NVARCHAR(10) NOT NULL
);
INSERT INTO SousTitres VALUES
    (1,'Fran�ais'),
    (2,'Anglais'),
    (3,'Espagnol');
------------------------------------------------------------------------------
CREATE TABLE Supplements (
    NoSupplement INT NOT NULL PRIMARY KEY,
    Description NVARCHAR(50) NOT NULL
);
INSERT INTO Supplements VALUES
    (1,'Bande-annonce (Trailer)'),
    (2,'Bande sonore'),
    (3,'Commentaires audio'),
    (4,'Documentaire sur la cr�ation du film'),
    (5,'Fin alternative'),
    (6,'Gaffes (Bloopers)'),
    (7,'Galerie d''images'),
    (8,'Interpr�tes et artisans'),
    (9,'Montages de prises rat�es'),
    (10,'Notes de production'),
    (11,'Sauvegarde d''�cran'),
    (12,'Sc�nes in�dites'),
    (13,'Sc�nes supprim�es'),
    (14,'S�lection des sc�nes'),
    (15,'Visionneur de sc�nario-maquette');
------------------------------------------------------------------------------
CREATE TABLE TypesUtilisateur (
    TypeUtilisateur NCHAR(1) NOT NULL PRIMARY KEY,
    Description NVARCHAR(50) NOT NULL
);
INSERT INTO TypesUtilisateur VALUES
    ('A','Administrateur'),
    ('S','Super utilisateur'),
    ('U','Utilisateur');
------------------------------------------------------------------------------
CREATE TABLE Utilisateurs (
    NoUtilisateur INT NOT NULL PRIMARY KEY,
    NomUtilisateur NVARCHAR(15) NOT NULL, -- initialement NVARCHAR(10)
    Courriel NVARCHAR(50) NOT NULL,
    MotPasse INT NOT NULL,
    TypeUtilisateur NCHAR(1) NOT NULL FOREIGN KEY REFERENCES TypesUtilisateur(TypeUtilisateur)
);
INSERT INTO Utilisateurs VALUES
    (1,'admin','m.airouche@cgodin.qc.ca',99999,'A'),
    (2,'helene','helene@gmail.com',11111,'S'),
    (3,'lucille','lucille@gmail.com',22222,'U'),
    (4,'louis.marie','louis@gmail.com',33333,'U'),
    (5,'rejean','rejean@gmail.com',44444,'U'),
    (6,'christian','christian@gmail.com',55555,'U'),
    (7,'jose','jose@gmail.com',66666,'U');

------------------------------------------------------------------------------
CREATE TABLE UtilisateursPreferences (
    NoUtilisateur INT NOT NULL FOREIGN KEY REFERENCES Utilisateurs(NoUtilisateur),
    NoPreference INT NOT NULL FOREIGN KEY REFERENCES Preferences(NoPreference),
	Valeur NVARCHAR(50)
);
INSERT INTO UtilisateursPreferences VALUES
    (3,1,'Yellow'),
    (3,2,'Blue'),
    (4,3,NULL),
    (5,3,NULL),
    (5,4,NULL),
    (6,3,NULL),
    (6,4,NULL),
    (6,5,NULL),
    (7,1,'Blue'),
    (7,2,'Yellow'),
    (7,3,NULL),
    (7,4,NULL),
    (7,5,NULL),
    (7,7,'20');
------------------------------------------------------------------------------
/*CREATE TABLE ValeursPreferences (
    NoUtilisateur INT NOT NULL FOREIGN KEY REFERENCES UtilisateursPreferences(NoUtilisateur),
    NoPreference INT NOT NULL FOREIGN KEY REFERENCES UtilisateursPreferences(NoPreference),
    Valeur NVARCHAR(50) NOT NULL
);
INSERT INTO ValeursPreferences VALUES
    (3,1,'Yellow'),
    (3,2,'Blue'),
    (7,1,'Blue'),
    (7,2,'Yellow'),
    (7,7,'20');
*/
------------------------------------------------------------------------------

CREATE TABLE EmpruntsFilms (
    NoExemplaire INT NOT NULL PRIMARY KEY,
    NoUtilisateur INT NOT NULL FOREIGN KEY REFERENCES Utilisateurs(NoUtilisateur),
    DateEmprunt DATETIME NOT NULL
);
INSERT INTO EmpruntsFilms VALUES
    (18100101,3,'2018-10-01 00:00:00'),
    (18100201,4,'2018-10-01 00:00:00'),
    (18100301,6,'2018-10-01 00:00:00'),
    (18100401,6,'2018-10-01 00:00:00'),
    (18100501,2,'2018-10-02 00:00:00'),
    (18100601,2,'2018-10-02 00:00:00'),
    (18100701,3,'2018-10-05 00:00:00'),
    (18100801,4,'2018-10-07 00:00:00'),
    (18100901,3,'2018-10-09 00:00:00'),
    (18101001,3,'2018-10-10 00:00:00'),
    (18101101,6,'2018-10-11 00:00:00'),
    (18101201,4,'2018-10-23 00:00:00'),
    (18101301,2,'2018-10-24 00:00:00'),
    (18101401,2,'2018-10-24 00:00:00'),
    (18110101,3,'2018-11-01 00:00:00'),
    (18110201,3,'2018-11-02 00:00:00'),
    (18110301,3,'2018-11-03 00:00:00'),
    (18110401,6,'2018-11-08 00:00:00'),
    (18110501,3,'2018-11-13 00:00:00'),
    (18110601,3,'2018-11-14 00:00:00'),
    (18110701,2,'2018-11-15 00:00:00'),
    (18110801,3,'2018-11-16 00:00:00'),
    (18110901,3,'2018-11-17 00:00:00'),
    (18111001,2,'2018-11-17 00:00:00'),
    (18111101,6,'2018-11-18 00:00:00'),
    (18111201,4,'2018-11-19 00:00:00'),
    (18111301,3,'2018-11-20 00:00:00'),
    (18111401,3,'2018-11-21 00:00:00'),
    (18111501,6,'2018-11-22 00:00:00'),
    (18111601,3,'2018-11-23 00:00:00'),
    (18111701,6,'2018-11-24 00:00:00'),
    (18111801,4,'2018-11-25 00:00:00'),
    (18111901,3,'2018-11-26 00:00:00'),
    (18120101,2,'2018-12-01 00:00:00'),
    (18120201,6,'2018-12-02 00:00:00'),
    (18120301,6,'2018-12-03 00:00:00');

------------------------------------------------------------------------------

CREATE TABLE Exemplaires (
    NoExemplaire INT NOT NULL PRIMARY KEY,
    NoUtilisateurProprietaire INT NOT NULL FOREIGN KEY REFERENCES Utilisateurs(NoUtilisateur)
);
INSERT INTO Exemplaires VALUES
    (18100101,3),
    (18100201,4),
    (18100301,6),
    (18100401,6),
    (18100501,2),
    (18100601,2),
    (18100701,3),
    (18100801,4),
    (18100901,3),
    (18101001,3),
    (18101101,6),
    (18101201,4),
    (18101301,2),
    (18101401,2),
    (18110101,3),
    (18110201,3),
    (18110301,3),
    (18110401,6),
    (18110501,3),
    (18110601,3),
    (18110701,2),
    (18110801,3),
    (18110901,3),
    (18111001,2),
    (18111101,6),
    (18111201,4),
    (18111301,3),
    (18111401,3),
    (18111501,6),
    (18111601,3),
    (18111701,6),
    (18111801,4),
    (18111901,3),
    (18120101,2),
    (18120201,6),
    (18120301,6);

------------------------------------------------------------------------------

CREATE TABLE Films (
    NoFilm INT NOT NULL PRIMARY KEY,
    AnneeSortie INT,
    Categorie INT FOREIGN KEY REFERENCES Categories(NoCategorie),
    Format INT FOREIGN KEY REFERENCES Formats(NoFormat),
    DateMAJ DATETIME NOT NULL,
    NoUtilisateurMAJ INT NOT NULL FOREIGN KEY REFERENCES Utilisateurs(NoUtilisateur),
    Resume NVARCHAR(500),
    DureeMinutes INT,
    FilmOriginal INT,
    ImagePochette NVARCHAR(50),
    NbDisques INT,
    TitreFrancais NVARCHAR(50) NOT NULL,
    TitreOriginal NVARCHAR(50),
    VersionEtendue BIT,
    NoRealisateur INT FOREIGN KEY REFERENCES Realisateurs(NoRealisateur),
    NoProducteur INT FOREIGN KEY REFERENCES Producteurs(NoProducteur),
    XTra NVARCHAR(255) NOT NULL
);
INSERT INTO Films VALUES
    (181001,1979,20,3,'2018-10-01 00:00:00',3,'Le capitaine Willard (Martin Sheen) est envoy� au Cambodge avec pour mission d''ex�cuter le colonel Kurtz (Marlon Brando), un officier am�ricain d�serteur qui a perdu la raison et s''est improvis� souverain d''une tribu indig�ne. En descendant la rivi�re qui le m�nera � son but, Willard rencontre le lieutenant colonel Kilgore (Robert Duvall) dont l''amour de la guerre n''a d''�gal que sa passion pour le " surf ".',217,NULL,'171001.jpg',3,'C''est l''apocalypse','Apocalypse now',1,1,1,'http://www.cinemamontreal.com/films/3114/C_est_l_Apocalypse.html'),
    (181002,2004,15,3,'2018-10-01 00:00:00',4,'En 2035, la couche d''ozone a �t� d�truite par le gaz carbonique des voitures, l''industrie chimique et le pouch-pouch en ca-cane. La Terre cuit sous les rayons du soleil et les compagnies de cr�me solaire s''enrichissent. Il faut trouver une nouvelle plan�te pour six milliards de tatas. Le capitaine Charles Patenaude et son �quipage s''embarquent ainsi sur le vaisseau spatial Romano Fafard, en route vers les confins de l''univers !',109,1,'171002.jpg',1,'Dans une galaxie pr�s de chez vous','Dans une galaxie pr�s de chez vous',0,2,NULL,'http://www.cinemamontreal.com/films/5918/Dans_une_galaxie_pres_de_chez_vous.html'),
    (181003,2007,50,1,'2018-10-01 00:00:00',6,NULL,122,1,'171003.jpg',1,'Danny Ocean 13','Ocean''s thirteen',0,3,2,'http://www.cinemamontreal.com/films/10648/Danny_Ocean_13.html'),
    (181004,2004,19,1,'2018-10-01 00:00:00',6,'Michael Moore pr�sente avec scepticisme le Pr�sident George W. Bush et ses propres conseillers. Prenant pour point de d�part l''�lection controvers�e de 2000, le r�alisateur retrace l''improbable ascension d''un m�diocre p�trolier texan devenu ma�tre du monde libre. Puis il ouvre la bo�te de Pandore du Pr�sident et r�v�le les liens personnels et financiers qui unissent la famille Bush � celle de Ben Laden. Michael Moore y d�nonce �galement les m�faits du Patriot Act et les souffrances provoqu�es pa',110,1,'171004.jpg',1,'Fahrenheit 9/11 v.f.','Fahrenheit 9/11',0,4,3,'http://www.cinemamontreal.com/films/6399/Fahrenheit_9_11_v_f.html'),
    (181005,NULL,NULL,NULL,'2018-10-02 00:00:00',2,NULL,NULL,NULL,NULL,NULL,'Op�ration G-Force','G-Force',NULL,NULL,NULL,'http://www.cinemamontreal.com/films/13879/G-Force.html'),
    (181006,2008,30,3,'2018-10-02 00:00:00',2,'10 000 ans avant J-C, un homme de 21 et sa tribu luttent pour survivre en chassant les mammouths. Quand les chasseurs de son clan et la princesse dont il est tomb� amoureux sont faits prisonniers, il se lance � leur secours...',109,1,'171006.jpg',1,'10 000 av. J.-C.','10,000 B.C.',0,5,4,'http://www.cinemamontreal.com/films/10687/10_000_av__J_-C.html'),
    (181007,NULL,NULL,NULL,'2018-10-05 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'Ghandi',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/3601/Gandhi.html'),
    (181008,2005,30,3,'2018-10-07 00:00:00',4,'25 d�cembre 1960: Zachary Beaulieu vient au monde, quatri�me d''une famille de cinq gar�ons. Famille de banlieue sans histoire avec une m�re aimante et un p�re un peu bourru, mais fier de ses gar�ons. Le d�but d''une belle enfance, o� se succ�dent les No�l et les anniversaires avec l''�ternel solo du p�re Beaulieu chantant Aznavour, Emm�ne-moi au bout de la terre, les s�ances de lavage de voiture en plein air et les visites au casse-cro�te pour Zac, le chouchou de son p�re pour une fois.',127,1,'171008.jpg',1,'C.R.A.Z.Y.','C.R.A.Z.Y.',0,6,5,'http://www.cinemamontreal.com/films/8020/C_R_A_Z_Y.html'),
    (181009,NULL,NULL,NULL,'2018-10-09 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'G.I. Joe: Le r�veil du cobra',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/16921/G_I__Joe__Le_reveil_du_cobra.html'),
    (181010,NULL,NULL,NULL,'2018-10-10 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'Les gangs de New-York',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/2975/Les_Gangs_de_New-York.html'),
    (181011,2000,18,3,'2018-10-11 00:00:00',6,'Cruella De Vil (Glenn Close) est lib�r�e de prison pour bonne conduite, avec la promesse que plus jamais elle n''aura affaire avec la fourrure. Promesse rapidement oubli�e alors qu''elle �chafaude une magouille pour se procurer l''ultime manteau en peaux de dalmatiens.',100,1,NULL,1,'102 Dalmatiens vf.','102 Dalmatians',0,7,6,'http://www.cinemamontreal.com/films/2/102_Dalmatiens_vf.html'),
    (181012,2010,15,1,'2018-10-23 00:00:00',4,'Benoit, un com�dien qui survit gr�ce � un emploi de barman, suit le conseil de son fr�re Frank, un ex-joueur de hockey devenu son agent. Il d�cide de se faire pousser la barbe pour un r�le dans un souper-spectacle. Sa blonde Vicky, une ex-dramaturge devenue biblioth�caire, accepte mal cette nouvelle lubie car elle retarde leur projet d''acheter le condo de leurs amis Caro et Vincent, qui tiennent un salon de coiffure et d''esth�tique. Mais la barbe de Benoit semble magique: il commence � avoir du ',100,1,'171012.jpg',1,'Le baiser du barbu','Le baiser du barbu',0,8,7,'http://www.cinemamontreal.com/films/36092/Le_Baiser_du_barbu.html'),
    (181013,2007,15,3,'2018-10-24 00:00:00',2,'Cadavres raconte, sous la forme d''une com�die cynique r�solument moderne, l''�ternelle histoire du p�ch� originel. Le jour de la mort de sa m�re, Raymond Marchildon appelle � la rescousse Ang�le, sa soeur a�n�e. Il r�veille alors la conscience qu''il lui manquait, ainsi que les souvenirs d''un paradis perdu: l''innocence de leur enfance. Le fr�re et la soeur deviennent rapidement ins�parables dans un monde de plus en plus absurde o� les cadavres s''accumulent dans le sous-sol de la maison. Voil� que ',117,1,'171013.jpg',1,'Cadavres','Cadavres',0,9,8,'http://www.cinemamontreal.com/films/12015/Cadavres.html'),
    (181014,NULL,NULL,NULL,'2018-10-24 00:00:00',2,NULL,NULL,NULL,NULL,NULL,'J''ai tu� ma m�re',NULL,NULL,10,9,'http://www.cinemamontreal.com/films/32791/J_ai_tue_ma_mere.html'),
    (181101,NULL,NULL,NULL,'2018-11-01 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'Madagascar v.f.','Madagascar',NULL,NULL,NULL,'http://www.cinemamontreal.com/films/7729/Madagascar_v_f.html'),
    (181102,NULL,NULL,NULL,'2018-11-02 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'Le Parrain',NULL,NULL,1,10,'http://www.cinemamontreal.com/films/526/Le_Parrain.html'),
    (181103,NULL,NULL,NULL,'2018-11-03 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'La Bataille de Passchendaele',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/19063/Passchendaele.html'),
    (181104,1957,30,2,'2018-11-08 00:00:00',6,NULL,96,1,'171104.jpg',1,'12 hommes en col�re','12 angry men',0,11,11,'http://www.cinemamontreal.com/films/3546/12_Hommes_En_Colere.html'),
    (181105,2005,50,1,'2018-11-13 00:00:00',3,'Jack Starks (Adrian Brody) est tr�s chanceux lorsqu''il �chappe miraculeusement � la mort lors de la guerre du Golf et retourne dans son pays natal. Malheureusement, sa cicatrice de guerre c''est l''amn�sie, ce qui l''emp�che, alors qu''il est accus� de meurtre, de se d�fendre. Il �choue dans un asile o� un docteur (Kris Kristofferson) d�veloppe, pour �liminer les instincts criminels, un traitement exp�rimental � base d''un cocktail m�dicamenteux. Enferm� dans un caisson, ce traitement va le faire voy',102,1,'171105.jpg',1,'La camisole de force','The jacket',0,12,12,'http://www.cinemamontreal.com/films/7708/La_Camisole_de_force.html'),
    (181106,NULL,NULL,NULL,'2018-11-14 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'La passion du Christ',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/5811/La_Passion_du_Christ.html'),
    (181107,1994,30,3,'2018-11-15 00:00:00',2,NULL,142,1,'171107.jpg',2,'� l''ombre de Shawshank','The Shawshank Redemption',0,13,13,'http://www.cinemamontreal.com/films/1194/A_l_ombre_de_Shawshank.html'),
    (181108,NULL,NULL,NULL,'2018-11-16 00:00:00',3,NULL,NULL,0,NULL,NULL,'Hary Potter et les reliques de la mort : Partie 1',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/21868/Harry_Potter_et_les_reliques_de_la_mort__Partie_1.html'),
    (181109,NULL,NULL,NULL,'2018-11-17 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'La saga Twilight : H�sitation',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/35777/La_Saga_Twilight__Hesitation.html'),
    (181110,NULL,NULL,NULL,'2018-11-17 00:00:00',2,NULL,NULL,NULL,NULL,NULL,'Le Seigneur des Anneaux: La Communaut� de l''Anneau',NULL,NULL,NULL,14,'http://www.cinemamontreal.com/films/2046/Le_Seigneur_des_Anneaux__La_Communaute_de_l_Anneau.html'),
    (181111,NULL,NULL,NULL,'2018-11-18 00:00:00',6,NULL,NULL,NULL,NULL,NULL,'Le Seigneur des anneaux: le retour du roi ',NULL,NULL,NULL,14,'http://www.cinemamontreal.com/films/4965/Le_Seigneur_des_anneaux__le_retour_du_roi.html'),
    (181112,1998,44,3,'2018-11-19 00:00:00',4,'Nous sommes au 16e sci�cle. Danielle est une jeune femme, qui aime lire, et qui est capable de citer facilement des extraits d''Utopia de Thomas Moore. Elle en possede assez de charme pour capturer le coeur d''un prince... apr�s l''avoir tir� de son cheval avec une pomme.',121,1,'171112.jpg',1,'� Tout Jamais','Ever After',0,14,NULL,'http://www.cinemamontreal.com/films/435/A_Tout_Jamais.html'),
    (181113,NULL,NULL,NULL,'2018-11-20 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'Le Seigneur des Anneaux: Les Deux Tours',NULL,NULL,NULL,14,'http://www.cinemamontreal.com/films/3671/Le_Seigneur_des_Anneaux__Les_Deux_Tours.html'),
    (181114,2010,15,1,'2018-11-21 00:00:00',3,'Quatre soldats am�ricains sont arr�t�s au Moyen-Orient suite � une mission secr�te. Ils s''�chappent de la prison militaire pour monter une �quipe de mercenaires du bien.',117,1,'171114.jpg',1,'L''Agence tous risques','The A-Team',0,15,15,'http://www.cinemamontreal.com/films/20568/L_Agence_tous_risques.html'),
    (181115,NULL,NULL,NULL,'2018-11-22 00:00:00',6,NULL,NULL,NULL,NULL,NULL,'Les Sept jours du Talion',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/34235/Les_Sept_jours_du_Talion.html'),
    (181116,NULL,NULL,NULL,'2018-11-23 00:00:00',3,NULL,NULL,0,NULL,NULL,'Lance et compte',NULL,NULL,NULL,NULL,'http://www.lanceetcompte-lefilm.ca/'),
    (181117,2008,38,1,'2018-11-24 00:00:00',6,'Un couple est hant� par un esprit d�moniaque.',99,1,'171117.jpg',1,'Activit� paranormale','Paranormal Activity',0,16,16,'http://www.cinemamontreal.com/films/19213/Activite_paranormale.html'),
    (181118,2008,15,3,'2018-11-25 00:00:00',4,'Convaincus du bien-fond� de leur mission (et aussi parce qu''ils n''avaient rien d''autre � faire ce jour-l�), les membres de l''�quipage du vaisseau Romano Fafard explorent de nouvelles galaxies � la recherche d''une plan�te habitable o� d�m�nager les Terriens. Toutefois, cette exploration tourne court suite � la perte accidentelle de la seule sonde qui leur reste. Selon les calculs de Flavien, la sonde se serait �cras�e sur la plan�te "Cr�me hydratante pour le visage - soulage la peau s�che". Le Ca',100,1,'171118.jpg',1,'Dans une galaxie pr�s de chez vous 2','Dans une galaxie pr�s de chez vous 2',0,17,NULL,'http://www.cinemamontreal.com/films/18091/Dans_une_galaxie_pres_de_chez_vous_2.html'),
    (181119,NULL,NULL,NULL,'2018-11-26 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'T''choupi, le film',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/7712/T_choupi__le_film.html'),
    (181201,2007,11,1,'2018-12-01 00:00:00',2,'Une histoire d''amour qui se d�roule au milieu des ann�es 60 et des manifestations anti-guerre, de la lutte pour la libert� d''expression et les droits civiques, l''exploration des esprits et le rock''n roll. Le film nous fait voyager des Universit�s du Massachussetts et de l''Ohio, aux �meutes de D�troit et aux champs de batailles du Vietnam, en passant par les docks de Liverpool. Les amants Jude (Jim Sturgess) et Lucy (Evan Rachel Wood) se retrouvent, en compagnie d''une bande de musiciens et d''amis',133,1,'171201.jpg',1,'� travers l''univers','Across the Universe',0,18,17,'http://www.cinemamontreal.com/films/11057/A_travers_l_univers.html'),
    (181202,NULL,NULL,NULL,'2018-12-02 00:00:00',6,NULL,NULL,NULL,NULL,NULL,'Le tambour',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/3173/Le_Tambour.html'),
    (181203,NULL,NULL,NULL,'2018-12-03 00:00:00',6,NULL,NULL,NULL,NULL,NULL,'V for Vendetta',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/8531/V_for_Vendetta.html');

------------------------------------------------------------------------------

CREATE TABLE FilmsActeurs (
    NoFilm INT NOT NULL FOREIGN KEY REFERENCES Films(NoFilm),
    NoActeur INT NOT NULL FOREIGN KEY REFERENCES Acteurs(NoActeur)
);
INSERT INTO FilmsActeurs VALUES
    (181001,1),
    (181001,2),
    (181001,3),
    (181002,4),
    (181002,5),
    (181002,6),
    (181003,7),
    (181003,8),
    (181003,9),
    (181006,10),
    (181006,11),
    (181006,12),
    (181008,13),
    (181008,14),
    (181008,15),
    (181011,16),
    (181011,17),
    (181011,18),
    (181012,19),
    (181012,20),
    (181012,21),
    (181013,22),
    (181013,23),
    (181013,24),
    (181014,25),
    (181014,26),
    (181102,1),
    (181102,27),
    (181102,28),
    (181104,29),
    (181105,30),
    (181105,31),
    (181105,32),
    (181107,33),
    (181107,34),
    (181107,35),
    (181112,36),
    (181112,37),
    (181112,38),
    (181114,39),
    (181114,40),
    (181118,4),
    (181118,5),
    (181118,6);

------------------------------------------------------------------------------

CREATE TABLE FilmsLangues (
    NoFilm INT NOT NULL FOREIGN KEY REFERENCES Films(NoFilm),
    NoLangue INT NOT NULL FOREIGN KEY REFERENCES Langues(NoLangue)
);
INSERT INTO FilmsLangues VALUES
    (181001,1),
    (181001,2),
    (181001,3),
    (181002,1),
    (181003,1),
    (181003,2),
    (181003,3),
    (181004,2),
    (181005,1),
    (181006,1),
    (181006,2),
    (181006,3),
    (181007,1),
    (181008,1),
    (181009,1),
    (181010,1),
    (181011,1),
    (181011,2),
    (181011,3),
    (181012,1),
    (181013,1),
    (181014,1),
    (181101,1),
    (181102,1),
    (181102,2),
    (181102,3),
    (181103,1),
    (181104,1),
    (181104,2),
    (181104,3),
    (181105,1),
    (181105,2),
    (181105,3),
    (181106,1),
    (181107,1),
    (181107,2),
    (181107,3),
    (181108,1),
    (181109,1),
    (181110,1),
    (181111,1),
    (181112,1),
    (181112,2),
    (181112,3),
    (181113,1),
    (181115,1),
    (181116,1),
    (181117,1),
    (181117,2),
    (181117,3),
    (181118,1),
    (181119,1),
    (181201,1),
    (181201,2),
    (181201,3),
    (181202,1),
    (181203,1);

------------------------------------------------------------------------------

CREATE TABLE FilmsSousTitres (
    NoFilm INT NOT NULL FOREIGN KEY REFERENCES Films(NoFilm),
    NoSousTitre INT NOT NULL FOREIGN KEY REFERENCES SousTitres(NoSousTitre)
);
INSERT INTO FilmsSousTitres VALUES
    (181001,1),
    (181001,2),
    (181001,3),
    (181003,1),
    (181003,2),
    (181003,3),
    (181004,1),
    (181004,3),
    (181006,1),
    (181006,2),
    (181006,3),
    (181011,1),
    (181011,2),
    (181011,3),
    (181012,2),
    (181013,2),
    (181014,2),
    (181102,1),
    (181102,2),
    (181102,3),
    (181104,1),
    (181104,2),
    (181104,3),
    (181105,1),
    (181105,2),
    (181105,3),
    (181107,1),
    (181107,2),
    (181107,3),
    (181112,1),
    (181112,2),
    (181112,3),
    (181115,2),
    (181116,2),
    (181117,1),
    (181117,2),
    (181117,3),
    (181201,1),
    (181201,2),
    (181201,3);

------------------------------------------------------------------------------

CREATE TABLE FilmsSupplements (
    NoFilm INT NOT NULL FOREIGN KEY REFERENCES Films(NoFilm),
    NoSupplement INT NOT NULL FOREIGN KEY REFERENCES Supplements(NoSupplement)
);
INSERT INTO FilmsSupplements VALUES
    (181001,4),
    (181001,13),
    (181002,6),
    (181002,13),
    (181002,14),
    (181003,4),
    (181003,9),
    (181003,12),
    (181004,1),
    (181006,1),
    (181006,2),
    (181006,4),
    (181008,1),
    (181008,2),
    (181008,14),
    (181011,1),
    (181011,4),
    (181011,11),
    (181012,1),
    (181012,13),
    (181012,15),
    (181013,1),
    (181013,4),
    (181013,8),
    (181014,8),
    (181014,10),
    (181014,15),
    (181105,1),
    (181105,5),
    (181105,10),
    (181107,1),
    (181107,8),
    (181112,6),
    (181114,1),
    (181114,6),
    (181114,9),
    (181117,1),
    (181117,4),
    (181117,14),
    (181118,1),
    (181118,4),
    (181118,6),
    (181201,1),
    (181201,2),
    (181201,8);
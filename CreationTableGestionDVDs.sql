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
    (6,'Stéphane Crête','H'),
    (7,'Georges Clooney','H'),
    (8,'Brad Pitt','H'),
    (9,'Matt Damon','H'),
    (10,'Steven Strait','H'),
    (11,'Nathanael Baring','H'),
    (12,'Tim Barlow','H'),
    (13,'Michel Côté','H'),
    (14,'Marc-André Grodin','H'),
    (15,'Danielle Proulx','F'),
    (16,'Glenn Close','F'),
    (17,'Gérard Depardieu','H'),
    (18,'Alice Evans','F'),
    (19,'Isabelle Blais','F'),
    (20,'Ricardo Trogi','H'),
    (21,'Louis-José Houde','H'),
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
    (4,'Cape et d''épée'),
    (5,'Catastrophe'),
    (6,'Chronique'),
    (7,'Comédie de moeurs'),
    (8,'Comédie d''horreur'),
    (9,'Comédie dramatique'),
    (10,'Comédie fantaisiste'),
    (11,'Comédie musicale'),
    (12,'Comédie policière'),
    (13,'Comédie satirique'),
    (14,'Comédie sentimentale'),
    (15,'Comédie'),
    (16,'Criminel'),
    (17,'Danse'),
    (18,'Dessins animés'),
    (19,'Documentaire'),
    (20,'Drame de guerre'),
    (21,'Drame de moeurs'),
    (22,'Drame d''horreur'),
    (23,'Drame judiciaire'),
    (24,'Drame musical'),
    (25,'Drame poétique'),
    (26,'Drame policier'),
    (27,'Drame psychologique'),
    (28,'Drame sentimental'),
    (29,'Drame social'),
    (30,'Drame'),
    (31,'Espionnage'),
    (32,'Expérimental'),
    (33,'Fantastique'),
    (34,'Film à sketches'),
    (35,'Film d''animation'),
    (36,'Film d''art martial'),
    (37,'Historique'),
    (38,'Horreur'),
    (39,'Humoristique'),
    (40,'Marionnettes'),
    (41,'Mélodrame'),
    (42,'Musical'),
    (43,'Road movie'),
    (44,'Romantique'),
    (45,'Science-fiction'),
    (46,'Série policière'),
    (47,'Série TV'),
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
    (1,'Français'),
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
    (6,'Jean-Marc Vallée'),
    (7,'Kevin Lima'),
    (8,'Yves Pelletier'),
    (9,'Éric Canuel'),
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
    (1,'Français'),
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
    (4,'Documentaire sur la création du film'),
    (5,'Fin alternative'),
    (6,'Gaffes (Bloopers)'),
    (7,'Galerie d''images'),
    (8,'Interprètes et artisans'),
    (9,'Montages de prises ratées'),
    (10,'Notes de production'),
    (11,'Sauvegarde d''écran'),
    (12,'Scènes inédites'),
    (13,'Scènes supprimées'),
    (14,'Sélection des scènes'),
    (15,'Visionneur de scénario-maquette');
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
    (181001,1979,20,3,'2018-10-01 00:00:00',3,'Le capitaine Willard (Martin Sheen) est envoyé au Cambodge avec pour mission d''exécuter le colonel Kurtz (Marlon Brando), un officier américain déserteur qui a perdu la raison et s''est improvisé souverain d''une tribu indigène. En descendant la rivière qui le mènera à son but, Willard rencontre le lieutenant colonel Kilgore (Robert Duvall) dont l''amour de la guerre n''a d''égal que sa passion pour le " surf ".',217,NULL,'171001.jpg',3,'C''est l''apocalypse','Apocalypse now',1,1,1,'http://www.cinemamontreal.com/films/3114/C_est_l_Apocalypse.html'),
    (181002,2004,15,3,'2018-10-01 00:00:00',4,'En 2035, la couche d''ozone a été détruite par le gaz carbonique des voitures, l''industrie chimique et le pouch-pouch en ca-cane. La Terre cuit sous les rayons du soleil et les compagnies de crême solaire s''enrichissent. Il faut trouver une nouvelle planète pour six milliards de tatas. Le capitaine Charles Patenaude et son équipage s''embarquent ainsi sur le vaisseau spatial Romano Fafard, en route vers les confins de l''univers !',109,1,'171002.jpg',1,'Dans une galaxie près de chez vous','Dans une galaxie près de chez vous',0,2,NULL,'http://www.cinemamontreal.com/films/5918/Dans_une_galaxie_pres_de_chez_vous.html'),
    (181003,2007,50,1,'2018-10-01 00:00:00',6,NULL,122,1,'171003.jpg',1,'Danny Ocean 13','Ocean''s thirteen',0,3,2,'http://www.cinemamontreal.com/films/10648/Danny_Ocean_13.html'),
    (181004,2004,19,1,'2018-10-01 00:00:00',6,'Michael Moore présente avec scepticisme le Président George W. Bush et ses propres conseillers. Prenant pour point de départ l''élection controversée de 2000, le réalisateur retrace l''improbable ascension d''un médiocre pétrolier texan devenu maître du monde libre. Puis il ouvre la boîte de Pandore du Président et révèle les liens personnels et financiers qui unissent la famille Bush à celle de Ben Laden. Michael Moore y dénonce également les méfaits du Patriot Act et les souffrances provoquées pa',110,1,'171004.jpg',1,'Fahrenheit 9/11 v.f.','Fahrenheit 9/11',0,4,3,'http://www.cinemamontreal.com/films/6399/Fahrenheit_9_11_v_f.html'),
    (181005,NULL,NULL,NULL,'2018-10-02 00:00:00',2,NULL,NULL,NULL,NULL,NULL,'Opération G-Force','G-Force',NULL,NULL,NULL,'http://www.cinemamontreal.com/films/13879/G-Force.html'),
    (181006,2008,30,3,'2018-10-02 00:00:00',2,'10 000 ans avant J-C, un homme de 21 et sa tribu luttent pour survivre en chassant les mammouths. Quand les chasseurs de son clan et la princesse dont il est tombé amoureux sont faits prisonniers, il se lance à leur secours...',109,1,'171006.jpg',1,'10 000 av. J.-C.','10,000 B.C.',0,5,4,'http://www.cinemamontreal.com/films/10687/10_000_av__J_-C.html'),
    (181007,NULL,NULL,NULL,'2018-10-05 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'Ghandi',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/3601/Gandhi.html'),
    (181008,2005,30,3,'2018-10-07 00:00:00',4,'25 décembre 1960: Zachary Beaulieu vient au monde, quatrième d''une famille de cinq garçons. Famille de banlieue sans histoire avec une mère aimante et un père un peu bourru, mais fier de ses garçons. Le début d''une belle enfance, où se succèdent les Noël et les anniversaires avec l''éternel solo du père Beaulieu chantant Aznavour, Emmène-moi au bout de la terre, les séances de lavage de voiture en plein air et les visites au casse-croûte pour Zac, le chouchou de son père pour une fois.',127,1,'171008.jpg',1,'C.R.A.Z.Y.','C.R.A.Z.Y.',0,6,5,'http://www.cinemamontreal.com/films/8020/C_R_A_Z_Y.html'),
    (181009,NULL,NULL,NULL,'2018-10-09 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'G.I. Joe: Le réveil du cobra',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/16921/G_I__Joe__Le_reveil_du_cobra.html'),
    (181010,NULL,NULL,NULL,'2018-10-10 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'Les gangs de New-York',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/2975/Les_Gangs_de_New-York.html'),
    (181011,2000,18,3,'2018-10-11 00:00:00',6,'Cruella De Vil (Glenn Close) est libérée de prison pour bonne conduite, avec la promesse que plus jamais elle n''aura affaire avec la fourrure. Promesse rapidement oubliée alors qu''elle échafaude une magouille pour se procurer l''ultime manteau en peaux de dalmatiens.',100,1,NULL,1,'102 Dalmatiens vf.','102 Dalmatians',0,7,6,'http://www.cinemamontreal.com/films/2/102_Dalmatiens_vf.html'),
    (181012,2010,15,1,'2018-10-23 00:00:00',4,'Benoit, un comédien qui survit grâce à un emploi de barman, suit le conseil de son frère Frank, un ex-joueur de hockey devenu son agent. Il décide de se faire pousser la barbe pour un rôle dans un souper-spectacle. Sa blonde Vicky, une ex-dramaturge devenue bibliothécaire, accepte mal cette nouvelle lubie car elle retarde leur projet d''acheter le condo de leurs amis Caro et Vincent, qui tiennent un salon de coiffure et d''esthétique. Mais la barbe de Benoit semble magique: il commence à avoir du ',100,1,'171012.jpg',1,'Le baiser du barbu','Le baiser du barbu',0,8,7,'http://www.cinemamontreal.com/films/36092/Le_Baiser_du_barbu.html'),
    (181013,2007,15,3,'2018-10-24 00:00:00',2,'Cadavres raconte, sous la forme d''une comédie cynique résolument moderne, l''éternelle histoire du péché originel. Le jour de la mort de sa mère, Raymond Marchildon appelle à la rescousse Angèle, sa soeur aînée. Il réveille alors la conscience qu''il lui manquait, ainsi que les souvenirs d''un paradis perdu: l''innocence de leur enfance. Le frère et la soeur deviennent rapidement inséparables dans un monde de plus en plus absurde où les cadavres s''accumulent dans le sous-sol de la maison. Voilà que ',117,1,'171013.jpg',1,'Cadavres','Cadavres',0,9,8,'http://www.cinemamontreal.com/films/12015/Cadavres.html'),
    (181014,NULL,NULL,NULL,'2018-10-24 00:00:00',2,NULL,NULL,NULL,NULL,NULL,'J''ai tué ma mère',NULL,NULL,10,9,'http://www.cinemamontreal.com/films/32791/J_ai_tue_ma_mere.html'),
    (181101,NULL,NULL,NULL,'2018-11-01 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'Madagascar v.f.','Madagascar',NULL,NULL,NULL,'http://www.cinemamontreal.com/films/7729/Madagascar_v_f.html'),
    (181102,NULL,NULL,NULL,'2018-11-02 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'Le Parrain',NULL,NULL,1,10,'http://www.cinemamontreal.com/films/526/Le_Parrain.html'),
    (181103,NULL,NULL,NULL,'2018-11-03 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'La Bataille de Passchendaele',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/19063/Passchendaele.html'),
    (181104,1957,30,2,'2018-11-08 00:00:00',6,NULL,96,1,'171104.jpg',1,'12 hommes en colère','12 angry men',0,11,11,'http://www.cinemamontreal.com/films/3546/12_Hommes_En_Colere.html'),
    (181105,2005,50,1,'2018-11-13 00:00:00',3,'Jack Starks (Adrian Brody) est très chanceux lorsqu''il échappe miraculeusement à la mort lors de la guerre du Golf et retourne dans son pays natal. Malheureusement, sa cicatrice de guerre c''est l''amnésie, ce qui l''empêche, alors qu''il est accusé de meurtre, de se défendre. Il échoue dans un asile où un docteur (Kris Kristofferson) développe, pour éliminer les instincts criminels, un traitement expérimental à base d''un cocktail médicamenteux. Enfermé dans un caisson, ce traitement va le faire voy',102,1,'171105.jpg',1,'La camisole de force','The jacket',0,12,12,'http://www.cinemamontreal.com/films/7708/La_Camisole_de_force.html'),
    (181106,NULL,NULL,NULL,'2018-11-14 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'La passion du Christ',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/5811/La_Passion_du_Christ.html'),
    (181107,1994,30,3,'2018-11-15 00:00:00',2,NULL,142,1,'171107.jpg',2,'À l''ombre de Shawshank','The Shawshank Redemption',0,13,13,'http://www.cinemamontreal.com/films/1194/A_l_ombre_de_Shawshank.html'),
    (181108,NULL,NULL,NULL,'2018-11-16 00:00:00',3,NULL,NULL,0,NULL,NULL,'Hary Potter et les reliques de la mort : Partie 1',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/21868/Harry_Potter_et_les_reliques_de_la_mort__Partie_1.html'),
    (181109,NULL,NULL,NULL,'2018-11-17 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'La saga Twilight : Hésitation',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/35777/La_Saga_Twilight__Hesitation.html'),
    (181110,NULL,NULL,NULL,'2018-11-17 00:00:00',2,NULL,NULL,NULL,NULL,NULL,'Le Seigneur des Anneaux: La Communauté de l''Anneau',NULL,NULL,NULL,14,'http://www.cinemamontreal.com/films/2046/Le_Seigneur_des_Anneaux__La_Communaute_de_l_Anneau.html'),
    (181111,NULL,NULL,NULL,'2018-11-18 00:00:00',6,NULL,NULL,NULL,NULL,NULL,'Le Seigneur des anneaux: le retour du roi ',NULL,NULL,NULL,14,'http://www.cinemamontreal.com/films/4965/Le_Seigneur_des_anneaux__le_retour_du_roi.html'),
    (181112,1998,44,3,'2018-11-19 00:00:00',4,'Nous sommes au 16e sciècle. Danielle est une jeune femme, qui aime lire, et qui est capable de citer facilement des extraits d''Utopia de Thomas Moore. Elle en possede assez de charme pour capturer le coeur d''un prince... après l''avoir tiré de son cheval avec une pomme.',121,1,'171112.jpg',1,'À Tout Jamais','Ever After',0,14,NULL,'http://www.cinemamontreal.com/films/435/A_Tout_Jamais.html'),
    (181113,NULL,NULL,NULL,'2018-11-20 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'Le Seigneur des Anneaux: Les Deux Tours',NULL,NULL,NULL,14,'http://www.cinemamontreal.com/films/3671/Le_Seigneur_des_Anneaux__Les_Deux_Tours.html'),
    (181114,2010,15,1,'2018-11-21 00:00:00',3,'Quatre soldats américains sont arrêtés au Moyen-Orient suite à une mission secrète. Ils s''échappent de la prison militaire pour monter une équipe de mercenaires du bien.',117,1,'171114.jpg',1,'L''Agence tous risques','The A-Team',0,15,15,'http://www.cinemamontreal.com/films/20568/L_Agence_tous_risques.html'),
    (181115,NULL,NULL,NULL,'2018-11-22 00:00:00',6,NULL,NULL,NULL,NULL,NULL,'Les Sept jours du Talion',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/34235/Les_Sept_jours_du_Talion.html'),
    (181116,NULL,NULL,NULL,'2018-11-23 00:00:00',3,NULL,NULL,0,NULL,NULL,'Lance et compte',NULL,NULL,NULL,NULL,'http://www.lanceetcompte-lefilm.ca/'),
    (181117,2008,38,1,'2018-11-24 00:00:00',6,'Un couple est hanté par un esprit démoniaque.',99,1,'171117.jpg',1,'Activité paranormale','Paranormal Activity',0,16,16,'http://www.cinemamontreal.com/films/19213/Activite_paranormale.html'),
    (181118,2008,15,3,'2018-11-25 00:00:00',4,'Convaincus du bien-fondé de leur mission (et aussi parce qu''ils n''avaient rien d''autre à faire ce jour-là), les membres de l''équipage du vaisseau Romano Fafard explorent de nouvelles galaxies à la recherche d''une planète habitable où déménager les Terriens. Toutefois, cette exploration tourne court suite à la perte accidentelle de la seule sonde qui leur reste. Selon les calculs de Flavien, la sonde se serait écrasée sur la planète "Crème hydratante pour le visage - soulage la peau sèche". Le Ca',100,1,'171118.jpg',1,'Dans une galaxie près de chez vous 2','Dans une galaxie près de chez vous 2',0,17,NULL,'http://www.cinemamontreal.com/films/18091/Dans_une_galaxie_pres_de_chez_vous_2.html'),
    (181119,NULL,NULL,NULL,'2018-11-26 00:00:00',3,NULL,NULL,NULL,NULL,NULL,'T''choupi, le film',NULL,NULL,NULL,NULL,'http://www.cinemamontreal.com/films/7712/T_choupi__le_film.html'),
    (181201,2007,11,1,'2018-12-01 00:00:00',2,'Une histoire d''amour qui se déroule au milieu des années 60 et des manifestations anti-guerre, de la lutte pour la liberté d''expression et les droits civiques, l''exploration des esprits et le rock''n roll. Le film nous fait voyager des Universités du Massachussetts et de l''Ohio, aux émeutes de Détroit et aux champs de batailles du Vietnam, en passant par les docks de Liverpool. Les amants Jude (Jim Sturgess) et Lucy (Evan Rachel Wood) se retrouvent, en compagnie d''une bande de musiciens et d''amis',133,1,'171201.jpg',1,'À travers l''univers','Across the Universe',0,18,17,'http://www.cinemamontreal.com/films/11057/A_travers_l_univers.html'),
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
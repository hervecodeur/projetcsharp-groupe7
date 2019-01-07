/*
SQLyog Community v12.4.2 (64 bit)
MySQL - 5.0.18-nt : Database - pressing
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`pressing` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `pressing`;

/*Table structure for table `authentification` */

DROP TABLE IF EXISTS `authentification`;

CREATE TABLE `authentification` (
  `login` varchar(25) default NULL,
  `pasword` varchar(25) NOT NULL default '',
  PRIMARY KEY  (`pasword`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `authentification` */

/*Table structure for table `facture` */

DROP TABLE IF EXISTS `facture`;

CREATE TABLE `facture` (
  `idfacture` int(11) NOT NULL auto_increment,
  `numeroamoire` int(11) default NULL,
  `datedepot` date default NULL,
  `datedispo` date default NULL,
  `montantpaye` int(11) default NULL,
  `dateretrait` date default NULL,
  `idpers` int(11) default NULL,
  PRIMARY KEY  (`idfacture`),
  KEY `fk_facture_personne` (`idpers`),
  CONSTRAINT `fk_facture_personne` FOREIGN KEY (`idpers`) REFERENCES `personne` (`idpers`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `facture` */

insert  into `facture`(`idfacture`,`numeroamoire`,`datedepot`,`datedispo`,`montantpaye`,`dateretrait`,`idpers`) values 
(1,45,'2019-01-01','2018-12-28',45000,'2018-12-28',NULL),
(2,545,'2018-12-28','2018-12-28',7585,'2018-12-28',NULL),
(3,88,'2018-12-28','2018-12-28',2626,'2018-12-28',4),
(4,566,'2018-12-28','2018-12-28',262,'2018-12-28',3);

/*Table structure for table `fichelavage` */

DROP TABLE IF EXISTS `fichelavage`;

CREATE TABLE `fichelavage` (
  `idlav` int(11) NOT NULL auto_increment,
  `dateretrait_lav` date default NULL,
  `typelavage` varchar(20) default NULL,
  `idlaveur` int(11) default NULL,
  PRIMARY KEY  (`idlav`),
  KEY `fk_fichelavage_personne` (`idlaveur`),
  CONSTRAINT `fk_fichelavage_personne` FOREIGN KEY (`idlaveur`) REFERENCES `personne` (`idpers`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `fichelavage` */

/*Table structure for table `ficherepassage` */

DROP TABLE IF EXISTS `ficherepassage`;

CREATE TABLE `ficherepassage` (
  `idrepas` int(11) NOT NULL auto_increment,
  `dateretrait_rep` date default NULL,
  `idrepasseur` int(11) default NULL,
  PRIMARY KEY  (`idrepas`),
  KEY `fk_ficherepassage_personne` (`idrepasseur`),
  CONSTRAINT `fk_ficherepassage_personne` FOREIGN KEY (`idrepasseur`) REFERENCES `personne` (`idpers`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `ficherepassage` */

/*Table structure for table `incident` */

DROP TABLE IF EXISTS `incident`;

CREATE TABLE `incident` (
  `idincident` int(11) NOT NULL auto_increment,
  `nature` varchar(55) default NULL,
  `datederoulement` date default NULL,
  `idvetement` int(11) default NULL,
  `idpers` int(11) default NULL,
  PRIMARY KEY  (`idincident`),
  KEY `fk_incident_vetement` (`idvetement`),
  KEY `fk_incident_personne` (`idpers`),
  CONSTRAINT `fk_incident_personne` FOREIGN KEY (`idpers`) REFERENCES `personne` (`idpers`) ON UPDATE CASCADE,
  CONSTRAINT `fk_incident_vetement` FOREIGN KEY (`idvetement`) REFERENCES `vetement` (`identifiant`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `incident` */

/*Table structure for table `personne` */

DROP TABLE IF EXISTS `personne`;

CREATE TABLE `personne` (
  `idpers` int(11) NOT NULL auto_increment,
  `nom` varchar(25) default NULL,
  `prenom` varchar(25) default NULL,
  `tel` varchar(20) default NULL,
  `adresse` varchar(20) default NULL,
  `idserv` int(11) default NULL,
  PRIMARY KEY  (`idpers`),
  KEY `fk_personne_service` (`idserv`),
  CONSTRAINT `fk_personne_service` FOREIGN KEY (`idserv`) REFERENCES `service` (`idserv`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `personne` */

insert  into `personne`(`idpers`,`nom`,`prenom`,`tel`,`adresse`,`idserv`) values 
(3,'hjjh','jjk','jhjh','jjk,',NULL),
(4,'Tesrt','Prenom','888','klikjk',NULL),
(5,'a455','kkkk','7894562','k',NULL),
(6,'kllk','klkl','555','5255',4),
(7,'kjjk','kj','jkjk','jkj',7),
(8,'','','','',NULL),
(9,'','','','',NULL);

/*Table structure for table `produit` */

DROP TABLE IF EXISTS `produit`;

CREATE TABLE `produit` (
  `ref` varchar(25) NOT NULL,
  `designation` varchar(20) default NULL,
  `pu` int(11) NOT NULL,
  `qtestock` int(11) NOT NULL,
  PRIMARY KEY  (`ref`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `produit` */

/*Table structure for table `service` */

DROP TABLE IF EXISTS `service`;

CREATE TABLE `service` (
  `idserv` int(11) NOT NULL auto_increment,
  `nom` varchar(25) default NULL,
  PRIMARY KEY  (`idserv`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `service` */

insert  into `service`(`idserv`,`nom`) values 
(1,'repassage'),
(2,'klklk'),
(3,'rrs'),
(4,'srsrsr'),
(5,'jkjjk'),
(6,'ghh'),
(7,'repassage'),
(8,'repassage'),
(9,'fiib  hggl');

/*Table structure for table `sortiefinanciere` */

DROP TABLE IF EXISTS `sortiefinanciere`;

CREATE TABLE `sortiefinanciere` (
  `idfinance` int(11) NOT NULL auto_increment,
  `datesortie` date default NULL,
  `typesortie` varchar(55) default NULL,
  `montantsortie` int(11) default NULL,
  `description` varchar(50) default NULL,
  PRIMARY KEY  (`idfinance`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sortiefinanciere` */

/*Table structure for table `vetement` */

DROP TABLE IF EXISTS `vetement`;

CREATE TABLE `vetement` (
  `identifiant` int(11) NOT NULL default '0',
  `typevetement` varchar(25) default NULL,
  `prixunitaire` int(11) default NULL,
  `descrition` varchar(55) default NULL,
  `idlav` int(11) default NULL,
  `idrepas` int(11) default NULL,
  `idfacture` int(11) default NULL,
  PRIMARY KEY  (`identifiant`),
  KEY `fk_vetement_fichelavage` (`idlav`),
  KEY `fk_vetement_ficherepassage` (`idrepas`),
  KEY `fk_vetement_facture` (`idfacture`),
  CONSTRAINT `fk_vetement_facture` FOREIGN KEY (`idfacture`) REFERENCES `facture` (`idfacture`) ON UPDATE CASCADE,
  CONSTRAINT `fk_vetement_fichelavage` FOREIGN KEY (`idlav`) REFERENCES `fichelavage` (`idlav`) ON UPDATE CASCADE,
  CONSTRAINT `fk_vetement_ficherepassage` FOREIGN KEY (`idrepas`) REFERENCES `ficherepassage` (`idrepas`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `vetement` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: hotel
-- ------------------------------------------------------
-- Server version	5.7.32-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `hot_bookings`
--

DROP TABLE IF EXISTS `hot_bookings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hot_bookings` (
  `booking_ID` int(11) NOT NULL AUTO_INCREMENT,
  `usr_ID` int(11) DEFAULT NULL,
  `room_ID` int(11) DEFAULT NULL,
  `booking_Date` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `checkin_Date` date DEFAULT NULL,
  `checkout_Date` date DEFAULT NULL,
  `booking_Comments` text COLLATE utf8mb4_unicode_ci,
  PRIMARY KEY (`booking_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hot_bookings`
--

LOCK TABLES `hot_bookings` WRITE;
/*!40000 ALTER TABLE `hot_bookings` DISABLE KEYS */;
INSERT INTO `hot_bookings` VALUES (1,1,1,'2023-07-02 09:55:56','2023-07-07','2023-07-12',NULL),(2,1,2,'2023-06-30 21:00:00','2023-07-01','2023-07-22',NULL);
/*!40000 ALTER TABLE `hot_bookings` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hot_rooms`
--

DROP TABLE IF EXISTS `hot_rooms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hot_rooms` (
  `room_ID` int(4) NOT NULL AUTO_INCREMENT,
  `room_Type` int(4) DEFAULT NULL,
  `room_TypeN` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `room_Balcony` int(1) DEFAULT NULL,
  `room_SeaView` int(1) DEFAULT NULL,
  `room_isAvailable` int(1) DEFAULT NULL,
  `room_Price` float DEFAULT NULL,
  PRIMARY KEY (`room_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hot_rooms`
--

LOCK TABLES `hot_rooms` WRITE;
/*!40000 ALTER TABLE `hot_rooms` DISABLE KEYS */;
INSERT INTO `hot_rooms` VALUES (1,1,'Μονόκλινο',1,1,0,49.99),(2,1,'Μονόκλινο',1,0,0,109.99),(3,1,'Μονόκλινο',0,0,1,NULL),(4,2,'Δίκλινο',1,1,1,NULL);
/*!40000 ALTER TABLE `hot_rooms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hot_type`
--

DROP TABLE IF EXISTS `hot_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hot_type` (
  `room_type` int(4) NOT NULL AUTO_INCREMENT,
  `type_Name` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`room_type`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hot_type`
--

LOCK TABLES `hot_type` WRITE;
/*!40000 ALTER TABLE `hot_type` DISABLE KEYS */;
INSERT INTO `hot_type` VALUES (1,'Μονόκλινο'),(2,'Δίκλινο'),(3,'Τρίκλινο'),(4,'Τετράκλινο'),(5,'Σουίτα');
/*!40000 ALTER TABLE `hot_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hot_usr`
--

DROP TABLE IF EXISTS `hot_usr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hot_usr` (
  `usr_ID` int(11) NOT NULL AUTO_INCREMENT,
  `usr_FName` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `usr_LName` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `usr_username` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `usr_password` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `usr_Email` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `usr_Type` int(11) DEFAULT '0',
  PRIMARY KEY (`usr_ID`),
  UNIQUE KEY `usr_username` (`usr_username`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hot_usr`
--

LOCK TABLES `hot_usr` WRITE;
/*!40000 ALTER TABLE `hot_usr` DISABLE KEYS */;
INSERT INTO `hot_usr` VALUES (1,'Νεκτάριος','Γκουβούσης','gouvo','1234','gouvo@gmail.com',1),(2,'Kostas','Laki','kostas','1234','test@test.com',0),(3,'Νίκος','Δαμιανός','ndam','ndam123','123',0),(4,'Nektarios','Gaves','Tzoulian','tzoul@gmail.com','123',0);
/*!40000 ALTER TABLE `hot_usr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hot_usr_det`
--

DROP TABLE IF EXISTS `hot_usr_det`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hot_usr_det` (
  `det_ID` int(4) NOT NULL AUTO_INCREMENT,
  `usr_ID` int(4) NOT NULL,
  `usrID_Street` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `usrID_StreetNum` varchar(5) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `usrID_Region` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `usrID_Country` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `usrID_Phone` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`det_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hot_usr_det`
--

LOCK TABLES `hot_usr_det` WRITE;
/*!40000 ALTER TABLE `hot_usr_det` DISABLE KEYS */;
INSERT INTO `hot_usr_det` VALUES (1,1,'Καυκάσου','54','Αθήνα, Αττική','Ελλάδα','6988896560');
/*!40000 ALTER TABLE `hot_usr_det` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'hotel'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-07-03 16:43:45

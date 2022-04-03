CREATE DATABASE IF NOT EXISTS `meal-sharing`
/*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */
/*!80016 DEFAULT ENCRYPTION='N' */;
USE `meal-sharing`;
-- MySQL dump 10.13  Distrib 8.0.26, for macos11 (x86_64)
--
-- Host: localhost    Database: meal-sharing
-- ------------------------------------------------------
-- Server version	8.0.28
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
-- Table structure for table `Meals`
--
DROP TABLE IF EXISTS `Meals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Meals` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(45) DEFAULT NULL,
  `Description` varchar(45) DEFAULT NULL,
  `Location` varchar(45) DEFAULT NULL,
  `When` datetime DEFAULT NULL,
  `Price` decimal(10, 0) DEFAULT NULL,
  `MaxReservations` int DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE = InnoDB AUTO_INCREMENT = 6 DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
--
-- Dumping data for table `Meals`
--
LOCK TABLES `Meals` WRITE;
/*!40000 ALTER TABLE `Meals` DISABLE KEYS */;
INSERT INTO
  `Meals`
VALUES
  (
    1,
    'BRQ',
    'Grill meeting',
    'cph',
    '2023-01-23 12:45:56',
    100,
    12
  ),(
    2,
    'Paella',
    'Spanish dish',
    'Bagsvaerd',
    '2022-07-23 12:45:56',
    200,
    10
  ),(
    5,
    'Couscous',
    'Morocain ',
    'Bagsværd',
    '2022-05-29 16:08:49',
    990,
    10
  );
  /*!40000 ALTER TABLE `Meals` ENABLE KEYS */;
UNLOCK TABLES;
--
  -- Table structure for table `reservations`
  --
  DROP TABLE IF EXISTS `reservations`;
  /*!40101 SET @saved_cs_client     = @@character_set_client */;
  /*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservations` (
    `id` int NOT NULL AUTO_INCREMENT,
    `MealID` int NOT NULL,
    `NumberOfGuests` int NOT NULL,
    `ContactPhoneNumber` int NOT NULL,
    `ContactName` varchar(45) DEFAULT NULL,
    `ContactEmail` varchar(45) DEFAULT NULL,
    `CreatedDate` datetime DEFAULT NULL,
    PRIMARY KEY (`id`)
  ) ENGINE = InnoDB AUTO_INCREMENT = 6 DEFAULT CHARSET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci;
  /*!40101 SET character_set_client = @saved_cs_client */;
--
  -- Dumping data for table `reservations`
  --
  LOCK TABLES `reservations` WRITE;
  /*!40000 ALTER TABLE `reservations` DISABLE KEYS */;
INSERT INTO
  `reservations`
VALUES
  (
    1,
    2,
    5,
    601806035,
    'kira',
    'email@gmail.com',
    NULL
  );
  /*!40000 ALTER TABLE `reservations` ENABLE KEYS */;
UNLOCK TABLES;
  /*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;
  /*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
  /*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
  /*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
  /*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
  /*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
  /*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
  /*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
-- Dump completed on 2022-04-03  4:36:00
-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: localhost    Database: login
-- ------------------------------------------------------
-- Server version	9.4.0

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
-- Table structure for table `estrela`
--

DROP TABLE IF EXISTS `estrela`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estrela` (
  `Nome` varchar(70) DEFAULT NULL,
  `estrelas` int DEFAULT NULL,
  `Filme` varchar(70) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estrela`
--

LOCK TABLES `estrela` WRITE;
/*!40000 ALTER TABLE `estrela` DISABLE KEYS */;
INSERT INTO `estrela` VALUES ('k',NULL,NULL),(NULL,2,'setimo'),('u',2,NULL),('u',2,'setimo'),('u',2,'Jaw'),('u',2,'Alien'),('o',NULL,NULL),('o',2,'setimo'),('o',2,'Meia'),('o',2,'Rio'),('o',2,'Futuro'),('ShaoShao',NULL,NULL),('ShaoShao',3,'Vagabond'),('ShaoShao',2,'Blade'),('ShaoShao',3,'Rio'),('gabexx_bonitao',3,NULL),('gabexx_bonitao',3,'setimo'),('gabexx_bonitao',3,'Meia'),('gabexx_bonitao',3,'Alien'),('gabexx_bonitao',3,'Jaw'),('gabexx_bonitao',3,'Vagabond'),('gabexx_bonitao',2,'Futuro'),('gabexx_bonitao',3,'Blade'),('gabexx_bonitao',2,'Rio'),('gabexx_bonitao',1,'Acossado'),('o',3,'Vagabond'),('q',NULL,NULL),('q',2,'setimo'),('q',3,'Cure'),('q',1,'Vagabond'),('q',3,'Blade');
/*!40000 ALTER TABLE `estrela` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-12-03 20:05:54

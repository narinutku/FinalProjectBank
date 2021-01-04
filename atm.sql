-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: atm
-- ------------------------------------------------------
-- Server version	8.0.20

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
-- Table structure for table `bill`
--

DROP TABLE IF EXISTS `bill`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bill` (
  `Bill_ID` int NOT NULL AUTO_INCREMENT,
  `Type` varchar(45) NOT NULL,
  `Amount` varchar(45) NOT NULL,
  `Deadline` varchar(45) NOT NULL,
  `customer_id` int NOT NULL,
  PRIMARY KEY (`Bill_ID`),
  UNIQUE KEY `BillId_UNIQUE` (`Bill_ID`),
  KEY `customer_id` (`customer_id`),
  CONSTRAINT `bill_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2149 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bill`
--

LOCK TABLES `bill` WRITE;
/*!40000 ALTER TABLE `bill` DISABLE KEYS */;
INSERT INTO `bill` VALUES (2086,'electric','150','2020',123456),(2088,'internet','50','2020',123456),(2092,'loan','388','04.05.2021',123456),(2093,'loan','388','04.06.2021',123456),(2094,'loan','388','04.07.2021',123456),(2095,'loan','388','04.08.2021',123456),(2096,'loan','388','04.09.2021',123456),(2097,'loan','388','04.10.2021',123456),(2098,'loan','388','04.11.2021',123456),(2099,'loan','388','04.12.2021',123456),(2100,'loan','388','04.01.2022',123456),(2101,'loan','388','04.02.2022',123456),(2102,'loan','388','04.03.2022',123456),(2103,'loan','388','04.04.2022',123456),(2104,'loan','388','04.05.2022',123456),(2105,'loan','388','04.06.2022',123456),(2106,'loan','388','04.07.2022',123456),(2107,'loan','388','04.08.2022',123456),(2108,'loan','388','04.09.2022',123456),(2109,'loan','388','04.10.2022',123456),(2110,'loan','388','04.11.2022',123456),(2111,'loan','388','04.12.2022',123456),(2112,'loan','388','04.01.2023',123456),(2113,'loan','388','04.02.2023',123456),(2114,'loan','388','04.03.2023',123456),(2115,'loan','388','04.04.2023',123456),(2116,'loan','388','04.05.2023',123456),(2117,'loan','388','04.06.2023',123456),(2118,'loan','388','04.07.2023',123456),(2119,'loan','388','04.08.2023',123456),(2120,'loan','388','04.09.2023',123456),(2121,'loan','388','04.10.2023',123456),(2122,'loan','388','04.11.2023',123456),(2123,'loan','388','04.12.2023',123456),(2124,'loan','388','04.01.2024',123456),(2125,'loan','388','04.02.2024',123456),(2126,'loan','388','04.03.2024',123456),(2127,'loan','388','04.04.2024',123456),(2128,'loan','388','04.05.2024',123456),(2129,'loan','388','04.06.2024',123456),(2130,'loan','388','04.07.2024',123456),(2131,'loan','388','04.08.2024',123456),(2132,'loan','388','04.09.2024',123456),(2133,'loan','388','04.10.2024',123456),(2134,'loan','388','04.11.2024',123456),(2135,'loan','388','04.12.2024',123456),(2136,'loan','388','04.01.2025',123456),(2137,'loan','388','04.02.2025',123456),(2138,'loan','388','04.03.2025',123456),(2139,'loan','388','04.04.2025',123456),(2140,'loan','388','04.05.2025',123456),(2141,'loan','388','04.06.2025',123456),(2142,'loan','388','04.07.2025',123456),(2143,'loan','388','04.08.2025',123456),(2144,'loan','388','04.09.2025',123456),(2145,'loan','388','04.10.2025',123456),(2146,'loan','388','04.11.2025',123456),(2147,'loan','388','04.12.2025',123456),(2148,'loan','388','04.01.2026',123456);
/*!40000 ALTER TABLE `bill` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `customer_id` int NOT NULL,
  `customer_name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci NOT NULL,
  `password` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_turkish_ci NOT NULL,
  `balance` int NOT NULL,
  `salary` double NOT NULL,
  `creditDebt` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (123456,'utku','123456',22986,3500,22116),(654321,'deneme','654321',50500,35000,0),(369852147,'CİHAN KALELİ','*6BB4837EB74329105EE4568DDA7DC67ED2CA2AD9',50000,7000,0),(456985236,'AHMET AYDIN','*6BB4837EB74329105EE4568DDA7DC67ED2CA2AD9',50000,6230,0),(456987452,'EMRAH DEMİR','*6BB4837EB74329105EE4568DDA7DC67ED2CA2AD9',50000,15000,0),(856987412,'ZEYNEP BATMAZ','*6BB4837EB74329105EE4568DDA7DC67ED2CA2AD9',50000,1500,0),(985641258,'SERKAN GÜNAL','*6BB4837EB74329105EE4568DDA7DC67ED2CA2AD9',50000,2850,0);
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `loan`
--

DROP TABLE IF EXISTS `loan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `loan` (
  `idLoan` int NOT NULL,
  `Type` varchar(45) NOT NULL,
  `Monthlyinterest` float NOT NULL,
  `MaxMonth` int NOT NULL,
  PRIMARY KEY (`idLoan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loan`
--

LOCK TABLES `loan` WRITE;
/*!40000 ALTER TABLE `loan` DISABLE KEYS */;
INSERT INTO `loan` VALUES (1,'Mortgage',0.78,240),(2,'Auto Loan',0.87,96),(3,'Personel Loan',0.99,36),(4,'Small Business Loan',0.92,60);
/*!40000 ALTER TABLE `loan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transfer`
--

DROP TABLE IF EXISTS `transfer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transfer` (
  `transfer_id` int NOT NULL AUTO_INCREMENT,
  `remitter_id` int NOT NULL,
  `remittee_id` int NOT NULL,
  `amount` varchar(45) NOT NULL,
  `date` varchar(45) NOT NULL,
  PRIMARY KEY (`transfer_id`),
  KEY `remitter_id` (`remitter_id`),
  KEY `remittee_id` (`remittee_id`),
  CONSTRAINT `transfer_ibfk_1` FOREIGN KEY (`remitter_id`) REFERENCES `customer` (`customer_id`),
  CONSTRAINT `transfer_ibfk_2` FOREIGN KEY (`remittee_id`) REFERENCES `customer` (`customer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transfer`
--

LOCK TABLES `transfer` WRITE;
/*!40000 ALTER TABLE `transfer` DISABLE KEYS */;
INSERT INTO `transfer` VALUES (1,123456,654321,'150','10/10/2020'),(2,123456,654321,'150','29.12.2020 19:19:03'),(3,123456,654321,'200','29.12.2020 19:19:24');
/*!40000 ALTER TABLE `transfer` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-01-04 18:15:26

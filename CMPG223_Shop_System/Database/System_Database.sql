-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: projectdb
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Table structure for table `tblconsoles`
--

DROP TABLE IF EXISTS `tblconsoles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblconsoles` (
  `Console_ID` int NOT NULL,
  `Console_Name` varchar(45) DEFAULT NULL,
  `Console_Price` decimal(10,0) DEFAULT NULL,
  `Console_Release` date DEFAULT NULL,
  `Console_Quantity` int DEFAULT NULL,
  PRIMARY KEY (`Console_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblconsoles`
--

LOCK TABLES `tblconsoles` WRITE;
/*!40000 ALTER TABLE `tblconsoles` DISABLE KEYS */;
INSERT INTO `tblconsoles` VALUES (1000,'Playstation 5',17000,'2021-06-17',344),(2000,'Xbox 1',11000,'2017-05-04',122),(3000,'Nintendo',6500,'2016-05-23',100),(4000,'Playstation 4',7999,'2015-04-03',90),(5000,'Xbox series X',8000,'2014-04-23',23);
/*!40000 ALTER TABLE `tblconsoles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblcustomers`
--

DROP TABLE IF EXISTS `tblcustomers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblcustomers` (
  `Customer_ID` int NOT NULL,
  `Employee_ID` int DEFAULT NULL,
  `Customer_Name` varchar(45) DEFAULT NULL,
  `Customer_Surname` varchar(45) DEFAULT NULL,
  `Loyalty_Points` int DEFAULT NULL,
  PRIMARY KEY (`Customer_ID`),
  KEY `Employee_ID_idx` (`Employee_ID`),
  CONSTRAINT `Employee_ID` FOREIGN KEY (`Employee_ID`) REFERENCES `tblemployees` (`Employee_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblcustomers`
--

LOCK TABLES `tblcustomers` WRITE;
/*!40000 ALTER TABLE `tblcustomers` DISABLE KEYS */;
INSERT INTO `tblcustomers` VALUES (5,10,'Jevon','Gounden',1222),(10,20,'Paul','Black',1333),(15,30,'Jane','Jackson',2000),(20,40,'Smith','Jane',1211),(25,50,'Derek','Pillay',1111);
/*!40000 ALTER TABLE `tblcustomers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbldevelopers`
--

DROP TABLE IF EXISTS `tbldevelopers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbldevelopers` (
  `Developer_ID` int NOT NULL,
  `Console_ID` int DEFAULT NULL,
  `Game_ID` int DEFAULT NULL,
  `Developer_Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Developer_ID`),
  KEY `Console_ID_idx` (`Console_ID`),
  KEY `Game_ID_idx` (`Game_ID`),
  CONSTRAINT `Console_ID` FOREIGN KEY (`Console_ID`) REFERENCES `tblconsoles` (`Console_ID`),
  CONSTRAINT `Game_ID` FOREIGN KEY (`Game_ID`) REFERENCES `tblgames` (`Game_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbldevelopers`
--

LOCK TABLES `tbldevelopers` WRITE;
/*!40000 ALTER TABLE `tbldevelopers` DISABLE KEYS */;
INSERT INTO `tbldevelopers` VALUES (2,1000,100,'Sony'),(4,2000,200,'Microsoft'),(6,3000,300,'Microsoft'),(8,4000,400,'Sony'),(10,5000,500,'Microsoft');
/*!40000 ALTER TABLE `tbldevelopers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblemployees`
--

DROP TABLE IF EXISTS `tblemployees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblemployees` (
  `Employee_ID` int NOT NULL,
  `Location_Code` int DEFAULT NULL,
  `Employee_Name` varchar(45) DEFAULT NULL,
  `Employee_Surname` varchar(45) DEFAULT NULL,
  `Customer_ID` int DEFAULT NULL,
  PRIMARY KEY (`Employee_ID`),
  KEY `Customer_ID_idx` (`Customer_ID`),
  KEY `Location_Code_idx` (`Location_Code`),
  CONSTRAINT `Customer_ID` FOREIGN KEY (`Customer_ID`) REFERENCES `tblcustomers` (`Customer_ID`),
  CONSTRAINT `Location_Code` FOREIGN KEY (`Location_Code`) REFERENCES `tbllocation` (`Location_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblemployees`
--

LOCK TABLES `tblemployees` WRITE;
/*!40000 ALTER TABLE `tblemployees` DISABLE KEYS */;
INSERT INTO `tblemployees` VALUES (10,3,'Ayanda','Matafeng',5),(20,6,'John','White',10),(30,9,'Jackson','Joe',15),(40,12,'Joe','Jackson',20),(50,15,'Smith','Allen',25);
/*!40000 ALTER TABLE `tblemployees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblgames`
--

DROP TABLE IF EXISTS `tblgames`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblgames` (
  `Game_ID` int NOT NULL,
  `Game_Name` varchar(45) DEFAULT NULL,
  `Game_Price` decimal(10,0) DEFAULT NULL,
  `Release_Date` date DEFAULT NULL,
  `Game_Genre` varchar(45) DEFAULT NULL,
  `Game_Quantity` int DEFAULT NULL,
  PRIMARY KEY (`Game_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblgames`
--

LOCK TABLES `tblgames` WRITE;
/*!40000 ALTER TABLE `tblgames` DISABLE KEYS */;
INSERT INTO `tblgames` VALUES (100,'God of war',1200,'2022-11-11','Adventure',223),(200,'Fifa',1100,'2022-12-02','Sport',211),(300,'Foza',1300,'2020-03-02','Racing',100),(400,'Need for Speed',1000,'2018-05-01','Racing',45),(500,'Mortal Kombat',950,'2012-09-15','Fighting',66);
/*!40000 ALTER TABLE `tblgames` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbllocation`
--

DROP TABLE IF EXISTS `tbllocation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbllocation` (
  `Location_ID` int NOT NULL,
  `Dev_ID` int DEFAULT NULL,
  `Order_ID` int DEFAULT NULL,
  `EmployeeID` int DEFAULT NULL,
  PRIMARY KEY (`Location_ID`),
  KEY `Dev_ID_idx` (`Dev_ID`),
  KEY `Order_ID_idx` (`Order_ID`),
  KEY `EmpoyeeID_idx` (`EmployeeID`),
  CONSTRAINT `Dev_ID` FOREIGN KEY (`Dev_ID`) REFERENCES `tbldevelopers` (`Developer_ID`),
  CONSTRAINT `EmpoyeeID` FOREIGN KEY (`EmployeeID`) REFERENCES `tblemployees` (`Employee_ID`),
  CONSTRAINT `Order_ID` FOREIGN KEY (`Order_ID`) REFERENCES `tblorders` (`Order_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbllocation`
--

LOCK TABLES `tbllocation` WRITE;
/*!40000 ALTER TABLE `tbllocation` DISABLE KEYS */;
INSERT INTO `tbllocation` VALUES (3,2,1,10),(6,4,2,20),(9,6,3,30),(12,8,4,40),(15,10,5,50);
/*!40000 ALTER TABLE `tbllocation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblorders`
--

DROP TABLE IF EXISTS `tblorders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblorders` (
  `Order_ID` int NOT NULL,
  `LocationCode` int DEFAULT NULL,
  `ConsoleID` int DEFAULT NULL,
  `GameID` int DEFAULT NULL,
  `Order_Date` date DEFAULT NULL,
  PRIMARY KEY (`Order_ID`),
  KEY `LocationCode_idx` (`LocationCode`),
  KEY `ConsoleID_idx` (`ConsoleID`),
  KEY `GameID_idx` (`GameID`),
  CONSTRAINT `ConsoleID` FOREIGN KEY (`ConsoleID`) REFERENCES `tblconsoles` (`Console_ID`),
  CONSTRAINT `GameID` FOREIGN KEY (`GameID`) REFERENCES `tblgames` (`Game_ID`),
  CONSTRAINT `LocationCode` FOREIGN KEY (`LocationCode`) REFERENCES `tbllocation` (`Location_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblorders`
--

LOCK TABLES `tblorders` WRITE;
/*!40000 ALTER TABLE `tblorders` DISABLE KEYS */;
INSERT INTO `tblorders` VALUES (1,3,1000,100,'2022-09-08'),(2,6,2000,200,'2022-09-01'),(3,9,3000,300,'2022-01-05'),(4,12,4000,400,'2022-05-11'),(5,15,5000,500,'2021-12-23');
/*!40000 ALTER TABLE `tblorders` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-09-08 16:42:40

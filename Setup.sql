-- MariaDB dump 10.19  Distrib 10.4.24-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: ambergrey_trading
-- ------------------------------------------------------
-- Server version	10.4.24-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tblapplogs`
--

DROP TABLE IF EXISTS `tblapplogs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblapplogs` (
  `logs_id` int(20) NOT NULL AUTO_INCREMENT,
  `employee_id` int(20) NOT NULL,
  `log_datetime` datetime NOT NULL,
  PRIMARY KEY (`logs_id`),
  KEY `employee_id` (`employee_id`),
  CONSTRAINT `tblapplogs_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `tblemployees` (`employee_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblapplogs`
--

LOCK TABLES `tblapplogs` WRITE;
/*!40000 ALTER TABLE `tblapplogs` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblapplogs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblcontainer`
--

DROP TABLE IF EXISTS `tblcontainer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblcontainer` (
  `container_id` int(11) NOT NULL AUTO_INCREMENT,
  `container_name` varchar(50) NOT NULL,
  PRIMARY KEY (`container_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblcontainer`
--

LOCK TABLES `tblcontainer` WRITE;
/*!40000 ALTER TABLE `tblcontainer` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblcontainer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblcustomer`
--

DROP TABLE IF EXISTS `tblcustomer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblcustomer` (
  `customer_id` varchar(20) NOT NULL,
  `first_name` varchar(20) NOT NULL,
  `middle_name` varchar(20) NOT NULL,
  `last_name` varchar(20) NOT NULL,
  `contact_number` varchar(20) NOT NULL,
  `house_number` varchar(20) NOT NULL,
  `street_name` varchar(20) NOT NULL,
  `barangay` varchar(20) NOT NULL,
  `city` varchar(20) NOT NULL,
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblcustomer`
--

LOCK TABLES `tblcustomer` WRITE;
/*!40000 ALTER TABLE `tblcustomer` DISABLE KEYS */;
INSERT INTO `tblcustomer` VALUES ('6','No','','Record','','','','','');
/*!40000 ALTER TABLE `tblcustomer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbldefective`
--

DROP TABLE IF EXISTS `tbldefective`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbldefective` (
  `defective_id` int(20) NOT NULL AUTO_INCREMENT,
  `product_id` varchar(20) NOT NULL,
  `defective_quantity` int(20) NOT NULL,
  `defective_comment` varchar(50) NOT NULL,
  `defection_date` date NOT NULL,
  PRIMARY KEY (`defective_id`),
  KEY `product_id` (`product_id`),
  CONSTRAINT `tbldefective_ibfk_1` FOREIGN KEY (`product_id`) REFERENCES `tblproducts` (`product_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbldefective`
--

LOCK TABLES `tbldefective` WRITE;
/*!40000 ALTER TABLE `tbldefective` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbldefective` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbldiscounts`
--

DROP TABLE IF EXISTS `tbldiscounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbldiscounts` (
  `discount_id` int(11) NOT NULL AUTO_INCREMENT,
  `discount` int(11) NOT NULL,
  PRIMARY KEY (`discount_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbldiscounts`
--

LOCK TABLES `tbldiscounts` WRITE;
/*!40000 ALTER TABLE `tbldiscounts` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbldiscounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblemployees`
--

DROP TABLE IF EXISTS `tblemployees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblemployees` (
  `employee_id` int(20) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(20) NOT NULL,
  `middle_name` varchar(20) NOT NULL,
  `last_name` varchar(20) NOT NULL,
  `username` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `password` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `user_level` varchar(20) NOT NULL,
  `contact_number` varchar(20) NOT NULL,
  `security_question` text NOT NULL,
  `security_answer` text CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`employee_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblemployees`
--

LOCK TABLES `tblemployees` WRITE;
/*!40000 ALTER TABLE `tblemployees` DISABLE KEYS */;
INSERT INTO `tblemployees` VALUES (4,'admin','admin','admin','admin','admin','admin','admin','admin','admin');
/*!40000 ALTER TABLE `tblemployees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblorders`
--

DROP TABLE IF EXISTS `tblorders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblorders` (
  `order_id` int(11) NOT NULL AUTO_INCREMENT,
  `transaction_id` varchar(20) NOT NULL,
  `product_id` varchar(20) NOT NULL,
  `quantity` int(20) NOT NULL,
  PRIMARY KEY (`order_id`),
  KEY `transaction_id` (`transaction_id`),
  KEY `product_id` (`product_id`),
  CONSTRAINT `tblorders_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `tblproducts` (`product_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tblorders_ibfk_3` FOREIGN KEY (`transaction_id`) REFERENCES `tbltransaction` (`transaction_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblorders`
--

LOCK TABLES `tblorders` WRITE;
/*!40000 ALTER TABLE `tblorders` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblorders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblprodname`
--

DROP TABLE IF EXISTS `tblprodname`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblprodname` (
  `prodname_id` int(11) NOT NULL AUTO_INCREMENT,
  `prod_name` varchar(50) NOT NULL,
  PRIMARY KEY (`prodname_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblprodname`
--

LOCK TABLES `tblprodname` WRITE;
/*!40000 ALTER TABLE `tblprodname` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblprodname` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblproducts`
--

DROP TABLE IF EXISTS `tblproducts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblproducts` (
  `product_id` varchar(20) NOT NULL,
  `product_name` varchar(50) NOT NULL,
  `prod_variant` varchar(50) NOT NULL,
  `size` int(20) NOT NULL,
  `container` varchar(20) NOT NULL,
  `price` decimal(20,2) NOT NULL,
  `category` varchar(50) NOT NULL,
  `supplier_id` varchar(20) NOT NULL,
  `quantity` int(20) NOT NULL,
  PRIMARY KEY (`product_id`),
  KEY `supplier_id` (`supplier_id`),
  CONSTRAINT `tblproducts_ibfk_1` FOREIGN KEY (`supplier_id`) REFERENCES `tblsupplier` (`supplier_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblproducts`
--

LOCK TABLES `tblproducts` WRITE;
/*!40000 ALTER TABLE `tblproducts` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblproducts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblsize`
--

DROP TABLE IF EXISTS `tblsize`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblsize` (
  `size_id` int(11) NOT NULL AUTO_INCREMENT,
  `size_quantity` int(11) NOT NULL,
  PRIMARY KEY (`size_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblsize`
--

LOCK TABLES `tblsize` WRITE;
/*!40000 ALTER TABLE `tblsize` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblsize` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblstockin`
--

DROP TABLE IF EXISTS `tblstockin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblstockin` (
  `stock_id` int(20) NOT NULL AUTO_INCREMENT,
  `product_id` varchar(20) NOT NULL,
  `date_added` date NOT NULL,
  `quantity` int(20) NOT NULL,
  PRIMARY KEY (`stock_id`),
  KEY `product_id` (`product_id`),
  CONSTRAINT `tblstockin_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `tblproducts` (`product_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblstockin`
--

LOCK TABLES `tblstockin` WRITE;
/*!40000 ALTER TABLE `tblstockin` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblstockin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblsupplier`
--

DROP TABLE IF EXISTS `tblsupplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblsupplier` (
  `supplier_id` varchar(20) NOT NULL,
  `supplier_name` varchar(50) NOT NULL,
  `supplier_address` varchar(50) NOT NULL,
  `supplier_contact_number` varchar(20) NOT NULL,
  PRIMARY KEY (`supplier_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblsupplier`
--

LOCK TABLES `tblsupplier` WRITE;
/*!40000 ALTER TABLE `tblsupplier` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblsupplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbltransaction`
--

DROP TABLE IF EXISTS `tbltransaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbltransaction` (
  `transaction_id` varchar(20) NOT NULL,
  `totaldue` decimal(20,2) NOT NULL,
  `date_time` datetime NOT NULL,
  `employee_id` int(20) NOT NULL,
  `customer_id` varchar(20) NOT NULL,
  `discount` int(11) NOT NULL,
  PRIMARY KEY (`transaction_id`),
  KEY `employee_id` (`employee_id`),
  KEY `customer_id` (`customer_id`),
  CONSTRAINT `tbltransaction_ibfk_3` FOREIGN KEY (`employee_id`) REFERENCES `tblemployees` (`employee_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tbltransaction_ibfk_4` FOREIGN KEY (`customer_id`) REFERENCES `tblcustomer` (`customer_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbltransaction`
--

LOCK TABLES `tbltransaction` WRITE;
/*!40000 ALTER TABLE `tbltransaction` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbltransaction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblvariants`
--

DROP TABLE IF EXISTS `tblvariants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblvariants` (
  `variant_id` int(11) NOT NULL AUTO_INCREMENT,
  `variant_name` varchar(50) NOT NULL,
  PRIMARY KEY (`variant_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblvariants`
--

LOCK TABLES `tblvariants` WRITE;
/*!40000 ALTER TABLE `tblvariants` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblvariants` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-06-02 13:57:13

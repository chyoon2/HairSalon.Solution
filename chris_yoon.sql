DROP DATABASE IF EXISTS `chris_yoon`;
CREATE DATABASE `chris_yoon`;
USE `chris_yoon`;
DROP TABLE IF EXISTS `clients`;
CREATE TABLE `clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Phone` int DEFAULT NULL,
  `MemberSince` datetime DEFAULT NULL,
  `StylistId` int DEFAULT NULL,
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `stylists`;
CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `DateOfHire` datetime DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
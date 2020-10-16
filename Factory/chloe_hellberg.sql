  CREATE DATABASE `chloe_hellberg` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
  USE `chloe_hellberg`;
  CREATE TABLE `Engineers` (
    `EngineerId` int(11) NOT NULL AUTO_INCREMENT,
    `Name` longtext,
    PRIMARY KEY (`EngineerId`)
  ) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
  CREATE TABLE `Machines` (
    `MachineId` int(11) NOT NULL AUTO_INCREMENT,
    `Name` longtext,
    PRIMARY KEY (`MachineId`)
  ) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
  CREATE TABLE `EngineerMachine` (
    `EngineerMachineId` int(11) NOT NULL AUTO_INCREMENT,
    `EngineerId` int(11) NOT NULL,
    `MachineId` int(11) NOT NULL,
    PRIMARY KEY (`EngineerMachineId`),
    KEY `IX_EngineerMachine_EngineerId` (`EngineerId`),
    KEY `IX_EngineerMachine_MachineId` (`MachineId`),
    CONSTRAINT `FK_EngineerMachine_Engineers_EngineerId` FOREIGN KEY (`EngineerId`) REFERENCES `engineers` (`EngineerId`) ON DELETE CASCADE,
    CONSTRAINT `FK_EngineerMachine_Machines_MachineId` FOREIGN KEY (`MachineId`) REFERENCES `machines` (`MachineId`) ON DELETE CASCADE
  ) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
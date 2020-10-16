# _Dr. Sillystringz's Factory Project_

#### _Console application for an imaginary repair factory using C#/.NET, MySQL and Entity Framework to display many-to-many relationships, Oct 16th 2020_

#### By _**Chloe Hellberg**_

## Description

_This is an MVC web application for an imaginary factory that helps keep track of their machine repairs. Application helps manage the factory's engineers and the machines they are licensed to fix._
  * _Specific Functionality Includes_
   * Ability to add and see a list of all engineers as well as ability to add and see a list of all machines
   * Ability to select an engineer, see their details and a list of all machines that engineer is licensed to repair
   * Ability to select a machine, see its details and a list of all engineers licensed to repair it
   * Ability to add new engineers to the system when they are hired and ability to add new machines to the system when they are installed
   * Ability to add new machines even if no engineers are employed and ability to add new engineers even if no machines are installed
   * Ability to add or remove machines that a specific engineer is licensed to repair. Ability to modify this relationship from the other side and add or remove engineers from a specific machine
   * Ability to navigate to a splash page that lists all engineers and machines. Users should be able to click on individual engineers or machines to see all the engineers/machines that belong to it


## Setup/Installation Requirements

#### Project Folder Setup
* _Download Option_
  * Download files from GitHub repository by click Code and Download Zip
  * Extract files into a single directory
  * Go into appsettings.json and change the password to match your SQL password if needed
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Have fun exploring the application!

* _Cloning Option_
  * For cloning please use the following GitHub [tutorial](https://docs.github.com/en/enterprise/2.16/user/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
  * Place files into a single directory
  * Go into appsettings.json and change the password to match your SQL password if needed
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Have fun exploring the application!

#### Production Database Setup

* Setup with SQL Statements
  * Enter the below code into your SQL database to create/run: 

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

## Known Bugs

_No known bugs at this time._

## Support and contact details

_If you run into issues, please email chloe.hellberg@gmail.com with questions or concerns. Feel free to contribute to this code._

[GitHub](https://github.com/chloehellberg)

## Technologies Used

_Main Programs_
  * C# and .NET
  * MySQL
  * Entity Framework
  * CSS and Bootstrap

### License

*Licensed under MIT*

Copyright (c) 2020 **_Chloe Hellberg_**
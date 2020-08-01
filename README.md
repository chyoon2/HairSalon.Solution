#  _Hair Salon_

#### _A Collection of stylists and clients_
##### __Created:__ 7/29/2020
##### __Last Updated:__ 7/30/2020 
##### By _**Chris Yoon**_  


## Description

_Keep track of your stylists and your clients with a click of a button. Save time with this program that organizes your busy by sorting clients with their respective stylists._

## Behaviors

| Spec| Example input | Example Output
| ----------- | ----------- | ----------- |
| The program takes a user input of a Stylist
name and their Date of Hire | "Name: John, Date of Hire: June 1, 2020" | N/A |
| The program allows user to EDIT Stylist input. | "Name John Pats , Date of Hire: June 1, 2020" | N/A |
| The program allows user to DELETE Stylist | N/A | N/A |
| The program displays user inputs of Stylist and Client | N/A | "Pat: Stylist John"|
| The program takes a user input of a Client name, number, membership date, and stylist | "Name: Pat, Phone Number: 555-555-5555, Member Since: 1/1/2010" | N/A |
| The program allows user to EDIT Client input. | "Name: Spat, Phone Number: 555-555-5555, Member Since: 1/1/2010"  | N/A |
| The program allows user to DELETE Client | N/A | N/A |

## Setup/Installation Requirements

##### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Configue MySQL Workbench Database:
1. Launch MySQL Workbench
2. Select "Create a new SQL tab for executing queries"
![NewQuery](./BestRestaurant/wwwroot/assets/images/readme/NewQuery.PNG)
3. Enter the following SQL into the query window and click "execute"

```
DROP DATABASE IF EXISTS chris_yoon;
CREATE DATABASE chris_yoon;
USE chris_yoon;
CREATE TABLE `clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(225) DEFAULT NULL,
  `MemberSince` datetime DEFAULT NULL,
  `Phone` int DEFAULT NULL,
  `StylistId` int DEFAULT '0',
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `stylists`;
CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `DateOfHire` datetime DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```

Open via Bash/GitBash:

1. Clone this repository onto your computer:
    "git clone https://github.com/Lackeyt/BestRestaurant.Solution"
2. Navigate into the "BestRestaurant" directory in Visual Studio Code or preferred text editor:
3. Open the project
    "code ."
4. Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.
5. Enter the command "dotnet build" in the terminal and press "Enter".
6. Enter the command "dotnet watch run" in the terminal and press "Enter".

## Known Bugs

* no form input error handling
* no limit on score (should be 0-10)
* no null handling for certain form fields

## Feature Roadmap

## Support and contact details

## Technologies Used

* Visual Studio Code
* HTML
* CSS
* Bootstrap
* C#
* MVC
* MySQL Workbench
* Entity Framework
* .NET Core

## Resources:

### License

Copyright (c) 2020 ** Chris Yoon_**

This software is licensed under the MIT license.
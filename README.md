# _Hair Salon_

#### _A database-backed web app that lets a user add machines and engineers to a database and assign machines to engineers and vice versa from views for either class._

#### By _**Cat Denton**_

## Technologies Used

* C#
* .NET V5
* ASPNET CORE MVC
* Razor
* Entity Framework Core
* MySql Workbench

## Description

_This program allows the user to create both Engineers and Machines. Engineers can be assigned to Machines from the Machine/Details/AddEngineer view, and Machines can be assigned to Engineers from the Engineer/Details/AddMachine view. Either relationship can be deleted from the respective Details view._

![Relationship Chart](https://i.imgur.com/Hip7Q5G.png)

## Setup/Installation Requirements

* Install microsoft .NET V5
* Clone repository to local drive
* Open code with a text editor
* Open terminal
* Change directory to HairSalon.Solution/HairSalon
* Type "dotnet touch appsettings.json"
* Enter the following code into appsettings.json, change the password to your MySql server password and save
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=cat_denton;uid=root;pwd=[yourPwHere];"
  }
}
```
* Type "dotnet build" in terminal and hit enter
* Set up database in a mysql terminal
```
CREATE DATABASE `cat_denton`;
    USE cat_denton;
    CREATE TABLE `engineers` (
        `EngineerId` int(11) NOT NULL AUTO_INCREMENT,
        `Name` varchar(255) DEFAULT NULL,
        `ContactInfo` varchar(255) DEFAULT NULL,
        PRIMARY KEY (`EngineerId`)
    );
    CREATE TABLE `machines` (
        `MachineId` int(11) NOT NULL AUTO_INCREMENT,
        `Model` varchar(255) DEFAULT NULL,
        `Make` varchar(255) DEFAULT NULL,
        PRIMARY KEY (`MachineId`)
    );
    CREATE TABLE `engineer_machine` (
        `EngineerMachineId` int(11) NOT NULL AUTO_INCREMENT,
        `EngineerId` int(11) NOT NULL DEFAULT '0',
        `MachineId` int(11) NOT NULL DEFAULT '0',
        PRIMARY KEY (`EngineerMachineId`)
    );
```
* Type "dotnet run" in the terminal and hit enter

## Known Bugs

* None

## License

Copyright 2021 Cat Denton

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.



## Contact Information

_Cat Denton <willwdenton@gmail.com>_

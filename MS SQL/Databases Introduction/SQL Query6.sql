CREATE DATABASE HOTEL
GO

USE HOTEL
GO

CREATE TABLE Employees 
(
Id INT PRIMARY KEY IDENTITY, 
FirstName VARCHAR(50) NOT NULL, 
LastName VARCHAR(50) NOT NULL, 
Title VARCHAR(150), 
Notes VARCHAR(MAX)
)

CREATE TABLE Customers 
(
AccountNumber INT PRIMARY KEY IDENTITY, 
FirstName VARCHAR(50) NOT NULL, 
LastName VARCHAR(50) NOT NULL, 
PhoneNumber VARCHAR(15) NOT NULL, 
EmergencyName VARCHAR(50) NOT NULL, 
EmergencyNumber VARCHAR(15) NOT NULL, 
Notes VARCHAR(MAX)
)

CREATE TABLE RoomStatus 
(
RoomStatus BIT NOT NULL, 
Notes VARCHAR(MAX)
)

CREATE TABLE RoomTypes 
(
RoomType TINYINT NOT NULL, 
Notes VARCHAR(MAX)
)

CREATE TABLE BedTypes 
(
BedType VARCHAR(15) NOT NULL, 
Notes VARCHAR(MAX)
)

CREATE TABLE Rooms 
(
RoomNumber INT PRIMARY KEY NOT NULL, 
RoomType VARCHAR(15) NOT NULL, 
BedType VARCHAR(15) NOT NULL, 
Rate DECIMAL(8,2), 
RoomStatus BIT NOT NULL, 
Notes VARCHAR(MAX)
)

CREATE TABLE Payments 
(
Id INT PRIMARY KEY IDENTITY, 
EmployeeId INT NOT NULL, 
PaymentDate DATETIME2, 
AccountNumber INT, 
FirstDateOccupied DATETIME2, 
LastDateOccupied DATETIME2, 
TotalDays TINYINT, 
AmountCharged DECIMAL(15,2), 
TaxRate INT, 
TaxAmount DECIMAL(15,2), 
PaymentTotal DECIMAL(15,2), 
Notes VARCHAR(MAX)
)

CREATE TABLE Occupancies 
(
Id INT PRIMARY KEY IDENTITY, 
EmployeeId INT NOT NULL, 
DateOccupied DATETIME2, 
AccountNumber INT, 
RoomNumber INT, 
RateApplied INT, 
PhoneCharge DECIMAL(15,2), 
Notes VARCHAR(MAX)
)

INSERT INTO Employees
VALUES
('Nikola', 'Petrov', 'Piccolo',''),
('Maria', 'Georgieva', 'cleaning woman',''),
('Asen', 'Stoyanov', 'Menager','')

INSERT INTO Customers
VALUES
('Georgi', 'Milanov', '0888-569-965', 'Filip', '0878-111-568', ''),
('Kamen', 'Papazov', '0888-569-965', 'Ivo', '0878-958-568', ''),
('Lubo', 'Penev', '0888-569-965', 'Vasil', '0878-111-654', '')

INSERT INTO RoomStatus
VALUES
(1,''),
(1,''),
(1,'')

INSERT INTO RoomTypes
VALUES
(2, ''),
(4, ''),
(1, '')

INSERT BedTypes
VALUES
('BED', ''),
('SOME BED', ''),
('BIG BED','')

INSERT INTO Rooms
VALUES
(5, 2, 'SOME BED', 6.5, 1, ''),
(2, 1, 'BED', 3, 1, ''),
(3, 1, 'BED', 2.5, 1, '')

INSERT INTO Payments
VALUES
(1, '2-11-2023', 2342424, '2-08-2023', '2-18-2023', 10, 60, 6, 20, 72, ''),
(2, '12-11-2023', 784962145, '12-13-2023', '2-18-2023', 5, 30, 6, 20, 36, ''),
(3, '2-1-2013', 575757765, '2-08-2013', '2-18-2013', 10, 60, 6, 20, 72, '')

INSERT INTO Occupancies
VALUES
(1, '', NULL, NULL, NULL, NULL, ''),
(2, '', 5, 8, 5, 4.8, ''),
(3, '', NULL, NULL, NULL, '6.2', '')


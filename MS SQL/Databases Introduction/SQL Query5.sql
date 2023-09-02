CREATE DATABASE CarRental

USE CarRental

CREATE TABLE Categories 
(
Id INT PRIMARY KEY IDENTITY, 
CategoryName VARCHAR(100), 
DailyRate DECIMAL(8,2), 
WeeklyRate DECIMAL(8,2), 
MonthlyRate DECIMAL(8,2), 
WeekendRate DECIMAL(8,2)
)

CREATE TABLE Cars
(
Id INT PRIMARY KEY IDENTITY,
PlateNumber VARCHAR(10) NOT NULL, 
Manufacturer VARCHAR(30) NOT NULL, 
Model VARCHAR(30) NOT NULL, 
CarYear INT, 
CategoryId INT, 
Doors TINYINT, 
Picture VARBINARY(MAX),
Condition VARCHAR(100), 
Available BIT
)

CREATE TABLE Employees 
(
Id INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(50) NOT NULL, 
LastName VARCHAR(50) NOT NULL, 
Title VARCHAR(150), 
Notes VARCHAR(300)
)

CREATE TABLE Customers 
(
Id INT PRIMARY KEY IDENTITY, 
DriverLicenceNumber INT NOT NULL, 
FullName VARCHAR (100) NOT NULL, 
[Address] VARCHAR(300), 
City VARCHAR(50), 
ZIPCode TINYINT, 
Notes VARCHAR(300)
)

CREATE TABLE RentalOrders 
(
Id INT PRIMARY KEY IDENTITY, 
EmployeeId INT NOT NULL, 
CustomerId INT NOT NULL, 
CarId TINYINT NOT NULL, 
TankLevel TINYINT NOT NULL, 
KilometrageStart INT NOT NULL, 
KilometrageEnd INT NOT NULL, 
TotalKilometrage INT NOT NULL, 
StartDate DATETIME2 NOT NULL, 
EndDate DATETIME2 NOT NULL, 
TotalDays TINYINT NOT NULL, 
RateApplied DECIMAL(8,2), 
TaxRate DECIMAL(8,2), 
OrderStatus BIT, 
Notes VARCHAR(300))

INSERT INTO Categories
VALUES
('SPORT CAR', 50, 250, 1000, 100),
('PASSANGER CAR', 80, 400, 1600, 160),
('GARGO', 200, 1000, 4000, 0)

INSERT INTO Cars
VALUES
('CB0001AA', 'BMW', 'X6', 2018, 5, 5, NULL, 'TOP', 1),
('CB0002AA', 'Ford', 'Fiesta', 2015, 4, 4, NULL, 'TOP', 0),
('CB0003AA', 'Iveco', 'Daily', 2014, 2, 2, NULL, 'TOP', 1)

INSERT INTO Employees
VALUES
('Ivan', 'Ivanov', 'Menager', ''),
('Niki', 'Kolev', 'Driver', ''),
('Spas', 'Todorov', 'Mechanic', '')

INSERT INTO Customers
VALUES
(35156515, 'Stoyan Pehlivarov', 'Kraslo Selo', 'Sofia', '', ''),
(95955541, 'Milen Ivanov', 'Ovcha Kupel', 'Sofia', '', ''),
(91364447, 'Georgi Kirilov', 'Obely', 'Sofia', '', '')

INSERT INTO RentalOrders
VALUES
(1, 1, 1, 65, 85000, 85700, 700, '1-6-2023', '1-11-2023', 5, 112.5, 20, 1, ''),
(1, 2, 3, 95, 225000, 226000, 1000, '2-1-2023', '2-6-2023', 5, 140, 20, 1, ''),
(3, 3, 2, 65, 85000, 85700, 700, '1-6-2023', '1-11-2023', 5, 112.5, 20, 0, '')

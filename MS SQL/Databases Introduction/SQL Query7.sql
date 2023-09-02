CREATE DATABASE SoftUni

USE SoftUni

CREATE TABLE Towns
(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(150) NOT NULL
)

CREATE TABLE Addresses
(
Id INT PRIMARY KEY IDENTITY,
AddressText VARCHAR(300) NOT NULL,
TownId INT NOT NULL
)
CREATE TABLE Departments
(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(150) NOT NULL
)

CREATE TABLE Employees
(
Id INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(50) NOT NULL, 
MiddleName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
JobTitle VARCHAR(50) NOT NULL, 
DepartmentId INT NOT NULL,
HireDate DATETIME2 NOT NULL,
Salary DECIMAL(10, 2) NOT NULL, 
AddressId INT NOT NULL
)

ALTER TABLE Addresses
ADD FOREIGN KEY	(TownId) REFERENCES Towns (Id)

ALTER TABLE Employees
ADD FOREIGN KEY	(DepartmentId) REFERENCES Departments (Id)

ALTER TABLE Employees
ADD FOREIGN KEY	(AddressId) REFERENCES Addresses (Id)

INSERT INTO Towns
VALUES
('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas')

INSERT INTO Addresses
VALUES
('Some address', 1),
('Some address', 2),
('Some address', 3),
('Some address', 4)

INSERT INTO Departments
VALUES
('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance')


INSERT INTO Employees
VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '02-01-2013', 3500, 1),
('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '03-02-2004', 4000, 2),
('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '08-28-2016', 525.25, 3),
('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '12-9-2007', 3000, 4),
('Peter', 'Pan', 'Pan', 'Intern', 3, '08-28-2016', 599.88, 1)

-- -- Task 19

SELECT * FROM Towns

SELECT * FROM Departments

SELECT * FROM Employees

-- Task 20

SELECT * FROM Towns

ORDER BY [Name]

SELECT * FROM Departments

ORDER BY [Name]

SELECT * FROM Employees

ORDER BY Salary DESC

-- -- Task 21

SELECT [Name]
FROM Towns
ORDER BY [Name]

SELECT [Name]
FROM Departments
ORDER BY [Name]

SELECT FirstName, LastName, JobTitle, Salary
FROM Employees
ORDER BY Salary DESC

-- Task 22

UPDATE Employees 
SET Salary *= 1.1

SELECT Salary
FROM Employees

-- Task 22

UPDATE Payments
SET TaxRate *= 0.97

SELECT TaxRate 
FROM Payments

-- Task 24
DELETE FROM Occupancies
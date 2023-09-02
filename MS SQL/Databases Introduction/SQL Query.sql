CREATE DATABASE Minions

USE Minions

CREATE TABLE Minions
	(
	Id INT PRIMARY KEY,
	[Name] VARCHAR(100),
	Age INT
	)

	CREATE TABLE Towns
	(
	Id INT PRIMARY KEY, 
	[Name] VARCHAR(100)
	)

	ALTER TABLE Minions
	ADD TownId INT Foreign KEY REFERENCES Towns (Id)
	
	INSERT INTO Towns
	VALUES
	(1,'Sofia'),
	(2,'Plovdiv'),
	(3,'Varna')

	INSERT INTO Minions
	VALUES
	(1, 'Kevin', 22, 1),
	(2, 'Bob', 15, 3),
	(3, 'Steward', NULL, 2)

	TRUNCATE TABLE Minions
	

	DROP TABLE Minions
	DROP TABLE Towns
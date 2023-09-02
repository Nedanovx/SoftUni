CREATE DATABASE People

USE People

CREATE TABLE People
	(
		Id BIGINT PRIMARY KEY IDENTITY,
		[Name] VARCHAR(30) NOT NULL,
		Picture VARBINARY(MAX),
		Height DECIMAL(10,2),
		[Weight] DECIMAL(10,2),
		Gender CHAR NOT NULL CHECK(Gender='m' OR Gender='f'),
		Birthdate DATETIME2 NOT NULL,
		Biography NVARCHAR(MAX)
	)

	INSERT INTO People
	([Name], Picture, Height, [Weight], Gender, Birthdate, Biography)
	VALUES
	('Ivan', NULL, 1.68, 56, 'm', '1-8-1988', '   '),
	('Kiro', NULL, 1.78, 64, 'm', '6-19-1998', 'Drink beer and coding       '),
	('Spas', NULL, 1.7, 61, 'm', '10-12-1982', NULL),
	('Ina', NULL, 1.75, 58, 'f', '12-1-1995', NULL),
	('Ana', NULL, 1.88, 61, 'f', '1-8-1990', 'Drink beer and coding')

	
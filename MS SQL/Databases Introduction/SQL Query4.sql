CREATE DATABASE Movies

USE Movies

CREATE TABLE Directors
(
Id INT PRIMARY KEY IDENTITY,
DirectorName VARCHAR(100),
Notes VARCHAR(300)
)

CREATE TABLE Genres
(
Id INT PRIMARY KEY IDENTITY,
GenreName VARCHAR(100),
Notes VARCHAR(300)
)

CREATE TABLE Categories
(
Id INT PRIMARY KEY IDENTITY,
CategoryName VARCHAR(100),
Notes VARCHAR(300)
)

CREATE TABLE Movies
(
Id INT PRIMARY KEY IDENTITY,
Title VARCHAR(100),
DirectorId INT NOT NULL,
CopyrightYear DATETIME2,
[Length] DECIMAL(8,2),
GenreId INT NOT NULL,
CategoryId INT NOT NULL,
Rating  DECIMAL(8,2),
Notes VARCHAR(300)
)

INSERT INTO Directors
VALUES
('Ivan', 'The best movie director!'),
('Spas', NULL),
('Niki', '  '),
('Pesho', '  '),
('Krum', '  ')

INSERT INTO Genres
VALUES
('Horror',''),
('Comedy','Very funny'),
('Fantasy','WOW'),
('Drama',''),
('Action','')

INSERT INTO Categories
VALUES
('Horror',''),
('Comedy',''),
('Fantasy',''),
('Drama',''),
('Action','')

INSERT INTO Movies
VALUES
('Bad boys', 1, '6-15-2002', 2.45, 2, 2, 8.5, ''),
('SAW', 2, '6-15-2009', 2.05, 1, 1, 8, ''),
('Wrong turn', 3, '6-15-2010', 2.15, 1, 1, 7.6, ''),
('Avatar 2', 4, '6-15-2023', 3.15, 3, 3, 9, ''),
('Prey', 5, '6-15-2021', 2.24, 5, 5, 6.9, '')


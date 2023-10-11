SELECT * FROM Addresses
WHERE SUBSTRING(TOWN, 1,1) ='L'

--5
SELECT * FROM Publishers
WHERE AddressId = 5

--1,16
SELECT * FROM Boardgames 
WHERE PublisherId IN(1,16)

DELETE FROM CreatorsBoardgames WHERE BoardgameId IN (1,16,31,47)
DELETE FROM Boardgames WHERE PublisherId IN (1,16)
DELETE FROM Publishers WHERE AddressId = 5
DELETE FROM Addresses WHERE SUBSTRING(TOWN, 1,1) ='L'
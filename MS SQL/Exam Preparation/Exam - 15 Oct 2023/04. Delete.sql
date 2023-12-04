SELECT * FROM Tourists
WHERE [Name] like '%Smith%'
--6, 16, 25

DELETE FROM Bookings
WHERE TouristId IN (6, 16, 25)

DELETE FROM Tourists
WHERE Id in (6, 16, 25)
CREATE OR ALTER PROCEDURE usp_SearchByTown(@townName VARCHAR(30)) 
AS
SELECT p.[Name], t.DateOfDeparture, tr.HourOfDeparture  FROM Passengers AS p
JOIN Tickets AS t ON t.PassengerId = p.Id
JOIN Trains AS tr ON tr.Id = t.TrainId
JOIN Towns ON Towns.Id = tr.ArrivalTownId
WHERE Towns.[Name] = @townName
ORDER BY t.DateOfDeparture DESC, p.[Name]

EXEC usp_SearchByTown 'Berlin'
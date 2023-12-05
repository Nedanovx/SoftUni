SELECT
 tw.[Name] AS TownName, COUNT(*) AS PassengersCount FROM Passengers AS p
JOIN Tickets AS t ON p.Id = t.PassengerId
JOIN Trains ON t.TrainId = Trains.Id
JOIN Towns AS tw ON Trains.ArrivalTownId = tw.Id
WHERE t.Price > 76.99
GROUP BY tw.[Name]
ORDER BY TownName;



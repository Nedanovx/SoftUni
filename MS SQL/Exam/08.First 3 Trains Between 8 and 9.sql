SELECT TOP 3 tr.Id AS TrainId, tr.HourOfDeparture AS HourOfDeparture, t.Price AS TicketPrice, town.[Name] AS Destination  FROM Trains AS tr
JOIN Tickets AS t ON t.TrainId = tr.Id
JOIN Towns AS town ON town.Id = tr.ArrivalTownId
WHERE tr.HourOfDeparture >= '08:00' AND tr.HourOfDeparture <= '08:59' AND t.Price > 50
ORDER BY Price
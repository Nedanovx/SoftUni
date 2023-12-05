SELECT p.[Name] AS PassengerName, t.Price AS TicketPrice, t.DateOfDeparture AS DateOfDeparture, tr.Id AS TrainId
FROM Passengers AS p
JOIN Tickets AS t ON t.PassengerId = p.Id
JOIN Trains AS tr ON tr.Id = t.TrainId
ORDER BY Price DESC, PassengerName
SELECT p.FullName, COUNT(*) AS CountOfAircraft, SUM(fd.TicketPrice) AS TotalPayed
FROM Passengers AS p
JOIN FlightDestinations AS fd ON fd.PassengerId = p.Id
JOIN Aircraft AS a ON a.Id = fd.AircraftId
WHERE SUBSTRING(p.FullName, 2, 1) ='a' 
GROUP BY p.FullName
HAVING COUNT(*) > 1
ORDER BY p.FullName
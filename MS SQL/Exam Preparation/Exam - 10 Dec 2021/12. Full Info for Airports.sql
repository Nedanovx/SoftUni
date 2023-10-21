CREATE PROCEDURE usp_SearchByAirportName(@airportName VARCHAR(70))
AS 
	SELECT a.AirportName, p.FullName,
	CASE
	WHEN fd.TicketPrice <= 400 THEN 'LOW'
	WHEN fd.TicketPrice BETWEEN 401 AND 1500 THEN 'Medium'
	WHEN fd.TicketPrice > 1500 THEN 'High'
	END AS LevelOfTickerPrice,
	ac.Manufacturer, ac.Condition, [at].TypeName
	FROM Airports AS a
	JOIN FlightDestinations AS fd ON fd.AirportId = a.Id
	JOIN Passengers AS p ON p.Id = fd.PassengerId
	JOIN Aircraft AS ac ON ac.Id = fd.AircraftId
	JOIN AircraftTypes AS [at] ON [at].Id = ac.TypeId
	WHERE a.AirportName = @airportName
	ORDER BY ac.Manufacturer, p.FullName
	
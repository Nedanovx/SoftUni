SELECT a.Id AS AircraftId, a.Manufacturer, a.FlightHours, COUNT(*) AS FlightDestinationsCount, ROUND(AVG(fd.TicketPrice),2)
FROM Aircraft AS a
JOIN FlightDestinations AS fd ON fd.AircraftId = a.Id
GROUP BY a.Id, a.Manufacturer, a.FlightHours
HAVING COUNT(*)  >= 2
ORDER BY FlightDestinationsCount DESC, AircraftId
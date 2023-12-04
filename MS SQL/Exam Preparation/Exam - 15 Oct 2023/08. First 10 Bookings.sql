SELECT TOP 10 h.[Name], d.[Name], c.[Name] FROM Bookings AS b
JOIN Hotels AS h ON h.Id = b.HotelId
JOIN Destinations AS d ON d.Id = h.DestinationId
JOIN Countries AS c ON c.Id = d.CountryId
WHERE B.ArrivalDate < '2023-12-31' AND b.HotelId % 2 > 0
ORDER BY c.[Name], b.ArrivalDate
SELECT h.Id, h.[Name] FROM HotelsRooms AS hr
JOIN Hotels AS h ON h.Id = hr.HotelId
JOIN Rooms AS r ON r.Id = hr.RoomId
JOIN Bookings AS b ON b.HotelId = h.Id
WHERE r.[Type] = 'VIP Apartment'
GROUP BY h.Id, h.[Name]
ORDER BY COUNT(b.Id) DESC
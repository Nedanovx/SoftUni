UPDATE Bookings
SET DepartureDate = DATEADD(DAY, 1, DepartureDate)
WHERE YEAR(ArrivalDate) = 2023 AND MONTH(ArrivalDate) = '12'

UPDATE Tourists
SET Email = NULL
WHERE Email LIKE '%MA%'


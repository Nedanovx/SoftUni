UPDATE Tickets

SET DateOfArrival = DATEADD(DAY, 7, DateOfArrivAL)
WHERE DateOfDeparture > '2023-10-31'

UPDATE Tickets
SET DateOfDeparture = DATEADD(DAY, 7, DateOfDeparture)
WHERE DateOfDeparture > '2023-10-31'


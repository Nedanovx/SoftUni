SELECT * FROM Towns
WHERE [Name] = 'Berlin'
--3

SELECT * FROM Trains
WHERE DepartureTownId = 3
--7
DELETE FROM MaintenanceRecords
WHERE TrainId = 7

DELETE FROM TrainsRailwayStations
WHERE TrainId =7

DELETE FROM Tickets
WHERE TrainId = 7

DELETE FROM Trains
WHERE Trains.Id = 7
SELECT t.Id AS TrainID, tw.[Name] AS DepartureTown, mr.Details AS Details FROM Trains AS t
JOIN Towns AS tw ON tw.Id = t.DepartureTownId
JOIN MaintenanceRecords AS mr ON mr.TrainId = t.Id
WHERE mr.Details LIKE '%inspection%'
ORDER BY t.Id

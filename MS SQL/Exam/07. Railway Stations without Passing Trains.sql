SELECT t.[Name] AS Town, rs.[Name] AS RailwayStation FROM RailwayStations AS rs
JOIN Towns AS t ON t.Id = rs.TownId
LEFT JOIN TrainsRailwayStations AS trs ON trs.RailwayStationId = rs.Id
LEFT JOIN Trains AS tr ON tr.Id = trs.TrainId
WHERE trs.RailwayStationId IS NULL
ORDER BY Town, RailwayStation
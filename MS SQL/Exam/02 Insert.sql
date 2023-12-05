INSERT INTO Trains
VALUES
('07:00', '19:00', 1, 3),
('08:30', '20:30', 5, 6),
('09:00', '21:00', 4, 8),
('06:45', '03:55', 27, 7),
('10:15', '12:15', 15, 5)

INSERT INTO TrainsRailwayStations(TrainId, RailwayStationId)
VALUES
(36, 1), (37, 6), (39, 3),
(36, 4), (37, 16),(39,31),
(36, 31), (38, 10),(39,	19),
(36, 57), (38, 50), (40, 41),
(36, 7), (38, 52),(40, 7),
(37, 13), (38, 22), (40, 52),
(37, 54), (39, 68), (40,13)

INSERT INTO Tickets
VALUES
(90.00,	'2023-12-01', '2023-12-01',	36,	1),
(115.00, '2023-08-02', '2023-08-02', 37, 2),
(160.00, '2023-08-03', '2023-08-03', 38, 3),
(255.00, '2023-09-01', '2023-09-02', 39, 21),
(95.00,	'2023-09-02', '2023-09-03',	40,	22)
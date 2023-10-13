SELECT s.[Name] AS [Site], l.[Name] AS [Location], l.Municipality, l.Province, s.Establishment 
FROM Sites AS s
JOIN Locations AS l ON l.Id = s.LocationId
WHERE LEFT(s.[Name], 1) NOT IN ('B', 'M', 'D') AND s.Establishment LIKE '%BC'
ORDER BY [Site]
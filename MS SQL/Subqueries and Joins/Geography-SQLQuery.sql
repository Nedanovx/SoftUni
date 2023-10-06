--12. Highest Peaks in Bulgaria

SELECT c.CountryCode, m.MountainRange, p.PeakName, p.Elevation

FROM Countries AS c

JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode 

AND mc.CountryCode = 'BG'

JOIN Mountains AS m ON m.Id = mc.MountainId

JOIN Peaks AS p ON p.MountainId = m.Id 

AND p.Elevation > 2835

ORDER BY p.Elevation DESC

--13. Count Mountain Ranges

SELECT c.CountryCode, COUNT(*) AS MountainRanges

FROM Countries AS c

JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode

AND mc.CountryCode IN ('BG', 'RU', 'US')

GROUP BY c.CountryCode


--14. Countries With or Without Rivers

SELECT TOP 5

c.CountryName, r.RiverName 

FROM Countries AS c

LEFT JOIN  CountriesRivers AS cr ON c.CountryCode = cr.CountryCode

LEFT JOIN Rivers AS r ON r.Id = cr.RiverId

WHERE c.ContinentCode = 'AF'

ORDER BY c.CountryName

--15. *Continents and Currencies

SELECT ContinentCode, CurrencyCode, CurrencyUsage

FROM

(SELECT *, DENSE_RANK () OVER(PARTITION BY ContinentCode ORDER BY CurrencyUsage DESC) AS r

FROM 

(SELECT ContinentCode, CurrencyCode, COUNT(CurrencyCode) AS CurrencyUsage

FROM Countries

GROUP BY ContinentCode, CurrencyCode) AS FirstQuery

WHERE CurrencyUsage > 1) AS SecondQuery

WHERE r = 1

ORDER BY ContinentCode

--16. Countries Without any Mountains

SELECT COUNT(*)

FROM Countries AS c

LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode

WHERE mc.MountainId IS NULL

--17. Highest Peak and Longest River by Country

SELECT TOP 5 CountryName, 

MAX(p.Elevation) AS HighestPeakElevation, 

MAX(r.[Length]) AS LongestRiverLength

FROM Countries AS c

LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode

LEFT JOIN Mountains AS m ON m.Id = mc.MountainId

LEFT JOIN Peaks AS p ON p.MountainId = m.Id

LEFT JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode 

LEFT JOIN Rivers AS r ON r.Id = cr.RiverId

GROUP BY CountryName

ORDER BY HighestPeakElevation DESC, 

LongestRiverLength DESC,

CountryName

--18. Highest Peak Name and Elevation by Country

SELECT TOP 5
c.CountryName AS Country,

CASE
WHEN p.PeakName IS NOT NULL THEN p.PeakName
ELSE '(no highest peak)'
END AS [Highest Peak Name],

CASE 
WHEN MAX(p.Elevation) IS NOT NULL THEN p.Elevation
ELSE 0
END AS [Highest Peak Elevation],

CASE
WHEN m.MountainRange IS NOT NULL THEN m.MountainRange
ELSE '(no mountain)'
END AS Mountain

FROM Countries AS c

LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode

LEFT JOIN Mountains AS m ON m.Id = mc.MountainId

LEFT JOIN Peaks AS p ON m.Id = p.MountainId

GROUP BY c.CountryName, p.PeakName, p.Elevation, m.MountainRange

ORDER BY Country, [Highest Peak Elevation]
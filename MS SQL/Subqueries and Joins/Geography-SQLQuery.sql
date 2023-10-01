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



--12. Countries Holding 'A' 3 or More Times

SELECT CountryName, IsoCode FROM Countries

WHERE

CountryName LIKE '%a%%a%%a%'

ORDER BY IsoCode

--13. Mix of Peak and River Names

SELECT p.PeakName, r.RiverName, LOWER(CONCAT_WS('', p.PeakName, SUBSTRING(r.RiverName, 2, LEN(r.RiverName)))) AS Mix 
FROM Peaks AS p
JOIN Rivers AS r
ON 
RIGHT(p.PeakName,1) LIKE LEFT(r.RiverName,1) ORDER BY Mix
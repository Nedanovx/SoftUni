--22. All Mountain Peaks

SELECT PeakName 
FROM Peaks 
ORDER BY PeakName

--23. Biggest Countries by Population

SELECT TOP(30) CountryName, [Population] 

FROM Countries

WHERE

ContinentCode = 'EU'
ORDER BY [Population] DESC,
CountryName ASC

--24. *Countries and Currency (Euro / Not Euro)

SELECT CountryName, CountryCode, 
CASE [CurrencyCode]
WHEN 'EUR' THEN 'Euro'
ELSE 'Not Euro'
END
AS 'Currency'
FROM Countries
ORDER BY CountryName

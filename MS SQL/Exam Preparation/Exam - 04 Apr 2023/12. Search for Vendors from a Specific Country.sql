CREATE PROCEDURE usp_SearchByCountry(@country VARCHAR(100))
AS 
SELECT v.[Name] AS Vendor, v.NumberVAT AS VAT, 
CONCAT_WS(' ', a.StreetName, a.StreetNumber) AS [Street Info ], 
CONCAT_WS(' ', a.City, a.PostCode) AS [City Info ]
FROM Vendors AS v
JOIN Addresses AS a ON a.Id = v.AddressId
JOIN Countries AS c ON c.Id = a.CountryId
WHERE @country = c.[Name]
ORDER BY v.[Name], a.City

EXEC usp_SearchByCountry 'France'
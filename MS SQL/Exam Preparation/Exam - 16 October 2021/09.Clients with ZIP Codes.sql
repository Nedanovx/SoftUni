SELECT CONCAT_WS(' ', c.FirstName, c.LastName) AS FullName, a.Country AS Country, a.ZIP AS ZIP, CONCAT('$', MAX(cig.PriceForSingleCigar)) AS CigarPrice 
FROM Clients AS c
JOIN Addresses AS a ON a.Id = c.AddressId
JOIN ClientsCigars AS cc ON cc.ClientId = c.Id
JOIN Cigars AS cig ON cig.Id = cc.CigarId
WHERE ISNUMERIC(a.ZIP) = 1
GROUP BY CONCAT_WS(' ', c.FirstName, c.LastName), a.Country, a.ZIP
ORDER BY FullName


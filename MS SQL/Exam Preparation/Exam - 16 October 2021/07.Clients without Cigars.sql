SELECT c.Id, CONCAT_WS(' ', c.FirstName, c.LastName) AS ClientName, c.Email AS Email  FROM Clients AS c
LEFT JOIN ClientsCigars AS cc ON cc.ClientId = c.Id
LEFT JOIN Cigars AS cig ON cig.Id = cc.CigarId
WHERE cc.CigarId IS NULL
GROUP BY c.Id, CONCAT_WS(' ', c.FirstName, c.LastName), c.Email
ORDER BY ClientName
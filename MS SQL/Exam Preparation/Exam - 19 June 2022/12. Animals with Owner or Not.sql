CREATE PROCEDURE usp_AnimalsWithOwnersOrNot(@AnimalName VARCHAR (100))
AS 
SELECT a.[Name],
CASE
WHEN  o.Id IS NULL THEN 'For adoption'
ELSE o.[Name]
END AS OwnersName
FROM Animals AS a
LEFT JOIN Owners AS o ON o.Id = a.OwnerId
WHERE @AnimalName = a.[Name]
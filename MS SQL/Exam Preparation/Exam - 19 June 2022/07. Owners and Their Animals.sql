SELECT TOP 5
o.[Name], COUNT(*) AS CountOfAnimals
FROM Owners AS o
JOIN Animals AS a ON a.OwnerId = o.Id
GROUP BY o.[Name]
ORDER BY CountOfAnimals DESC, o.[Name] 
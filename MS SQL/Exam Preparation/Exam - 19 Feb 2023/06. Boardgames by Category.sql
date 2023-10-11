SELECT b.Id, b.[Name], b.YearPublished, c.[Name] AS CategoryName
FROM Boardgames AS b
JOIN Categories AS c ON c.Id = b.CategoryId
WHERE c.Name IN ('Strategy Games', 'Wargames') 
ORDER BY YearPublished DESC

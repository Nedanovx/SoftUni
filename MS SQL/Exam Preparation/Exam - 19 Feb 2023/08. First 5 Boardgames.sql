--08. First 5 Boardgames

SELECT TOP 5  
b.[Name], B.Rating, c.[Name]
FROM Boardgames AS b
JOIN Categories AS c ON c.Id = b.CategoryId
JOIN PlayersRanges pr ON pr.Id = b.PlayersRangeId
WHERE b.Rating > 7 AND b.[Name] LIKE '%a%' 
OR b.Rating > 7.50 AND pr.PlayersMin >= 2 AND pr.PlayersMax <= 5
ORDER BY b.[Name], b.Rating DESC
SELECT r.[Description], c.[Name] AS CategoryName
FROM Reports AS r
LEFT JOIN Categories AS c ON c.Id = r.CategoryId
WHERE r.[Description] IS NOT NULL
ORDER BY r.[Description], c.[Name]
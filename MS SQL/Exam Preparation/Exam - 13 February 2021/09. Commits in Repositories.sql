SELECT TOP 5 r.Id, r.[Name], COUNT(r.[Name]) AS Commits FROM Repositories AS r
LEFT JOIN Commits AS c ON c.RepositoryId = r.Id
JOIN RepositoriesContributors AS rc ON rc.RepositoryId = r.Id
GROUP BY r.Id, r.[Name]
ORDER BY Commits DESC, r.Id, r.[Name]
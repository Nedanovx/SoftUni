SELECT f.Id, f.[Name], CONCAT_WS('', f.Size, 'KB') AS SIZE FROM Files AS f
LEFT JOIN Files ON Files.ParentId = f.Id
WHERE Files.Id IS NULL
ORDER BY f.Id, f.[Name], SIZE DESC

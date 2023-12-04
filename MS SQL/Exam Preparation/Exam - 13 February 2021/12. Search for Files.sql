CREATE PROCEDURE usp_SearchForFiles(@fileExtension VARCHAR(5))
AS
SELECT Id, [Name], CONCAT_WS('', Size, 'KB') AS Size
FROM Files AS f
WHERE SUBSTRING(f.[Name], CHARINDEX('.', f.[Name]) +1, LEN(f.[Name])) = @fileExtension

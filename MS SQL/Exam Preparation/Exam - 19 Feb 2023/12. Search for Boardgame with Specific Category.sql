--12. Search for Boardgame with Specific Category
CREATE PROCEDURE usp_SearchByCategory
@category NVARCHAR (50)
AS
	
	DECLARE @categoryId INT =
		(
			SELECT Id 
			FROM Categories
			WHERE [Name] = @category
		)

		SELECT b.[Name], b.YearPublished, b.Rating, @category AS [CategoryName], p.[Name] AS PublisherName,
		CONCAT_WS(' ', pr.PlayersMin, 'people') AS MinPlayers, CONCAT_WS(' ', pr.PlayersMax, 'people') AS MaxPlayers
		FROM Boardgames AS b
		JOIN Publishers AS p ON p.Id = b.PublisherId
		JOIN PlayersRanges AS pr ON pr.Id = b.PlayersRangeId

		WHERE CategoryId = @categoryId
		ORDER BY PublisherName, YearPublished DESC

		EXEC usp_SearchByCategory 'Wargames'
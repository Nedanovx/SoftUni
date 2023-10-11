--11. Creator with Boardgames
CREATE FUNCTION udf_CreatorWithBoardgames(@name NVARCHAR (50))
RETURNS INT
AS
BEGIN
	DECLARE @total INT = 
		(
		SELECT COUNT(BoardgameId)
		FROM CreatorsBoardgames AS cb
		JOIN Creators AS c ON C.Id = cb.CreatorId
		WHERE c.FirstName = @name
		)
		RETURN @total
END
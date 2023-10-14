CREATE FUNCTION udf_ProductWithClients(@name VARCHAR (100))
RETURNS INT
AS
BEGIN
	DECLARE @Result INT 
		SET @Result = (
		SELECT COUNT(*) 
		FROM Clients AS c
		JOIN ProductsClients AS pc ON pc.ClientId = c.Id
		JOIN Products AS p ON p.Id = pc.ProductId
		WHERE @name = p.[Name])	
		RETURN @Result
END

SELECT dbo.udf_ProductWithClients ('DAF FILTER HU12103X')
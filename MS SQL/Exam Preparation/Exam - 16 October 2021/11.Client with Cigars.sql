CREATE FUNCTION udf_ClientWithCigars(@name NVARCHAR(30)) 
RETURNS INT 
AS
BEGIN
	DECLARE @total INT =
		(
		SELECT COUNT(c.Id)
		FROM Cigars AS c
		JOIN ClientsCigars AS cc ON cc.CigarId =c.Id
		JOIN Clients ON Clients.Id = cc.ClientId
		WHERE Clients.FirstName = @name
		)
		RETURN @total
END

SELECT dbo.udf_ClientWithCigars('Betty')
CREATE FUNCTION udf_FlightDestinationsByEmail(@email VARCHAR (100))
RETURNS INT
AS
BEGIN
	DECLARE @Result INT = (
			SELECT COUNT(*) 
			FROM Passengers AS p
			JOIN FlightDestinations AS fd ON fd.PassengerId = p.Id
			WHERE p.Email = @email)
			RETURN @Result
		
END
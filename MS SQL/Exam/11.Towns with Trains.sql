CREATE FUNCTION udf_TownsWithTrains( @townName NVARCHAR(30) )
RETURNS INT
AS
BEGIN
    DECLARE @totalTrains INT;

    SELECT @totalTrains = COUNT(DISTINCT t.Id)
    FROM Trains AS t
    WHERE t.DepartureTownId IN (SELECT Id FROM Towns WHERE [Name] = @townName)
       OR t.ArrivalTownId IN (SELECT Id FROM Towns WHERE [Name] = @townName);

    RETURN @totalTrains;
END;

SELECT dbo.udf_TownsWithTrains('Paris')
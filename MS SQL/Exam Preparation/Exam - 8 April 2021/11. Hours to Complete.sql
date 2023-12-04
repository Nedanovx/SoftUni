CREATE OR ALTER FUNCTION udf_HoursToComplete(@StartDate DATETIME, @EndDate DATETIME)
RETURNS INT
AS
	BEGIN
		IF(@StartDate IS NULL OR @EndDate IS NULL)
		BEGIN 
			RETURN 0;
		END

			RETURN ABS(DATEDIFF(HOUR, @EndDate, @StartDate))
	END

	SELECT dbo.udf_HoursToComplete(OpenDate, CloseDate) AS TotalHours
   FROM Reports
   WHERE Reports.Id = 24
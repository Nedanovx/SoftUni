CREATE FUNCTION  udf_RoomsWithTourists(@name VARCHAR(100))
RETURNS INT 
AS
BEGIN
	DECLARE @Result INT 
	SET @Result = 
	(
	SELECT SUM(b.AdultsCount + ChildrenCount) FROM Rooms AS r
	JOIN Bookings AS b ON b.RoomId = r.Id
	WHERE @name  = r.Type)
	RETURN @Result
END
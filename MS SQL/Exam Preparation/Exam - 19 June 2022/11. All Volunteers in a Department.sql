CREATE FUNCTION udf_GetVolunteersCountFromADepartment (@VolunteersDepartment VARCHAR (100))
RETURNS INT
AS 
BEGIN
	DECLARE @Result INT = (
	SELECT COUNT(*) 
	FROM VolunteersDepartments AS vd
	JOIN Volunteers AS v ON v.DepartmentId = vd.Id
	WHERE vd.DepartmentName = @VolunteersDepartment)
	RETURN @Result
END

SELECT dbo.udf_GetVolunteersCountFromADepartment ('Education program assistant')
CREATE OR ALTER PROCEDURE usp_AssignEmployeeToReport(@EmployeeId INT, @ReportId INT)
AS
BEGIN

	DECLARE @employeeDepartmet INT =
	(SELECT DepartmentId
		FROM Employees 
		WHERE Id = @EmployeeId);

	DECLARE @departmetCategory INT =
		(SELECT C.DepartmentId FROM Reports AS r
		JOIN Categories AS c ON c.Id = r.CategoryId
		WHERE r.Id = @ReportId);

		IF(@employeeDepartmet = @departmetCategory)
		BEGIN
		UPDATE Reports
		SET EmployeeId = @EmployeeId
		WHERE Id = @ReportId
		END

	ELSE 
		BEGIN 
			RAISERROR ('Employee doesn''t belong to the appropriate department!', 15, 1);
			END 
END

EXEC usp_AssignEmployeeToReport 30, 1
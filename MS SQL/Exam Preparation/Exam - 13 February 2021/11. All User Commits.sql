CREATE FUNCTION udf_AllUserCommits(@username VARCHAR(30)) 
RETURNS INT
AS
BEGIN
	DECLARE @result INT =
	(SELECT COUNT(c.Id) FROM Users AS u
	JOIN Commits AS c ON c.ContributorId = u.Id
	WHERE u.Username = @username)
	RETURN @result
	END
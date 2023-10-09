--01. Employees with Salary Above 35000

CREATE PROCEDURE usp_GetEmployeesSalaryAbove35000
AS
SELECT FirstName, LastName
FROM Employees
WHERE Salary > 35000

EXEC usp_GetEmployeesSalaryAbove35000


--02. Employees with Salary Above Number

CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber
@salaryLevel DECIMAL (18,4)
AS
SELECT FirstName, LastName
FROM Employees
WHERE Salary >= @salaryLevel

EXEC usp_GetEmployeesSalaryAboveNumber 30000

--03. Town Names Starting With

CREATE PROCEDURE usp_GetTownsStartingWith
@inputString NVARCHAR (50)
AS
SELECT [Name] 
FROM Towns
WHERE [Name] LIKE @inputString + '%'

EXEC usp_GetTownsStartingWith 'S'

--04. Employees from Town

CREATE PROCEDURE usp_GetEmployeesFromTown
@townName NVARCHAR(50)
AS
SELECT FirstName AS [First Name], LastName AS [Last Name]
FROM Employees AS e
JOIN Addresses AS a ON e.AddressID = a.AddressID
JOIN Towns AS t ON a.TownID = t.TownID
WHERE t.Name = @townName


EXEC usp_GetEmployeesFromTown 'Sofia'

--05. Salary Level Function

CREATE FUNCTION ufn_GetSalaryLevel (@salary DECIMAL(18,4))
RETURNS VARCHAR(20)
AS
BEGIN
	IF @salary < 30000
	RETURN 'Low'
	ELSE IF @salary <= 50000
	RETURN 'Average'

	RETURN  'High'
END
 
 SELECT dbo.ufn_GetSalaryLevel (20000)


 --06. Employees by Salary Level

 CREATE PROCEDURE usp_EmployeesBySalaryLevel
 @salaryLevel VARCHAR (20)
 AS 
 BEGIN
 SELECT FirstName AS [First Name], LastName AS [Last Name]  
 FROM Employees
 WHERE
 dbo.ufn_GetSalaryLevel(Salary) = @salaryLevel
 END

 EXEC usp_EmployeesBySalaryLevel 'Low'


 --07. Define Function

 CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR (100), @word VARCHAR (100))
 RETURNS BIT 
 AS
 BEGIN
	DECLARE @I INT = 1
	WHILE @I <=LEN(@word)
	BEGIN
		DECLARE @ch VARCHAR(1) = SUBSTRING(@word, @I, 1)
		IF CHARINDEX(@ch, @setOfLetters) = 0
		RETURN 0
		ELSE 
		SET @i += 1
		END
		RETURN 1
	END

	SELECT dbo.ufn_IsWordComprised('osfiadd', 'limon')

--09. Find Full Name
CREATE PROCEDURE usp_GetHoldersFullName
AS 
SELECT
CONCAT_WS(' ', FirstName, LastName)
FROM AccountHolders

EXEC usp_GetHoldersFullName

--10. People with Balance Higher Than

CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan
@inputNumber DECIMAL (18,2)
AS
SELECT ah.FirstName AS [First Name], ah.LastName AS [Last Name]
FROM AccountHolders AS ah
WHERE ah.Id IN
(SELECT AccountHolderId
FROM Accounts
GROUP BY AccountHolderId
HAVING SUM(Balance) > @inputNumber)
ORDER BY FirstName, LastName

EXEC usp_GetHoldersWithBalanceHigherThan 30000

--11. Future Value Function

CREATE FUNCTION ufn_CalculateFutureValue(@Sum DECIMAL (18,2), @Rate FLOAT, @Years INT)
RETURNS DECIMAL (20,4)
AS
BEGIN
	RETURN @SUM * POWER((1 + @Rate), @Years) 
END

SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5)

--12. Calculating Interest

CREATE PROCEDURE usp_CalculateFutureValueForAccount (@AccountId INT, @Rate FLOAT)
AS
	DECLARE @Years INT = 5
	SELECT a.Id AS [Account Id], ah.FirstName AS [First Name], ah.LastName AS [Last Name], a.Balance AS [Current Balance],
	dbo.ufn_CalculateFutureValue(a.Balance, @Rate, @Years) AS [Balance in 5 years]
	FROM AccountHolders AS ah
	JOIN Accounts AS a ON a.AccountHolderId = ah.Id
	WHERE 
	a.Id = @AccountId

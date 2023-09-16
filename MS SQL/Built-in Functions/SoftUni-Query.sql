--1. Find Names of All Employees by First Name

SELECT FirstName, LastName FROM Employees
WHERE
FirstName LIKE 'SA%'

--2. Find Names of All Employees by Last Name

SELECT FirstName, LastName FROM Employees
WHERE
LastName LIKE '%ei%'

--3. Find First Names of All Employees

SELECT FirstName FROM Employees
WHERE
DepartmentID IN (3, 10) 
AND
YEAR(HireDate) >= 1995 AND YEAR(HireDate) <= 2005

--4. Find All Employees Except Engineers

SELECT FirstName, LastName FROM Employees
WHERE
JobTitle NOT LIKE '%engineer%'

--5. Find Towns with Name Length
SELECT [Name] FROM Towns
WHERE
LEN([Name]) = 5 OR LEN([Name]) = 6 ORDER BY [Name]

--6. Find Towns Starting With
-- FIRST OPTION
SELECT * FROM Towns
WHERE
LEFT ([Name], 1) LIKE 'R'
OR
LEFT ([Name], 1) LIKE 'M'
OR
LEFT ([Name], 1) LIKE 'B'
OR
LEFT ([Name], 1) LIKE 'E'
ORDER BY [Name]

--SECOND OPTION

SELECT * FROM Towns
WHERE
SUBSTRING([Name], 1, 1) LIKE 'M'
OR
SUBSTRING([Name], 1, 1) LIKE 'K'
OR
SUBSTRING([Name], 1, 1) LIKE 'B'
OR
SUBSTRING([Name], 1, 1) LIKE 'E'
ORDER BY [Name]

--7. Find Towns Not Starting With
-- FIRST OPTION

SELECT * FROM Towns
WHERE
SUBSTRING([Name], 1, 1) NOT LIKE 'R'
AND
SUBSTRING([Name], 1, 1) NOT LIKE 'B'
AND
SUBSTRING([Name], 1, 1) NOT LIKE 'D'
ORDER BY [Name]

--SECOND OPTION

SELECT * FROM Towns
WHERE
LEFT ([Name], 1) NOT LIKE 'R'
AND
LEFT ([Name], 1) NOT LIKE 'B'
AND
LEFT ([Name], 1) NOT LIKE 'D'
ORDER BY [Name]

--8. Create View Employees Hired After 2000 Year

CREATE VIEW V_EmployeesHiredAfter2000 AS

SELECT FirstName, LastName FROM Employees

WHERE 

YEAR(HireDate) > 2000

--9. Length of Last Name

SELECT FirstName, LastName FROM Employees

WHERE
LEN(LastName) = 5

--10. Rank Employees by Salary

SELECT EmployeeID, FirstName, LastName, Salary, DENSE_RANK() OVER (PARTITION BY SALARY ORDER BY EmployeeID) AS [Rank]

FROM Employees

WHERE 

Salary BETWEEN 10000 AND 50000 ORDER BY Salary DESC

--11. Find All Employees with Rank 2

SELECT * FROM (SELECT EmployeeID, FirstName, LastName, Salary, DENSE_RANK() OVER (PARTITION BY SALARY ORDER BY EmployeeID) AS [Rank]

FROM Employees) AS x

WHERE 

Salary BETWEEN 10000 AND 50000 AND x.[Rank] = 2 

ORDER BY Salary DESC

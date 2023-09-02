--2. Find All the Information About Departments

SELECT * FROM Departments

--3. Find all Department Names

SELECT [Name] FROM Departments

--4. Find Salary of Each Employee

SELECT FirstName, LastName, Salary 

FROM Employees

--5. Find Full Name of Each Employee

SELECT FirstName, MiddleName, LastName 

FROM Employees

--6. Find Email Address of Each Employee

SELECT FirstName + '.' + LastName + '@softuni.bg' 

FROM Employees AS [Full Email Address]

--7. Find All Different Employees' Salaries

SELECT DISTINCT Salary 

FROM Employees

--8. Find All Information About Employees

SELECT * FROM Employees

WHERE

JobTitle = 'Sales Representative'

--9. Find Names of All Employees by Salary in Rang

SELECT FirstName, LastName, JobTitle FROM Employees

WHERE
Salary >= 20000 AND Salary <= 30000

--10. Find Names of All Employees

SELECT FirstName + ' ' + MiddleName + ' ' + LastName 

FROM Employees AS [Full Name]

WHERE

Salary IN (25000, 14000, 12500, 23600)

--11. Find All Employees Without a Manager

SELECT FirstName, LastName 

FROM Employees

WHERE

ManagerID IS NULL

--12. Find All Employees with a Salary More Than 50000

SELECT FirstName, LastName, Salary

FROM Employees

WHERE

Salary > 50000

ORDER BY Salary DESC

--13. Find 5 Best Paid Employees.

SELECT TOP(5) FirstName, LastName 

FROM Employees

WHERE

Salary > 50000

ORDER BY Salary DESC

--14. Find All Employees Except Marketing

SELECT FirstName, LastName 

FROM Employees

WHERE

DepartmentId <> 4

--15. Sort Employees Table

SELECT * 

FROM Employees 
ORDER BY Salary DESC, 
FirstName ASC,
LastName DESC, 
MiddleName ASC

--16. Create View Employees with Salaries

CREATE VIEW v_EmployeesSalaries AS 

SELECT FirstName, LastName, Salary

FROM Employees

--17. Create View Employees with Job Titles

CREATE VIEW v_EmployeeNameJobTitle AS

SELECT FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName AS [Full Name], JobTitle

FROM Employees

--18. Distinct Job Titles

SELECT DISTINCT JobTitle 

FROM Employees

--19. Find First 10 Started Projects

SELECT  TOP(10) ProjectID AS Id, [Name], [Description], StartDate, EndDate

FROM Projects

ORDER BY StartDate, [Name]

--20. Last 7 Hired Employees

SELECT TOP(7) FirstName, LastName, HireDate FROM Employees ORDER BY HireDate DESC

--21. Increase Salaries

SELECT DepartmentID

FROM Departments

WHERE

[Name] IN ('Engineering', 'Tool Design', 'Marketing', 'Information Services')

UPDATE Employees
SET Salary *= 1.12

WHERE 

DepartmentID IN (1, 2, 4, 11)

SELECT SALARY FROM Employees


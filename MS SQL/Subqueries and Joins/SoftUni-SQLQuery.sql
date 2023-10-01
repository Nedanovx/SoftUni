--01. Employee Address

SELECT TOP 5 
e.EmployeeID, e.JobTitle, e.AddressID, a.AddressText

FROM Employees AS e

LEFT JOIN Addresses AS a ON e.AddressID = a.AddressID

ORDER BY AddressID

--02. Addresses with Towns

SELECT TOP 50 

e.FirstName, e.LastName, t.[Name], a.AddressText

FROM Employees AS e

LEFT JOIN Addresses AS a ON a.AddressID = e.AddressID

LEFT JOIN Towns AS t ON t.TownID = a.TownID

ORDER BY e.FirstName, e.LastName

--03. Sales Employees

SELECT e.EmployeeID, e.FirstName, e.LastName, d.[Name]

FROM Employees AS e

JOIN Departments AS d ON e.DepartmentID = d.DepartmentID

WHERE d.Name = 'Sales'

ORDER BY e.EmployeeID

--04. Employee Departments

SELECT TOP 5

e.EmployeeID, e.FirstName, e.Salary, d.[Name] 

FROM Employees AS e

JOIN Departments AS d ON e.DepartmentID = d.DepartmentID

WHERE e.Salary > 15000

ORDER BY d.DepartmentID

--05. Employees Without Projects

SELECT TOP 3

e.EmployeeID, e.FirstName

FROM Employees AS e

FULL JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID

WHERE ep.ProjectID IS NULL

ORDER BY e.EmployeeID

--06. Employees Hired After

SELECT e.FirstName, e.LastName, e.HireDate, d.[Name] AS DeptName 

FROM Employees AS e

JOIN Departments AS d ON e.DepartmentID = d.DepartmentID

WHERE e.HireDate > '1999/1/1' AND d.[Name] IN ('Sales', 'Finance')

ORDER BY e.HireDate

--07. Employees With Project

SELECT TOP 5

e.EmployeeID, e.FirstName, p.[Name] AS ProjectName

FROM Employees AS e

JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID

JOIN Projects AS p ON p.ProjectID = ep.ProjectID

WHERE p.StartDate > '2002/08/13' AND p.EndDate IS NULL

ORDER BY e.EmployeeID

--08. Employee 24

SELECT e.EmployeeID, e.FirstName, IIF(YEAR(p.StartDate) >= 2005, NULL, p.[Name]) AS ProjectName 

FROM Employees AS e

JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID AND e.EmployeeID = 24
JOIN Projects AS p ON p.ProjectID = ep.ProjectID

--09. Employee Manager

SELECT e.EmployeeID, e.FirstName, e.ManagerID, x.FirstName AS ManagerName

FROM Employees AS e

JOIN Employees AS x ON x.EmployeeID = e.ManagerID AND e.ManagerID IN (3,7)

ORDER BY e.EmployeeID

--10. Employees Summary

SELECT TOP 50

e.EmployeeID, CONCAT_WS(' ', e.FirstName, e.LastName) AS EmployeeName,

CONCAT_WS(' ',x.FirstName, X.LastName) AS ManagerName,

d.[Name] AS DepartmentName

FROM Employees AS e

LEFT JOIN Departments AS d ON e.DepartmentID = d.DepartmentID

LEFT JOIN Employees AS x ON e.ManagerID = x.EmployeeID

ORDER BY e.EmployeeID

--11. Min Average Salary
SELECT MIN(dt.AverageSalary) AS MinAverageSalary 

FROM
(SELECT e.DepartmentID, AVG (e.Salary) AS AverageSalary

FROM Employees AS e

GROUP BY e.DepartmentID) AS dt
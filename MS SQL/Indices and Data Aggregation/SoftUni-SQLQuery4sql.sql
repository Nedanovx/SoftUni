--13. Departments Total Salaries

SELECT DepartmentID, SUM(Salary) AS TotalSalary
FROM Employees
GROUP BY DepartmentID

--14. Employees Minimum Salaries

SELECT DepartmentID, MIN(Salary) AS MinimumSalary
FROM Employees
WHERE DepartmentID IN (2,5,7) AND HireDate > '1/1/2000'
GROUP BY DepartmentID

--15. Employees Average Salaries

SELECT * INTO EmployeesNew
FROM Employees
WHERE Salary > 30000

DELETE FROM EmployeesNew
WHERE ManagerID = 42

UPDATE EmployeesNew
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentID, AVG(Salary) AS AverageSalary
FROM EmployeesNew
GROUP BY DepartmentID

--16. Employees Maximum Salaries

SELECT DepartmentID, MAX(Salary) AS MaxSalary
FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000


--17. Employees Count Salaries

SELECT COUNT(*) AS Count
FROM Employees
WHERE ManagerID IS NULL

--18. *3rd Highest Salary
SELECT DepartmentID, Salary AS ThirdHighestSalary 
FROM
(SELECT Salary, DepartmentID, 
DENSE_RANK() OVER(PARTITION BY DepartmentID ORDER BY Salary DESC) AS salaryRanking
FROM Employees
GROUP BY DepartmentID, Salary) AS subq
WHERE subq.salaryRanking = 3

--19. **Salary Challenge

SELECT TOP 10
FirstName, LastName, DepartmentID
FROM Employees AS e
WHERE
Salary > 
(SELECT AVG(Salary) AS avgSalary
FROM Employees AS x
WHERE X.DepartmentID = E.DepartmentID
GROUP BY DepartmentID)
ORDER BY DepartmentID

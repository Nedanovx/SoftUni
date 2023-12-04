SELECT CONCAT_WS(' ', e.FirstName, e.LastName) AS FullName, COUNT(u.Id) AS UsersCount
FROM Employees AS e 
LEFT JOIN Reports AS r ON r.EmployeeId = e.Id
LEFT JOIN Users AS u ON u.Id = r.StatusId
GROUP BY CONCAT_WS(' ', e.FirstName, e.LastName)
ORDER BY UsersCount DESC, FullName
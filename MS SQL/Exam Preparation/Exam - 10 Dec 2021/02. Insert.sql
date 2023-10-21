INSERT INTO Passengers
SELECT CONCAT_WS(' ', FirstName, LastName) AS FullName, CONCAT_WS('', FirstName, LastName, '@gmail.com') AS Email  
FROM PILOTS 
WHERE Id BETWEEN 5 AND 15


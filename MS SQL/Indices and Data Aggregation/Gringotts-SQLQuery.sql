--01. Records’ Count

SELECT COUNT(*) AS Count
FROM WizzardDeposits

--02. Longest Magic Wand

SELECT MAX(MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits

--03. Longest Magic Wand per Deposit Groups

SELECT DepositGroup, MAX(MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits
GROUP BY DepositGroup

--04. Smallest Deposit Group per Magic Wand Size

SELECT TOP 2 
DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)

--05. Deposits Sum

SELECT  
DepositGroup, SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
GROUP BY DepositGroup


--06. Deposits Sum for Ollivander Family

SELECT  
DepositGroup, SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE
MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup

--07. Deposits Filter

SELECT  
DepositGroup, SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE
MagicWandCreator = 'Ollivander family' 
GROUP BY DepositGroup
HAVING SUM(DepositAmount) < 150000
ORDER BY SUM(DepositAmount) DESC

--08. Deposit Charge

SELECT DepositGroup, MagicWandCreator, MIN(DepositCharge) AS MinDepositCharge
FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator, DepositGroup

--09. Age Groups

SELECT AgeGroup, COUNT(*) AS WizardCount
FROM
(SELECT AGE,
CASE
WHEN AGE BETWEEN 0 AND 10 THEN '[0-10]'
WHEN AGE BETWEEN 11 AND 20 THEN '[11-20]'
WHEN AGE BETWEEN 21 AND 30 THEN '[21-30]'
WHEN AGE BETWEEN 31 AND 40 THEN '[31-40]'
WHEN AGE BETWEEN 41 AND 50 THEN '[41-50]'
WHEN AGE BETWEEN 51 AND 60 THEN '[51-60]'
ELSE '[61+]'
END AS AgeGroup
FROM WizzardDeposits) AS AgeGroup
GROUP BY AgeGroup

--10. First Letter
SELECT FirstLetter FROM
(SELECT SUBSTRING(FirstName, 1, 1) AS FirstLetter
FROM WizzardDeposits
WHERE 
DepositGroup = 'Troll Chest') AS SubQuery
GROUP BY FirstLetter
ORDER BY FirstLetter

--11. Average Interest


SELECT DepositGroup, IsDepositExpired, AVG(DepositInterest) AS AverageInterest 
FROM WizzardDeposits
WHERE
DepositStartDate > '1/1/1985'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired





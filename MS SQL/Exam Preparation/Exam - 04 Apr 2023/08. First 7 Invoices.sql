SELECT TOP 7 
i.Number, i.Amount, c.[Name]
FROM Invoices AS i
JOIN Clients AS c ON c.Id = i.ClientId
WHERE i.IssueDate < '2023-01-01' AND 
i.Currency = 'EUR' OR 
i.Amount > 500 AND 
c.NumberVAT LIKE 'DE%'
ORDER BY i.Number, i.Amount DESC
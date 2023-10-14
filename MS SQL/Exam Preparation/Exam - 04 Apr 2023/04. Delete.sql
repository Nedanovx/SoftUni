DELETE FROM ProductsClients
WHERE ClientId =11

DELETE FROM Invoices
WHERE ClientId = 11

DELETE FROM Clients
WHERE NumberVAT LIKE'IT%'
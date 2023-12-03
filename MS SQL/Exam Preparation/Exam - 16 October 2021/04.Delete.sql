SELECT * FROM Addresses
WHERE Addresses.Country LIKE 'C%'
--7,8,10,23

DELETE FROM Clients
WHERE Clients.AddressId IN (7,8,10,23)

DELETE FROM Addresses
WHERE Addresses.Country LIKE 'C%'
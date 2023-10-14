UPDATE Animals
SET OwnerId = (
SELECT Id FROM Owners
WHERE [Name] = 'Kaloqn Stoqnov'
)

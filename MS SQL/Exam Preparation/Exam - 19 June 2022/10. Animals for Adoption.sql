SELECT a.[Name], YEAR(a.BirthDate), [at].AnimalType
FROM Animals AS a
JOIN AnimalTypes AS [at] ON [at].Id = a.AnimalTypeId
WHERE a.BirthDate > '2018-1-1' AND [at].AnimalType <> 'Birds' AND a.OwnerId IS NULL
ORDER BY a.[Name]



--Id 5
SELECT * FROM BonusPrizes WHERE [Name] = 'Sleeping bag'

DELETE FROM TouristsBonusPrizes WHERE BonusPrizeId = 5
DELETE FROM BonusPrizes WHERE [Name] = 'Sleeping bag'
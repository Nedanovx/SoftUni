--SELECT Id FROM Tastes
--WHERE TasteType LIKE 'Spicy'

UPDATE Cigars
SET PriceForSingleCigar *= 1.2
WHERE TastId = 1

UPDATE Brands
SET BrandDescription = 'New description'
WHERE BrandDescription IS NULL

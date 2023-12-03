SELECT c.CigarName, C.PriceForSingleCigar, C.ImageURL
FROM Cigars AS c
ORDER BY c.PriceForSingleCigar, c.CigarName DESC
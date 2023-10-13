CREATE FUNCTION udf_GetTouristsCountOnATouristSite (@Site VARCHAR(100))
RETURNS INT
AS
BEGIN 
DECLARE @Result INT = 
(SELECT COUNT(*)
FROM Sites AS s
JOIN SitesTourists AS st ON st.SiteId = s.Id
WHERE @Site = s.[Name])
RETURN @Result
END


SELECT
 dbo.udf_GetTouristsCountOnATouristSite ('Regional History Museum – Vratsa')
 --OUTPUT -> 6
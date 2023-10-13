CREATE PROCEDURE usp_AnnualRewardLottery(@TouristName VARCHAR(100))
AS 
SELECT t.[Name],
CASE
WHEN COUNT(*) >= 100 THEN 'Gold badge'
WHEN COUNT(*) >= 50 THEN 'Silver badge'
WHEN COUNT(*) >= 25 THEN 'Bronze badge'
END AS Reward
FROM Tourists AS t
JOIN SitesTourists AS st ON st.TouristId = T.Id
WHERE @TouristName = t.[Name]
GROUP BY t.[Name]
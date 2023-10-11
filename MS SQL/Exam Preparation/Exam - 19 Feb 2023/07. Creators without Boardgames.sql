--07. Creators without Boardgames

SELECT c.Id, CONCAT_WS(' ', FirstName, LastName) AS CreatorName, c.Email
FROM Creators AS c
WHERE c.Id NOT IN 
	( SELECT CreatorId FROM CreatorsBoardgames)
	ORDER BY CreatorName
SELECT i.Id AS Id, CONCAT_WS(' : ', u.Username, I.Title) AS IssueAssignee FROM Issues AS i
JOIN Users AS u ON u.Id = i.AssigneeId
ORDER BY Id DESC, IssueAssignee
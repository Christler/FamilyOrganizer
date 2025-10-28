CREATE PROCEDURE dbo.spGetChoresByFamily
    @FamilyID INT
AS
BEGIN
    SELECT 
        c.ID,
        c.Name,
        c.Status,
        c.AssignedToUserID,
        u.Username AS AssignedTo
    FROM Chore c
    LEFT JOIN [User] u ON c.AssignedToUserID = u.ID
    WHERE c.FamilyID = @FamilyID
    ORDER BY c.Status, c.Name;
END

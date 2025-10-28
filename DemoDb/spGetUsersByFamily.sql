CREATE PROCEDURE dbo.spGetUsersByFamily
    @FamilyID INT
AS
BEGIN
    SELECT 
        u.ID,
        u.Username,
        u.IsParent
    FROM [User] u
    WHERE u.FamilyID = @FamilyID
    ORDER BY u.Username;
END

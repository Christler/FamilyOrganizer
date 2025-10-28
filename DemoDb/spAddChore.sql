CREATE PROCEDURE [dbo].[spAddChore]
    @FamilyID INT,
    @Name NVARCHAR(100),
    @AssignedToUserID INT = NULL
AS
BEGIN
    INSERT INTO Chore (FamilyID, [Name], AssignedToUserID)
    VALUES (@FamilyID, @Name, @AssignedToUserID);

    SELECT SCOPE_IDENTITY() AS ChoreID;
END

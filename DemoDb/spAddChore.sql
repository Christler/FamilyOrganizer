CREATE PROCEDURE [dbo].[spAddChore]
    @FamilyID INT,
    @Name NVARCHAR(100)
AS
BEGIN
    INSERT INTO Chore (FamilyID, [Name])
    VALUES (@FamilyID, @Name);

    SELECT SCOPE_IDENTITY() AS ChoreID;
END

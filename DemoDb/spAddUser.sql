CREATE PROCEDURE [dbo].[spAddUser]
    @FamilyID INT,
    @Username NVARCHAR(50),
    @IsParent BIT = 0
AS
BEGIN
    INSERT INTO [User] (FamilyID, Username, IsParent)
    VALUES (@FamilyID, @Username, @IsParent);

    SELECT SCOPE_IDENTITY() AS MemberID;
END

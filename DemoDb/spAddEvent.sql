CREATE PROCEDURE [dbo].[spAddEvent]
    @FamilyID INT,
    @Name NVARCHAR(100),
    @StartTime DATETIME,
    @EndTime DATETIME
AS
BEGIN
    INSERT INTO Event (FamilyID, [Name], StartTime, EndTime)
    VALUES (@FamilyID, @Name, @StartTime, @EndTime);

    SELECT SCOPE_IDENTITY() AS EventID;
END

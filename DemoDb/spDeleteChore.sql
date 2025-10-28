CREATE PROCEDURE [dbo].[spDeleteChore]
    @ChoreID INT
AS
BEGIN
    DELETE FROM Chore
    WHERE ID = @ChoreID;
END

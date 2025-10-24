CREATE PROCEDURE [dbo].[spAssignChoreToUser]
    @ChoreID INT,
    @UserID INT
AS
BEGIN
    UPDATE Chore
    SET AssignedToUserID = @UserID
    WHERE ID = @ChoreID;

END
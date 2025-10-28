CREATE PROCEDURE dbo.spUpdateChoreStatus
    @ChoreID INT,
    @Status NVARCHAR(20)
AS
BEGIN
    UPDATE Chore
    SET Status = @Status
    WHERE ID = @ChoreID;
END

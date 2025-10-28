CREATE PROCEDURE [dbo].[spDeleteEvent]
    @EventID INT
AS
BEGIN
    DELETE FROM [Event]
    WHERE ID = @EventID;
END

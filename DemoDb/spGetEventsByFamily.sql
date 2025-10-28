CREATE PROCEDURE [dbo].[spGetEventsByFamily]
    @FamilyID INT
AS
BEGIN
    SELECT 
        e.ID,
        e.Name,
        e.StartTime,
        e.EndTime
    FROM Event e
    WHERE e.FamilyID = @FamilyID
    ORDER BY e.StartTime;
END

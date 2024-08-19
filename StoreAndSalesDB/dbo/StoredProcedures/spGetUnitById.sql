CREATE PROCEDURE [dbo].[spGetUnitById]
	@UnitId int
AS
BEGIN
Select * From Unit 
Where Id = @UnitId
END
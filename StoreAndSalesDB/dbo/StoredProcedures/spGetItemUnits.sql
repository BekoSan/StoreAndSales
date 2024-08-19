CREATE PROCEDURE [dbo].[spGetItemUnits]
@ItemId int

AS
BEGIN

Select * from ItemUnit

Where ItemId = @ItemId

END

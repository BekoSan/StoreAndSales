CREATE PROCEDURE [dbo].[spEditItem]
@ItemId int,
@ItemName nvarchar(250),
@ReorderLevel int = 0

AS
BEGIN

Update  Item 
Set 
ItemName = @ItemName,
ReorderLevel = @ReorderLevel

Where Id = @ItemId

END

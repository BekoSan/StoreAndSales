CREATE PROCEDURE [dbo].[spEditItem]
@ItemId int,
@ItemName nvarchar(250)

AS
BEGIN

Update  Item 
Set 
ItemName = @ItemName
Where Id = @ItemId

END

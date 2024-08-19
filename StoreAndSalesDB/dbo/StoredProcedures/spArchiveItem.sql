CREATE PROCEDURE [dbo].[spArchiveItem]
@ItemId int

AS

BEGIN
Update Item Set [Status] = 0
Where Id = @ItemId
END
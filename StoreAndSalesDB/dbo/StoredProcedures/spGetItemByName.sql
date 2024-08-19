CREATE PROCEDURE [dbo].[spGetItemByName]
@ItemName nvarchar(250)

AS

BEGIN

Select * from Item Where ItemName = @ItemName 

END

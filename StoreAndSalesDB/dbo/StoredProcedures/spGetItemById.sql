CREATE PROCEDURE [dbo].[spGetItemById]
@ItemId int

AS


BEGIN

Select * from Item Where Id = @ItemId 

END
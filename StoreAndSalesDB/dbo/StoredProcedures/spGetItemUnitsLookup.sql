CREATE PROCEDURE [dbo].[spGetItemUnitsLookup]
@ItemId int

AS
BEGIN

Select iu.Id as "ItemUnitId", u.Id as "Id",UnitName,UnitPrice from Unit u inner join ItemUnit iu
on 
u.Id = iu.UnitId

Where ItemId = @ItemId

END

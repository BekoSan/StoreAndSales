CREATE PROCEDURE [dbo].[spEditItemUnitPrice]
@ItemId int,
@UnitId int,
@UnitPrice money

As
BEGIN

Update ItemUnit Set UnitPrice = @UnitPrice

Where ItemId = @ItemId and UnitId = @UnitId

END

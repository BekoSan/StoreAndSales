CREATE PROCEDURE [dbo].[spCreateItemUnit]
@Id int = 0 output,
@ItemId int,
@UnitId int,
@UnitPrice money

As
BEGIN

Insert Into ItemUnit(ItemId,UnitId,UnitPrice) Values(@ItemId,@UnitId,@UnitPrice)

Select @Id = SCOPE_IDENTITY()
END

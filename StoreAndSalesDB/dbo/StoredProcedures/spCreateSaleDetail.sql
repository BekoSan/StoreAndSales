CREATE PROCEDURE [dbo].[spCreateSaleDetail]

@Id int = 0 output,
@SaleId int,
@ItemId int,
@UnitId int,
@Quantity int,
@Price Money

AS
BEGIN

Insert into SaleDetail(SaleId,ItemId,UnitId,Quantity,Price) Values

(@SaleId,@ItemId,@UnitId,@Quantity,@Price)

Select @Id = SCOPE_IDENTITY()

END
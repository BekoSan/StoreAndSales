CREATE PROCEDURE [dbo].[spGetItemQuantity]
	@ItemId int,
	@UnitId int
AS
Declare
@PurchaseQuantity int,
@SaleQuantity int,
@Output int
BEGIN

--Get Purchase Quantity
Select @PurchaseQuantity = Sum(Quantity) from PurchaseDetail 
Where 
ItemId = @ItemId
and 
UnitId = @UnitId

Set @PurchaseQuantity = ISNULL(@PurchaseQuantity,0)

--Get Sale Quantity
Select @SaleQuantity = Sum(Quantity) from SaleDetail 
Where 
ItemId = @ItemId
and 
UnitId = @UnitId

Set @SaleQuantity = ISNULL(@SaleQuantity,0)

Set @Output = (@PurchaseQuantity - @SaleQuantity)

Select @Output as 'ItemQuantity'

END
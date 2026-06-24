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
Select @PurchaseQuantity = Sum(Quantity) from PurchaseDetail --pd
--inner join
--Purchase p 
--on p.Id = pd.PurchaseId
Where 
ItemId = @ItemId
and 
UnitId = @UnitId
--and 
--p.PurchaseDate > '2026-05-03 00:00:00.0000000'

Set @PurchaseQuantity = ISNULL(@PurchaseQuantity,0)

--Get Sale Quantity
Select @SaleQuantity = Sum(Quantity) from SaleDetail --sd
--inner join 
--Sale s
--on s.Id = sd.SaleId
Where 
ItemId = @ItemId
and 
UnitId = @UnitId
--and 
--s.SaleDate > '2026-05-03 00:00:00.0000000'

Set @SaleQuantity = ISNULL(@SaleQuantity,0)

Set @Output = (@PurchaseQuantity - @SaleQuantity)

if (@Output < 0) Set @Output = 0

Select @Output as 'ItemQuantity'

END
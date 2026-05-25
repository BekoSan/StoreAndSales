CREATE PROCEDURE [dbo].[spFilterQuantitiesAfterDate]
	@ItemId int,
	@UnitId int,
	@FilterDate datetime2(7)
AS
Declare
@PurchaseQuantity int,
@SaleQuantity int,
@Output int
BEGIN

--Get Purchase Quantity
Select @PurchaseQuantity = Sum(Quantity) from PurchaseDetail pd
inner join
Purchase p 
on p.Id = pd.PurchaseId
Where 
ItemId = @ItemId
and 
UnitId = @UnitId
and 
p.PurchaseDate > @FilterDate

Set @PurchaseQuantity = ISNULL(@PurchaseQuantity,0)

--Get Sale Quantity
Select @SaleQuantity = Sum(Quantity) from SaleDetail sd
inner join 
Sale s
on s.Id = sd.SaleId
Where 
ItemId = @ItemId
and 
UnitId = @UnitId
and 
s.SaleDate > @FilterDate

Set @SaleQuantity = ISNULL(@SaleQuantity,0)

Set @Output = (@PurchaseQuantity - @SaleQuantity)

Select @Output as 'ItemQuantity'

END
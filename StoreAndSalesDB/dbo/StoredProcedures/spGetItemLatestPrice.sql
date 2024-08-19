CREATE PROCEDURE [dbo].[spGetItemLatestPrice]
	@ItemId int,
	@UnitId int
AS
Declare
@LatestPurchasePrice money,
@LatestDate datetime2
BEGIN

Select @LatestDate = MAX(PurchaseDate) from 
Purchase p
inner join
PurchaseDetail pd
on
p.Id = pd.PurchaseId
Where
pd.ItemId = @ItemId

Select @LatestPurchasePrice = Price from
Purchase p 
inner join 
PurchaseDetail pd
on
p.Id = pd.PurchaseId 

Where 
ItemId = @ItemId
and 
UnitId = @UnitId
and 
p.PurchaseDate = @LatestDate

Set @LatestPurchasePrice = ISNULL(@LatestPurchasePrice,0)

Select @LatestPurchasePrice as 'ItemPrice'

END


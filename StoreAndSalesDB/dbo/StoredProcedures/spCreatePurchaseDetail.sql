CREATE PROCEDURE [dbo].[spCreatePurchaseDetail]
@Id int = 0 output,
@PurchaseId int,
@ItemId int,
@UnitId int,
@Quantity int,
@Price Money

AS

BEGIN

Insert into PurchaseDetail(PurchaseId,ItemId,UnitId,Quantity,Price) Values

(@PurchaseId,@ItemId,@UnitId,@Quantity,@Price)

Select @Id = SCOPE_IDENTITY()

END

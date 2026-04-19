CREATE PROCEDURE [dbo].[spEditPurchaseDisscount]
@PurchaseId int,
@Disscount money
AS
BEGIN
Update Purchase Set Disscount = @Disscount Where Id = @PurchaseId 
END

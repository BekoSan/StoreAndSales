CREATE PROCEDURE [dbo].[spEditPurchaseStatus]
    @PurchaseId int,
	@Status bit
AS
BEGIN
Update Purchase Set [Status] = @Status  Where Id = @PurchaseId
END
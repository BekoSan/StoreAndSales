CREATE PROCEDURE [dbo].[spGetAllPurchaseDetails]
@PurchaseId int

AS
BEGIN

Select * from PurchaseDetail Where PurchaseId = @PurchaseId

END

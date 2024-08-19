CREATE PROCEDURE [dbo].[spGetLastPurchaseId]

AS
Declare @PurchaseId int
BEGIN
Select @PurchaseId =  MAX(Id)  from Purchase

Set @PurchaseId = ISNULL(@PurchaseId,0)
 
Select @PurchaseId as 'PurchaseId'
END
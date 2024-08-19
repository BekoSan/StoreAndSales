CREATE PROCEDURE [dbo].[spGetPurchaseById]
@PurchaseId int
AS
BEGIN
Select * from Purchase Where Id = @PurchaseId
END

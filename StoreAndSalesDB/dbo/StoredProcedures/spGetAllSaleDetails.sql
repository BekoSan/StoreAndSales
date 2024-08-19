CREATE PROCEDURE [dbo].[spGetAllSaleDetails]
@SaleId int

AS
BEGIN
Select * from SaleDetail Where SaleId = @SaleId
END

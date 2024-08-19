CREATE PROCEDURE [dbo].[spGetLastSaleId]

AS
Declare @SaleId int
BEGIN
Select @SaleId =  MAX(Id)  from Sale

Set @SaleId = ISNULL(@SaleId,0)
 
Select @SaleId as 'SaleId'
END

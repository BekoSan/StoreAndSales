CREATE PROCEDURE [dbo].[spGetSaleById]
@SaleId int
AS
BEGIN

Select * From Sale Where Id = @SaleId
END
CREATE PROCEDURE [dbo].[spGetSalesByDate]
@DateFrom date,
@DateTo date

AS
BEGIN
Select * from Sale Where SaleDate between @DateFrom and @DateTo
END

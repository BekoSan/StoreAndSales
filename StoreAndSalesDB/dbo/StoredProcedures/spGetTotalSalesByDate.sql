CREATE PROCEDURE [dbo].[spGetTotalSalesByDate]
@DateFrom date,
@DateTo date
AS
BEGIN
Select Sum(Total) from Sale Where SaleDate between @DateFrom and @DateTo
END

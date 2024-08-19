CREATE PROCEDURE [dbo].[spGetTotalPurchasesByDate]
@DateFrom date,
@DateTo date

AS
BEGIN
Select Sum(Total) From Purchase Where PurchaseDate between @DateFrom and @DateTo
END

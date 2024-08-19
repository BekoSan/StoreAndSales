CREATE PROCEDURE [dbo].[spGetPurchasesByDate]

@DateFrom date,
@DateTo date

AS
BEGIN
Select * From Purchase Where PurchaseDate between @DateFrom and @DateTo
END

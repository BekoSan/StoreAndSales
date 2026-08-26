CREATE PROCEDURE [dbo].[spGetAllItemQuantitiesByStore]
    @StoreId INT = 0
AS
BEGIN
    DECLARE @ResolvedStoreId INT = ISNULL(NULLIF(@StoreId, 0), (SELECT TOP (1) Id FROM dbo.Store WHERE Status = 1 ORDER BY IsDefault DESC, Id));
    ;WITH Purchases AS (SELECT pd.ItemId, pd.UnitId, SUM(pd.Quantity) Quantity FROM dbo.PurchaseDetail pd INNER JOIN dbo.Purchase p ON p.Id = pd.PurchaseId WHERE p.StoreId = @ResolvedStoreId GROUP BY pd.ItemId, pd.UnitId),
    Sales AS (SELECT sd.ItemId, sd.UnitId, SUM(sd.Quantity) Quantity FROM dbo.SaleDetail sd INNER JOIN dbo.Sale s ON s.Id = sd.SaleId WHERE s.StoreId = @ResolvedStoreId GROUP BY sd.ItemId, sd.UnitId)
    SELECT iu.ItemId, iu.UnitId,
        CASE WHEN ISNULL(Purchases.Quantity, 0) - ISNULL(Sales.Quantity, 0) < 0 THEN 0 ELSE ISNULL(Purchases.Quantity, 0) - ISNULL(Sales.Quantity, 0) END AS ItemQuantity,
        CAST(0 AS MONEY) AS ItemPrice
    FROM dbo.ItemUnit iu LEFT JOIN Purchases ON Purchases.ItemId = iu.ItemId AND Purchases.UnitId = iu.UnitId
    LEFT JOIN Sales ON Sales.ItemId = iu.ItemId AND Sales.UnitId = iu.UnitId;
END

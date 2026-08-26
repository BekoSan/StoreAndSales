CREATE PROCEDURE [dbo].[spFilterQuantitiesAfterDateByStore]
    @ItemId INT, @UnitId INT, @FilterDate DATETIME2, @StoreId INT = 0
AS
BEGIN
    DECLARE @ResolvedStoreId INT = ISNULL(NULLIF(@StoreId, 0), (SELECT TOP (1) Id FROM dbo.Store WHERE Status = 1 ORDER BY IsDefault DESC, Id));
    DECLARE @Purchases INT = (SELECT ISNULL(SUM(pd.Quantity), 0) FROM dbo.PurchaseDetail pd INNER JOIN dbo.Purchase p ON p.Id = pd.PurchaseId WHERE pd.ItemId = @ItemId AND pd.UnitId = @UnitId AND p.StoreId = @ResolvedStoreId AND p.PurchaseDate >= @FilterDate);
    DECLARE @Sales INT = (SELECT ISNULL(SUM(sd.Quantity), 0) FROM dbo.SaleDetail sd INNER JOIN dbo.Sale s ON s.Id = sd.SaleId WHERE sd.ItemId = @ItemId AND sd.UnitId = @UnitId AND s.StoreId = @ResolvedStoreId AND s.SaleDate >= @FilterDate);
    SELECT CASE WHEN @Purchases - @Sales < 0 THEN 0 ELSE @Purchases - @Sales END AS ItemQuantity;
END

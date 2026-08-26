CREATE PROCEDURE [dbo].[spGetItemLatestPrice]
    @ItemId INT,
    @UnitId INT,
    @StoreId INT = 0
AS
BEGIN
    DECLARE @ResolvedStoreId INT = ISNULL(NULLIF(@StoreId, 0),
        (SELECT TOP (1) Id FROM dbo.Store WHERE Status = 1 ORDER BY IsDefault DESC, Id));
    SELECT ISNULL((
        SELECT TOP (1) pd.Price FROM dbo.PurchaseDetail pd
        INNER JOIN dbo.Purchase p ON p.Id = pd.PurchaseId
        WHERE pd.ItemId = @ItemId AND pd.UnitId = @UnitId AND p.StoreId = @ResolvedStoreId
        ORDER BY p.PurchaseDate DESC, p.Id DESC, pd.Id DESC), 0) AS ItemPrice;
END

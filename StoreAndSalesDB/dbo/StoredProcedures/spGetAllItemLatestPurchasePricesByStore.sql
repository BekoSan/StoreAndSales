CREATE PROCEDURE [dbo].[spGetAllItemLatestPurchasePricesByStore]
    @StoreId INT = 0
AS
BEGIN
    DECLARE @ResolvedStoreId INT = ISNULL(NULLIF(@StoreId, 0),
        (SELECT TOP (1) Id FROM dbo.Store WHERE Status = 1 ORDER BY IsDefault DESC, Id));

    ;WITH LatestPrices AS
    (
        SELECT pd.ItemId, pd.UnitId, pd.Price AS ItemPrice,
            ROW_NUMBER() OVER (PARTITION BY pd.ItemId, pd.UnitId ORDER BY p.PurchaseDate DESC, p.Id DESC, pd.Id DESC) AS RowNumber
        FROM dbo.PurchaseDetail pd
        INNER JOIN dbo.Purchase p ON p.Id = pd.PurchaseId
        WHERE p.StoreId = @ResolvedStoreId
    )
    SELECT ItemId, UnitId, CAST(0 AS INT) AS ItemQuantity, ItemPrice
    FROM LatestPrices
    WHERE RowNumber = 1;
END

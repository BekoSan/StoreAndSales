CREATE PROCEDURE [dbo].[spGetAllItemLatestPurchasePrices]
AS
BEGIN
    SET NOCOUNT ON;

    WITH LatestItemPurchaseDate AS
    (
        SELECT pd.ItemId, MAX(p.PurchaseDate) AS LatestPurchaseDate
        FROM Purchase p
        INNER JOIN PurchaseDetail pd ON pd.PurchaseId = p.Id
        GROUP BY pd.ItemId
    )
    SELECT
        iu.ItemId,
        iu.UnitId,
        CAST(0 AS int) AS ItemQuantity,
        CAST(ISNULL(MAX(CASE WHEN p.Id IS NOT NULL THEN pd.Price END), 0) AS money) AS ItemPrice
    FROM ItemUnit iu
    LEFT JOIN LatestItemPurchaseDate latest ON latest.ItemId = iu.ItemId
    LEFT JOIN PurchaseDetail pd ON pd.ItemId = iu.ItemId AND pd.UnitId = iu.UnitId
    LEFT JOIN Purchase p ON p.Id = pd.PurchaseId AND p.PurchaseDate = latest.LatestPurchaseDate
    GROUP BY iu.ItemId, iu.UnitId;
END

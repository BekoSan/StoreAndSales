CREATE PROCEDURE [dbo].[spGetAllItemQuantitiesAfterDate]
    @FilterDate datetime2(7)
AS
BEGIN
    SET NOCOUNT ON;

    WITH PurchaseTotals AS
    (
        SELECT pd.ItemId, pd.UnitId, SUM(pd.Quantity) AS PurchaseQuantity
        FROM PurchaseDetail pd
        INNER JOIN Purchase p ON p.Id = pd.PurchaseId
        WHERE p.PurchaseDate > @FilterDate
        GROUP BY pd.ItemId, pd.UnitId
    ),
    SaleTotals AS
    (
        SELECT sd.ItemId, sd.UnitId, SUM(sd.Quantity) AS SaleQuantity
        FROM SaleDetail sd
        INNER JOIN Sale s ON s.Id = sd.SaleId
        WHERE s.SaleDate > @FilterDate
        GROUP BY sd.ItemId, sd.UnitId
    )
    SELECT
        iu.ItemId,
        iu.UnitId,
        CASE
            WHEN ISNULL(pt.PurchaseQuantity, 0) - ISNULL(st.SaleQuantity, 0) < 0 THEN 0
            ELSE ISNULL(pt.PurchaseQuantity, 0) - ISNULL(st.SaleQuantity, 0)
        END AS ItemQuantity,
        CAST(0 AS money) AS ItemPrice
    FROM ItemUnit iu
    LEFT JOIN PurchaseTotals pt ON pt.ItemId = iu.ItemId AND pt.UnitId = iu.UnitId
    LEFT JOIN SaleTotals st ON st.ItemId = iu.ItemId AND st.UnitId = iu.UnitId;
END

CREATE PROCEDURE [dbo].[spGetAllItemQuantities]
AS
BEGIN
    SET NOCOUNT ON;

    WITH PurchaseTotals AS
    (
        SELECT ItemId, UnitId, SUM(Quantity) AS PurchaseQuantity
        FROM PurchaseDetail
        GROUP BY ItemId, UnitId
    ),
    SaleTotals AS
    (
        SELECT ItemId, UnitId, SUM(Quantity) AS SaleQuantity
        FROM SaleDetail
        GROUP BY ItemId, UnitId
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

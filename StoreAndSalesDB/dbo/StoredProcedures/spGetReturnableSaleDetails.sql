CREATE PROCEDURE spGetReturnableSaleDetails
    @SaleId INT
AS
BEGIN
    SELECT
        sd.ItemId,
        i.ItemName  AS ItemName,
        sd.Price,
        sd.Quantity AS OriginalQuantity,
        ISNULL(ret.ReturnedQty, 0) AS AlreadyReturned,
        sd.Quantity - ISNULL(ret.ReturnedQty, 0)  AS RemainingQuantity,
        sd.UnitId AS UnitId
    FROM dbo.SaleDetail sd
    INNER JOIN dbo.Item i ON i.Id = sd.ItemId
    OUTER APPLY (
        -- المرتجعات مخزّنة بكمية سالبة، نقلبها هنا لرقم موجب للمقارنة
        SELECT SUM(-rsd.Quantity) AS ReturnedQty
        FROM dbo.SaleDetail rsd
        INNER JOIN dbo.Sale r ON r.Id = rsd.SaleId
        WHERE r.OriginalSaleId = sd.SaleId
          AND r.IsReturn = 1
          AND rsd.ItemId = sd.ItemId
    ) ret
    WHERE sd.SaleId = @SaleId;
END
GO


-- ============================================================
-- ملاحظة حول التقارير:
-- أي استعلام يحسب SUM(Total) أو SUM(SaleDetail.Quantity) سيطرح
-- المرتجعات تلقائياً لأنها مخزّنة بقيم سالبة - لا تحتاج تعديل.
--
-- أما لو عندك تقرير يحسب "عدد الفواتير" أو "متوسط قيمة الفاتورة"،
-- لازم تضيف فلتر WHERE IsReturn = 0 حتى ما تتداخل فواتير المرتجع
-- مع فواتير البيع الحقيقية في العدّ.
-- ============================================================

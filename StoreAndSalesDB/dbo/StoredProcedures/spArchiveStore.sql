CREATE PROCEDURE [dbo].[spArchiveStore]
    @StoreId INT
AS
BEGIN
    SET NOCOUNT ON;
    IF (SELECT COUNT(*) FROM dbo.Store WHERE Status = 1) <= 1
    BEGIN
        RAISERROR(N'لا يمكن إيقاف المخزن الوحيد في النظام.', 16, 1);
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM dbo.Store WHERE Id = @StoreId AND IsDefault = 1 AND Status = 1)
    BEGIN
        RAISERROR(N'اختر مخزناً افتراضياً آخر قبل إيقاف المخزن الحالي.', 16, 1);
        RETURN;
    END

    UPDATE dbo.Store SET Status = 0 WHERE Id = @StoreId;
END

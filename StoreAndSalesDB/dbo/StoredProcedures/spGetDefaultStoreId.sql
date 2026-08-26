CREATE PROCEDURE [dbo].[spGetDefaultStoreId]
AS
BEGIN
    SELECT TOP (1) Id
    FROM dbo.Store
    WHERE Status = 1
    ORDER BY IsDefault DESC, Id ASC;
END

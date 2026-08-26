CREATE PROCEDURE [dbo].[spGetAllStores]
AS
BEGIN
    SELECT Id, StoreName, StoreAddress, IsDefault, Status
    FROM dbo.Store
    WHERE Status = 1
    ORDER BY IsDefault DESC, StoreName ASC;
END

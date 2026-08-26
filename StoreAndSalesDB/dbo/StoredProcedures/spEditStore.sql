CREATE PROCEDURE [dbo].[spEditStore]
    @StoreId INT,
    @StoreName NVARCHAR(150),
    @StoreAddress NVARCHAR(400) = NULL,
    @IsDefault BIT = 0
AS
BEGIN
    SET NOCOUNT ON;
    IF @IsDefault = 1
    BEGIN
        UPDATE dbo.Store SET IsDefault = 0 WHERE Status = 1 AND Id <> @StoreId;
    END

    UPDATE dbo.Store
    SET StoreName = @StoreName,
        StoreAddress = @StoreAddress,
        IsDefault = @IsDefault
    WHERE Id = @StoreId AND Status = 1;
END

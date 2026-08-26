CREATE PROCEDURE [dbo].[spCreateStore]
    @Id INT = 0 OUTPUT,
    @StoreName NVARCHAR(150),
    @StoreAddress NVARCHAR(400) = NULL,
    @IsDefault BIT = 0
AS
BEGIN
    SET NOCOUNT ON;
    IF @IsDefault = 1 OR NOT EXISTS (SELECT 1 FROM dbo.Store WHERE Status = 1)
    BEGIN
        UPDATE dbo.Store SET IsDefault = 0 WHERE Status = 1;
        SET @IsDefault = 1;
    END

    INSERT INTO dbo.Store (StoreName, StoreAddress, IsDefault, Status)
    VALUES (@StoreName, @StoreAddress, @IsDefault, 1);
    SET @Id = SCOPE_IDENTITY();
END

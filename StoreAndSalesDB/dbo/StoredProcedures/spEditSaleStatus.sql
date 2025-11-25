CREATE PROCEDURE [dbo].[spEditSaleStatus]
    @SaleId int,
	@Status bit
AS
BEGIN
Update Sale Set [Status] = @Status  Where Id = @SaleId
END

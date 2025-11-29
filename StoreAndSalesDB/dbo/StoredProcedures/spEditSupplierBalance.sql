CREATE PROCEDURE [dbo].[spEditSupplierBalance]
	@SupplierId int,
	@NewBalance money
AS
BEGIN
Update Supplier Set Balance = @NewBalance Where Id = @SupplierId
END
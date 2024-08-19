CREATE PROCEDURE [dbo].[spEditSupplier]

@SupplierId int,
@SupplierName nvarchar(250),
@Address nvarchar(150),
@Phone nvarchar(13)

AS
BEGIN

Update  Supplier Set 
SupplierName  = @SupplierName,
[Address] = @Address,
Phone = @Phone

Where Id = @SupplierId

END
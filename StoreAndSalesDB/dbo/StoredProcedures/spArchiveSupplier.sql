CREATE PROCEDURE [dbo].[spArchiveSupplier]
@SupplierId int

As 
BEGIN

Update Supplier Set [Status] = 0 Where Id = @SupplierId

END
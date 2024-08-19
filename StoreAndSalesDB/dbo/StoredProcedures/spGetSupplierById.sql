CREATE PROCEDURE [dbo].[spGetSupplierById]
@SupplierId int

AS
BEGIN

Select * from Supplier Where Id = @SupplierId

END
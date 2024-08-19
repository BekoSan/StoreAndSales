CREATE PROCEDURE [dbo].[spGetSupplierByName]
@SupplierName nvarchar(250)

AS
BEGIN

Select * from Supplier Where SupplierName Like N'%'+ @SupplierName + '%'

END
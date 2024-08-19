CREATE PROCEDURE [dbo].[spGetAllSuppliers]
AS
BEGIN
Select * from Supplier 
Where [Status] = 1
END

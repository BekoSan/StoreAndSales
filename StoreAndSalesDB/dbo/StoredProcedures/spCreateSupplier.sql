CREATE PROCEDURE [dbo].[spCreateSupplier]
@Id int = 0 output,
@SupplierName nvarchar(250),
@Address nvarchar(150),
@Phone nvarchar(13)

AS
BEGIN

Insert Into Supplier(SupplierName,[Address],Phone) Values(@SupplierName,@Address,@Phone)

Select @Id = SCOPE_IDENTITY()

END

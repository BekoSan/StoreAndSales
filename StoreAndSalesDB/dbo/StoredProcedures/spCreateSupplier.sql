CREATE PROCEDURE [dbo].[spCreateSupplier]
@Id int = 0 output,
@SupplierName nvarchar(250),
@Address nvarchar(150),
@Phone nvarchar(13),
@Balance money

AS
BEGIN

Insert Into Supplier(SupplierName,[Address],Phone,Balance) Values(@SupplierName,@Address,@Phone,@Balance)

Select @Id = SCOPE_IDENTITY()

END

CREATE PROCEDURE [dbo].[spCreateCustomer]

@Id int = 0 output,
@CustomerName nvarchar(250),
@Address nvarchar(150),
@Phone nvarchar(13)

AS
BEGIN

Insert Into Customer(CustomerName,[Address],Phone) Values(@CustomerName,@Address,@Phone)

Select @Id = SCOPE_IDENTITY()

END

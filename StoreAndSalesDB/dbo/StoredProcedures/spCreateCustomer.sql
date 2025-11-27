CREATE PROCEDURE [dbo].[spCreateCustomer]

@Id int = 0 output,
@CustomerName nvarchar(250),
@Address nvarchar(150),
@Phone nvarchar(13),
@Balance money

AS
BEGIN

Insert Into Customer(CustomerName,[Address],Phone,Balance) Values(@CustomerName,@Address,@Phone,@Balance)

Select @Id = SCOPE_IDENTITY()

END

CREATE PROCEDURE [dbo].[spEditCustomer]

@CustomerId int,
@CustomerName nvarchar(250),
@Address nvarchar(150),
@Phone nvarchar(13),
@CreditLimit money

AS
BEGIN

Update  Customer Set 
CustomerName  = @CustomerName,
[Address] = @Address,
Phone = @Phone,
CreditLimit = @CreditLimit

Where Id = @CustomerId

END

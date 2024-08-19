CREATE PROCEDURE [dbo].[spEditCustomer]

@CustomerId int,
@CustomerName nvarchar(250),
@Address nvarchar(150),
@Phone nvarchar(13)

AS
BEGIN

Update  Customer Set 
CustomerName  = @CustomerName,
[Address] = @Address,
Phone = @Phone

Where Id = @CustomerId

END

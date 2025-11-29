CREATE PROCEDURE [dbo].[spEditCustomerBalance]
	@CustomerId int,
	@NewBalance money
AS
BEGIN
Update Customer Set Balance = @NewBalance Where Id = @CustomerId
END

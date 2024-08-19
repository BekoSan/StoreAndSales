CREATE PROCEDURE [dbo].[spArchiveCustomer]

@CustomerId int

As 
BEGIN

Update Customer Set [Status] = 0 Where Id = @CustomerId

END
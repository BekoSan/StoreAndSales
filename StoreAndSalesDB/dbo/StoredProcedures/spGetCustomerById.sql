CREATE PROCEDURE [dbo].[spGetCustomerById]
@CustomerId int

AS
BEGIN

Select * from Customer Where Id = @CustomerId

END
CREATE PROCEDURE [dbo].[spGetAllCustomers]

AS

BEGIN

Select * from Customer
Where [Status] = 1
END

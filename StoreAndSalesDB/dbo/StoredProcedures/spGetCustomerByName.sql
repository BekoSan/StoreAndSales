CREATE PROCEDURE [dbo].[spGetCustomerByName]
@CustomerName nvarchar(250)

AS
BEGIN

Select * from Customer Where CustomerName Like N'%'+ @CustomerName + '%'

END
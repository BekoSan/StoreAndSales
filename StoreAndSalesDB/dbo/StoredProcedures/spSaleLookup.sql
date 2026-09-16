CREATE PROCEDURE [dbo].[spSaleLookup]
@DateFrom date,
@DateTo date

AS
BEGIN
Select s.Id as 'SaleId', c.CustomerName as 'CustomerName',s.SaleDate as 'SaleDate', s.Total as 'Total' ,s.Disscount as 'Disscount',u.UserName as 'UserName',s.IsReturn as 'IsReturn',PaymentType
from Sale s inner join Customer c on
s.CustomerId = c.Id
inner join Users u
on s.UserId = u.Id
Where s.SaleDate between @DateFrom and @DateTo

END

CREATE PROCEDURE [dbo].[spSaleLookup]
@DateFrom date,
@DateTo date

AS
BEGIN
Select s.Id as 'SaleId', c.CustomerName as 'CustomerName',s.SaleDate as 'SaleDate', s.Total as 'Total' ,s.Disscount as 'Disscount'
from Sale s inner join Customer c on
s.CustomerId = c.Id
Where s.SaleDate between @DateFrom and @DateTo

END

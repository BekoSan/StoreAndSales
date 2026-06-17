CREATE PROCEDURE [dbo].[spPurchaseLookup]
@DateFrom date,
@DateTo date

AS
BEGIN
Select p.Id as 'PurchaseId', s.SupplierName as 'SupplierName',p.PurchaseDate as 'PurchaseDate', p.Total as 'Total' ,p.Disscount as 'Disscount' ,u.UserName as 'UserName'
from Purchase p inner join Supplier s on
p.SupplierId = s.Id
inner join Users u on
p.UserId = u.Id
Where p.PurchaseDate between @DateFrom  and @DateTo  

END

CREATE PROCEDURE [dbo].[spGetTotalSaleVoucher]
	@SaleId int,
	@CustomerId int,
	@VoucherType nvarchar(1)
AS
BEGIN

Select Sum(Amount) as 'Total' from Voucher Where
SaleId = @SaleId 
and
CustomerId = @CustomerId
and 
VoucherType = @VoucherType

END

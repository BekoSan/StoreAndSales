CREATE PROCEDURE [dbo].[spGetTotalSaleVoucher]
	@SaleId int,
	@CustomerId int,
	@VoucherType nvarchar(1),
	@Total money = 0 output
AS
BEGIN

Select @Total = (Select Sum(Amount) from Voucher Where
SaleId = @SaleId 
and
CustomerId = @CustomerId
and 
VoucherType = @VoucherType)

END

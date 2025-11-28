CREATE PROCEDURE [dbo].[spGetTotalSaleVoucher]
	@SaleId int,
	@CustomerId int,
	@VoucherType nvarchar(1)
AS
Declare
@Total money
BEGIN

Select @Total = Sum(Amount) from Voucher Where
SaleId = @SaleId 
and
CustomerId = @CustomerId
and 
VoucherType = @VoucherType

Set @Total = ISNULL(@Total,0)

Select @Total as 'Total'

END

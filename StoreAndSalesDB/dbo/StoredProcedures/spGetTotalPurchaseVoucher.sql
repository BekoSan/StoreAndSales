CREATE PROCEDURE [dbo].[spGetTotalPurchaseVoucher]
	@PurchaseId int,
	@SupplierId int,
	@VoucherType nvarchar(1)
AS
Declare
@Total money
BEGIN

Select @Total =  Sum(Amount) from Voucher Where
PurchaseId = @PurchaseId 
and
SupplierId = @SupplierId
and 
VoucherType = @VoucherType

Set @Total = ISNULL(@Total,0)

Select @Total as 'Total'

END
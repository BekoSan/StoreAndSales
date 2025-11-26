CREATE PROCEDURE [dbo].[spGetTotalPurchaseVoucher]
	@PurchaseId int,
	@SupplierId int,
	@VoucherType nvarchar(1),
	@Total money = 0 output
AS
BEGIN

Select @Total = (Select Sum(Amount) from Voucher Where
PurchaseId = @PurchaseId 
and
SupplierId = @SupplierId
and 
VoucherType = @VoucherType)

END
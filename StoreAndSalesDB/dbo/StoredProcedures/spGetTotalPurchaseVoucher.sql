CREATE PROCEDURE [dbo].[spGetTotalPurchaseVoucher]
	@PurchaseId int,
	@SupplierId int,
	@VoucherType nvarchar(1)
AS
BEGIN

Select Sum(Amount) as 'Total' from Voucher Where
PurchaseId = @PurchaseId 
and
SupplierId = @SupplierId
and 
VoucherType = @VoucherType

END
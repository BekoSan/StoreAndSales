CREATE PROCEDURE [dbo].[spCreatePurchaseVoucher]
	@Id int = 0 output,
	@VoucherType NVARCHAR(1), 
    @Amount MONEY, 
    --@PurchaseId INT,  
    @SupplierId INT, 
    @Notes NVARCHAR(2000)
AS
BEGIN
--Insert into Voucher(VoucherType,Amount,PurchaseId,SupplierId,Notes) 
--values (@VoucherType,@Amount,@PurchaseId,@SupplierId,@Notes) 

Insert into Voucher(VoucherType,Amount,SupplierId,Notes) 
values (@VoucherType,@Amount,@SupplierId,@Notes) 

Select @Id = SCOPE_IDENTITY()
END

CREATE PROCEDURE [dbo].[spCreateSaleVoucher]
	@Id int = 0 output,
	@VoucherType NVARCHAR(1), 
    @Amount MONEY, 
    @SaleId INT,  
    @CustomerId INT, 
    @Notes NVARCHAR(2000)
AS
BEGIN
Insert into Voucher(VoucherType,Amount,SaleId,CustomerId,Notes) 
values (@VoucherType,@Amount,@SaleId,@CustomerId,@Notes) 

Select @Id = SCOPE_IDENTITY()
END
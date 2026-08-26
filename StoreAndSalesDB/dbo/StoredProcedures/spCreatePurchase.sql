CREATE PROCEDURE [dbo].[spCreatePurchase]

@Id int = 0 output,
@SupplierId int,
@StoreId int,
@Total Money,
@Disscount Money,
@Notes nvarchar(2000),
@PaymentType bit,
@IsDisscount bit,
@Status bit,
@UserId int

AS
BEGIN
Insert Into Purchase(SupplierId,StoreId,Total,Disscount,Notes,PaymentType,IsDisscount,[Status],UserId)
Values
(@SupplierId,@StoreId,@Total,@Disscount,@Notes,@PaymentType,@IsDisscount,@Status,@UserId)

Select @Id = SCOPE_IDENTITY()
END

CREATE PROCEDURE [dbo].[spCreatePurchase]

@Id int = 0 output,
@SupplierId int,
@Total Money,
@Disscount Money,
@Notes nvarchar(2000),
@PaymentType bit,
@IsDisscount bit,
@Status bit

AS
BEGIN
Insert Into Purchase(SupplierId,Total,Disscount,Notes,PaymentType,IsDisscount,[Status])
Values
(@SupplierId,@Total,@Disscount,@Notes,@PaymentType,@IsDisscount,@Status)

Select @Id = SCOPE_IDENTITY()
END

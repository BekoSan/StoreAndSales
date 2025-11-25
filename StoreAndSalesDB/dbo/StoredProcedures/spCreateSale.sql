CREATE PROCEDURE [dbo].[spCreateSale]
@Id int = 0 output,
@CustomerId int,
@Total Money,
@Disscount Money,
@Notes nvarchar(2000),
@PaymentType bit,
@IsDisscount bit

AS
BEGIN

Insert Into Sale(CustomerId,Total,Disscount,Notes,PaymentType,IsDisscount) Values(@CustomerId,@Total,@Disscount,@Notes,@PaymentType,@IsDisscount)

Select @Id = SCOPE_IDENTITY()
END
CREATE PROCEDURE [dbo].[spCreateSale]
@Id int = 0 output,
@CustomerId int,
@Total Money,
@Disscount Money,
@Notes nvarchar(2000),
@PaymentType bit,
@IsDisscount bit,
@Status bit

AS
BEGIN

Insert Into Sale(CustomerId,Total,Disscount,Notes,PaymentType,IsDisscount,[Status]) Values(@CustomerId,@Total,@Disscount,@Notes,
@PaymentType,@IsDisscount,@Status)

Select @Id = SCOPE_IDENTITY()
END
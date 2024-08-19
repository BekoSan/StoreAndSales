CREATE PROCEDURE [dbo].[spCreateSale]
@Id int = 0 output,
@CustomerId int,
@Total Money,
@Disscount Money,
@Notes nvarchar(2000)

AS
BEGIN

Insert Into Sale(CustomerId,Total,Disscount,Notes) Values(@CustomerId,@Total,@Disscount,@Notes)

Select @Id = SCOPE_IDENTITY()
END
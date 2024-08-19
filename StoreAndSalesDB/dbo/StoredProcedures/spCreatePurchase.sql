CREATE PROCEDURE [dbo].[spCreatePurchase]

@Id int = 0 output,
@SupplierId int,
@Total Money,
@Disscount Money,
@Notes nvarchar(2000)

AS
BEGIN
Insert Into Purchase(SupplierId,Total,Disscount,Notes)
Values
(@SupplierId,@Total,@Disscount,@Notes)

Select @Id = SCOPE_IDENTITY()
END

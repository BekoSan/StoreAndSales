CREATE PROCEDURE [dbo].[spEditSaleDisscount]
@SaleId int,
@Disscount money
AS
BEGIN
Update Sale Set Disscount = @Disscount Where Id = @SaleId 
END


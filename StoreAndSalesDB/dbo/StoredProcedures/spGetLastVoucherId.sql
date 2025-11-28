CREATE PROCEDURE [dbo].[spGetLastVoucherId]
AS
Declare @VoucherId int
BEGIN
Select @VoucherId =  MAX(Id)  from Voucher

Set @VoucherId = ISNULL(@VoucherId,0)
 
Select @VoucherId as 'VoucherId'
END
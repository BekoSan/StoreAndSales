CREATE PROCEDURE [dbo].[sp_Login]
@UserName nvarchar(50),
@Password nvarchar(8)
AS
BEGIN

Select * From 
Users Where UserName = @UserName and [Password] = @Password

END
GO
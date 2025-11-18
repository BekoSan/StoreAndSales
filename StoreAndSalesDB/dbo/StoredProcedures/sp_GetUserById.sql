CREATE PROCEDURE [dbo].[sp_GetUserById]
	@UserId int
AS
BEGIN

Select * From Users Where Id = @UserId

END
GO
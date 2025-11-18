CREATE PROCEDURE [dbo].[sp_RemoveUser] 
@UserId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
Delete  From Users Where Id = @UserId
END
GO
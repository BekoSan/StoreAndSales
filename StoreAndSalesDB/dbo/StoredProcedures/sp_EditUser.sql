CREATE PROCEDURE [dbo].[sp_EditUser] 
     @UserId int,
     @UserName nvarchar(50),
     @Password nvarchar(8),
     @RoleId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
Update Users  Set

     UserName = @UserName,
     [Password] = @Password,
     RoleId = @RoleId

	 Where Id = @UserId
END
GO
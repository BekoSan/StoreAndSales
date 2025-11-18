CREATE PROCEDURE [dbo].[sp_CreateUser] 
     @Id int = 0 output ,
     @UserName nvarchar(50),
     @Password nvarchar(8),
     @RoleId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
Insert Into Users 
(
     UserName,
     [Password],
     RoleId) 
	 Values (
     @UserName,
     @Password,
     @RoleId)

	 Select @Id = SCOPE_IDENTITY()
END
GO
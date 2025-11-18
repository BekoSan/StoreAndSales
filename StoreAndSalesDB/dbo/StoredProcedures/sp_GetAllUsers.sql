CREATE PROCEDURE [dbo].[sp_GetAllUsers] 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
Select * From Users
END
GO
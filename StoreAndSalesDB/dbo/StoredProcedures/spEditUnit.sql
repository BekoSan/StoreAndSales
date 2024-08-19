CREATE PROCEDURE [dbo].[spEditUnit]
@UnitId int,
@UnitName nvarchar(250)

As
BEGIN
Update Unit Set UnitName = @UnitName
Where Id = @UnitId
END

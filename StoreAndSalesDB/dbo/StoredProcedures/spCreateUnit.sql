CREATE PROCEDURE [dbo].[spCreateUnit]
@Id int = 0 output,
@UnitName nvarchar(250)

As
BEGIN
Insert into Unit(UnitName) Values(@UnitName) 
END

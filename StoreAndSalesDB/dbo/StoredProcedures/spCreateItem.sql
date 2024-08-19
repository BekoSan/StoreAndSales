CREATE PROCEDURE [dbo].[spCreateItem]
@Id int = 0 output,
@ItemName nvarchar(250)

AS
BEGIN

Insert Into Item(ItemName) Values(@ItemName)

Select @Id = SCOPE_IDENTITY()

END

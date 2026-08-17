CREATE PROCEDURE [dbo].[spCreateItem]
@Id int = 0 output,
@ItemName nvarchar(250),
@ReorderLevel int = 0

AS
BEGIN

Insert Into Item(ItemName, ReorderLevel) Values(@ItemName, @ReorderLevel)

Select @Id = SCOPE_IDENTITY()

END

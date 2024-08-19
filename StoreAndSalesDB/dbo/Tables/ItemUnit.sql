CREATE TABLE [dbo].[ItemUnit]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ItemId] INT NOT NULL, 
	[UnitId] INT NOT NULL, 
    [UnitPrice] MONEY NOT NULL, 
    CONSTRAINT [FK_ItemUnits_Item] FOREIGN KEY (ItemId) REFERENCES Item(Id),
    CONSTRAINT [FK_ItemUnits_Unit] FOREIGN KEY (UnitId) REFERENCES Unit(Id)

)

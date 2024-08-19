CREATE TABLE [dbo].[SaleDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[SaleId] INT NOT NULL, 
    [ItemId] INT NOT NULL, 
    [UnitId] INT NOT NULL, 
    [Quantity] INT NOT NULL DEFAULT 1, 
    [Price] MONEY NOT NULL,
    CONSTRAINT [FK_SaleDetail_Sale] FOREIGN KEY (SaleId) REFERENCES [Sale]([Id]),
	CONSTRAINT [FK_SaleDetail_Item] FOREIGN KEY (ItemId) REFERENCES [Item]([Id]),
    CONSTRAINT [FK_SaleDetail_Unit] FOREIGN KEY ([UnitId]) REFERENCES [Unit]([Id])
)

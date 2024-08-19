CREATE TABLE [dbo].[PurchaseDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[PurchaseId] INT NOT NULL, 
    [ItemId] INT NOT NULL, 
    [UnitId] INT NOT NULL, 
    [Quantity] INT NOT NULL DEFAULT 1, 
    [Price] MONEY NOT NULL, 
    CONSTRAINT [FK_PurchaseDetail_Purchase] FOREIGN KEY (PurchaseId) REFERENCES [Purchase]([Id])
)

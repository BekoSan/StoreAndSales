CREATE TABLE [dbo].[Purchase]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[SupplierId] INT NOT NULL,
	[PurchaseDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [Total] MONEY NOT NULL, 
    [Disscount] MONEY NOT NULL, 
    [Notes] NVARCHAR(2000) NOT NULL DEFAULT '', 
    [PaymentType] BIT NOT NULL DEFAULT 0, 
    [IsDisscount] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Purchase_Supplier] FOREIGN KEY (SupplierId) REFERENCES [Supplier]([Id])
)

CREATE TABLE [dbo].[Sale]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[CustomerId] INT NOT NULL,
    [SaleDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [Total] MONEY NOT NULL, 
    [Disscount] MONEY NOT NULL,  
    [Notes] NVARCHAR(2000) NOT NULL DEFAULT '',
    [PaymentType] BIT NOT NULL DEFAULT 0, 
    [IsDisscount] BIT NOT NULL DEFAULT 0, 
    [Status] BIT NOT NULL DEFAULT 1, 
    CONSTRAINT [FK_Sale_Customer] FOREIGN KEY (CustomerId) REFERENCES [Customer]([Id])
)

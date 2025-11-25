CREATE TABLE [dbo].[Voucher]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [VoucherType] NVARCHAR NOT NULL DEFAULT 'R', 
    [Amount] MONEY NOT NULL, 
    [SaleId] INT NULL, 
    [PurchaseId] INT NULL, 
    [CustomerId] INT NULL, 
    [SupplierId] INT NULL, 
    [Notes] NVARCHAR(2000) NOT NULL
)

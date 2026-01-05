CREATE TABLE [dbo].[Voucher]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [VoucherType] NVARCHAR NOT NULL DEFAULT 'R', 
    [Amount] MONEY NOT NULL, 
    [SaleId] INT NULL, 
    [PurchaseId] INT NULL, 
    [CustomerId] INT NULL, 
    [SupplierId] INT NULL, 
    [Notes] NVARCHAR(2000) NULL, 
    [VoucherDate] DATETIME2 NOT NULL DEFAULT Format(getdate(),'dd/MM/yyyy hh:mm:ss'), 
    CONSTRAINT [FK_Voucher_Sale] FOREIGN KEY (SaleId) REFERENCES Sale(Id),
    CONSTRAINT [FK_Voucher_Purchase] FOREIGN KEY (PurchaseId) REFERENCES Purchase(Id),
    CONSTRAINT [FK_Voucher_Customer] FOREIGN KEY (CustomerId) REFERENCES Customer(Id),
    CONSTRAINT [FK_Voucher_Supplier] FOREIGN KEY (SupplierId) REFERENCES Supplier(Id)
)

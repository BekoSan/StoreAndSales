CREATE TABLE [dbo].[Store]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [StoreName] NVARCHAR(150) NOT NULL,
    [StoreAddress] NVARCHAR(400) NULL,
    [IsDefault] BIT NOT NULL CONSTRAINT [DF_Store_IsDefault] DEFAULT (0),
    [Status] BIT NOT NULL CONSTRAINT [DF_Store_Status] DEFAULT (1)
)

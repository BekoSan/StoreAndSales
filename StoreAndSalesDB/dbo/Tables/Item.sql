CREATE TABLE [dbo].[Item]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ItemName] NVARCHAR(250) NOT NULL, 
    [Status] BIT NOT NULL DEFAULT 1,
    [ReorderLevel] INT NOT NULL DEFAULT 0,
	[HasExpiryDate] BIT NOT NULL CONSTRAINT [DF_Item_HasExpiryDate] DEFAULT 0,
	[ExpiryDate] DATE NULL,
    [ExpiryAlertDays] INT NOT NULL CONSTRAINT [DF_Item_ExpiryAlertDays] DEFAULT 30,
		CONSTRAINT [CK_Item_ExpiryConfiguration] CHECK
		(
			([HasExpiryDate] = 0 AND [ExpiryDate] IS NULL)
			OR ([HasExpiryDate] = 1 AND [ExpiryDate] IS NOT NULL)
		),
		CONSTRAINT [CK_Item_ExpiryAlertDays] CHECK ([ExpiryAlertDays] BETWEEN 1 AND 3650)
		)
CREATE TABLE [dbo].[UserLog]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [UserName] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [LogTime] DATETIME2 NOT NULL DEFAULT sysdatetime(), 
    CONSTRAINT [FK_UserLog_Users] FOREIGN KEY (UserId) REFERENCES [Users]([Id])
)

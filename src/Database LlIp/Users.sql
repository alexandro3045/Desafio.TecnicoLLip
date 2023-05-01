CREATE TABLE [dbo].[Users]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(200) NULL, 
    [Email] NVARCHAR(200) NULL, 
    [Password] NVARCHAR(400) NULL
)

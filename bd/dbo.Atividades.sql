CREATE TABLE [dbo].[Activities]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Title] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(600) NOT NULL, 
    [CreationDate] DATETIME NOT NULL,
	[ProjectId] INT FOREIGN KEY REFERENCES Projects(Id)
);
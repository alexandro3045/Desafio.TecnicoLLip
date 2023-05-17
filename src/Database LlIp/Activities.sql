CREATE TABLE [dbo].[Activities]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Title] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(600) NOT NULL, 
    [CreationDate] DATETIME NOT NULL,
    [ConclusionDate] DATETIME NULL,
	[ProjectId] INT FOREIGN KEY REFERENCES Projects(Id),
    [UserId] INT FOREIGN KEY REFERENCES Users(Id),
    [Status] [char](1) NOT NULL
);
GO
ALTER TABLE [dbo].[Activities] ADD  DEFAULT ('P') FOR [Status]
GO
ALTER TABLE [dbo].[Activities]  WITH CHECK ADD  CONSTRAINT [chk_val] CHECK  (([Status]='C' OR [Status]='A' OR [Status]='P'))
GO
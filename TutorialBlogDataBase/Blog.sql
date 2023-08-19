CREATE TABLE [dbo].[Blog]
(
	[BlogId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Url] NVARCHAR(MAX) NOT NULL, 
    [Title] NVARCHAR(200) NOT NULL, 
    [Author] INT NOT NULL, 
    [BlogType] INT NOT NULL DEFAULT 1, 
    [PreviousBlogId] INT NULL, 
    [NextBlogId] INT NULL, 
    [Content] TEXT NOT NULL, 
    [Description] NVARCHAR(500) NULL, 
    [Views] INT NOT NULL DEFAULT 0, 
    [Votes] INT NOT NULL DEFAULT 0, 
    [ShortUrl] NVARCHAR(200) NULL, 
    [CreatedBy] INT NOT NULL, 
    [CreatedAt] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UpdatedBy] INT NOT NULL, 
    [UpdatedAt] DATETIME NOT NULL DEFAULT GETDATE()
)

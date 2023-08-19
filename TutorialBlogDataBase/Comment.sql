CREATE TABLE [dbo].[Comment]
(
	[CommentId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Content] NCHAR(10) NULL, 
    [Author] NCHAR(10) NULL, 
    [Blog] NCHAR(10) NULL
)

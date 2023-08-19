CREATE TABLE [dbo].[Menu]
(
	[MenuId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(10) NOT NULL, 
    [Description] NCHAR(10) NULL, 
    [Url] NCHAR(10) NOT NULL, 
    [MenuType] NCHAR(10) NOT NULL DEFAULT 1, 
    [CreatedBy] NCHAR(10) NULL, 
    [CreatedAt] NCHAR(10) NOT NULL DEFAULT GetDate(), 
    [UpdatedBy] NCHAR(10) NULL, 
    [UpdatedAt] NCHAR(10) NULL DEFAULT GetDate()
)

CREATE TABLE [dbo].[Activity]
(
	[ActivityID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Action] SMALLINT NOT NULL, 
    [Object] NVARCHAR(100) NOT NULL, 
    [UserId] INT NOT NULL, 
    [Description] NVARCHAR(200) NULL, 
    [CreatedBy] INT NOT NULL, 
    [CreatedAt] DATETIME NOT NULL DEFAULT GetDate(), 
    [UpdatedBy] INT NOT NULL, 
    [UpdatedAt] DATETIME NOT NULL DEFAULT GetDate() 
)

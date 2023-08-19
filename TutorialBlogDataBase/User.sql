CREATE TABLE [dbo].[User]
(
	[UserId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(200) NOT NULL, 
    [DateOfBirth] DATETIME NULL, 
    [Details] NVARCHAR(500) NULL, 
    [ProfilePicture] NVARCHAR(100) NULL, 
    [WebsiteLink] NVARCHAR(100) NULL, 
    [ContactNumber] NVARCHAR(13) NULL, 
    [Email] NVARCHAR(100) NULL, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(200) NOT NULL, 
    [IsActive] TINYINT NOT NULL DEFAULT 0, 
    [CreatedBy] INT NULL, 
    [CreatedAt] DATETIME NULL DEFAULT GetDate(), 
    [UpdatedBy] INT NULL, 
    [UpdatedAt] DATETIME NULL DEFAULT GetDate()
)

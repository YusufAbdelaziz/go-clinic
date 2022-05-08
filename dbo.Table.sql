CREATE TABLE [dbo].[Table]
(
	[userID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [username] NCHAR(15) NOT NULL, 
    [password] NCHAR(15) NOT NULL, 
    [number] NCHAR(12) NOT NULL
)

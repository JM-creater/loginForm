CREATE TABLE [dbo].[Table_Book]
(
	[Book_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Book_Title] VARCHAR(50) NULL, 
    [Book_Author] VARCHAR(50) NULL, 
    [Book_Quantity] INT NULL 
)

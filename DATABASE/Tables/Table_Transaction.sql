CREATE TABLE [dbo].[Table_Transaction]
(
	[Transaction_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Transaction_Book_ID] INT NULL, 
    [Transaction_Borrower_ID] INT NULL, 
    [Transaction_IsReturned] INT NULL
)

CREATE TABLE [dbo].[Table_Transaction]
(
	[Transaction_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Transaction_Book_ID] INT NULL, 
    [Transaction_Borrower_ID] INT NULL, 
    [Transaction_IsReturned] BIT NULL DEFAULT 0, 
    [Transaction_Borrowed_Date] DATETIME NULL, 
    [Transaction_Returned_Date] DATETIME NULL
)

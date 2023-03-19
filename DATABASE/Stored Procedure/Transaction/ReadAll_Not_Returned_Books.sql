CREATE PROCEDURE [dbo].[ReadAll_Not_Returned_Books]
AS
	SELECT 
		[ID] = Transaction_ID
		, [Book Title] = Book_Title
		, [Full Name] = Borrower_Fname + ' ' + Borrower_Lname
		, [Returned] = Transaction_IsReturned

	FROM dbo.Table_Transaction 
	INNER JOIN dbo.Table_Book ON Transaction_Book_ID = Book_ID
	INNER JOIN dbo.Table_Borrower ON Transaction_Borrower_ID = Borrower_ID

	WHERE Transaction_IsReturned = 0

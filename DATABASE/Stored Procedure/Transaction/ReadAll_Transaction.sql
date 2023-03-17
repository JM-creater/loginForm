CREATE PROCEDURE [dbo].[ReadAll_Transaction]
		@StartDate		DATE
	  , @EndDate		DATE
AS
	SELECT 
		  [Book Title] = Book_Title
		, [Full Name] = Borrower_Fname + ' ' + Borrower_Lname
		, [Borrowed Date] = CAST (Transaction_Borrowed_Date AS DATE)
		, [Returned Date] = CAST (Transaction_Returned_Date AS DATE)
		, [Returned] = Transaction_IsReturned

	FROM dbo.Table_Transaction 
	INNER JOIN dbo.Table_Book ON Transaction_Book_ID = Book_ID
	INNER JOIN dbo.Table_Borrower ON Transaction_Borrower_ID = Borrower_ID

	WHERE
		Transaction_Borrowed_Date BETWEEN @StartDate AND @EndDate
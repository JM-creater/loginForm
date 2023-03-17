CREATE PROCEDURE [dbo].[Create_Transaction]
	  @Transaction_Book_ID			int
	, @Transaction_Borrower_ID		int
	, @Transaction_Borrowed_Date	datetime
AS
	INSERT INTO dbo.Table_Transaction
	(
		  Transaction_Book_ID
		, Transaction_Borrower_ID
		, Transaction_Borrowed_Date
	)
	VALUES
	(
		  @Transaction_Book_ID
		, @Transaction_Borrower_ID
		, @Transaction_Borrowed_Date
	)
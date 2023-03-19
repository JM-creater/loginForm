CREATE PROCEDURE [dbo].[Update_Transaction]
	  @Transaction_ID				varchar(50)
	, @Transaction_IsReturned		bit
	, @PlusOne						int = 1
	, @Transaction_Returned_Date	datetime
AS
	UPDATE dbo.Table_Transaction 
	SET
	Transaction_IsReturned = @Transaction_IsReturned
	, Transaction_Returned_Date = @Transaction_Returned_Date

	WHERE 
	Transaction_ID = @Transaction_ID 


	UPDATE dbo.Table_Book
	SET
	dbo.Table_Book.Book_Quantity += @PlusOne

	FROM dbo.Table_Book 
	INNER JOIN dbo.Table_Transaction
	ON dbo.Table_Transaction.Transaction_Book_ID = dbo.Table_Book.Book_ID

	WHERE 
	Transaction_ID = @Transaction_ID


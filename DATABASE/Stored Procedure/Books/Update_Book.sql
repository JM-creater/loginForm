CREATE PROCEDURE [dbo].[Update_Book]
	@Book_ID varchar(50)
	, @Book_Title varchar(100)
	, @Book_Author varchar(100)
	, @Book_Quantity int
AS
	UPDATE dbo.Table_Book
	SET 
		Book_Title = @Book_Title
		, Book_Author = @Book_Author
		, Book_Quantity = @Book_Quantity
	WHERE
		Book_ID = @Book_ID
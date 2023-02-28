CREATE PROCEDURE [dbo].[Create_Book]
	@Book_Title varchar(100)
	, @Book_Author varchar(100)
	, @Book_Quantity int
AS
	INSERT INTO dbo.Table_Book
	(
		Book_Title
		, Book_Author
		, Book_Quantity
	)
	VALUES
	(
		@Book_Title
		, @Book_Author
		, @Book_Quantity
	)
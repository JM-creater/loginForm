CREATE PROCEDURE [dbo].[AlreadyExist_Books]
	@Book_Title varchar(100)
	, @Book_Author varchar(100)
AS
	SELECT * FROM dbo.Table_Book
	WHERE Book_Title = @Book_Title AND Book_Author = @Book_Author

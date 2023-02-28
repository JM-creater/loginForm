CREATE PROCEDURE [dbo].[Read_Book]
	@Book_Title varchar(50)
AS
	SELECT * FROM dbo.Table_Book
	WHERE Book_Title LIKE @Book_Title
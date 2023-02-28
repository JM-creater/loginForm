CREATE PROCEDURE [dbo].[Delete_Book]
	@Book_ID varchar(100)
AS
	DELETE FROM dbo.Table_Book
	WHERE Book_ID = @Book_ID
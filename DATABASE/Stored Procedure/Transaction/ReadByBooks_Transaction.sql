CREATE PROCEDURE [dbo].[ReadByBooks_Transaction]
AS
	SELECT * FROM dbo.Table_Book
	WHERE Book_Quantity != 0

CREATE PROCEDURE [dbo].[Read_Transaction]
	@Transaction_ID int
AS
	SELECT * FROM dbo.Table_Transaction
	WHERE Transaction_ID = @Transaction_ID
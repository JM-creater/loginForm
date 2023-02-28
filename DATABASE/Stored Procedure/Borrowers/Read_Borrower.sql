CREATE PROCEDURE [dbo].[Read_Borrower]
	@Borrower_Fname varchar(50)
AS
	SELECT * FROM dbo.Table_Borrower
	WHERE Borrower_Fname LIKE @Borrower_Fname
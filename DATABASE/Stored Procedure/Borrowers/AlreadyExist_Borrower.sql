CREATE PROCEDURE [dbo].[AlreadyExist_Borrower]
	@Borrower_Fname varchar(100)
	, @Borrower_Lname varchar(100)
AS
	SELECT * FROM dbo.Table_Borrower
	WHERE Borrower_Fname = @Borrower_Fname AND Borrower_Lname = @Borrower_Lname
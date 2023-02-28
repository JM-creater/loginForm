CREATE PROCEDURE [dbo].[Update_Borrower]
	@Borrower_ID varchar(50)
	, @Borrower_Fname varchar(50)
	, @Borrower_Lname varchar(50)
AS
	UPDATE dbo.Table_Borrower
	SET
		Borrower_Fname = @Borrower_Fname
		, Borrower_Lname = @Borrower_Lname
	WHERE 
		Borrower_ID = @Borrower_ID
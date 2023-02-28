CREATE PROCEDURE [dbo].[Create_Borrower]
	@Borrower_Fname varchar(50)
	, @Borrower_Lname varchar(50)
AS
	INSERT INTO dbo.Table_Borrower
	(
		Borrower_Fname
		, Borrower_Lname
	)
	VALUES
	(
		@Borrower_Fname
		, @Borrower_Lname
	)
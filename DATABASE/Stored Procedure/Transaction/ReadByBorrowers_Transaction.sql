CREATE PROCEDURE [dbo].[ReadByBorrowers_Transaction]
AS
	SELECT 
			Borrower_ID
			, [Fullname] = Borrower_Fname + ' ' + Borrower_Lname
	FROM dbo.Table_Borrower

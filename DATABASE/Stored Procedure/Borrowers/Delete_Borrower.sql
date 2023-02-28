CREATE PROCEDURE [dbo].[Delete_Borrower]
	@Borrower_ID varchar(50)
AS
	DELETE dbo.Table_Borrower
	WHERE @Borrower_ID = @Borrower_ID
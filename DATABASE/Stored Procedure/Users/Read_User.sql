CREATE PROCEDURE [dbo].[Read_User]
	@User_username varchar(100)
AS
	SELECT * FROM dbo.table_user
	WHERE User_username = @User_username
	
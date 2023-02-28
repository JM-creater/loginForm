CREATE PROCEDURE [dbo].[LogIn_User]
	@User_username varchar(50)
	, @User_password varchar(50)
AS
	SELECT * FROM dbo.table_user
	WHERE User_username = @User_username
	AND User_password = @User_password

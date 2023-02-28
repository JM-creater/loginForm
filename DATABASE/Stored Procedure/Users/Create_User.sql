CREATE PROCEDURE [dbo].[Create_User]
	@User_username varchar(50)
	, @User_password varchar(50)
AS
	INSERT INTO dbo.table_user
	(
		User_username
		, User_password
	)
	VALUES
	(
		@User_username
		, @User_password
	)

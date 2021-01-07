CREATE PROCEDURE [dbo].[SP_AddTeam]
	@nm NVARCHAR(16),
	@uid INT
AS
	INSERT INTO [Teams]([Name],[UserId])
		OUTPUT @@IDENTITY
		VALUES(@nm,@uid)

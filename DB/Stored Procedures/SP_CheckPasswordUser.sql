CREATE PROCEDURE [dbo].[SP_CheckPasswordUser]
	@pd NVARCHAR(16),
	@pwd NVARCHAR(16)
AS
	SELECT [Id]
		FROM [Users]
		WHERE @pd = [Pseudo]
		AND HASHBYTES('SHA2_256',[salt]+@pwd) = [Password]
RETURN 0

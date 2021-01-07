CREATE PROCEDURE [dbo].[SP_GetUserById]
	@id int
AS
	SELECT [Id], [FirstName], [LastName], [Pseudo], '********' AS [Password]
		FROM [Users]
		WHERE [Id] = @id
RETURN 0

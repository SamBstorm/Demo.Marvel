CREATE PROCEDURE [dbo].[SP_GetTeamById]
	@id INT
AS
	SELECT [Id], [Name], [UserId], [LeaderId]
		FROM [Teams]
		WHERE [Id] = @id
RETURN 0

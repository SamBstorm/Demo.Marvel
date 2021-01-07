CREATE PROCEDURE [dbo].[SP_GetHeroesByTeamId]
	@tid int
AS
	SELECT [HeroId]
		FROM [Teams_Heroes]
		WHERE [TeamId] = @tid
RETURN 0

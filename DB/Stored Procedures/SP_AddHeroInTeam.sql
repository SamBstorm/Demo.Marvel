CREATE PROCEDURE [dbo].[SP_AddHeroInTeam]
	@hid int,
	@tid int
AS
	INSERT INTO [Teams_Heroes] ([TeamId],[HeroId])
		VALUES (@tid,@hid)
RETURN 0

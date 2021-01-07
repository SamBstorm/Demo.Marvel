CREATE TABLE [dbo].[Teams_Heroes]
(
	[TeamId] INT NOT NULL,
	[HeroId] INT NOT NULL,
	CONSTRAINT PK_Teams_Heroes PRIMARY KEY ([TeamId],[HeroId]),
	CONSTRAINT CK_FiveHeroes CHECK (dbo.SF_GetHeroesCountByTeamId(TeamId) < 5)
)

CREATE FUNCTION [dbo].[SF_GetHeroesCountByTeamId]
(
	@teamId int
)
RETURNS INT
AS
BEGIN
	IF(OBJECT_ID('Teams_Heroes','T') IS NOT NULL)
	BEGIN
		RETURN (
			SELECT COUNT(TeamId)
				FROM Teams_Heroes
				WHERE TeamId = @teamId
				);
	END
	RETURN 0;
END

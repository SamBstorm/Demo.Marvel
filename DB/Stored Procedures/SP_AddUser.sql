CREATE PROCEDURE [dbo].[SP_AddUser]
	@fn NVARCHAR(16),
	@ln NVARCHAR(16),
	@pd NVARCHAR(16),
	@pwd NVARCHAR(16)
AS
	DECLARE @salt NCHAR(8)
	SET @salt = dbo.SF_GenerateSalt();
	INSERT INTO [Users]([FirstName],[LastName],[Pseudo],[Password],[Salt]) 
		OUTPUT @@IDENTITY
		VALUES (@fn,@ln,@pd,HASHBYTES('SHA2_256',CONCAT(@salt,@pwd)),@salt)

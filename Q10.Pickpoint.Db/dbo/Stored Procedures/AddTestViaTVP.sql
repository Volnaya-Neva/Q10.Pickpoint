Create PROCEDURE [dbo].[AddTestViaTVP] 
@Dtos TestTVP READONLY 
AS

INSERT INTO Test
(
	[Id],
	[Type],
	[Name],
	[Adress],
	[Metro],
	[Latitude],
	[Longitude]
)
SELECT [Id],
	[Type],
	[Name],
	[Adress],
	[Metro],
	[Latitude],
	[Longitude] FROM @Dtos
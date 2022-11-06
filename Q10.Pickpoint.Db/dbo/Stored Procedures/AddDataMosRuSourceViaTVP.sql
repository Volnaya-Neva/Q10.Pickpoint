
CREATE PROCEDURE [dbo].[AddDataMosRuSourceViaTVP] 
@Dtos DataMosRuSourceTVP READONLY 
AS

INSERT INTO DataMosRuSource
(
	[Number],
	[Type],
	[CommonName],
	[FullName],
	[ShortName],
	[Area],
	[Address],
	[GlobalId]
)
SELECT [Number],
	[Type],
	[CommonName],
	[FullName],
	[ShortName],
	[Area],
	[Address],
	[GlobalId] FROM @Dtos

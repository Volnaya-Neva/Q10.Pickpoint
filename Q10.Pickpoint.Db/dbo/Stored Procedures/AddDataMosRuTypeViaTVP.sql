CREATE PROCEDURE [dbo].[AddDataMosRuTypeViaTVP] 
@Dtos DataMosRuTypeTVP READONLY 
AS

INSERT INTO DataMosRuType
(
	[Number],
	[Type],
	[IsUse]
)
SELECT [Number],
	[Type],
	[IsUse] FROM @Dtos
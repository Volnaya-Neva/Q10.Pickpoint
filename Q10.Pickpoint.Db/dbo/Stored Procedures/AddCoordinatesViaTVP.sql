

CREATE PROCEDURE [dbo].[AddCoordinatesViaTVP] 
@Dtos CoordinatesTVP READONLY 
AS

INSERT INTO [dbo].[Coordinates]
(
      [GlobalId],
      [Float_0],
      [Float_1]
)
SELECT 
      [GlobalId],
      [Float_0],
      [Float_1]
	  FROM @Dtos

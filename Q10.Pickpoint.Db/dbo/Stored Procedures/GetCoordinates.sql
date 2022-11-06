
CREATE PROCEDURE [GetCoordinates]
AS
BEGIN
     SELECT 
	  [Id]
	 ,[GlobalId]
	 ,[Float_0]
	 ,[Float_1]
	FROM [dbo].[Coordinates]
END

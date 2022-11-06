
CREATE PROCEDURE [GetCoordinatesByGlobalId]
(
	@GlobalId [nvarchar](max)
)
AS
BEGIN
     SELECT 
	  [Id]
	 ,[GlobalId]
	 ,[Float_0]
	 ,[Float_1]
	FROM [dbo].[Coordinates]
	WHERE [GlobalId] = @GlobalId
END

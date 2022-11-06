CREATE PROCEDURE [dbo].[GetDistricts]
AS
BEGIN
     SELECT 
		[Id],
		[Name]
	FROM dbo.District
END

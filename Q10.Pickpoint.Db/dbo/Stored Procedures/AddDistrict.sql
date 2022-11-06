CREATE PROCEDURE [dbo].[AddDistrict]
(
    @name NVARCHAR(MAX)
)
AS
BEGIN
     INSERT INTO dbo.District
	 ([Name])
	 OUTPUT INSERTED.ID
     VALUES
     (
		@name
     )
END
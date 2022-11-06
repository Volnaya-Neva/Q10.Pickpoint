CREATE PROCEDURE dbo.AddDataMosRuType
(
	@Number	INT,
    @Type NVARCHAR(MAX),
    @IsUse BIT
)
AS
BEGIN
     INSERT INTO dbo.DataMosRuType
	 (
		[Number],
        [Type],
        [IsUse]
     )
	 OUTPUT INSERTED.ID
     VALUES
     (
        @Number,
        @Type,
        @IsUse
     )
END
